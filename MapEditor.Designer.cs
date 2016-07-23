namespace LevelEditor
{
    partial class MapEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapEditor));
            this.pctSurface = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.groupBoxRightClick = new System.Windows.Forms.GroupBox();
            this.cboCodeValues = new System.Windows.Forms.ComboBox();
            this.lblCurrentCode = new System.Windows.Forms.Label();
            this.txtNewCode = new System.Windows.Forms.TextBox();
            this.radioCode = new System.Windows.Forms.RadioButton();
            this.radioPassable = new System.Windows.Forms.RadioButton();
            this.timerGameUpdate = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.passableCheckBox = new System.Windows.Forms.CheckBox();
            this.loadTexture = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveLevel = new System.Windows.Forms.SaveFileDialog();
            this.loadLevel = new System.Windows.Forms.OpenFileDialog();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.game1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foregroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pctSurface)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxRightClick.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.game1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pctSurface
            // 
            this.pctSurface.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pctSurface.Location = new System.Drawing.Point(407, 52);
            this.pctSurface.Name = "pctSurface";
            this.pctSurface.Size = new System.Drawing.Size(1128, 706);
            this.pctSurface.TabIndex = 0;
            this.pctSurface.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.tilesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1564, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMapToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveMapToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadMapToolStripMenuItem
            // 
            this.loadMapToolStripMenuItem.Name = "loadMapToolStripMenuItem";
            this.loadMapToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.loadMapToolStripMenuItem.Text = "&Load";
            this.loadMapToolStripMenuItem.Click += new System.EventHandler(this.loadMapToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveMapToolStripMenuItem
            // 
            this.saveMapToolStripMenuItem.Name = "saveMapToolStripMenuItem";
            this.saveMapToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saveMapToolStripMenuItem.Text = "S&ave Map As";
            this.saveMapToolStripMenuItem.Click += new System.EventHandler(this.saveMapToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.clearMapToolStripMenuItem,
            this.levelPropertiesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.startToolStripMenuItem.Text = "&Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // clearMapToolStripMenuItem
            // 
            this.clearMapToolStripMenuItem.Name = "clearMapToolStripMenuItem";
            this.clearMapToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.clearMapToolStripMenuItem.Text = "&Clear Map";
            this.clearMapToolStripMenuItem.Click += new System.EventHandler(this.clearMapToolStripMenuItem_Click);
            // 
            // levelPropertiesToolStripMenuItem
            // 
            this.levelPropertiesToolStripMenuItem.Name = "levelPropertiesToolStripMenuItem";
            this.levelPropertiesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.levelPropertiesToolStripMenuItem.Text = "Level Properties";
            this.levelPropertiesToolStripMenuItem.Click += new System.EventHandler(this.levelPropertiesToolStripMenuItem_Click);
            // 
            // tilesToolStripMenuItem
            // 
            this.tilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadNewToolStripMenuItem});
            this.tilesToolStripMenuItem.Name = "tilesToolStripMenuItem";
            this.tilesToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.tilesToolStripMenuItem.Text = "T&iles";
            // 
            // loadNewToolStripMenuItem
            // 
            this.loadNewToolStripMenuItem.Name = "loadNewToolStripMenuItem";
            this.loadNewToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.loadNewToolStripMenuItem.Text = "Load New Texture";
            this.loadNewToolStripMenuItem.Click += new System.EventHandler(this.loadNewToolStripMenuItem_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.LargeChange = 48;
            this.vScrollBar1.Location = new System.Drawing.Point(1544, 55);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 703);
            this.vScrollBar1.TabIndex = 3;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar1.Location = new System.Drawing.Point(407, 761);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1128, 17);
            this.hScrollBar1.TabIndex = 4;
            // 
            // groupBoxRightClick
            // 
            this.groupBoxRightClick.Controls.Add(this.cboCodeValues);
            this.groupBoxRightClick.Controls.Add(this.lblCurrentCode);
            this.groupBoxRightClick.Controls.Add(this.txtNewCode);
            this.groupBoxRightClick.Controls.Add(this.radioCode);
            this.groupBoxRightClick.Controls.Add(this.radioPassable);
            this.groupBoxRightClick.Location = new System.Drawing.Point(21, 614);
            this.groupBoxRightClick.Name = "groupBoxRightClick";
            this.groupBoxRightClick.Size = new System.Drawing.Size(248, 101);
            this.groupBoxRightClick.TabIndex = 5;
            this.groupBoxRightClick.TabStop = false;
            this.groupBoxRightClick.Text = "Right Click Mode";
            // 
            // cboCodeValues
            // 
            this.cboCodeValues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodeValues.FormattingEnabled = true;
            this.cboCodeValues.Location = new System.Drawing.Point(6, 73);
            this.cboCodeValues.Name = "cboCodeValues";
            this.cboCodeValues.Size = new System.Drawing.Size(167, 21);
            this.cboCodeValues.TabIndex = 4;
            this.cboCodeValues.SelectedIndexChanged += new System.EventHandler(this.cboCodeValues_SelectedIndexChanged);
            // 
            // lblCurrentCode
            // 
            this.lblCurrentCode.AutoSize = true;
            this.lblCurrentCode.Location = new System.Drawing.Point(19, 57);
            this.lblCurrentCode.Name = "lblCurrentCode";
            this.lblCurrentCode.Size = new System.Drawing.Size(91, 13);
            this.lblCurrentCode.TabIndex = 3;
            this.lblCurrentCode.Text = "----------------------------";
            // 
            // txtNewCode
            // 
            this.txtNewCode.Location = new System.Drawing.Point(62, 36);
            this.txtNewCode.Name = "txtNewCode";
            this.txtNewCode.Size = new System.Drawing.Size(180, 20);
            this.txtNewCode.TabIndex = 2;
            this.txtNewCode.TextChanged += new System.EventHandler(this.txtNewCode_TextChanged);
            // 
            // radioCode
            // 
            this.radioCode.AutoSize = true;
            this.radioCode.Location = new System.Drawing.Point(6, 39);
            this.radioCode.Name = "radioCode";
            this.radioCode.Size = new System.Drawing.Size(50, 17);
            this.radioCode.TabIndex = 1;
            this.radioCode.TabStop = true;
            this.radioCode.Text = "Code";
            this.radioCode.UseVisualStyleBackColor = true;
            // 
            // radioPassable
            // 
            this.radioPassable.AutoSize = true;
            this.radioPassable.Location = new System.Drawing.Point(6, 16);
            this.radioPassable.Name = "radioPassable";
            this.radioPassable.Size = new System.Drawing.Size(104, 17);
            this.radioPassable.TabIndex = 0;
            this.radioPassable.TabStop = true;
            this.radioPassable.Text = "Toggle Passable";
            this.radioPassable.UseVisualStyleBackColor = true;
            this.radioPassable.CheckedChanged += new System.EventHandler(this.radioPassable_CheckedChanged);
            // 
            // timerGameUpdate
            // 
            this.timerGameUpdate.Enabled = true;
            this.timerGameUpdate.Interval = 20;
            this.timerGameUpdate.Tick += new System.EventHandler(this.timerGameUpdate_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.passableCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(21, 721);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 45);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Level Editor Controls";
            // 
            // passableCheckBox
            // 
            this.passableCheckBox.AutoSize = true;
            this.passableCheckBox.ForeColor = System.Drawing.Color.Black;
            this.passableCheckBox.Location = new System.Drawing.Point(6, 19);
            this.passableCheckBox.Name = "passableCheckBox";
            this.passableCheckBox.Size = new System.Drawing.Size(141, 17);
            this.passableCheckBox.TabIndex = 0;
            this.passableCheckBox.Text = "Show Passable Property";
            this.passableCheckBox.UseVisualStyleBackColor = true;
            this.passableCheckBox.CheckedChanged += new System.EventHandler(this.passableCheckBox_CheckedChanged);
            // 
            // loadTexture
            // 
            this.loadTexture.FileName = "plce";
            this.loadTexture.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1564, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Load";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Save";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 414);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 418);
            this.panel1.TabIndex = 13;
            // 
            // loadLevel
            // 
            this.loadLevel.FileName = "level";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.interactiveToolStripMenuItem,
            this.foregroundToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // interactiveToolStripMenuItem
            // 
            this.interactiveToolStripMenuItem.Checked = true;
            this.interactiveToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.interactiveToolStripMenuItem.Name = "interactiveToolStripMenuItem";
            this.interactiveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.interactiveToolStripMenuItem.Text = "Interactive";
            this.interactiveToolStripMenuItem.Click += new System.EventHandler(this.interactiveToolStripMenuItem_Click);
            // 
            // game1BindingSource
            // 
            this.game1BindingSource.DataSource = typeof(LevelEditor.Game1);
            // 
            // foregroundToolStripMenuItem
            // 
            this.foregroundToolStripMenuItem.Name = "foregroundToolStripMenuItem";
            this.foregroundToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.foregroundToolStripMenuItem.Text = "Foreground";
            this.foregroundToolStripMenuItem.Click += new System.EventHandler(this.foregroundToolStripMenuItem_Click);
            // 
            // MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 787);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBoxRightClick);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pctSurface);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MapEditor";
            this.Text = "Map Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MapEditor_Activated);
            this.Deactivate += new System.EventHandler(this.MapEditor_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MapEditor_FormClosed);
            this.Load += new System.EventHandler(this.MapEditor_Load);
            this.Resize += new System.EventHandler(this.MapEditor_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pctSurface)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxRightClick.ResumeLayout(false);
            this.groupBoxRightClick.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.game1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pctSurface;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMapToolStripMenuItem;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.GroupBox groupBoxRightClick;
        private System.Windows.Forms.ComboBox cboCodeValues;
        private System.Windows.Forms.TextBox txtNewCode;
        private System.Windows.Forms.RadioButton radioCode;
        private System.Windows.Forms.RadioButton radioPassable;
        private System.Windows.Forms.Timer timerGameUpdate;
        private System.Windows.Forms.Label lblCurrentCode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox passableCheckBox;
        private System.Windows.Forms.ToolStripMenuItem levelPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog loadTexture;
        private System.Windows.Forms.BindingSource game1BindingSource;
        private System.Windows.Forms.ToolStripMenuItem tilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadNewToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.SaveFileDialog saveLevel;
        private System.Windows.Forms.OpenFileDialog loadLevel;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interactiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foregroundToolStripMenuItem;
    }
}