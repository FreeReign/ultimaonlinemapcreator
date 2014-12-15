namespace CreateTransitions
{
    partial class GroupSelect
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
            this.PropertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.SelectGroup = new System.Windows.Forms.ComboBox();
            this.SelectGroupName = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PropertyGrid1
            // 
            this.PropertyGrid1.CommandsVisibleIfAvailable = false;
            this.PropertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.PropertyGrid1.Location = new System.Drawing.Point(8, 48);
            this.PropertyGrid1.Name = "PropertyGrid1";
            this.PropertyGrid1.Size = new System.Drawing.Size(184, 256);
            this.PropertyGrid1.TabIndex = 0;
            // 
            // SelectGroup
            // 
            this.SelectGroup.FormattingEnabled = true;
            this.SelectGroup.Location = new System.Drawing.Point(8, 24);
            this.SelectGroup.Name = "SelectGroup";
            this.SelectGroup.Size = new System.Drawing.Size(184, 21);
            this.SelectGroup.Sorted = true;
            this.SelectGroup.TabIndex = 1;
            this.SelectGroup.SelectedIndexChanged += new System.EventHandler(this.SelectGroup_SelectedIndexChanged);
            // 
            // SelectGroupName
            // 
            this.SelectGroupName.AutoSize = true;
            this.SelectGroupName.Location = new System.Drawing.Point(8, 8);
            this.SelectGroupName.Name = "SelectGroupName";
            this.SelectGroupName.Size = new System.Drawing.Size(79, 13);
            this.SelectGroupName.TabIndex = 2;
            this.SelectGroupName.Text = "Select Group X";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(8, 312);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "Select";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GroupSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 342);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.SelectGroupName);
            this.Controls.Add(this.SelectGroup);
            this.Controls.Add(this.PropertyGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GroupSelect";
            this.Text = "GroupSelect";
            this.Load += new System.EventHandler(this.GroupSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid PropertyGrid1;
        private System.Windows.Forms.ComboBox SelectGroup;
        public System.Windows.Forms.Label SelectGroupName;
        private System.Windows.Forms.Button Button1;
    }
}