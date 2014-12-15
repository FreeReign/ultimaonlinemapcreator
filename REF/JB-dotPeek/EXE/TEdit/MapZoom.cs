// Decompiled with JetBrains decompiler
// Type: TEdit.MapZoom
// Assembly: TEdit, Version=1.0.1819.29268, Culture=neutral, PublicKeyToken=null
// MVID: 17FAC474-4301-4029-AF6B-D3AA98301AC6
// Assembly location: W:\JetBrains\UOLandscaper\TEdit.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ultima;

namespace TEdit
{
  public class MapZoom : Form
  {
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("VScrollBar1")]
    private VScrollBar _VScrollBar1;
    private IContainer components;
    private Art UOArt;

    internal virtual VScrollBar VScrollBar1
    {
      get
      {
        return this._VScrollBar1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._VScrollBar1 != null)
          this._VScrollBar1.Scroll -= new ScrollEventHandler(this.VScrollBar1_Scroll);
        this._VScrollBar1 = value;
        if (this._VScrollBar1 == null)
          return;
        this._VScrollBar1.Scroll += new ScrollEventHandler(this.VScrollBar1_Scroll);
      }
    }

    internal virtual Panel Panel1
    {
      get
      {
        return this._Panel1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Panel1 != null)
        {
          this._Panel1.Paint -= new PaintEventHandler(this.Panel1_Paint);
          this._Panel1.MouseDown -= new MouseEventHandler(this.Panel1_MouseDown);
        }
        this._Panel1 = value;
        if (this._Panel1 == null)
          return;
        this._Panel1.Paint += new PaintEventHandler(this.Panel1_Paint);
        this._Panel1.MouseDown += new MouseEventHandler(this.Panel1_MouseDown);
      }
    }

    public MapZoom()
    {
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
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
      VScrollBar vscrollBar1_1 = this.VScrollBar1;
      Point point1 = new Point(302, 0);
      Point point2 = point1;
      vscrollBar1_1.Location = point2;
      this.VScrollBar1.Maximum = 16384;
      this.VScrollBar1.Name = "VScrollBar1";
      VScrollBar vscrollBar1_2 = this.VScrollBar1;
      Size size1 = new Size(16, 480);
      Size size2 = size1;
      vscrollBar1_2.Size = size2;
      this.VScrollBar1.TabIndex = 0;
      this.Panel1.Controls.Add((Control) this.VScrollBar1);
      Panel panel1_1 = this.Panel1;
      point1 = new Point(8, 8);
      Point point3 = point1;
      panel1_1.Location = point3;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      size1 = new Size(318, 480);
      Size size3 = size1;
      panel1_2.Size = size3;
      this.Panel1.TabIndex = 1;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(334, 499);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Panel1);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Name = "MapZoom";
      this.Text = "Map Tiles";
      this.Panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void Panel1_Paint(object sender, PaintEventArgs e)
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
          graphics.DrawRectangle(pen, checked (num2 * 50), checked (num1 * 60), 48, 58);
          if (Art.GetLand(index) == null)
          {
            checked { ++index; }
          }
          else
          {
            graphics.DrawString(index.ToString(), font, (Brush) solidBrush, (float) checked (num2 * 50 + 1), (float) checked (num1 * 60 + 1));
            graphics.DrawImage((Image) Art.GetLand(index), new Point(checked (num2 * 50 + 2), checked (num1 * 60 + 12)));
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

    private void Panel1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      int x = e.X;
      int num1;
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
      int num2;
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
      LateBinding.LateSetComplex(this.Tag, (Type) null, "Value", new object[1]
      {
        (object) checked (this.VScrollBar1.Value + num2 * 6 + num1)
      }, (string[]) null, 0 != 0, 1 != 0);
    }
  }
}
