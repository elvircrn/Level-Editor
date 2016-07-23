using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TileEngine;

namespace LevelEditor
{
    public partial class Level_properties : Form
    {
        public Level_properties()
        {
            InitializeComponent();
        }

        private void Level_properties_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = TileEngine.TileMap.TileWidth;
            numericUpDown2.Value = TileEngine.TileMap.TileHeight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplyChanges();
            Program.form.Enabled = true;
            this.Hide();
        }

        private void Level_properties_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.form.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplyChanges();
        }

        #region Helper Methods

        private void ApplyChanges()
        {
            TileEngine.TileMap.TileWidth = (int)numericUpDown1.Value;
            TileEngine.TileMap.TileHeight = (int)numericUpDown2.Value;

            TileEngine.TileMap.MapWidth = (int)levelWidth.Value;
            TileEngine.TileMap.MapHeight = (int)levelHeight.Value;

            //Program.form.imgListTiles.ImageSize = new System.Drawing.Size(TielEngine.TileMap.TileWidth, TileEngine.TileMap.TileWidth);
            //Program.form.listTiles.TileSize = new System.Drawing.Size(TileEngine.TileMap.TileWidth, TileEngine.TileMap.TileHeight);

            Program.form.LoadImageList();
        }

        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
