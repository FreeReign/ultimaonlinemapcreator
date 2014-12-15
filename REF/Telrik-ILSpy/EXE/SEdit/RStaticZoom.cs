using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ultima;

namespace SEdit
{
	public class RStaticZoom : Form
	{
		[AccessedThroughProperty("VScrollBar1")]
		private VScrollBar _VScrollBar1;

		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		private IContainer components;

		private Art UOArt;

		private int iSelected;

		internal virtual Panel Panel2
		{
			get
			{
				return this._Panel2;
			}
			set
			{
				if (this._Panel2 != null)
				{
					RStaticZoom rStaticZoom = this;
					this._Panel2.MouseDown -= new MouseEventHandler(rStaticZoom.Panel2_MouseDown);
					RStaticZoom rStaticZoom1 = this;
					this._Panel2.Paint -= new PaintEventHandler(rStaticZoom1.Panel2_Paint);
				}
				this._Panel2 = value;
				if (this._Panel2 != null)
				{
					RStaticZoom rStaticZoom2 = this;
					this._Panel2.MouseDown += new MouseEventHandler(rStaticZoom2.Panel2_MouseDown);
					RStaticZoom rStaticZoom3 = this;
					this._Panel2.Paint += new PaintEventHandler(rStaticZoom3.Panel2_Paint);
				}
			}
		}

		internal virtual VScrollBar VScrollBar1
		{
			get
			{
				return this._VScrollBar1;
			}
			set
			{
				if (this._VScrollBar1 != null)
				{
					RStaticZoom rStaticZoom = this;
					this._VScrollBar1.Scroll -= new ScrollEventHandler(rStaticZoom.VScrollBar1_Scroll);
				}
				this._VScrollBar1 = value;
				if (this._VScrollBar1 != null)
				{
					RStaticZoom rStaticZoom1 = this;
					this._VScrollBar1.Scroll += new ScrollEventHandler(rStaticZoom1.VScrollBar1_Scroll);
				}
			}
		}

		public RStaticZoom()
		{
			this.iSelected = 0;
			this.InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.components != null)
				{
					this.components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Panel2 = new Panel();
			this.VScrollBar1 = new VScrollBar();
			this.Panel2.SuspendLayout();
			this.SuspendLayout();
			this.Panel2.Controls.Add(this.VScrollBar1);
			Panel panel2 = this.Panel2;
			Point point = new Point(8, 8);
			panel2.Location = point;
			this.Panel2.Name = "Panel2";
			Panel panel = this.Panel2;
			System.Drawing.Size size = new System.Drawing.Size(318, 480);
			panel.Size = size;
			this.Panel2.TabIndex = 3;
			this.VScrollBar1.Dock = DockStyle.Right;
			this.VScrollBar1.LargeChange = 16;
			VScrollBar vScrollBar1 = this.VScrollBar1;
			point = new Point(302, 0);
			vScrollBar1.Location = point;
			this.VScrollBar1.Maximum = 16384;
			this.VScrollBar1.Name = "VScrollBar1";
			VScrollBar vScrollBar = this.VScrollBar1;
			size = new System.Drawing.Size(16, 480);
			vScrollBar.Size = size;
			this.VScrollBar1.TabIndex = 0;
			size = new System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new System.Drawing.Size(334, 493);
			this.ClientSize = size;
			this.Controls.Add(this.Panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "RStaticZoom";
			this.Text = "Select Static Item";
			this.Panel2.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private void Panel2_MouseDown(object sender, MouseEventArgs e)
		{
			int num = 0;
			int num1 = 0;
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				int x = e.X;
				if (x >= 0 && x <= 49)
				{
					num = 0;
				}
				else if (x >= 50 && x <= 99)
				{
					num = 1;
				}
				else if (x >= 100 && x <= 149)
				{
					num = 2;
				}
				else if (x >= 150 && x <= 199)
				{
					num = 3;
				}
				else if (x >= 200 && x <= 249)
				{
					num = 4;
				}
				else if (x >= 250 && x <= 399)
				{
					num = 5;
				}
				int y = e.Y;
				if (y >= 0 && y <= 59)
				{
					num1 = 0;
				}
				else if (y >= 60 && y <= 118)
				{
					num1 = 1;
				}
				else if (y >= 120 && y <= 177)
				{
					num1 = 2;
				}
				else if (y >= 180 && y <= 236)
				{
					num1 = 3;
				}
				else if (y >= 240 && y <= 295)
				{
					num1 = 4;
				}
				else if (y >= 300 && y <= 354)
				{
					num1 = 5;
				}
				else if (y >= 360 && y <= 413)
				{
					num1 = 6;
				}
				else if (y >= 420 && y <= 472)
				{
					num1 = 7;
				}
				this.iSelected = checked(checked(this.VScrollBar1.Value + checked(num1 * 6)) + num);
				object tag = this.Tag;
				object[] objArray = new object[] { this.iSelected };
				LateBinding.LateSetComplex(tag, null, "Value", objArray, null, false, true);
			}
		}

		private void Panel2_Paint(object sender, PaintEventArgs e)
		{
			System.Drawing.Font font = new System.Drawing.Font("Arial", 8f);
			SolidBrush solidBrush = new SolidBrush(Color.Black);
			Pen pen = new Pen(Color.Black);
			Graphics graphics = e.Graphics;
			graphics.Clear(Color.LightGray);
			int value = this.VScrollBar1.Value;
			int num = 0;
			do
			{
				int num1 = 0;
				do
				{
					graphics.DrawRectangle(pen, checked(num1 * 50), checked(num * 60), 48, 58);
					if (Art.GetStatic(value) != null)
					{
						graphics.DrawString(value.ToString(), font, solidBrush, (float)(checked(checked(num1 * 50) + 1)), (float)(checked(checked(num * 60) + 1)));
						Rectangle rectangle = new Rectangle(checked(checked(num1 * 50) + 2), checked(checked(num * 60) + 12), 44, 44);
						Rectangle rectangle1 = new Rectangle(1, 1, 44, 44);
						graphics.DrawImage(Art.GetStatic(value), rectangle, rectangle1, GraphicsUnit.Pixel);
						value++;
					}
					else
					{
						value++;
					}
					num1++;
				}
				while (num1 <= 5);
				num++;
			}
			while (num <= 7);
			graphics = null;
		}

		private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
			this.Refresh();
		}
	}
}