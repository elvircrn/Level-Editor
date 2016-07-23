using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

using System.IO;

using TileEngine;

namespace LevelEditor
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        public static bool DEBUG_MODE = true;

        #region Game graphics and Assets declaratios

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        SpriteFont defaultFont;

        #endregion

        #region Level Editor Properties

        public int DrawLayer = 0;
        public int DrawTile = 0;
        public bool EditingCode = false;
        public string CurrentCodeValue = "";
        public string HoverCodeValue = "";

        #endregion

        #region Declarations

        public MouseState lastMouseState;

        public bool IsDragging = false;

        public System.Windows.Forms.VScrollBar vScroll;
        public System.Windows.Forms.HScrollBar hScroll;

        public Vector2 pivotPoint, endingPoint;

        #endregion

        #region DEBUG

        Vector2 toPrint;

        #endregion

        #region Level editor Viewport

        IntPtr drawSurface;
        System.Windows.Forms.Form parentForm;
        System.Windows.Forms.PictureBox pictureBox;

        System.Windows.Forms.Control gameForm;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        public Game1(IntPtr drawSurface, System.Windows.Forms.Form parentForm, System.Windows.Forms.PictureBox surfacePictureBox)
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            this.drawSurface = drawSurface;
            this.parentForm = parentForm;
            this.pictureBox = surfacePictureBox;

            graphics.PreparingDeviceSettings += new EventHandler<PreparingDeviceSettingsEventArgs>(graphics_PreparingDeviceSettings);

            gameForm = System.Windows.Forms.Control.FromHandle(this.Window.Handle);
            gameForm.VisibleChanged += new EventHandler(gameForm_VisibilityChanged);
            gameForm.SizeChanged += new EventHandler(pictureBox_SizeChanged);

            pictureBox.SizeChanged += new EventHandler(pictureBox_SizeChanged);

            Mouse.WindowHandle = drawSurface;

            vScroll = (System.Windows.Forms.VScrollBar)parentForm.Controls["vScrollBar1"];
            hScroll = (System.Windows.Forms.HScrollBar)parentForm.Controls["hScrollBar1"];
        }

        public void gameForm_VisibilityChanged(object sender, EventArgs e)
        {
            if (gameForm.Visible == true)
                gameForm.Visible = false;
        }

        public int cnt = 0;

        public void pictureBox_SizeChanged(object sender, EventArgs e)
        {
            if (parentForm.WindowState != System.Windows.Forms.FormWindowState.Minimized)
            {
                graphics.PreferredBackBufferWidth = pictureBox.Width;
                graphics.PreferredBackBufferHeight = pictureBox.Height;

                Camera.Width = pictureBox.Width;
                Camera.Height = pictureBox.Height;

                graphics.ApplyChanges();
            }
        }

        public void graphics_PreparingDeviceSettings(object sender,
                                              PreparingDeviceSettingsEventArgs e)
        {
            e.GraphicsDeviceInformation.PresentationParameters.
            DeviceWindowHandle = drawSurface;
        }

        #endregion

        #region Meat

        protected override void Initialize()
        {

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            TileMap.Initialize(Content.Load<Texture2D>(@"Textures\" + TileMap.TextureName));

            Camera.Width = pictureBox.Width;
            Camera.Height = pictureBox.Height;
            Camera.WorldRectangle = new Rectangle(0, 0, TileMap.TileWidth * TileMap.MapWidth, TileMap.TileHeight * TileMap.MapHeight);

            defaultFont = Content.Load<SpriteFont>(@"Fonts\myFont");

            TileMap.defaultFont = Content.Load<SpriteFont>(@"Fonts\myFont");

            lastMouseState = Mouse.GetState();

            pictureBox_SizeChanged(null, null);
        }

        protected override void UnloadContent()
        {
        }

        bool moze = false;

        protected override void Update(GameTime gameTime)
        {
            moze = !moze;

            if (!moze)
                return;

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            if (Program.form.Enabled  == false)
                return;

            Vector2 mouseLoc;

            Camera.WorldLocation = new Vector2(hScroll.Value, vScroll.Value);
            KeyboardState keyState = Keyboard.GetState();
            MouseState ms = Mouse.GetState();

            if (keyState.IsKeyDown(Keys.LeftControl) && keyState.IsKeyDown(Keys.C))
                TileMap.Clear();

            bool gate = false;

            if ((ms.X > 0) && (ms.Y > 0) && ms.X < Camera.Width && ms.Y < Camera.Height)
            {
                mouseLoc = Camera.ScreenToWorld(new Vector2(ms.X, ms.Y));

                if (Camera.WorldRectangle.Contains((int)mouseLoc.X, (int)mouseLoc.Y))
                {
                    if (ms.LeftButton == ButtonState.Pressed)
                    {
                        //Where the magic happends
                        TileMap.SetTileAtCell(TileMap.PixelToTileX((int)mouseLoc.X), 
                                              TileMap.PixelToTileY((int)mouseLoc.Y), DrawLayer, DrawTile);
                    }
                    if (ms.RightButton == ButtonState.Pressed && (Keyboard.GetState()).IsKeyDown(Keys.LeftControl))
                    {
                        TileMap.GetTileAtSquare(TileMap.PixelToTileX((int)mouseLoc.X), 
                                                TileMap.PixelToTileY((int)mouseLoc.Y)).MakeItUnpassable();
                    }
                    else if (ms.RightButton == ButtonState.Pressed && lastMouseState.RightButton == ButtonState.Released && gate == false)
                    {
                        if (EditingCode)
                        {
                            TileMap.GetTileAtSquare(TileMap.PixelToTileX((int)mouseLoc.X), 
                                TileMap.PixelToTileY((int)mouseLoc.Y)).CodeValue = CurrentCodeValue;

                            if (CurrentCodeValue == "START")
                            {
                                TileMap.PlayerStartPosition = mouseLoc;
                            }
                            
                        }
                        else
                        {
                            TileMap.GetTileAtSquare(TileMap.PixelToTileX((int)mouseLoc.X), TileMap.PixelToTileY((int)mouseLoc.Y)).TogglePassable();
                        }
                    }

                    if (TileMap.GetTileAtSquare(TileMap.PixelToTileX((int)mouseLoc.X), TileMap.PixelToTileY((int)mouseLoc.Y)).CodeValue == null)
                        HoverCodeValue = "";
                    else
                        HoverCodeValue = TileMap.GetTileAtSquare(TileMap.PixelToTileX((int)mouseLoc.X), TileMap.PixelToTileY((int)mouseLoc.Y)).CodeValue;
                }
            }

            #region Drag
            if (keyState.IsKeyDown(Keys.LeftShift))
            {
                gate = true;
                mouseLoc = Camera.ScreenToWorld(new Vector2(ms.X, ms.Y));
                if (ms.RightButton == ButtonState.Pressed && lastMouseState.RightButton == ButtonState.Released && Camera.WorldRectangle.Contains((int)mouseLoc.X, (int)mouseLoc.Y) && (ms.X > 0) && (ms.Y > 0) && ms.X < Camera.Width && ms.Y < Camera.Height)
                {
                    if (IsDragging == false)
                    {
                        int cX = (int)Camera.WorldLocation.X;
                        int cY = (int)Camera.WorldLocation.Y;
                        int mX = Mouse.GetState().X;
                        int mY = Mouse.GetState().Y;
                        pivotPoint = new Vector2(TileMap.PixelToTileX((cX + mX)), TileMap.PixelToTileY((cY + mY)));
                        IsDragging = true;
                    }
                    else if (IsDragging == true)
                    {
                        int cX = (int)Camera.WorldLocation.X;
                        int cY = (int)Camera.WorldLocation.Y;
                        int mX = Mouse.GetState().X;
                        int mY = Mouse.GetState().Y;
                        endingPoint = new Vector2(TileMap.PixelToTileX((cX + mX)), TileMap.PixelToTileY((cY + mY)));
                        if (keyState.IsKeyUp(Keys.LeftControl)) SetUnpassable(pivotPoint, endingPoint);
                        else SetPassable(pivotPoint, endingPoint);
                        endingPoint = mouseLoc;
                        IsDragging = false;
                    }
                }

                if (Camera.WorldRectangle.Contains((int)mouseLoc.X, (int)mouseLoc.Y) && (ms.X > 0) && (ms.Y > 0) && ms.X < Camera.Width && ms.Y < Camera.Height && ms.LeftButton == ButtonState.Pressed && lastMouseState.LeftButton == ButtonState.Released)
                {
                    if (keyState.IsKeyUp(Keys.LeftControl))
                    {
                        if (IsDragging == false)
                        {
                            int cX = (int)Camera.WorldLocation.X;
                            int cY = (int)Camera.WorldLocation.Y;
                            int mX = Mouse.GetState().X;
                            int mY = Mouse.GetState().Y;
                            pivotPoint = new Vector2(TileMap.PixelToTileX((cX + mX)), TileMap.PixelToTileY((cY + mY)));
                            IsDragging = true;
                        }
                        else if (IsDragging == true)
                        {
                            int cX = (int)Camera.WorldLocation.X;
                            int cY = (int)Camera.WorldLocation.Y;
                            int mX = Mouse.GetState().X;
                            int mY = Mouse.GetState().Y;
                            endingPoint = new Vector2(TileMap.PixelToTileX((cX + mX)), TileMap.PixelToTileY((cY + mY)));
                            SetTiles(pivotPoint, endingPoint);
                            endingPoint = mouseLoc;
                            IsDragging = false;
                        }
                    }
                }
            }
            else
            {
                IsDragging = false;
                pivotPoint = Vector2.Zero;
            }
            #endregion

            lastMouseState = ms;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            MouseState mouseState = Mouse.GetState();

            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);

            TileMap.Draw(spriteBatch);

            

            #region DEBUG
            if (DEBUG_MODE)
            {
                int cX = (int)Camera.WorldLocation.X;
                int cY = (int)Camera.WorldLocation.Y;
                int mX = Mouse.GetState().X;
                int mY = Mouse.GetState().Y;
                spriteBatch.DrawString(defaultFont, "Mouse pixel location: " + (Mouse.GetState()).X.ToString() + " " + (Mouse.GetState()).Y.ToString(), new Vector2(0, 0), Color.White);
                spriteBatch.DrawString(defaultFont, "Mouse tile cell location: " + TileMap.PixelToTileX((cX + mX)).ToString() + " " + TileMap.PixelToTileY((cY + mY)).ToString(), new Vector2(0, 20), Color.White);
                DrawString(toPrint.X.ToString() + " " + toPrint.Y.ToString(), new Vector2(0, 40), spriteBatch);
                spriteBatch.DrawString(defaultFont, "Camera pixel location: " + cX.ToString() + " " + cY.ToString(), new Vector2(0, 60), Color.White);
            }
            #endregion

            spriteBatch.End();

            base.Draw(gameTime);
        }

        #endregion

        #region Helper Methods

        public void Load_Texture(string fileName)
        {
            using (FileStream stream = File.OpenRead(MapEditor.TextureLocation))
            {
                TileMap.Texture = Texture2D.FromStream(graphics.GraphicsDevice, stream);
            }
        }

        public void DrawString(string text, Vector2 position, SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(defaultFont, text, position, Color.White);
        }

        public void SetTiles(Vector2 startingPoint, Vector2 endingPoint)
        {
            toPrint = endingPoint;

            if (startingPoint.X <= endingPoint.X && startingPoint.Y <= endingPoint.Y)
            {
            }
            else if (startingPoint.X >= endingPoint.X && startingPoint.Y >= endingPoint.Y)
            {
                Vector2 p = endingPoint;
                endingPoint = startingPoint;
                startingPoint = p;
            }
            else if (startingPoint.X >= endingPoint.X)
            {
                int p = (int)endingPoint.X;
                endingPoint.X = startingPoint.X;
                startingPoint.X = p;
            }
            else if (startingPoint.Y >= endingPoint.Y)
            {
                int p = (int)endingPoint.Y;
                endingPoint.Y = startingPoint.Y;
                startingPoint.Y = p;
            }
            for (int i = (int)startingPoint.X; i <= (int)endingPoint.X; i++)
            {
                for (int j = (int)startingPoint.Y; j <= (int)endingPoint.Y; j++)
                {
                    TileMap.SetTileAtCell(i, j, DrawLayer, DrawTile);
                }
            }
        }

        public void SetUnpassable(Vector2 startingPoint, Vector2 endingPoint)
        {
            toPrint = endingPoint;

            if (startingPoint.X <= endingPoint.X && startingPoint.Y <= endingPoint.Y)
            {
            }
            else if (startingPoint.X >= endingPoint.X && startingPoint.Y >= endingPoint.Y)
            {
                Vector2 p = endingPoint;
                endingPoint = startingPoint;
                startingPoint = p;
            }
            else if (startingPoint.X >= endingPoint.X)
            {
                int p = (int)endingPoint.X;
                endingPoint.X = startingPoint.X;
                startingPoint.X = p;
            }
            else if (startingPoint.Y >= endingPoint.Y)
            {
                int p = (int)endingPoint.Y;
                endingPoint.Y = startingPoint.Y;
                startingPoint.Y = p;
            }
            for (int i = (int)startingPoint.X; i <= (int)endingPoint.X; i++)
            {
                for (int j = (int)startingPoint.Y; j <= (int)endingPoint.Y; j++)
                {
                    TileMap.Map[i, j].Passable = false;
                }
            }
        }

        public void SetPassable(Vector2 startingPoint, Vector2 endingPoint)
        {
            toPrint = endingPoint;

            if (startingPoint.X <= endingPoint.X && startingPoint.Y <= endingPoint.Y)
            {
            }
            else if (startingPoint.X >= endingPoint.X && startingPoint.Y >= endingPoint.Y)
            {
                Vector2 p = endingPoint;
                endingPoint = startingPoint;
                startingPoint = p;
            }
            else if (startingPoint.X >= endingPoint.X)
            {
                int p = (int)endingPoint.X;
                endingPoint.X = startingPoint.X;
                startingPoint.X = p;
            }
            else if (startingPoint.Y >= endingPoint.Y)
            {
                int p = (int)endingPoint.Y;
                endingPoint.Y = startingPoint.Y;
                startingPoint.Y = p;
            }
            for (int i = (int)startingPoint.X; i <= (int)endingPoint.X; i++)
            {
                for (int j = (int)startingPoint.Y; j <= (int)endingPoint.Y; j++)
                {
                    TileMap.Map[i, j].Passable = true;
                }
            }
        }


        #endregion
    }
}
