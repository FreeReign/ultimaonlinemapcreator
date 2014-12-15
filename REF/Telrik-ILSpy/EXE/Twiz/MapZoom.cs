using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ultima;

namespace Twiz
{
	public class MapZoom : Form
	{
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		[AccessedThroughProperty("VScrollBar1")]
		private VScrollBar _VScrollBar1;

		private IContainer components;

		private Art UOArt;

		internal virtual Panel Panel1
		{
			get
			{
				return this._Panel1;
			}
			set
			{
				if (this._Panel1 != null)
				{
					MapZoom mapZoom = this;
					this._Panel1.Paint -= new PaintEventHandler(mapZoom.Panel1_Paint);
					MapZoom mapZoom1 = this;
					this._Panel1.MouseDown -= new MouseEventHandler(mapZoom1.Panel1_MouseDown);
				}
				this._Panel1 = value;
				if (this._Panel1 != null)
				{
					MapZoom mapZoom2 = this;
					this._Panel1.Paint += new PaintEventHandler(mapZoom2.Panel1_Paint);
					MapZoom mapZoom3 = this;
					this._Panel1.MouseDown += new MouseEventHandler(mapZoom3.Panel1_MouseDown);
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
					MapZoom mapZoom = this;
					this._VScrollBar1.Scroll -= new ScrollEventHandler(mapZoom.VScrollBar1_Scroll);
				}
				this._VScrollBar1 = value;
				if (this._VScrollBar1 != null)
				{
					MapZoom mapZoom1 = this;
					this._VScrollBar1.Scroll += new ScrollEventHandler(mapZoom1.VScrollBar1_Scroll);
				}
			}
		}

		public MapZoom()
		{
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
			this.VScrollBar1 = new VScrollBar();
			this.Panel1 = new Panel();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			this.VScrollBar1.Dock = DockStyle.Right;
			this.VScrollBar1.LargeChange = 16;
			VScrollBar vScrollBar1 = this.VScrollBar1;
			Point point = new Point(302, 0);
			vScrollBar1.Location = point;
			this.VScrollBar1.Maximum = 16384;
			this.VScrollBar1.Name = "VScrollBar1";
			VScrollBar vScrollBar = this.VScrollBar1;
			System.Drawing.Size size = new System.Drawing.Size(16, 480);
			vScrollBar.Size = size;
			this.VScrollBar1.TabIndex = 0;
			this.Panel1.Controls.Add(this.VScrollBar1);
			Panel panel1 = this.Panel1;
			point = new Point(8, 8);
			panel1.Location = point;
			this.Panel1.Name = "Panel1";
			Panel panel = this.Panel1;
			size = new System.Drawing.Size(318, 480);
			panel.Size = size;
			this.Panel1.TabIndex = 1;
			size = new System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new System.Drawing.Size(334, 499);
			this.ClientSize = size;
			this.Controls.Add(this.Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "MapZoom";
			this.Text = "Map Tiles";
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private void Panel1_MouseDown(object sender, MouseEventArgs e)
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
				object tag = this.Tag;
				object[] value = new object[] { checked(checked(this.VScrollBar1.Value + checked(num1 * 6)) + num) };
				LateBinding.LateSetComplex(tag, null, "Value", value, null, false, true);
			}
		}

		private void Panel1_Paint(object sender, PaintEventArgs e)
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
					if (Art.GetLand(value) != null)
					{
						graphics.DrawString(value.ToString(), font, solidBrush, (float)(checked(checked(num1 * 50) + 1)), (float)(checked(checked(num * 60) + 1)));
						Bitmap land = Art.GetLand(value);
						Point point = new Point(checked(checked(num1 * 50) + 2), checked(checked(num * 60) + 12));
						graphics.DrawImage(land, point);
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