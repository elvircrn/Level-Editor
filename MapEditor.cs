using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Xna.Framework;
using TileEngine;
using System.Diagnostics;
using MegamanClone;

namespace LevelEditor
{

    public partial class MapEditor : Form
    {
        public Game1 game = new Game1();
        private bool selected = true;
        public static string TextureLocation;
        public static string LevelPath;

        public int TextureOffset = 2;

        public MapEditor()
        {
            InitializeComponent();
        }

        private void MapEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            game.Exit();
            Application.Exit();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.Exit();
            Application.Exit();
        }

        public void LoadImageList()
        {
            string filepath = TextureLocation;
        }

        private void MapEditor_Load(object sender, EventArgs e)
        {
            panel1.AutoScroll = true;

            foregroundToolStripMenuItem.Checked  = true;
            backgroundToolStripMenuItem.Checked  = true;
            interactiveToolStripMenuItem.Checked = true;

            for (int i = 0; i < 3; i++)
                TileMap.Visible[i] = true;

            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Load(Application.StartupPath + @"\Content\Textures\" + TileMap.TextureName + ".png");
            
            TextureLocation = Application.StartupPath + @"\Content\Textures\" + TileMap.TextureName + ".png";

            LoadImageList();
            FixScrollBarScales();

            passableCheckBox.Checked = true;

            #region Set up tile sizes

            System.Drawing.Rectangle r = pictureBox1.DisplayRectangle;

            toolStripComboBox1.Items.Add("Background");
            toolStripComboBox1.Items.Add("Interactive");
            toolStripComboBox1.Items.Add("Foreground");

            toolStripComboBox1.SelectedIndex = 0;

            loadLevel.Filter = "MAP|*.MAP";
            saveLevel.Filter = "MAP|*.MAP";

            //imgListTiles.ImageSize = new System.Drawing.Size(TileEngine.TileMap.TileWidth, TileEngine.TileMap.TileHeight);
            //listTiles.TileSize = new System.Drawing.Size(TileEngine.TileMap.TileWidth, TileEngine.TileMap.TileHeight);

            #endregion

            #region Combo

            cboCodeValues.Items.Clear();
            cboCodeValues.Items.Add("Gemstone");
            cboCodeValues.Items.Add("Enemy");
            cboCodeValues.Items.Add("Lethal");
            cboCodeValues.Items.Add("EnemyBlocking");
            cboCodeValues.Items.Add("Start");
            cboCodeValues.Items.Add("Clear");
            cboCodeValues.Items.Add("Custom");

            #endregion

            TileMap.EditorMode = true;


            //TileMap.Load(new FileStream(@"C:\Users\Inspiron\Desktop\Shooter\MegamanClone\MegamanClone\MegamanCloneContent\Maps\MAP000.MAP", FileMode.Open));
        }

        public void FixScrollBarScales()
        {
            Camera.Width = pctSurface.Width;
            Camera.Height = pctSurface.Height;

            Camera.Move(Vector2.Zero);

            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum =
                Camera.WorldRectangle.Height -
                Camera.Height;

            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum =
                Camera.WorldRectangle.Width -
                Camera.Width;
        }

        private void MapEditor_Resize(object sender, EventArgs e)
        {
            FixScrollBarScales();
        }

        private void cboCodeValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNewCode.Enabled = false;
            switch (cboCodeValues.Items[cboCodeValues.SelectedIndex].ToString())
            {
                case "Gemstone":
                    txtNewCode.Text = "GEM";
                    break;
                case "Enemy":
                    txtNewCode.Text = "ENEMY";
                    break;
                case "Lethal":
                    txtNewCode.Text = "DEAD";
                    break;
                case "EnemyBlocking":
                    txtNewCode.Text = "BLOCK";
                    break;
                case "Start":
                    txtNewCode.Text = "START";
                    break;
                case "Clear":
                    txtNewCode.Text = "";
                    break;
                case "Custom":
                    txtNewCode.Text = "";
                    txtNewCode.Enabled = true;
                    break;
            }
        }

        private void radioPassable_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPassable.Checked)
            {
                game.EditingCode = false;
            }
            else
            {
                game.EditingCode = true;
            }
        }

        private void txtNewCode_TextChanged(object sender, EventArgs e)
        {
            game.CurrentCodeValue = txtNewCode.Text;
        }

        private void timerGameUpdate_Tick(object sender, EventArgs e)
        {
            if (hScrollBar1.Maximum < 0)
            {
                FixScrollBarScales();
            }

            if (selected)
                game.Tick();

            if (game.HoverCodeValue != lblCurrentCode.Text)
                lblCurrentCode.Text = game.HoverCodeValue;
        }

        private void clearMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TileMap.Clear();
        }

    /*
        TextureLocation = loadTexture.FileName;
        TileMap.TextureName = loadTexture.SafeFileName;
        Program.form.game.Load_Texture(loadTexture.SafeFileName);
        pictureBox1.Load(TextureLocation);
        LoadImageList();     
    */

        private void loadMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadLevel.ShowDialog();
            LevelPath = loadLevel.FileName;
            TileMap.Load(new FileStream(loadLevel.FileName, FileMode.Open));
        }

        private void saveMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveLevel.ShowDialog();
            TileMap.Save(new FileStream(saveLevel.FileName, FileMode.Create));
        }

        private void passableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TileMap.DisplayPassable = passableCheckBox.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Inspiron\Desktop\Adobe CS5\FTL_v1.01_Install.exe");
        }

        private void levelPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.form.Enabled = false;
            
            Program.level_properties = new Level_properties();


           Program.level_properties.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.Invoke (new Action ( () => openFileDialog1.ShowDialog()));
            loadTexture.Multiselect = false;
            loadTexture.InitialDirectory = TextureLocation;
            loadTexture.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            TextureLocation = loadTexture.FileName;
            TileMap.TextureName = loadTexture.SafeFileName;
            Program.form.game.Load_Texture(loadTexture.SafeFileName);
            pictureBox1.Load(TextureLocation);
            LoadImageList();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Inspiron\Desktop\maturski\Platformer\TESTESTEST\bin\WindowsGL\Debug\TESTESTEST.exe");
        }

        private void loadNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTexture.Multiselect = false;
            loadTexture.InitialDirectory = TextureLocation;
            loadTexture.ShowDialog();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            game.DrawLayer = (toolStripComboBox1.Items.Count - toolStripComboBox1.SelectedIndex) - 1;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Vector2 loc = TileMap.PixelToTile(new Vector2((float)e.X, (float)e.Y));
            game.DrawTile = (int)loc.Y * (int)TileMap.TilesPerRow + (int)loc.X;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MapEditor_Activated(object sender, EventArgs e)
        {
            selected = true;
        }

        private void MapEditor_Deactivate(object sender, EventArgs e)
        {
            selected = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            /*e.Graphics.DrawLine(
            new Pen(System.Drawing.Color.Red, 2f),
            new System.Drawing.Point(0, 0),
            new System.Drawing.Point(pictureBox1.Size.Width, pictureBox1.Size.Height));

            e.Graphics.DrawEllipse(
                new System.Drawing.Pen(System.Drawing.Color.Red, 2f),
                0, 0, pictureBox1.Size.Width, pictureBox1.Size.Height);*/
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LevelPath != null)
            {
                TileMap.Save(new FileStream (LevelPath, FileMode.Create));
            }
            else
            {
                saveLevel.ShowDialog();
                TileMap.Save(new FileStream(saveLevel.FileName, FileMode.Create));
            }
        }

        private void rightClickModeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void interactiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            interactiveToolStripMenuItem.Checked ^= true;
            TileMap.Visible[1] ^= true;
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgroundToolStripMenuItem.Checked ^= true;
            TileMap.Visible[0] ^= true;
        }

        private void foregroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foregroundToolStripMenuItem.Checked ^= true;
            TileMap.Visible[2] ^= true;
        }

    }
}
