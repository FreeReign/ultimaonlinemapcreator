namespace TransitionWizard
{
    partial class TransitionWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransitionWizard));
            this.MainMenu1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.TileID = new System.Windows.Forms.VScrollBar();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Select_Group_A = new System.Windows.Forms.ComboBox();
            this.Select_Group_B = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ToolBar1 = new System.Windows.Forms.ToolStrip();
            this.ToolAdd = new System.Windows.Forms.ToolStripButton();
            this.ToolDelete = new System.Windows.Forms.ToolStripButton();
            this.MapZoom = new System.Windows.Forms.ToolStripButton();
            this.StaticZoom = new System.Windows.Forms.ToolStripButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MainMenu1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.ToolBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu1
            // 
            this.MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem1,
            this.MenuItem2,
            this.MenuItem5});
            this.MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.MainMenu1.Name = "MainMenu1";
            this.MainMenu1.Size = new System.Drawing.Size(656, 24);
            this.MainMenu1.TabIndex = 0;
            this.MainMenu1.Text = "MainMenu1";
            // 
            // MenuItem1
            // 
            this.MenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem6,
            this.MenuItem7,
            this.MenuItem8});
            this.MenuItem1.Name = "MenuItem1";
            this.MenuItem1.Size = new System.Drawing.Size(37, 20);
            this.MenuItem1.Text = "File";
            // 
            // MenuItem6
            // 
            this.MenuItem6.Name = "MenuItem6";
            this.MenuItem6.Size = new System.Drawing.Size(152, 22);
            this.MenuItem6.Text = "New";
            this.MenuItem6.Click += new System.EventHandler(this.MenuItem6_Click);
            // 
            // MenuItem7
            // 
            this.MenuItem7.Name = "MenuItem7";
            this.MenuItem7.Size = new System.Drawing.Size(152, 22);
            this.MenuItem7.Text = "Save";
            this.MenuItem7.Click += new System.EventHandler(this.MenuItem7_Click);
            // 
            // MenuItem8
            // 
            this.MenuItem8.Name = "MenuItem8";
            this.MenuItem8.Size = new System.Drawing.Size(152, 22);
            this.MenuItem8.Text = "Load";
            this.MenuItem8.Visible = false;
            this.MenuItem8.Click += new System.EventHandler(this.MenuItem8_Click);
            // 
            // MenuItem2
            // 
            this.MenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem3,
            this.MenuItem4});
            this.MenuItem2.Name = "MenuItem2";
            this.MenuItem2.Size = new System.Drawing.Size(44, 20);
            this.MenuItem2.Text = "View";
            // 
            // MenuItem3
            // 
            this.MenuItem3.Name = "MenuItem3";
            this.MenuItem3.Size = new System.Drawing.Size(158, 22);
            this.MenuItem3.Text = "View Map Tiles";
            this.MenuItem3.Click += new System.EventHandler(this.MenuItem3_Click);
            // 
            // MenuItem4
            // 
            this.MenuItem4.Name = "MenuItem4";
            this.MenuItem4.Size = new System.Drawing.Size(158, 22);
            this.MenuItem4.Text = "View Static Tiles";
            this.MenuItem4.Click += new System.EventHandler(this.MenuItem4_Click);
            // 
            // MenuItem5
            // 
            this.MenuItem5.Name = "MenuItem5";
            this.MenuItem5.Size = new System.Drawing.Size(48, 20);
            this.MenuItem5.Text = "Make";
            this.MenuItem5.Click += new System.EventHandler(this.MenuItem5_Click);
            // 
            // TreeView1
            // 
            this.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TreeView1.Location = new System.Drawing.Point(272, 71);
            this.TreeView1.Name = "TreeView1";
            this.TreeView1.Size = new System.Drawing.Size(200, 296);
            this.TreeView1.TabIndex = 1;
            this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelec);
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Location = new System.Drawing.Point(8, 71);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(256, 296);
            this.Panel2.TabIndex = 65;
            this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.TileID);
            this.Panel1.Location = new System.Drawing.Point(480, 71);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(169, 240);
            this.Panel1.TabIndex = 66;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // TileID
            // 
            this.TileID.Dock = System.Windows.Forms.DockStyle.Right;
            this.TileID.LargeChange = 16;
            this.TileID.Location = new System.Drawing.Point(152, 0);
            this.TileID.Maximum = 16381;
            this.TileID.Name = "TileID";
            this.TileID.Size = new System.Drawing.Size(17, 240);
            this.TileID.TabIndex = 0;
            this.TileID.Scroll += new System.Windows.Forms.ScrollEventHandler(this.LandTileID_Scroll);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(272, 47);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(377, 20);
            this.TextBox1.TabIndex = 69;
            // 
            // Select_Group_A
            // 
            this.Select_Group_A.FormattingEnabled = true;
            this.Select_Group_A.Location = new System.Drawing.Point(8, 46);
            this.Select_Group_A.Name = "Select_Group_A";
            this.Select_Group_A.Size = new System.Drawing.Size(121, 21);
            this.Select_Group_A.Sorted = true;
            this.Select_Group_A.TabIndex = 70;
            this.Select_Group_A.SelectedIndexChanged += new System.EventHandler(this.Select_Group_A_SelectedIndexChanged);
            // 
            // Select_Group_B
            // 
            this.Select_Group_B.FormattingEnabled = true;
            this.Select_Group_B.Location = new System.Drawing.Point(136, 47);
            this.Select_Group_B.Name = "Select_Group_B";
            this.Select_Group_B.Size = new System.Drawing.Size(121, 21);
            this.Select_Group_B.Sorted = true;
            this.Select_Group_B.TabIndex = 71;
            this.Select_Group_B.SelectedIndexChanged += new System.EventHandler(this.Select_Group_B_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 13);
            this.Label1.TabIndex = 72;
            this.Label1.Text = "Group A";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(137, 30);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 13);
            this.Label2.TabIndex = 73;
            this.Label2.Text = "Group B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Description";
            // 
            // ToolBar1
            // 
            this.ToolBar1.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolBar1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolBar1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.ToolBar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolAdd,
            this.ToolDelete,
            this.MapZoom,
            this.StaticZoom});
            this.ToolBar1.Location = new System.Drawing.Point(481, 330);
            this.ToolBar1.Name = "ToolBar1";
            this.ToolBar1.Size = new System.Drawing.Size(155, 39);
            this.ToolBar1.TabIndex = 75;
            this.ToolBar1.Text = "toolStrip1";
            // 
            // ToolAdd
            // 
            this.ToolAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolAdd.Image = global::TransitionWizard.Properties.Resources.uol01;
            this.ToolAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolAdd.Name = "ToolAdd";
            this.ToolAdd.Size = new System.Drawing.Size(40, 36);
            this.ToolAdd.Tag = "Add";
            this.ToolAdd.Text = "Add";
            this.ToolAdd.Click += new System.EventHandler(this.ToolAdd_Click);
            // 
            // ToolDelete
            // 
            this.ToolDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolDelete.Image = global::TransitionWizard.Properties.Resources.uol02;
            this.ToolDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolDelete.Name = "ToolDelete";
            this.ToolDelete.Size = new System.Drawing.Size(40, 36);
            this.ToolDelete.Tag = "Delete";
            this.ToolDelete.Text = "Delete";
            this.ToolDelete.Click += new System.EventHandler(this.ToolDelete_Click);
            // 
            // MapZoom
            // 
            this.MapZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MapZoom.Image = global::TransitionWizard.Properties.Resources.uol25;
            this.MapZoom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MapZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MapZoom.Name = "MapZoom";
            this.MapZoom.Size = new System.Drawing.Size(36, 36);
            this.MapZoom.Tag = "MapZoom";
            this.MapZoom.Text = "Map Zoom";
            this.MapZoom.Click += new System.EventHandler(this.MapZoom_Click);
            // 
            // StaticZoom
            // 
            this.StaticZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StaticZoom.Image = global::TransitionWizard.Properties.Resources.uol25;
            this.StaticZoom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.StaticZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StaticZoom.Name = "StaticZoom";
            this.StaticZoom.Size = new System.Drawing.Size(36, 36);
            this.StaticZoom.Tag = "StaticZoom";
            this.StaticZoom.Text = "Static Zoom";
            this.StaticZoom.Click += new System.EventHandler(this.StaticZoom_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "uol01.png");
            this.ImageList1.Images.SetKeyName(1, "uol02.png");
            this.ImageList1.Images.SetKeyName(2, "uol25.png");
            // 
            // Twiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 380);
            this.Controls.Add(this.ToolBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Select_Group_B);
            this.Controls.Add(this.Select_Group_A);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.TreeView1);
            this.Controls.Add(this.MainMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainMenu1;
            this.Name = "Twiz";
            this.Text = "UO Landscaper Transition Wizard";
            this.MainMenu1.ResumeLayout(false);
            this.MainMenu1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ToolBar1.ResumeLayout(false);
            this.ToolBar1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem6;
        private System.Windows.Forms.ToolStripMenuItem MenuItem7;
        private System.Windows.Forms.ToolStripMenuItem MenuItem8;
        private System.Windows.Forms.ToolStripMenuItem MenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MenuItem4;
        private System.Windows.Forms.ToolStripMenuItem MenuItem5;
        private System.Windows.Forms.TreeView TreeView1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.VScrollBar TileID;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.ComboBox Select_Group_A;
        private System.Windows.Forms.ComboBox Select_Group_B;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip ToolBar1;
        private System.Windows.Forms.ToolStripButton ToolAdd;
        private System.Windows.Forms.ToolStripButton ToolDelete;
        private System.Windows.Forms.ToolStripButton MapZoom;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.ToolStripButton StaticZoom;
    }
}