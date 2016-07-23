using System;
using System.Threading;
using System.IO;

namespace LevelEditor
{
#if WINDOWS || XBOX

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static Level_properties level_properties;
        public static MapEditor form;
            
        [STAThread]
        static void Main(string[] args)
        {
            TileEngine.TileMap.TileWidth = 48;
            TileEngine.TileMap.TileHeight = 48;

            form = new MapEditor();
            form.Show();
            form.game = new Game1(form.pctSurface.Handle, form, form.pctSurface);
            form.game.Run();
        }
    }
#endif
}

