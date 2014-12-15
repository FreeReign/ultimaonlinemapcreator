using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Terrain;
using Transition;
using Ultima;

using Microsoft.VisualBasic.CompilerServices;

namespace CreateStatics
{
    public partial class CreateStatics : Form
    {
        private ClsTerrainTable iTerrain;
        private RandomStatics iRandomStatic;
        private Art UOArt;
        private TileData UOStatic;
        private Point[,] StaticGrid;


        public CreateStatics()
        {
            CreateStatics sEdit = this;
            base.Load += new EventHandler(sEdit.SEdit_Load);
            this.StaticGrid = new Point[13, 13];
            this.iTerrain = new ClsTerrainTable();
            this.iRandomStatic = new RandomStatics();
            InitializeComponent();

            int num = 302;
			int num1 = 246;
			int num2 = 0;
			do
			{
				int num3 = 0;
				do
				{
					Point[,] staticGrid = this.StaticGrid;
					Point point = new Point(checked(num - checked(num3 * 22)), checked(num1 + checked(num3 * 22)));
					staticGrid[num3, num2] = point;
					num3++;
				}
				while (num3 <= 12);
				num = checked(num + 22);
				num1 = checked(num1 + 22);
				num2++;
			}
			while (num2 <= 12);
		}

        private void GroupSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Panel3.Refresh();
        }

        private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.UpdatePanel();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PictureBox1.Image = null;
            RandomStaticCollection selectedItem = (RandomStaticCollection)this.ListBox1.SelectedItem;
            if (selectedItem != null)
            {
                this.TextBox3.Text = selectedItem.Description;
                this.NumericUpDown4.Value = new decimal(selectedItem.Freq);
                selectedItem.Display(this.ListBox2);
                this.Panel3.Refresh();
            }
        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RandomStatic selectedItem = (RandomStatic)this.ListBox2.SelectedItem;
            if (selectedItem != null)
            {
                RandomStatic randomStatic = selectedItem;
                this.VScrollBar1.Value = randomStatic.TileID;
                if (Art.GetStatic(randomStatic.TileID) != null)
                {
                    this.PictureBox1.Image = Art.GetStatic(randomStatic.TileID);
                    this.PropertyGrid1.SelectedObject = TileData.ItemTable[randomStatic.TileID];
                }
                this.TileID.Text = StringType.FromInteger(randomStatic.TileID);
                this.Xaxis.Value = new decimal(randomStatic.X);
                this.Yaxis.Value = new decimal(randomStatic.Y);
                this.Zaxis.Value = new decimal(randomStatic.Z);
                this.HueID.Text = StringType.FromInteger(randomStatic.Hue);
                randomStatic = null;
            }
        }

        private void MenuLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = string.Format("{0}Data/Statics", AppDomain.CurrentDomain.BaseDirectory),
                Filter = "xml files (*.xml)|*.xml",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                this.TextBox1.Text = fileInfo.Name;
                this.iRandomStatic = new RandomStatics(fileInfo.Name);
                this.iRandomStatic.Display(this.ListBox1);
                this.Panel3.Refresh();
            }
        }

        private void MenuNew_Click(object sender, EventArgs e)
        {
            //this.iRandomStatic = new RandomStatics();
            new CreateStatics().Show();
            this.Hide();
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                InitialDirectory = string.Format("{0}Data/Statics", AppDomain.CurrentDomain.BaseDirectory),
                Filter = "xml files (*.xml)|*.xml",
                FileName = this.TextBox1.Text,
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.iRandomStatic.Save(saveFileDialog.FileName);
            }
        }

        private void NumericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            RandomStaticCollection selectedItem = (RandomStaticCollection)this.ListBox1.SelectedItem;
            if (selectedItem != null)
            {
                selectedItem.Freq = Convert.ToInt32(this.NumericUpDown4.Value);
            }
        }

        private void NumericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            this.iRandomStatic.Freq = Convert.ToInt32(this.NumericUpDown5.Value);
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
            IEnumerator enumerator = null;
			Graphics graphics = e.Graphics;
			Pen pen = new Pen(Color.Gray);
			ClsTerrain selectedItem = (ClsTerrain)this.GroupSelect.SelectedItem;
			int num = 0;
			do
			{
				int num1 = 0;
				do
				{
					int num2 = num1;
					int num3 = num;
					if (selectedItem != null)
					{
						e.Graphics.DrawImage(Art.GetLand(selectedItem.TileID), checked(this.StaticGrid[num2, num3].X - 22), checked(this.StaticGrid[num2, num3].Y - 22));
					}
					e.Graphics.DrawLine(pen, checked(this.StaticGrid[num2, num3].X - 22), this.StaticGrid[num2, num3].Y, this.StaticGrid[num2, num3].X, checked(this.StaticGrid[num2, num3].Y + 22));
					e.Graphics.DrawLine(pen, this.StaticGrid[num2, num3].X, checked(this.StaticGrid[num2, num3].Y + 22), checked(this.StaticGrid[num2, num3].X + 22), this.StaticGrid[num2, num3].Y);
					e.Graphics.DrawLine(pen, checked(this.StaticGrid[num2, num3].X + 22), this.StaticGrid[num2, num3].Y, this.StaticGrid[num2, num3].X, checked(this.StaticGrid[num2, num3].Y - 22));
					e.Graphics.DrawLine(pen, this.StaticGrid[num2, num3].X, checked(this.StaticGrid[num2, num3].Y - 22), checked(this.StaticGrid[num2, num3].X - 22), this.StaticGrid[num2, num3].Y);
					num1++;
				}
				while (num1 <= 12);
				num++;
			}
			while (num <= 12);
			pen = new Pen(Color.Red);
			int num4 = Convert.ToInt32(decimal.Add(new decimal(6L), this.Yaxis.Value));
			int num5 = Convert.ToInt32(decimal.Add(new decimal(6L), this.Xaxis.Value));
			e.Graphics.DrawLine(pen, checked(this.StaticGrid[num4, num5].X - 22), this.StaticGrid[num4, num5].Y, this.StaticGrid[num4, num5].X, checked(this.StaticGrid[num4, num5].Y + 22));
			e.Graphics.DrawLine(pen, this.StaticGrid[num4, num5].X, checked(this.StaticGrid[num4, num5].Y + 22), checked(this.StaticGrid[num4, num5].X + 22), this.StaticGrid[num4, num5].Y);
			e.Graphics.DrawLine(pen, checked(this.StaticGrid[num4, num5].X + 22), this.StaticGrid[num4, num5].Y, this.StaticGrid[num4, num5].X, checked(this.StaticGrid[num4, num5].Y - 22));
			e.Graphics.DrawLine(pen, this.StaticGrid[num4, num5].X, checked(this.StaticGrid[num4, num5].Y - 22), checked(this.StaticGrid[num4, num5].X - 22), this.StaticGrid[num4, num5].Y);
			try
			{
				enumerator = this.ListBox2.Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					RandomStatic current = (RandomStatic)enumerator.Current;
					int y = checked(6 + current.Y);
					int x = checked(6 + current.X);
					Bitmap @static = Art.GetStatic(current.TileID);
					Point point = new Point(checked((int)Math.Round((double)this.StaticGrid[y, x].X - (double)@static.Width / 2)), checked(checked(this.StaticGrid[y, x].Y - @static.Height) + 22));
					e.Graphics.DrawImage(@static, point);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			graphics = null;
		}

        private void SEdit_Load(object sender, EventArgs e)
        {
            this.iTerrain.Load();
            this.iTerrain.Display(this.GroupSelect);
        }

        private void StaticZoom_Click(object sender, EventArgs e)
        {
            (new RStaticZoom()
            {
                Tag = this.VScrollBar1
            }).Show();
        }

        private void ToolBar1_ButtonClick(object sender, EventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;
            if (button == null)
            {
                return;
            }

            RandomStaticCollection selectedItem = (RandomStaticCollection)this.ListBox1.SelectedItem;
            if (selectedItem != null)
            {
                object tag = button.Tag;
                if (ObjectType.ObjTst(tag, "Add", false) == 0)
                {
                    selectedItem.Add(new RandomStatic(ShortType.FromString(this.TileID.Text), Convert.ToInt16(this.Xaxis.Value), Convert.ToInt16(this.Yaxis.Value), Convert.ToInt16(this.Zaxis.Value), ShortType.FromString(this.HueID.Text)));
                    selectedItem.Display(this.ListBox2);
                    this.Panel3.Refresh();
                }
                else if (ObjectType.ObjTst(tag, "Delete", false) == 0)
                {
                    selectedItem.Remove((RandomStatic)this.ListBox2.SelectedItem);
                    selectedItem.Display(this.ListBox2);
                    this.Panel3.Refresh();
                }
            }
        }

        private void ToolBar2_ButtonClick(object sender, EventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;
            if (button == null)
            {
                return;
            }

            object tag = button.Tag;
            if (ObjectType.ObjTst(tag, "Add", false) == 0)
            {
                if (StringType.StrCmp(this.TextBox3.Text, string.Empty, false) == 0)
                {
                    return;
                }
                this.iRandomStatic.Add(new RandomStaticCollection(this.TextBox3.Text, Convert.ToInt32(this.NumericUpDown4.Value)));
                this.iRandomStatic.Display(this.ListBox1);
                this.Panel3.Refresh();
            }

            else if (ObjectType.ObjTst(tag, "Delete", false) == 0)
            {
                this.iRandomStatic.Remove((RandomStaticCollection)this.ListBox1.SelectedItem);
                this.iRandomStatic.Display(this.ListBox1);
                this.Panel3.Refresh();
            }
        }

        private void ToolBar_NavClick(object sender, EventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;
            if (button == null)
            {
                return;
            }
            short num = Convert.ToInt16(this.Xaxis.Value);
            short y = Convert.ToInt16(this.Yaxis.Value);
            RandomStatic selectedItem = (RandomStatic)this.ListBox2.SelectedItem;
            if (selectedItem != null)
            {
                num = selectedItem.X;
                y = selectedItem.Y;
            }
            object tag = button.Tag;
            if (ObjectType.ObjTst(tag, 1, false) == 0)
            {
                y = checked((short)(checked(y - 1)));
                num = checked((short)(checked(num - 1)));
            }
            else if (ObjectType.ObjTst(tag, 2, false) == 0)
            {
                y = checked((short)(checked(y - 1)));
            }
            else if (ObjectType.ObjTst(tag, 3, false) == 0)
            {
                y = checked((short)(checked(y - 1)));
                num = checked((short)(checked(num + 1)));
            }
            else if (ObjectType.ObjTst(tag, 4, false) == 0)
            {
                num = checked((short)(checked(num - 1)));
            }
            else if (ObjectType.ObjTst(tag, 5, false) != 0)
            {
                if (ObjectType.ObjTst(tag, 6, false) == 0)
                {
                    num = checked((short)(checked(num + 1)));
                }
                else if (ObjectType.ObjTst(tag, 7, false) == 0)
                {
                    y = checked((short)(checked(y + 1)));
                    num = checked((short)(checked(num - 1)));
                }
                else if (ObjectType.ObjTst(tag, 8, false) == 0)
                {
                    y = checked((short)(checked(y + 1)));
                }
                else if (ObjectType.ObjTst(tag, 9, false) == 0)
                {
                    y = checked((short)(checked(y + 1)));
                    num = checked((short)(checked(num + 1)));
                }
            }
            this.Xaxis.Value = new decimal(num);
            this.Yaxis.Value = new decimal(y);
            if (selectedItem != null)
            {
                selectedItem.X = num;
                selectedItem.Y = y;
            }
            this.Panel3.Refresh();
        }

        private void UpdatePanel()
        {
            Panel panel3 = this.Panel3;
            Point point = new Point(checked(this.HScrollBar1.Value * -1), checked(this.VScrollBar2.Value * -1));
            panel3.Location = point;
        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateVScrollBar1();
        }

        private void UpdateVScrollBar1()
        {
            if (Art.GetStatic(this.VScrollBar1.Value) != null && this.VScrollBar1.Value < TileData.ItemTable.Length)
            {
                this.TileID.Text = this.VScrollBar1.Value.ToString();
                this.PictureBox1.Image = Art.GetStatic(this.VScrollBar1.Value);
                this.PropertyGrid1.SelectedObject = TileData.ItemTable[this.VScrollBar1.Value];
                this.TileDesc.Text = string.Format("{0} ({1})", TileData.ItemTable[this.VScrollBar1.Value].Name, this.VScrollBar1.Value);
            }
        }

        private void VScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            UpdateVScrollBar1();
        }

        private void VScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            this.UpdatePanel();
        }

        private void Xaxis_ValueChanged(object sender, EventArgs e)
        {
            this.Panel3.Refresh();
        }

        private void Yaxis_ValueChanged(object sender, EventArgs e)
        {
            this.Panel3.Refresh();
        }
    }
}
