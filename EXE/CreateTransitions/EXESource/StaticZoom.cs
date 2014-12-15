using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ultima;

using Microsoft.VisualBasic.CompilerServices;

namespace CreateTransitions
{
    public partial class StaticZoom : Form
    {
        private Art UOArt;
        private int iSelected;

        public StaticZoom()
        {
            this.iSelected = 0;
            InitializeComponent();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Arial", 8f);
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black);
            Graphics graphics = e.Graphics;
            graphics.Clear(Color.LightGray);
            int index = this.VScrollBar1.Value;
            int num1 = 0;
            do
            {
                int num2 = 0;
                do
                {
                    graphics.DrawRectangle(pen, checked(num2 * 50), checked(num1 * 60), 48, 58);
                    if (Art.GetStatic(index) == null)
                    {
                        checked { ++index; }
                    }
                    else
                    {
                        graphics.DrawString(index.ToString(), font, (Brush)solidBrush, (float)checked(num2 * 50 + 1), (float)checked(num1 * 60 + 1));
                        Rectangle destRect = new Rectangle(checked(num2 * 50 + 2), checked(num1 * 60 + 12), 44, 44);
                        Rectangle srcRect = new Rectangle(1, 1, 44, 44);
                        graphics.DrawImage((Image)Art.GetStatic(index), destRect, srcRect, GraphicsUnit.Pixel);
                        checked { ++index; }
                    }
                    checked { ++num2; }
                }
                while (num2 <= 5);
                checked { ++num1; }
            }
            while (num1 <= 7);
        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.Refresh();
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            int x = e.X;
            int num1 = 0;
            if (x >= 0 && x <= 49)
                num1 = 0;
            else if (x >= 50 && x <= 99)
                num1 = 1;
            else if (x >= 100 && x <= 149)
                num1 = 2;
            else if (x >= 150 && x <= 199)
                num1 = 3;
            else if (x >= 200 && x <= 249)
                num1 = 4;
            else if (x >= 250 && x <= 399)
                num1 = 5;
            int y = e.Y;
            int num2 = 0;
            if (y >= 0 && y <= 59)
                num2 = 0;
            else if (y >= 60 && y <= 118)
                num2 = 1;
            else if (y >= 120 && y <= 177)
                num2 = 2;
            else if (y >= 180 && y <= 236)
                num2 = 3;
            else if (y >= 240 && y <= 295)
                num2 = 4;
            else if (y >= 300 && y <= 354)
                num2 = 5;
            else if (y >= 360 && y <= 413)
                num2 = 6;
            else if (y >= 420 && y <= 472)
                num2 = 7;
            this.iSelected = checked(this.VScrollBar1.Value + num2 * 6 + num1);
            LateBinding.LateSetComplex(this.Tag, (Type)null, "Value", new object[1]
            {
                (object) this.iSelected
            }, (string[])null, 0 != 0, 1 != 0);
            if (Art.GetStatic(this.iSelected) != null)
            {
                this.PictureBox1.Image = (Image)Art.GetStatic(this.iSelected);
                this.PictureBox1.Refresh();
            }
        }
    }
}
