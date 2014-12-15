// Decompiled with JetBrains decompiler
// Type: DataVeiwer.Veiwer
// Assembly: DataVeiwer, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: 7660395F-2492-4B8F-8FDD-75A5A20BD629
// Assembly location: W:\JetBrains\UOLandscaper\DataViewer.exe

using Altitude;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Terrain;
using Ultima;

namespace DataVeiwer
{
  public class Veiwer : Form
  {
    [AccessedThroughProperty("MenuItem14")]
    private MenuItem _MenuItem14;
    [AccessedThroughProperty("MenuItem13")]
    private MenuItem _MenuItem13;
    [AccessedThroughProperty("MenuItem12")]
    private MenuItem _MenuItem12;
    [AccessedThroughProperty("MenuItem11")]
    private MenuItem _MenuItem11;
    [AccessedThroughProperty("MenuItem4")]
    private MenuItem _MenuItem4;
    [AccessedThroughProperty("MenuItem10")]
    private MenuItem _MenuItem10;
    [AccessedThroughProperty("MenuItem9")]
    private MenuItem _MenuItem9;
    [AccessedThroughProperty("ListBox1")]
    private ListBox _ListBox1;
    [AccessedThroughProperty("MenuItem2")]
    private MenuItem _MenuItem2;
    [AccessedThroughProperty("MenuItem1")]
    private MenuItem _MenuItem1;
    [AccessedThroughProperty("MenuItem8")]
    private MenuItem _MenuItem8;
    [AccessedThroughProperty("MainMenu1")]
    private MainMenu _MainMenu1;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("PropertyGrid1")]
    private PropertyGrid _PropertyGrid1;
    [AccessedThroughProperty("MenuItem5")]
    private MenuItem _MenuItem5;
    [AccessedThroughProperty("MenuItem6")]
    private MenuItem _MenuItem6;
    [AccessedThroughProperty("MenuItem3")]
    private MenuItem _MenuItem3;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("MenuItem7")]
    private MenuItem _MenuItem7;
    private IContainer components;
    private int i_Menu;
    private Art i_UOArt;
    private ClsAltitudeTable i_Altitude;
    private ClsTerrainTable i_Terrain;

    internal virtual ListBox ListBox1
    {
      get
      {
        return this._ListBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ListBox1 != null)
          this._ListBox1.SelectedIndexChanged -= new EventHandler(this.ListBox1_SelectedIndexChanged);
        this._ListBox1 = value;
        if (this._ListBox1 == null)
          return;
        this._ListBox1.SelectedIndexChanged += new EventHandler(this.ListBox1_SelectedIndexChanged);
      }
    }

    internal virtual PropertyGrid PropertyGrid1
    {
      get
      {
        return this._PropertyGrid1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PropertyGrid1 == null)
          ;
        this._PropertyGrid1 = value;
        if (this._PropertyGrid1 != null)
          ;
      }
    }

    internal virtual Label Label1
    {
      get
      {
        return this._Label1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label1 == null)
          ;
        this._Label1 = value;
        if (this._Label1 != null)
          ;
      }
    }

    internal virtual Label Label2
    {
      get
      {
        return this._Label2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label2 == null)
          ;
        this._Label2 = value;
        if (this._Label2 != null)
          ;
      }
    }

    internal virtual PictureBox PictureBox1
    {
      get
      {
        return this._PictureBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox1 == null)
          ;
        this._PictureBox1 = value;
        if (this._PictureBox1 != null)
          ;
      }
    }

    internal virtual MainMenu MainMenu1
    {
      get
      {
        return this._MainMenu1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MainMenu1 == null)
          ;
        this._MainMenu1 = value;
        if (this._MainMenu1 != null)
          ;
      }
    }

    internal virtual MenuItem MenuItem1
    {
      get
      {
        return this._MenuItem1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem1 == null)
          ;
        this._MenuItem1 = value;
        if (this._MenuItem1 != null)
          ;
      }
    }

    internal virtual MenuItem MenuItem2
    {
      get
      {
        return this._MenuItem2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem2 != null)
          this._MenuItem2.Click -= new EventHandler(this.MenuItem2_Click);
        this._MenuItem2 = value;
        if (this._MenuItem2 == null)
          return;
        this._MenuItem2.Click += new EventHandler(this.MenuItem2_Click);
      }
    }

    internal virtual MenuItem MenuItem3
    {
      get
      {
        return this._MenuItem3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem3 != null)
          this._MenuItem3.Click -= new EventHandler(this.MenuItem3_Click);
        this._MenuItem3 = value;
        if (this._MenuItem3 == null)
          return;
        this._MenuItem3.Click += new EventHandler(this.MenuItem3_Click);
      }
    }

    internal virtual MenuItem MenuItem4
    {
      get
      {
        return this._MenuItem4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem4 == null)
          ;
        this._MenuItem4 = value;
        if (this._MenuItem4 != null)
          ;
      }
    }

    internal virtual MenuItem MenuItem5
    {
      get
      {
        return this._MenuItem5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem5 != null)
          this._MenuItem5.Click -= new EventHandler(this.MenuItem5_Click);
        this._MenuItem5 = value;
        if (this._MenuItem5 == null)
          return;
        this._MenuItem5.Click += new EventHandler(this.MenuItem5_Click);
      }
    }

    internal virtual MenuItem MenuItem6
    {
      get
      {
        return this._MenuItem6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem6 != null)
          this._MenuItem6.Click -= new EventHandler(this.MenuItem6_Click);
        this._MenuItem6 = value;
        if (this._MenuItem6 == null)
          return;
        this._MenuItem6.Click += new EventHandler(this.MenuItem6_Click);
      }
    }

    internal virtual Label Label3
    {
      get
      {
        return this._Label3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label3 == null)
          ;
        this._Label3 = value;
        if (this._Label3 != null)
          ;
      }
    }

    internal virtual MenuItem MenuItem7
    {
      get
      {
        return this._MenuItem7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem7 == null)
          ;
        this._MenuItem7 = value;
        if (this._MenuItem7 != null)
          ;
      }
    }

    internal virtual MenuItem MenuItem8
    {
      get
      {
        return this._MenuItem8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem8 == null)
          ;
        this._MenuItem8 = value;
        if (this._MenuItem8 != null)
          ;
      }
    }

    internal virtual MenuItem MenuItem9
    {
      get
      {
        return this._MenuItem9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem9 != null)
          this._MenuItem9.Click -= new EventHandler(this.MenuItem9_Click);
        this._MenuItem9 = value;
        if (this._MenuItem9 == null)
          return;
        this._MenuItem9.Click += new EventHandler(this.MenuItem9_Click);
      }
    }

    internal virtual MenuItem MenuItem10
    {
      get
      {
        return this._MenuItem10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem10 == null)
          ;
        this._MenuItem10 = value;
        if (this._MenuItem10 != null)
          ;
      }
    }

    internal virtual MenuItem MenuItem11
    {
      get
      {
        return this._MenuItem11;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem11 == null)
          ;
        this._MenuItem11 = value;
        if (this._MenuItem11 != null)
          ;
      }
    }

    internal virtual MenuItem MenuItem12
    {
      get
      {
        return this._MenuItem12;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem12 != null)
          this._MenuItem12.Click -= new EventHandler(this.MenuItem12_Click);
        this._MenuItem12 = value;
        if (this._MenuItem12 == null)
          return;
        this._MenuItem12.Click += new EventHandler(this.MenuItem12_Click);
      }
    }

    internal virtual MenuItem MenuItem13
    {
      get
      {
        return this._MenuItem13;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem13 != null)
          this._MenuItem13.Click -= new EventHandler(this.MenuItem13_Click);
        this._MenuItem13 = value;
        if (this._MenuItem13 == null)
          return;
        this._MenuItem13.Click += new EventHandler(this.MenuItem13_Click);
      }
    }

    internal virtual MenuItem MenuItem14
    {
      get
      {
        return this._MenuItem14;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem14 != null)
          this._MenuItem14.Click -= new EventHandler(this.MenuItem14_Click);
        this._MenuItem14 = value;
        if (this._MenuItem14 == null)
          return;
        this._MenuItem14.Click += new EventHandler(this.MenuItem14_Click);
      }
    }

    public Veiwer()
    {
      this.Load += new EventHandler(this.Veiwer_Load);
      this.i_Menu = 0;
      this.i_Altitude = new ClsAltitudeTable();
      this.i_Terrain = new ClsTerrainTable();
      this.InitializeComponent();
    }

    [STAThread]
    public static void Main()
    {
      Application.Run((Form) new Veiwer());
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
      ResourceManager resourceManager = new ResourceManager(typeof (Veiwer));
      this.ListBox1 = new ListBox();
      this.PropertyGrid1 = new PropertyGrid();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.PictureBox1 = new PictureBox();
      this.MainMenu1 = new MainMenu();
      this.MenuItem1 = new MenuItem();
      this.MenuItem2 = new MenuItem();
      this.MenuItem3 = new MenuItem();
      this.MenuItem7 = new MenuItem();
      this.MenuItem8 = new MenuItem();
      this.MenuItem9 = new MenuItem();
      this.MenuItem13 = new MenuItem();
      this.MenuItem4 = new MenuItem();
      this.MenuItem5 = new MenuItem();
      this.MenuItem6 = new MenuItem();
      this.MenuItem10 = new MenuItem();
      this.MenuItem11 = new MenuItem();
      this.MenuItem12 = new MenuItem();
      this.MenuItem14 = new MenuItem();
      this.Label3 = new Label();
      this.SuspendLayout();
      ListBox listBox1_1 = this.ListBox1;
      Point point1 = new Point(8, 24);
      Point point2 = point1;
      listBox1_1.Location = point2;
      this.ListBox1.Name = "ListBox1";
      ListBox listBox1_2 = this.ListBox1;
      Size size1 = new Size(224, 368);
      Size size2 = size1;
      listBox1_2.Size = size2;
      this.ListBox1.Sorted = true;
      this.ListBox1.TabIndex = 1;
      this.PropertyGrid1.CommandsBackColor = Color.FromArgb(224, 224, 224);
      this.PropertyGrid1.CommandsVisibleIfAvailable = true;
      this.PropertyGrid1.HelpVisible = false;
      this.PropertyGrid1.LargeButtons = false;
      this.PropertyGrid1.LineColor = SystemColors.ScrollBar;
      PropertyGrid propertyGrid1_1 = this.PropertyGrid1;
      point1 = new Point(240, 24);
      Point point3 = point1;
      propertyGrid1_1.Location = point3;
      this.PropertyGrid1.Name = "PropertyGrid1";
      PropertyGrid propertyGrid1_2 = this.PropertyGrid1;
      size1 = new Size(216, 312);
      Size size3 = size1;
      propertyGrid1_2.Size = size3;
      this.PropertyGrid1.TabIndex = 2;
      this.PropertyGrid1.Text = "PropertyGrid1";
      this.PropertyGrid1.ViewBackColor = SystemColors.Window;
      this.PropertyGrid1.ViewForeColor = SystemColors.WindowText;
      this.Label1.AutoSize = true;
      this.Label1.ForeColor = Color.Blue;
      Label label1_1 = this.Label1;
      point1 = new Point(8, 8);
      Point point4 = point1;
      label1_1.Location = point4;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(61, 16);
      Size size4 = size1;
      label1_2.Size = size4;
      this.Label1.TabIndex = 3;
      this.Label1.Text = "Terrain List";
      this.Label2.AutoSize = true;
      this.Label2.ForeColor = Color.Blue;
      Label label2_1 = this.Label2;
      point1 = new Point(240, 8);
      Point point5 = point1;
      label2_1.Location = point5;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(77, 16);
      Size size5 = size1;
      label2_2.Size = size5;
      this.Label2.TabIndex = 4;
      this.Label2.Text = "Tile Properties";
      this.PictureBox1.BorderStyle = BorderStyle.FixedSingle;
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(240, 344);
      Point point6 = point1;
      pictureBox1_1.Location = point6;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(46, 46);
      Size size6 = size1;
      pictureBox1_2.Size = size6;
      this.PictureBox1.TabIndex = 5;
      this.PictureBox1.TabStop = false;
      this.MainMenu1.MenuItems.AddRange(new MenuItem[2]
      {
        this.MenuItem1,
        this.MenuItem4
      });
      this.MenuItem1.Index = 0;
      this.MenuItem1.MenuItems.AddRange(new MenuItem[4]
      {
        this.MenuItem2,
        this.MenuItem3,
        this.MenuItem7,
        this.MenuItem8
      });
      this.MenuItem1.Text = "Terrain";
      this.MenuItem2.Index = 0;
      this.MenuItem2.Text = "Load";
      this.MenuItem3.Index = 1;
      this.MenuItem3.Text = "Save";
      this.MenuItem7.Index = 2;
      this.MenuItem7.Text = "-";
      this.MenuItem8.Index = 3;
      this.MenuItem8.MenuItems.AddRange(new MenuItem[2]
      {
        this.MenuItem9,
        this.MenuItem13
      });
      this.MenuItem8.Text = "Export";
      this.MenuItem9.Index = 0;
      this.MenuItem9.Text = "Terrain.ACT";
      this.MenuItem13.Index = 1;
      this.MenuItem13.Text = "Terrain.ACO";
      this.MenuItem4.Index = 1;
      this.MenuItem4.MenuItems.AddRange(new MenuItem[4]
      {
        this.MenuItem5,
        this.MenuItem6,
        this.MenuItem10,
        this.MenuItem11
      });
      this.MenuItem4.Text = "Altitude";
      this.MenuItem5.Index = 0;
      this.MenuItem5.Text = "Load";
      this.MenuItem6.Index = 1;
      this.MenuItem6.Text = "Save";
      this.MenuItem10.Index = 2;
      this.MenuItem10.Text = "-";
      this.MenuItem11.Index = 3;
      this.MenuItem11.MenuItems.AddRange(new MenuItem[2]
      {
        this.MenuItem12,
        this.MenuItem14
      });
      this.MenuItem11.Text = "Export";
      this.MenuItem12.Index = 0;
      this.MenuItem12.Text = "Altitude.ACT";
      this.MenuItem14.Index = 1;
      this.MenuItem14.Text = "Altitude.ACO";
      Label label3_1 = this.Label3;
      point1 = new Point(296, 344);
      Point point7 = point1;
      label3_1.Location = point7;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(160, 48);
      Size size7 = size1;
      label3_2.Size = size7;
      this.Label3.TabIndex = 6;
      this.Label3.Text = "* The altitude will be randomized when the tile has been selected.";
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      this.BackColor = Color.FromArgb(224, 224, 224);
      size1 = new Size(466, 403);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.PropertyGrid1);
      this.Controls.Add((Control) this.ListBox1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Menu = this.MainMenu1;
      this.Name = "Veiwer";
      this.Text = "Data Viewer";
      this.ResumeLayout(false);
    }

    private void MenuItem5_Click(object sender, EventArgs e)
    {
      this.i_Menu = 1;
      this.Label1.Text = "Altitude List";
      this.i_Altitude.Load();
      this.i_Altitude.Display(this.ListBox1);
      this.PictureBox1.Visible = false;
    }

    private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.ListBox1.SelectedItem == null)
        return;
      switch (this.i_Menu)
      {
        case 0:
          ClsTerrain clsTerrain = (ClsTerrain) this.ListBox1.SelectedItem;
          this.PropertyGrid1.SelectedObject = (object) clsTerrain;
          this.PictureBox1.Image = (Image) Art.GetLand((int) clsTerrain.TileID);
          break;
        case 1:
          this.PropertyGrid1.SelectedObject = (object) (ClsAltitude) this.ListBox1.SelectedItem;
          break;
      }
    }

    private void MenuItem2_Click(object sender, EventArgs e)
    {
      this.i_Menu = 0;
      this.Label1.Text = "Terrain List";
      this.i_Terrain.Load();
      this.i_Terrain.Display(this.ListBox1);
      this.PictureBox1.Visible = true;
    }

    private void Veiwer_Load(object sender, EventArgs e)
    {
      this.i_Menu = 0;
      this.Label1.Text = "Terrain List";
      this.i_Terrain.Load();
      this.PictureBox1.Visible = true;
    }

    private void MenuItem6_Click(object sender, EventArgs e)
    {
      this.i_Altitude.Save();
    }

    private void MenuItem3_Click(object sender, EventArgs e)
    {
      this.i_Terrain.Save();
    }

    private void MenuItem9_Click(object sender, EventArgs e)
    {
      this.i_Terrain.SaveACT();
    }

    private void MenuItem12_Click(object sender, EventArgs e)
    {
      this.i_Altitude.SaveACT();
    }

    private void MenuItem13_Click(object sender, EventArgs e)
    {
      this.i_Terrain.SaveACO();
    }

    private void MenuItem14_Click(object sender, EventArgs e)
    {
      this.i_Altitude.SaveACO();
    }
  }
}
