namespace LevelEditor
{
    partial class RightClickMode
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.passableCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMapNumber = new System.Windows.Forms.ComboBox();
            this.groupBoxRightClick = new System.Windows.Forms.GroupBox();
            this.cboCodeValues = new System.Windows.Forms.ComboBox();
            this.lblCurrentCode = new System.Windows.Forms.Label();
            this.txtNewCode = new System.Windows.Forms.TextBox();
            this.radioCode = new System.Windows.Forms.RadioButton();
            this.radioPassable = new System.Windows.Forms.RadioButton();
            this.groupBox4.SuspendLayout();
            this.groupBoxRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.passableCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 45);
            this.groupBox4.TabIndex = 12;
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Map Number";
            // 
            // cboMapNumber
            // 
            this.cboMapNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMapNumber.FormattingEnabled = true;
            this.cboMapNumber.Location = new System.Drawing.Point(87, 127);
            this.cboMapNumber.Name = "cboMapNumber";
            this.cboMapNumber.Size = new System.Drawing.Size(168, 21);
            this.cboMapNumber.TabIndex = 9;
            // 
            // groupBoxRightClick
            // 
            this.groupBoxRightClick.Controls.Add(this.cboCodeValues);
            this.groupBoxRightClick.Controls.Add(this.lblCurrentCode);
            this.groupBoxRightClick.Controls.Add(this.txtNewCode);
            this.groupBoxRightClick.Controls.Add(this.radioCode);
            this.groupBoxRightClick.Controls.Add(this.radioPassable);
            this.groupBoxRightClick.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRightClick.Name = "groupBoxRightClick";
            this.groupBoxRightClick.Size = new System.Drawing.Size(248, 101);
            this.groupBoxRightClick.TabIndex = 10;
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
            // 
            // RightClickMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 209);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMapNumber);
            this.Controls.Add(this.groupBoxRightClick);
            this.Name = "RightClickMode";
            this.Text = "RightClickMode";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBoxRightClick.ResumeLayout(false);
            this.groupBoxRightClick.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox passableCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMapNumber;
        private System.Windows.Forms.GroupBox groupBoxRightClick;
        private System.Windows.Forms.ComboBox cboCodeValues;
        private System.Windows.Forms.Label lblCurrentCode;
        private System.Windows.Forms.TextBox txtNewCode;
        private System.Windows.Forms.RadioButton radioCode;
        private System.Windows.Forms.RadioButton radioPassable;
    }
}