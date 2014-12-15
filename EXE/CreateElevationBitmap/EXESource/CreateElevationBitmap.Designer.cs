namespace CreateElevationBitmap
{
    partial class CreateElevationBitmap
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
            this.Label3 = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenu1 = new System.Windows.Forms.MenuStrip();
            this.MenuPath = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMake = new System.Windows.Forms.ToolStripMenuItem();
            this.Label2 = new System.Windows.Forms.Label();
            this.AltitudeFile = new System.Windows.Forms.TextBox();
            this.TerrainFile = new System.Windows.Forms.TextBox();
            this.ProjectPath = new System.Windows.Forms.TextBox();
            this.MainMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(381, 35);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(98, 13);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Altitude Image Map";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar1.Location = new System.Drawing.Point(0, 99);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(493, 16);
            this.ProgressBar1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Path";
            // 
            // MainMenu1
            // 
            this.MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPath,
            this.MenuMake});
            this.MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.MainMenu1.Name = "MainMenu1";
            this.MainMenu1.Size = new System.Drawing.Size(493, 24);
            this.MainMenu1.TabIndex = 18;
            this.MainMenu1.Text = "MainMenu1";
            // 
            // MenuPath
            // 
            this.MenuPath.Name = "MenuPath";
            this.MenuPath.Size = new System.Drawing.Size(43, 20);
            this.MenuPath.Text = "Path";
            this.MenuPath.Click += new System.EventHandler(this.MenuPath_Click);
            // 
            // MenuMake
            // 
            this.MenuMake.Name = "MenuMake";
            this.MenuMake.Size = new System.Drawing.Size(129, 20);
            this.MenuMake.Text = "Make Altitude Image";
            this.MenuMake.Click += new System.EventHandler(this.MenuMake_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(273, 35);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(96, 13);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Terrain Image Map";
            // 
            // AltitudeFile
            // 
            this.AltitudeFile.Location = new System.Drawing.Point(381, 59);
            this.AltitudeFile.Name = "AltitudeFile";
            this.AltitudeFile.Size = new System.Drawing.Size(104, 20);
            this.AltitudeFile.TabIndex = 11;
            this.AltitudeFile.Text = "Altitude.bmp";
            // 
            // TerrainFile
            // 
            this.TerrainFile.Location = new System.Drawing.Point(273, 59);
            this.TerrainFile.Name = "TerrainFile";
            this.TerrainFile.Size = new System.Drawing.Size(104, 20);
            this.TerrainFile.TabIndex = 10;
            this.TerrainFile.Text = "Terrain.bmp";
            // 
            // ProjectPath
            // 
            this.ProjectPath.Location = new System.Drawing.Point(23, 59);
            this.ProjectPath.Name = "ProjectPath";
            this.ProjectPath.Size = new System.Drawing.Size(244, 20);
            this.ProjectPath.TabIndex = 8;
            // 
            // CreateElevationBitmap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 115);
            this.Controls.Add(this.ProjectPath);
            this.Controls.Add(this.TerrainFile);
            this.Controls.Add(this.AltitudeFile);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.MainMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainMenu1;
            this.Name = "CreateElevationBitmap";
            this.Text = "UO Altitude Map Set";
            this.Load += new System.EventHandler(this.AltImagePrep_Load);
            this.MainMenu1.ResumeLayout(false);
            this.MainMenu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip MainMenu1;
        private System.Windows.Forms.ToolStripMenuItem MenuPath;
        private System.Windows.Forms.ToolStripMenuItem MenuMake;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox AltitudeFile;
        private System.Windows.Forms.TextBox TerrainFile;
        private System.Windows.Forms.TextBox ProjectPath;
        public System.Windows.Forms.ProgressBar ProgressBar1;
    }
}

