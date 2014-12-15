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

namespace TransitionWizard
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
                if (Art.GetStatic(this.iSelected) != null)
                {
                    this.PictureBox1.Image = Art.GetStatic(this.iSelected);
                    this.PictureBox1.Refresh();
                }
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
