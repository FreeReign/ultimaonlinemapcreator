namespace CreateColorTable
{
    partial class Viewer
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
            this.MenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.PropertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.MainMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu1
            // 
            this.MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem1,
            this.MenuItem4});
            this.MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.MainMenu1.Name = "MainMenu1";
            this.MainMenu1.Size = new System.Drawing.Size(484, 24);
            this.MainMenu1.TabIndex = 0;
            this.MainMenu1.Text = "menuStrip1";
            // 
            // MenuItem1
            // 
            this.MenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem2,
            this.MenuItem3,
            this.MenuItem7,
            this.MenuItem8});
            this.MenuItem1.Name = "MenuItem1";
            this.MenuItem1.Size = new System.Drawing.Size(56, 20);
            this.MenuItem1.Text = "Terrain";
            // 
            // MenuItem2
            // 
            this.MenuItem2.Name = "MenuItem2";
            this.MenuItem2.Size = new System.Drawing.Size(152, 22);
            this.MenuItem2.Text = "Load";
            this.MenuItem2.Click += new System.EventHandler(this.MenuItem2_Click);
            // 
            // MenuItem3
            // 
            this.MenuItem3.Name = "MenuItem3";
            this.MenuItem3.Size = new System.Drawing.Size(152, 22);
            this.MenuItem3.Text = "Save";
            this.MenuItem3.Click += new System.EventHandler(this.MenuItem3_Click);
            // 
            // MenuItem7
            // 
            this.MenuItem7.Name = "MenuItem7";
            this.MenuItem7.Size = new System.Drawing.Size(104, 6);
            // 
            // MenuItem8
            // 
            this.MenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem9,
            this.MenuItem13});
            this.MenuItem8.Name = "MenuItem8";
            this.MenuItem8.Size = new System.Drawing.Size(152, 22);
            this.MenuItem8.Text = "Export";
            // 
            // MenuItem9
            // 
            this.MenuItem9.Name = "MenuItem9";
            this.MenuItem9.Size = new System.Drawing.Size(152, 22);
            this.MenuItem9.Text = "Terrain.ACT";
            this.MenuItem9.Click += new System.EventHandler(this.MenuItem9_Click);
            // 
            // MenuItem13
            // 
            this.MenuItem13.Name = "MenuItem13";
            this.MenuItem13.Size = new System.Drawing.Size(152, 22);
            this.MenuItem13.Text = "Terrain.ACO";
            this.MenuItem13.Click += new System.EventHandler(this.MenuItem13_Click);
            // 
            // MenuItem4
            // 
            this.MenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem5,
            this.MenuItem6,
            this.MenuItem10,
            this.MenuItem11});
            this.MenuItem4.Name = "MenuItem4";
            this.MenuItem4.Size = new System.Drawing.Size(61, 20);
            this.MenuItem4.Text = "Altitude";
            // 
            // MenuItem5
            // 
            this.MenuItem5.Name = "MenuItem5";
            this.MenuItem5.Size = new System.Drawing.Size(152, 22);
            this.MenuItem5.Text = "Load";
            this.MenuItem5.Click += new System.EventHandler(this.MenuItem5_Click);
            // 
            // MenuItem6
            // 
            this.MenuItem6.Name = "MenuItem6";
            this.MenuItem6.Size = new System.Drawing.Size(152, 22);
            this.MenuItem6.Text = "Save";
            this.MenuItem6.Click += new System.EventHandler(this.MenuItem6_Click);
            // 
            // MenuItem10
            // 
            this.MenuItem10.Name = "MenuItem10";
            this.MenuItem10.Size = new System.Drawing.Size(104, 6);
            // 
            // MenuItem11
            // 
            this.MenuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem12,
            this.MenuItem14});
            this.MenuItem11.Name = "MenuItem11";
            this.MenuItem11.Size = new System.Drawing.Size(152, 22);
            this.MenuItem11.Text = "Export";
            // 
            // MenuItem12
            // 
            this.MenuItem12.Name = "MenuItem12";
            this.MenuItem12.Size = new System.Drawing.Size(152, 22);
            this.MenuItem12.Text = "Altitude.ACT";
            this.MenuItem12.Click += new System.EventHandler(this.MenuItem12_Click);
            // 
            // MenuItem14
            // 
            this.MenuItem14.Name = "MenuItem14";
            this.MenuItem14.Size = new System.Drawing.Size(152, 22);
            this.MenuItem14.Text = "Altitude.ACO";
            this.MenuItem14.Click += new System.EventHandler(this.MenuItem14_Click);
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(14, 52);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(224, 381);
            this.ListBox1.Sorted = true;
            this.ListBox1.TabIndex = 1;
            this.ListBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // PropertyGrid1
            // 
            this.PropertyGrid1.HelpVisible = false;
            this.PropertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.PropertyGrid1.Location = new System.Drawing.Point(253, 51);
            this.PropertyGrid1.Name = "PropertyGrid1";
            this.PropertyGrid1.Size = new System.Drawing.Size(216, 318);
            this.PropertyGrid1.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.Color.Blue;
            this.Label1.Location = new System.Drawing.Point(13, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Terrain List";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.Color.Blue;
            this.Label2.Location = new System.Drawing.Point(251, 32);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(74, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Tile Properties";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Location = new System.Drawing.Point(254, 387);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(46, 46);
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            // 
            // Label3
            // 
            this.Label3.ForeColor = System.Drawing.Color.DarkRed;
            this.Label3.Location = new System.Drawing.Point(306, 392);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(166, 46);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "* The altitude will be randomized when the tile has been selected.";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 447);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PropertyGrid1);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.MainMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainMenu1;
            this.MaximizeBox = false;
            this.Name = "Viewer";
            this.Text = "Data Viewer";
            this.MainMenu1.ResumeLayout(false);
            this.MainMenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu1;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.PropertyGrid PropertyGrid1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MenuItem4;
        private System.Windows.Forms.ToolStripMenuItem MenuItem5;
        private System.Windows.Forms.ToolStripMenuItem MenuItem6;
        private System.Windows.Forms.ToolStripSeparator MenuItem7;
        private System.Windows.Forms.ToolStripMenuItem MenuItem8;
        private System.Windows.Forms.ToolStripMenuItem MenuItem9;
        private System.Windows.Forms.ToolStripMenuItem MenuItem13;
        private System.Windows.Forms.ToolStripSeparator MenuItem10;
        private System.Windows.Forms.ToolStripMenuItem MenuItem11;
        private System.Windows.Forms.ToolStripMenuItem MenuItem12;
        private System.Windows.Forms.ToolStripMenuItem MenuItem14;
        private System.Windows.Forms.Label Label3;
    }
}

