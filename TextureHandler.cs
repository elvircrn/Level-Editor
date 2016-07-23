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
    public static class TextureHandler
    {
        public static System.Drawing.Point TopLeft = new System.Drawing.Point(0, 0);
        public static System.Drawing.Rectangle textureRegion = new System.Drawing.Rectangle(0, 0, Program.form.pictureBox1.Width, Program.form.Height);

        public static void MoveTo(System.Drawing.Point location)
        {
            TopLeft.X = location.X;
            TopLeft.Y = location.Y;
        }

        public static System.Drawing.Rectangle TextureRegion
        {
            get
            {
                return new System.Drawing.Rectangle(TopLeft.X, TopLeft.Y, 300, 450);
            }
        }
    }
}
