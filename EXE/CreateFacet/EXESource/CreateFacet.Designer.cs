namespace CreateFacet
{
    partial class CreateFacet
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
            this.MainMenu1 = new System.Windows.Forms.MenuStrip();
            this.MenuPath = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMake = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStaticON = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStaticOFF = new System.Windows.Forms.ToolStripMenuItem();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.AltitudeFile = new System.Windows.Forms.TextBox();
            this.TerrainFile = new System.Windows.Forms.TextBox();
            this.ProjectPath = new System.Windows.Forms.TextBox();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.MainMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu1
            // 
            this.MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPath,
            this.MenuMake,
            this.MenuItem1});
            this.MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.MainMenu1.Name = "MainMenu1";
            this.MainMenu1.Size = new System.Drawing.Size(551, 24);
            this.MainMenu1.TabIndex = 0;
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
            this.MenuMake.Size = new System.Drawing.Size(95, 20);
            this.MenuMake.Text = "Make UO Map";
            this.MenuMake.Click += new System.EventHandler(this.MenuMake_Click);
            // 
            // MenuItem1
            // 
            this.MenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStaticON,
            this.MenuStaticOFF});
            this.MenuItem1.Name = "MenuItem1";
            this.MenuItem1.Size = new System.Drawing.Size(48, 20);
            this.MenuItem1.Text = "Static";
            // 
            // MenuStaticON
            // 
            this.MenuStaticON.Name = "MenuStaticON";
            this.MenuStaticON.Size = new System.Drawing.Size(171, 22);
            this.MenuStaticON.Text = "Random Static On";
            this.MenuStaticON.Click += new System.EventHandler(this.MenuStaticON_Click);
            // 
            // MenuStaticOFF
            // 
            this.MenuStaticOFF.Name = "MenuStaticOFF";
            this.MenuStaticOFF.Size = new System.Drawing.Size(171, 22);
            this.MenuStaticOFF.Text = "Random Static Off";
            this.MenuStaticOFF.Click += new System.EventHandler(this.MenuStaticOFF_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(29, 13);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "Path";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(311, 31);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(96, 13);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "Terrain Image Map";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(436, 31);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(98, 13);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "Altitude Image Map";
            // 
            // AltitudeFile
            // 
            this.AltitudeFile.Location = new System.Drawing.Point(436, 49);
            this.AltitudeFile.Name = "AltitudeFile";
            this.AltitudeFile.Size = new System.Drawing.Size(104, 20);
            this.AltitudeFile.TabIndex = 19;
            this.AltitudeFile.Text = "Altitude.bmp";
            // 
            // TerrainFile
            // 
            this.TerrainFile.Location = new System.Drawing.Point(312, 49);
            this.TerrainFile.Name = "TerrainFile";
            this.TerrainFile.Size = new System.Drawing.Size(104, 20);
            this.TerrainFile.TabIndex = 18;
            this.TerrainFile.Text = "Terrain.bmp";
            // 
            // ProjectPath
            // 
            this.ProjectPath.Location = new System.Drawing.Point(12, 49);
            this.ProjectPath.Name = "ProjectPath";
            this.ProjectPath.Size = new System.Drawing.Size(264, 20);
            this.ProjectPath.TabIndex = 17;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar1.Location = new System.Drawing.Point(0, 89);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(551, 16);
            this.ProgressBar1.TabIndex = 23;
            // 
            // UOMapMake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 105);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.ProjectPath);
            this.Controls.Add(this.TerrainFile);
            this.Controls.Add(this.AltitudeFile);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.MainMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainMenu1;
            this.Name = "UOMapMake";
            this.Text = "Ultima Online Map Making Utility";
            this.MainMenu1.ResumeLayout(false);
            this.MainMenu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu1;
        private System.Windows.Forms.ToolStripMenuItem MenuPath;
        private System.Windows.Forms.ToolStripMenuItem MenuMake;
        private System.Windows.Forms.ToolStripMenuItem MenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuStaticON;
        private System.Windows.Forms.ToolStripMenuItem MenuStaticOFF;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox AltitudeFile;
        private System.Windows.Forms.TextBox TerrainFile;
        private System.Windows.Forms.TextBox ProjectPath;
        private System.Windows.Forms.ProgressBar ProgressBar1;
    }
}

