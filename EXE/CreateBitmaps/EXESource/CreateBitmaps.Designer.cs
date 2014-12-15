namespace CreateBitmaps
{
    partial class CreateBitmaps
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
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Dungeon = new System.Windows.Forms.CheckBox();
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ProjectPath = new System.Windows.Forms.TextBox();
            this.TerrainFile = new System.Windows.Forms.TextBox();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.AltitudeFile = new System.Windows.Forms.TextBox();
            this.MainMenu1 = new System.Windows.Forms.MenuStrip();
            this.MenuPath = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTerrain = new System.Windows.Forms.ToolStripMenuItem();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.MainMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(218, 110);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(144, 21);
            this.ComboBox1.Sorted = true;
            this.ComboBox1.TabIndex = 38;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(215, 92);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(77, 13);
            this.Label3.TabIndex = 37;
            this.Label3.Text = "Default Terrain";
            // 
            // Dungeon
            // 
            this.Dungeon.AutoSize = true;
            this.Dungeon.Location = new System.Drawing.Point(371, 113);
            this.Dungeon.Name = "Dungeon";
            this.Dungeon.Size = new System.Drawing.Size(15, 14);
            this.Dungeon.TabIndex = 36;
            this.Dungeon.UseVisualStyleBackColor = true;
            // 
            // ProjectName
            // 
            this.ProjectName.Location = new System.Drawing.Point(292, 58);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(152, 20);
            this.ProjectName.TabIndex = 35;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(291, 40);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 13);
            this.Label2.TabIndex = 34;
            this.Label2.Text = "Project Name";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(18, 40);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(32, 13);
            this.Label1.TabIndex = 33;
            this.Label1.Text = "Path:";
            // 
            // ProjectPath
            // 
            this.ProjectPath.Location = new System.Drawing.Point(21, 58);
            this.ProjectPath.Name = "ProjectPath";
            this.ProjectPath.Size = new System.Drawing.Size(256, 20);
            this.ProjectPath.TabIndex = 32;
            // 
            // TerrainFile
            // 
            this.TerrainFile.Location = new System.Drawing.Point(21, 164);
            this.TerrainFile.Name = "TerrainFile";
            this.TerrainFile.Size = new System.Drawing.Size(104, 20);
            this.TerrainFile.TabIndex = 41;
            this.TerrainFile.Text = "Terrain.bmp";
            // 
            // ComboBox2
            // 
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Location = new System.Drawing.Point(21, 110);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(184, 21);
            this.ComboBox2.TabIndex = 40;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(18, 92);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(87, 13);
            this.Label5.TabIndex = 42;
            this.Label5.Text = "Select Map Size:";
            // 
            // AltitudeFile
            // 
            this.AltitudeFile.Location = new System.Drawing.Point(140, 164);
            this.AltitudeFile.Name = "AltitudeFile";
            this.AltitudeFile.Size = new System.Drawing.Size(104, 20);
            this.AltitudeFile.TabIndex = 47;
            this.AltitudeFile.Text = "Altitude.bmp";
            // 
            // MainMenu1
            // 
            this.MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPath,
            this.MenuTerrain});
            this.MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.MainMenu1.Name = "MainMenu1";
            this.MainMenu1.Size = new System.Drawing.Size(465, 24);
            this.MainMenu1.TabIndex = 11;
            this.MainMenu1.Text = "menuStrip1";
            // 
            // MenuPath
            // 
            this.MenuPath.Name = "MenuPath";
            this.MenuPath.Size = new System.Drawing.Size(43, 20);
            this.MenuPath.Text = "Path";
            this.MenuPath.Click += new System.EventHandler(this.MenuPath_Click);
            // 
            // MenuTerrain
            // 
            this.MenuTerrain.Name = "MenuTerrain";
            this.MenuTerrain.Size = new System.Drawing.Size(168, 20);
            this.MenuTerrain.Text = "MakeTerrain/Altitude Image";
            this.MenuTerrain.Click += new System.EventHandler(this.MenuTerrain_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(368, 92);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(76, 13);
            this.Label4.TabIndex = 48;
            this.Label4.Text = "Dungeon Area";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(140, 146);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(98, 13);
            this.Label6.TabIndex = 50;
            this.Label6.Text = "Altitude Image Map";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(20, 146);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(96, 13);
            this.Label7.TabIndex = 49;
            this.Label7.Text = "Terrain Image Map";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar1.Location = new System.Drawing.Point(0, 205);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(465, 16);
            this.ProgressBar1.TabIndex = 51;
            // 
            // MakeMapImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 221);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.AltitudeFile);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.ComboBox2);
            this.Controls.Add(this.TerrainFile);
            this.Controls.Add(this.ProjectPath);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.Dungeon);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.MainMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainMenu1;
            this.Name = "MakeMapImage";
            this.Text = "Make New Image Map";
            this.MainMenu1.ResumeLayout(false);
            this.MainMenu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.CheckBox Dungeon;
        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox ProjectPath;
        private System.Windows.Forms.TextBox TerrainFile;
        private System.Windows.Forms.ComboBox ComboBox2;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.TextBox AltitudeFile;
        private System.Windows.Forms.MenuStrip MainMenu1;
        private System.Windows.Forms.ToolStripMenuItem MenuPath;
        private System.Windows.Forms.ToolStripMenuItem MenuTerrain;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.ProgressBar ProgressBar1;
    }
}

