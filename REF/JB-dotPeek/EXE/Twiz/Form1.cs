// Decompiled with JetBrains decompiler
// Type: Twiz.Form1
// Assembly: Twiz, Version=1.0.1819.29268, Culture=neutral, PublicKeyToken=null
// MVID: E1613E23-3BB0-4A6C-8984-26F63596D392
// Assembly location: W:\JetBrains\UOLandscaper\Twiz.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using Terrain;
using Transition;
using Ultima;

namespace Twiz
{
  public class Form1 : Form
  {
    [AccessedThroughProperty("MainMenu1")]
    private MainMenu _MainMenu1;
    [AccessedThroughProperty("Select_Group_B")]
    private ComboBox _Select_Group_B;
    [AccessedThroughProperty("Select_Group_A")]
    private ComboBox _Select_Group_A;
    [AccessedThroughProperty("MenuItem2")]
    private MenuItem _MenuItem2;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("ToolZoom")]
    private ToolBarButton _ToolZoom;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("ToolDelete")]
    private ToolBarButton _ToolDelete;
    [AccessedThroughProperty("ToolAdd")]
    private ToolBarButton _ToolAdd;
    [AccessedThroughProperty("TreeView1")]
    private TreeView _TreeView1;
    [AccessedThroughProperty("MenuItem3")]
    private MenuItem _MenuItem3;
    [AccessedThroughProperty("MenuItem4")]
    private MenuItem _MenuItem4;
    [AccessedThroughProperty("Panel2")]
    private Panel _Panel2;
    [AccessedThroughProperty("MenuItem5")]
    private MenuItem _MenuItem5;
    [AccessedThroughProperty("MenuItem6")]
    private MenuItem _MenuItem6;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("MenuItem7")]
    private MenuItem _MenuItem7;
    [AccessedThroughProperty("MenuItem8")]
    private MenuItem _MenuItem8;
    [AccessedThroughProperty("TileID")]
    private VScrollBar _TileID;
    [AccessedThroughProperty("ImageList1")]
    private ImageList _ImageList1;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("TextBox1")]
    private TextBox _TextBox1;
    [AccessedThroughProperty("ToolBar1")]
    private ToolBar _ToolBar1;
    [AccessedThroughProperty("MenuItem1")]
    private MenuItem _MenuItem1;
    private IContainer components;
    private Art UOArt;
    private bool ViewTiles;
    private TreeNode iMapNode;
    private TreeNode iStaticNode;
    private TreeNode iMapOuterTopLeft;
    private TreeNode iMapOuterTopRight;
    private TreeNode iMapOuterBottomLeft;
    private TreeNode iMapOuterBottomRight;
    private TreeNode iMapInnerTopLeft;
    private TreeNode iMapInnerTop;
    private TreeNode iMapInnerTopRight;
    private TreeNode iMapInnerLeft;
    private TreeNode iMapInnerRight;
    private TreeNode iMapInnerBottomLeft;
    private TreeNode iMapInnerBottom;
    private TreeNode iMapInnerBottomRight;
    private TreeNode iStaticOuterTopLeft;
    private TreeNode iStaticOuterTopRight;
    private TreeNode iStaticOuterBottomLeft;
    private TreeNode iStaticOuterBottomRight;
    private TreeNode iStaticInnerTopLeft;
    private TreeNode iStaticInnerTop;
    private TreeNode iStaticInnerTopRight;
    private TreeNode iStaticInnerLeft;
    private TreeNode iStaticInnerRight;
    private TreeNode iStaticInnerBottomLeft;
    private TreeNode iStaticInnerBottom;
    private TreeNode iStaticInnerBottomRight;
    private ClsTerrainTable iGroupA;
    private ClsTerrainTable iGroupB;

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

    internal virtual Panel Panel2
    {
      get
      {
        return this._Panel2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Panel2 != null)
          this._Panel2.Paint -= new PaintEventHandler(this.Panel2_Paint);
        this._Panel2 = value;
        if (this._Panel2 == null)
          return;
        this._Panel2.Paint += new PaintEventHandler(this.Panel2_Paint);
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
          this._Panel1.Paint -= new PaintEventHandler(this.Panel1_Paint);
        this._Panel1 = value;
        if (this._Panel1 == null)
          return;
        this._Panel1.Paint += new PaintEventHandler(this.Panel1_Paint);
      }
    }

    internal virtual TreeView TreeView1
    {
      get
      {
        return this._TreeView1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TreeView1 != null)
          this._TreeView1.AfterSelect -= new TreeViewEventHandler(this.TreeView1_AfterSelect);
        this._TreeView1 = value;
        if (this._TreeView1 == null)
          return;
        this._TreeView1.AfterSelect += new TreeViewEventHandler(this.TreeView1_AfterSelect);
      }
    }

    internal virtual VScrollBar TileID
    {
      get
      {
        return this._TileID;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TileID != null)
          this._TileID.Scroll -= new ScrollEventHandler(this.LandTileID_Scroll);
        this._TileID = value;
        if (this._TileID == null)
          return;
        this._TileID.Scroll += new ScrollEventHandler(this.LandTileID_Scroll);
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
        if (this._MenuItem2 == null)
          ;
        this._MenuItem2 = value;
        if (this._MenuItem2 != null)
          ;
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
        if (this._MenuItem4 != null)
          this._MenuItem4.Click -= new EventHandler(this.MenuItem4_Click);
        this._MenuItem4 = value;
        if (this._MenuItem4 == null)
          return;
        this._MenuItem4.Click += new EventHandler(this.MenuItem4_Click);
      }
    }

    internal virtual TextBox TextBox1
    {
      get
      {
        return this._TextBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TextBox1 == null)
          ;
        this._TextBox1 = value;
        if (this._TextBox1 != null)
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

    internal virtual ToolBar ToolBar1
    {
      get
      {
        return this._ToolBar1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBar1 != null)
          this._ToolBar1.ButtonClick -= new ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
        this._ToolBar1 = value;
        if (this._ToolBar1 == null)
          return;
        this._ToolBar1.ButtonClick += new ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
      }
    }

    internal virtual ToolBarButton ToolAdd
    {
      get
      {
        return this._ToolAdd;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolAdd == null)
          ;
        this._ToolAdd = value;
        if (this._ToolAdd != null)
          ;
      }
    }

    internal virtual ToolBarButton ToolDelete
    {
      get
      {
        return this._ToolDelete;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolDelete == null)
          ;
        this._ToolDelete = value;
        if (this._ToolDelete != null)
          ;
      }
    }

    internal virtual ToolBarButton ToolZoom
    {
      get
      {
        return this._ToolZoom;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolZoom == null)
          ;
        this._ToolZoom = value;
        if (this._ToolZoom != null)
          ;
      }
    }

    internal virtual ImageList ImageList1
    {
      get
      {
        return this._ImageList1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ImageList1 == null)
          ;
        this._ImageList1 = value;
        if (this._ImageList1 != null)
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
        if (this._MenuItem6 == null)
          ;
        this._MenuItem6 = value;
        if (this._MenuItem6 != null)
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

    internal virtual ComboBox Select_Group_A
    {
      get
      {
        return this._Select_Group_A;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Select_Group_A != null)
          this._Select_Group_A.SelectedIndexChanged -= new EventHandler(this.Select_Group_A_SelectedIndexChanged);
        this._Select_Group_A = value;
        if (this._Select_Group_A == null)
          return;
        this._Select_Group_A.SelectedIndexChanged += new EventHandler(this.Select_Group_A_SelectedIndexChanged);
      }
    }

    internal virtual ComboBox Select_Group_B
    {
      get
      {
        return this._Select_Group_B;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Select_Group_B != null)
          this._Select_Group_B.SelectedIndexChanged -= new EventHandler(this.Select_Group_B_SelectedIndexChanged);
        this._Select_Group_B = value;
        if (this._Select_Group_B == null)
          return;
        this._Select_Group_B.SelectedIndexChanged += new EventHandler(this.Select_Group_B_SelectedIndexChanged);
      }
    }

    public Form1()
    {
      this.Load += new EventHandler(this.Form1_Load);
      this.ViewTiles = false;
      this.iMapNode = new TreeNode("Map Tiles");
      this.iStaticNode = new TreeNode("Static Tiles");
      this.iMapOuterTopLeft = new TreeNode("Outer Top Left");
      this.iMapOuterTopRight = new TreeNode("Outer Top Right");
      this.iMapOuterBottomLeft = new TreeNode("Outer Bottom Left");
      this.iMapOuterBottomRight = new TreeNode("Outer Bottom Right");
      this.iMapInnerTopLeft = new TreeNode("Inner Top Left");
      this.iMapInnerTop = new TreeNode("Inner Top");
      this.iMapInnerTopRight = new TreeNode("Inner Top Right");
      this.iMapInnerLeft = new TreeNode("Inner Left");
      this.iMapInnerRight = new TreeNode("Inner Right");
      this.iMapInnerBottomLeft = new TreeNode("Inner Bottom Left");
      this.iMapInnerBottom = new TreeNode("Inner Bottom");
      this.iMapInnerBottomRight = new TreeNode("Inner Bottom Right");
      this.iStaticOuterTopLeft = new TreeNode("Outer Top Left");
      this.iStaticOuterTopRight = new TreeNode("Outer Top Right");
      this.iStaticOuterBottomLeft = new TreeNode("Outer Bottom Left");
      this.iStaticOuterBottomRight = new TreeNode("Outer Bottom Right");
      this.iStaticInnerTopLeft = new TreeNode("Inner Top Left");
      this.iStaticInnerTop = new TreeNode("Inner Top");
      this.iStaticInnerTopRight = new TreeNode("Inner Top Right");
      this.iStaticInnerLeft = new TreeNode("Inner Left");
      this.iStaticInnerRight = new TreeNode("Inner Right");
      this.iStaticInnerBottomLeft = new TreeNode("Inner Bottom Left");
      this.iStaticInnerBottom = new TreeNode("Inner Bottom");
      this.iStaticInnerBottomRight = new TreeNode("Inner Bottom Right");
      this.iGroupA = new ClsTerrainTable();
      this.iGroupB = new ClsTerrainTable();
      this.InitializeComponent();
    }

    [STAThread]
    public static void Main()
    {
      Application.Run((Form) new Form1());
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
      this.components = (IContainer) new Container();
      ResourceManager resourceManager = new ResourceManager(typeof (Form1));
      this.MainMenu1 = new MainMenu();
      this.MenuItem1 = new MenuItem();
      this.MenuItem6 = new MenuItem();
      this.MenuItem7 = new MenuItem();
      this.MenuItem8 = new MenuItem();
      this.MenuItem2 = new MenuItem();
      this.MenuItem3 = new MenuItem();
      this.MenuItem4 = new MenuItem();
      this.MenuItem5 = new MenuItem();
      this.TreeView1 = new TreeView();
      this.Panel2 = new Panel();
      this.Panel1 = new Panel();
      this.TileID = new VScrollBar();
      this.TextBox1 = new TextBox();
      this.Select_Group_A = new ComboBox();
      this.Select_Group_B = new ComboBox();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.ToolBar1 = new ToolBar();
      this.ToolAdd = new ToolBarButton();
      this.ToolDelete = new ToolBarButton();
      this.ToolZoom = new ToolBarButton();
      this.ImageList1 = new ImageList(this.components);
      this.Panel1.SuspendLayout();
      this.SuspendLayout();
      this.MainMenu1.MenuItems.AddRange(new MenuItem[3]
      {
        this.MenuItem1,
        this.MenuItem2,
        this.MenuItem5
      });
      this.MenuItem1.Index = 0;
      this.MenuItem1.MenuItems.AddRange(new MenuItem[3]
      {
        this.MenuItem6,
        this.MenuItem7,
        this.MenuItem8
      });
      this.MenuItem1.Text = "File";
      this.MenuItem6.Index = 0;
      this.MenuItem6.Text = "New";
      this.MenuItem7.Index = 1;
      this.MenuItem7.Text = "Save";
      this.MenuItem8.Index = 2;
      this.MenuItem8.Text = "Load";
      this.MenuItem2.Index = 1;
      this.MenuItem2.MenuItems.AddRange(new MenuItem[2]
      {
        this.MenuItem3,
        this.MenuItem4
      });
      this.MenuItem2.Text = "View";
      this.MenuItem3.Index = 0;
      this.MenuItem3.Text = "View Map Tiles";
      this.MenuItem4.Index = 1;
      this.MenuItem4.Text = "View Static Tiles";
      this.MenuItem5.Index = 2;
      this.MenuItem5.Text = "Make";
      this.TreeView1.BorderStyle = BorderStyle.FixedSingle;
      this.TreeView1.ImageIndex = -1;
      TreeView treeView1_1 = this.TreeView1;
      Point point1 = new Point(272, 48);
      Point point2 = point1;
      treeView1_1.Location = point2;
      this.TreeView1.Name = "TreeView1";
      this.TreeView1.SelectedImageIndex = -1;
      TreeView treeView1_2 = this.TreeView1;
      Size size1 = new Size(200, 296);
      Size size2 = size1;
      treeView1_2.Size = size2;
      this.TreeView1.TabIndex = 66;
      this.Panel2.BorderStyle = BorderStyle.FixedSingle;
      Panel panel2_1 = this.Panel2;
      point1 = new Point(8, 48);
      Point point3 = point1;
      panel2_1.Location = point3;
      this.Panel2.Name = "Panel2";
      Panel panel2_2 = this.Panel2;
      size1 = new Size(256, 296);
      Size size3 = size1;
      panel2_2.Size = size3;
      this.Panel2.TabIndex = 65;
      this.Panel1.Controls.Add((Control) this.TileID);
      Panel panel1_1 = this.Panel1;
      point1 = new Point(480, 48);
      Point point4 = point1;
      panel1_1.Location = point4;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      size1 = new Size(128, 240);
      Size size4 = size1;
      panel1_2.Size = size4;
      this.Panel1.TabIndex = 64;
      this.TileID.Dock = DockStyle.Right;
      this.TileID.LargeChange = 16;
      VScrollBar tileId1 = this.TileID;
      point1 = new Point(112, 0);
      Point point5 = point1;
      tileId1.Location = point5;
      this.TileID.Maximum = 16381;
      this.TileID.Name = "TileID";
      VScrollBar tileId2 = this.TileID;
      size1 = new Size(16, 240);
      Size size5 = size1;
      tileId2.Size = size5;
      this.TileID.TabIndex = 0;
      TextBox textBox1_1 = this.TextBox1;
      point1 = new Point(272, 24);
      Point point6 = point1;
      textBox1_1.Location = point6;
      this.TextBox1.Name = "TextBox1";
      TextBox textBox1_2 = this.TextBox1;
      size1 = new Size(336, 20);
      Size size6 = size1;
      textBox1_2.Size = size6;
      this.TextBox1.TabIndex = 69;
      this.TextBox1.Text = "";
      ComboBox selectGroupA1 = this.Select_Group_A;
      point1 = new Point(8, 24);
      Point point7 = point1;
      selectGroupA1.Location = point7;
      this.Select_Group_A.Name = "Select_Group_A";
      ComboBox selectGroupA2 = this.Select_Group_A;
      size1 = new Size(121, 21);
      Size size7 = size1;
      selectGroupA2.Size = size7;
      this.Select_Group_A.Sorted = true;
      this.Select_Group_A.TabIndex = 70;
      ComboBox selectGroupB1 = this.Select_Group_B;
      point1 = new Point(136, 24);
      Point point8 = point1;
      selectGroupB1.Location = point8;
      this.Select_Group_B.Name = "Select_Group_B";
      ComboBox selectGroupB2 = this.Select_Group_B;
      size1 = new Size(121, 21);
      Size size8 = size1;
      selectGroupB2.Size = size8;
      this.Select_Group_B.Sorted = true;
      this.Select_Group_B.TabIndex = 71;
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(8, 8);
      Point point9 = point1;
      label1_1.Location = point9;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(46, 16);
      Size size9 = size1;
      label1_2.Size = size9;
      this.Label1.TabIndex = 72;
      this.Label1.Text = "Group A";
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(136, 8);
      Point point10 = point1;
      label2_1.Location = point10;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(46, 16);
      Size size10 = size1;
      label2_2.Size = size10;
      this.Label2.TabIndex = 73;
      this.Label2.Text = "Group B";
      this.Label3.AutoSize = true;
      Label label3_1 = this.Label3;
      point1 = new Point(272, 8);
      Point point11 = point1;
      label3_1.Location = point11;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(61, 16);
      Size size11 = size1;
      label3_2.Size = size11;
      this.Label3.TabIndex = 74;
      this.Label3.Text = "Description";
      this.ToolBar1.Buttons.AddRange(new ToolBarButton[3]
      {
        this.ToolAdd,
        this.ToolDelete,
        this.ToolZoom
      });
      ToolBar toolBar1_1 = this.ToolBar1;
      size1 = new Size(30, 30);
      Size size12 = size1;
      toolBar1_1.ButtonSize = size12;
      this.ToolBar1.Divider = false;
      this.ToolBar1.Dock = DockStyle.None;
      this.ToolBar1.DropDownArrows = true;
      this.ToolBar1.ImageList = this.ImageList1;
      ToolBar toolBar1_2 = this.ToolBar1;
      point1 = new Point(480, 296);
      Point point12 = point1;
      toolBar1_2.Location = point12;
      this.ToolBar1.Name = "ToolBar1";
      this.ToolBar1.ShowToolTips = true;
      ToolBar toolBar1_3 = this.ToolBar1;
      size1 = new Size(128, 42);
      Size size13 = size1;
      toolBar1_3.Size = size13;
      this.ToolBar1.TabIndex = 75;
      this.ToolAdd.ImageIndex = 0;
      this.ToolAdd.Tag = (object) "Add";
      this.ToolDelete.ImageIndex = 1;
      this.ToolDelete.Tag = (object) "Delete";
      this.ToolZoom.ImageIndex = 2;
      this.ToolZoom.Tag = (object) "Zoom";
      ImageList imageList1 = this.ImageList1;
      size1 = new Size(32, 32);
      Size size14 = size1;
      imageList1.ImageSize = size14;
      this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
      this.ImageList1.TransparentColor = Color.Transparent;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      this.BackColor = Color.FromArgb(224, 224, 224);
      size1 = new Size(614, 351);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.ToolBar1);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Select_Group_B);
      this.Controls.Add((Control) this.Select_Group_A);
      this.Controls.Add((Control) this.TextBox1);
      this.Controls.Add((Control) this.Panel2);
      this.Controls.Add((Control) this.TreeView1);
      this.Controls.Add((Control) this.Panel1);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Menu = this.MainMenu1;
      this.Name = "Form1";
      this.Text = "UO Landscaper Transition Wizard";
      this.Panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void Panel1_Paint(object sender, PaintEventArgs e)
    {
      Font font = new Font("Arial", 10f, FontStyle.Regular);
      SolidBrush solidBrush = new SolidBrush(Color.Black);
      Graphics graphics = e.Graphics;
      graphics.DrawString(StringType.FromInteger(this.TileID.Value), font, (Brush) solidBrush, 51f, 5f);
      switch (this.ViewTiles)
      {
        case false:
          if (Art.GetLand(this.TileID.Value) != null)
          {
            graphics.DrawImage((Image) Art.GetLand(this.TileID.Value), new Point(5, 5));
            break;
          }
          else
            break;
        case true:
          if (Art.GetStatic(this.TileID.Value) != null)
            graphics.DrawImage((Image) Art.GetStatic(this.TileID.Value), new Point(5, 5));
          break;
      }
    }

    private void LandTileID_Scroll(object sender, ScrollEventArgs e)
    {
      this.Panel1.Refresh();
    }

    private void NodeInit()
    {
      this.iMapNode.Nodes.Add(this.iMapOuterTopLeft);
      this.iMapNode.Nodes.Add(this.iMapInnerTopLeft);
      this.iMapNode.Nodes.Add(this.iMapInnerTop);
      this.iMapNode.Nodes.Add(this.iMapInnerTopRight);
      this.iMapNode.Nodes.Add(this.iMapOuterTopRight);
      this.iMapNode.Nodes.Add(this.iMapInnerLeft);
      this.iMapNode.Nodes.Add(this.iMapInnerRight);
      this.iMapNode.Nodes.Add(this.iMapOuterBottomLeft);
      this.iMapNode.Nodes.Add(this.iMapInnerBottomLeft);
      this.iMapNode.Nodes.Add(this.iMapInnerBottom);
      this.iMapNode.Nodes.Add(this.iMapInnerBottomRight);
      this.iMapNode.Nodes.Add(this.iMapOuterBottomRight);
      this.TreeView1.Nodes.Add(this.iMapNode);
      this.iStaticNode.Nodes.Add(this.iStaticOuterTopLeft);
      this.iStaticNode.Nodes.Add(this.iStaticInnerTopLeft);
      this.iStaticNode.Nodes.Add(this.iStaticInnerTop);
      this.iStaticNode.Nodes.Add(this.iStaticInnerTopRight);
      this.iStaticNode.Nodes.Add(this.iStaticOuterTopRight);
      this.iStaticNode.Nodes.Add(this.iStaticInnerLeft);
      this.iStaticNode.Nodes.Add(this.iStaticInnerRight);
      this.iStaticNode.Nodes.Add(this.iStaticOuterBottomLeft);
      this.iStaticNode.Nodes.Add(this.iStaticInnerBottomLeft);
      this.iStaticNode.Nodes.Add(this.iStaticInnerBottom);
      this.iStaticNode.Nodes.Add(this.iStaticInnerBottomRight);
      this.iStaticNode.Nodes.Add(this.iStaticOuterBottomRight);
      this.TreeView1.Nodes.Add(this.iStaticNode);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.iMapNode.Tag = (object) "Map Tiles";
      this.iStaticNode.Tag = (object) "Static Tiles";
      this.iGroupA.Load();
      this.iGroupB.Load();
      this.iGroupA.Display(this.Select_Group_A);
      this.iGroupB.Display(this.Select_Group_B);
      this.NodeInit();
    }

    private void DrawStatic(short TileID, short X, short Y, PaintEventArgs e)
    {
      Bitmap bitmap = new Bitmap((Image) Art.GetStatic((int) TileID));
      checked { X += (short) 22; }
      checked { Y += (short) 22; }
      Point point = new Point(checked ((int) Math.Round(unchecked ((double) X - (double) bitmap.Width / 2.0))), checked ((int) Y - bitmap.Height + 21));
      e.Graphics.DrawImage((Image) bitmap, point);
    }

    private void Panel2_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics1 = e.Graphics;
      graphics1.DrawPolygon(new Pen(Color.Blue), this.GetPoints(5, 125));
      graphics1.DrawPolygon(new Pen(Color.Blue), this.GetPoints(197, 125));
      graphics1.DrawPolygon(new Pen(Color.Blue), this.GetPoints(101, 29));
      graphics1.DrawPolygon(new Pen(Color.Blue), this.GetPoints(101, 221));
      graphics1.DrawPolygon(new Pen(Color.Blue), this.GetPoints(101, 79));
      graphics1.DrawPolygon(new Pen(Color.Blue), this.GetPoints(78, 102));
      graphics1.DrawPolygon(new Pen(Color.Blue), this.GetPoints(124, 102));
      graphics1.DrawPolygon(new Pen(Color.Blue), this.GetPoints(55, 125));
      graphics1.DrawPolygon(new Pen(Color.Blue), this.GetPoints(101, 125));
      graphics1.DrawPolygon(new Pen(Color.Blue), this.GetPoints(147, 125));
      graphics1.DrawPolygon(new Pen(Color.Blue), this.GetPoints(78, 148));
      graphics1.DrawPolygon(new Pen(Color.Blue), this.GetPoints(124, 148));
      graphics1.DrawPolygon(new Pen(Color.Blue), this.GetPoints(101, 171));
      Point point1;
      if (this.ViewTiles)
      {
        if (this.iStaticOuterTopLeft.GetNodeCount(true) > 0)
          this.DrawStatic(ShortType.FromObject(this.iStaticOuterTopLeft.Nodes[0].Tag), (short) 101, (short) 29, e);
        if (this.iStaticInnerTopLeft.GetNodeCount(true) > 0)
          this.DrawStatic(ShortType.FromObject(this.iStaticInnerTopLeft.Nodes[0].Tag), (short) 101, (short) 79, e);
        if (this.iStaticInnerTop.GetNodeCount(true) > 0)
          this.DrawStatic(ShortType.FromObject(this.iStaticInnerTop.Nodes[0].Tag), (short) 124, (short) 102, e);
        if (this.iStaticInnerTopRight.GetNodeCount(true) > 0)
          this.DrawStatic(ShortType.FromObject(this.iStaticInnerTopRight.Nodes[0].Tag), (short) 147, (short) 125, e);
        if (this.iStaticOuterTopRight.GetNodeCount(true) > 0)
          this.DrawStatic(ShortType.FromObject(this.iStaticOuterTopRight.Nodes[0].Tag), (short) 197, (short) 125, e);
        if (this.iStaticInnerLeft.GetNodeCount(true) > 0)
          this.DrawStatic(ShortType.FromObject(this.iStaticInnerLeft.Nodes[0].Tag), (short) 78, (short) 102, e);
        if (this.iStaticInnerRight.GetNodeCount(true) > 0)
          this.DrawStatic(ShortType.FromObject(this.iStaticInnerRight.Nodes[0].Tag), (short) 124, (short) 148, e);
        if (this.iStaticOuterBottomLeft.GetNodeCount(true) > 0)
          this.DrawStatic(ShortType.FromObject(this.iStaticOuterBottomLeft.Nodes[0].Tag), (short) 5, (short) 125, e);
        if (this.iStaticInnerBottomLeft.GetNodeCount(true) > 0)
          this.DrawStatic(ShortType.FromObject(this.iStaticInnerBottomLeft.Nodes[0].Tag), (short) 55, (short) 125, e);
        if (this.iStaticInnerBottom.GetNodeCount(true) > 0)
          this.DrawStatic(ShortType.FromObject(this.iStaticInnerBottom.Nodes[0].Tag), (short) 78, (short) 148, e);
        if (this.iStaticInnerBottomRight.GetNodeCount(true) > 0)
          this.DrawStatic(ShortType.FromObject(this.iStaticInnerBottomRight.Nodes[0].Tag), (short) 101, (short) 171, e);
        if (this.iStaticOuterBottomRight.GetNodeCount(true) > 0)
          this.DrawStatic(ShortType.FromObject(this.iStaticOuterBottomRight.Nodes[0].Tag), (short) 101, (short) 221, e);
      }
      else
      {
        if (this.iMapOuterTopLeft.GetNodeCount(true) > 0)
        {
          Graphics graphics2 = graphics1;
          Bitmap land = Art.GetLand(IntegerType.FromObject(this.iMapOuterTopLeft.Nodes[0].Tag));
          point1 = new Point(101, 29);
          Point point2 = point1;
          graphics2.DrawImage((Image) land, point2);
        }
        if (this.iMapInnerTopLeft.GetNodeCount(true) > 0)
        {
          Graphics graphics2 = graphics1;
          Bitmap land = Art.GetLand(IntegerType.FromObject(this.iMapInnerTopLeft.Nodes[0].Tag));
          point1 = new Point(101, 79);
          Point point2 = point1;
          graphics2.DrawImage((Image) land, point2);
        }
        if (this.iMapInnerTop.GetNodeCount(true) > 0)
        {
          Graphics graphics2 = graphics1;
          Bitmap land = Art.GetLand(IntegerType.FromObject(this.iMapInnerTop.Nodes[0].Tag));
          point1 = new Point(124, 102);
          Point point2 = point1;
          graphics2.DrawImage((Image) land, point2);
        }
        if (this.iMapInnerTopRight.GetNodeCount(true) > 0)
        {
          Graphics graphics2 = graphics1;
          Bitmap land = Art.GetLand(IntegerType.FromObject(this.iMapInnerTopRight.Nodes[0].Tag));
          point1 = new Point(147, 125);
          Point point2 = point1;
          graphics2.DrawImage((Image) land, point2);
        }
        if (this.iMapOuterTopRight.GetNodeCount(true) > 0)
        {
          Graphics graphics2 = graphics1;
          Bitmap land = Art.GetLand(IntegerType.FromObject(this.iMapOuterTopRight.Nodes[0].Tag));
          point1 = new Point(197, 125);
          Point point2 = point1;
          graphics2.DrawImage((Image) land, point2);
        }
        if (this.iMapInnerLeft.GetNodeCount(true) > 0)
        {
          Graphics graphics2 = graphics1;
          Bitmap land = Art.GetLand(IntegerType.FromObject(this.iMapInnerLeft.Nodes[0].Tag));
          point1 = new Point(78, 102);
          Point point2 = point1;
          graphics2.DrawImage((Image) land, point2);
        }
        if (this.iMapInnerRight.GetNodeCount(true) > 0)
        {
          Graphics graphics2 = graphics1;
          Bitmap land = Art.GetLand(IntegerType.FromObject(this.iMapInnerRight.Nodes[0].Tag));
          point1 = new Point(124, 148);
          Point point2 = point1;
          graphics2.DrawImage((Image) land, point2);
        }
        if (this.iMapOuterBottomLeft.GetNodeCount(true) > 0)
        {
          Graphics graphics2 = graphics1;
          Bitmap land = Art.GetLand(IntegerType.FromObject(this.iMapOuterBottomLeft.Nodes[0].Tag));
          point1 = new Point(5, 125);
          Point point2 = point1;
          graphics2.DrawImage((Image) land, point2);
        }
        if (this.iMapInnerBottomLeft.GetNodeCount(true) > 0)
        {
          Graphics graphics2 = graphics1;
          Bitmap land = Art.GetLand(IntegerType.FromObject(this.iMapInnerBottomLeft.Nodes[0].Tag));
          point1 = new Point(55, 125);
          Point point2 = point1;
          graphics2.DrawImage((Image) land, point2);
        }
        if (this.iMapInnerBottom.GetNodeCount(true) > 0)
        {
          Graphics graphics2 = graphics1;
          Bitmap land = Art.GetLand(IntegerType.FromObject(this.iMapInnerBottom.Nodes[0].Tag));
          point1 = new Point(78, 148);
          Point point2 = point1;
          graphics2.DrawImage((Image) land, point2);
        }
        if (this.iMapInnerBottomRight.GetNodeCount(true) > 0)
        {
          Graphics graphics2 = graphics1;
          Bitmap land = Art.GetLand(IntegerType.FromObject(this.iMapInnerBottomRight.Nodes[0].Tag));
          point1 = new Point(101, 171);
          Point point2 = point1;
          graphics2.DrawImage((Image) land, point2);
        }
        if (this.iMapOuterBottomRight.GetNodeCount(true) > 0)
        {
          Graphics graphics2 = graphics1;
          Bitmap land = Art.GetLand(IntegerType.FromObject(this.iMapOuterBottomRight.Nodes[0].Tag));
          point1 = new Point(101, 221);
          Point point2 = point1;
          graphics2.DrawImage((Image) land, point2);
        }
      }
      Pen pen1 = new Pen(Color.Red);
      if (this.iMapOuterTopLeft.IsSelected)
        graphics1.DrawPolygon(pen1, this.GetPoints(101, 29));
      if (this.iMapInnerTopLeft.IsSelected)
        graphics1.DrawPolygon(pen1, this.GetPoints(101, 79));
      if (this.iMapInnerTop.IsSelected)
        graphics1.DrawPolygon(pen1, this.GetPoints(124, 102));
      if (this.iMapInnerTopRight.IsSelected)
        graphics1.DrawPolygon(pen1, this.GetPoints(147, 125));
      if (this.iMapOuterTopRight.IsSelected)
        graphics1.DrawPolygon(pen1, this.GetPoints(197, 125));
      if (this.iMapInnerLeft.IsSelected)
        graphics1.DrawPolygon(pen1, this.GetPoints(78, 102));
      if (this.iMapInnerRight.IsSelected)
        graphics1.DrawPolygon(pen1, this.GetPoints(124, 148));
      if (this.iMapOuterBottomLeft.IsSelected)
        graphics1.DrawPolygon(pen1, this.GetPoints(5, 125));
      if (this.iMapInnerBottomLeft.IsSelected)
        graphics1.DrawPolygon(pen1, this.GetPoints(55, 125));
      if (this.iMapInnerBottom.IsSelected)
        graphics1.DrawPolygon(pen1, this.GetPoints(78, 148));
      if (this.iMapInnerBottomRight.IsSelected)
        graphics1.DrawPolygon(pen1, this.GetPoints(101, 171));
      if (this.iMapOuterBottomRight.IsSelected)
        graphics1.DrawPolygon(pen1, this.GetPoints(101, 221));
      Pen pen2 = new Pen(Color.Magenta);
      if (this.iStaticOuterTopLeft.IsSelected)
        graphics1.DrawPolygon(pen2, this.GetPoints(101, 29));
      if (this.iStaticInnerTopLeft.IsSelected)
        graphics1.DrawPolygon(pen2, this.GetPoints(101, 79));
      if (this.iStaticInnerTop.IsSelected)
        graphics1.DrawPolygon(pen2, this.GetPoints(124, 102));
      if (this.iStaticInnerTopRight.IsSelected)
        graphics1.DrawPolygon(pen2, this.GetPoints(147, 125));
      if (this.iStaticOuterTopRight.IsSelected)
        graphics1.DrawPolygon(pen2, this.GetPoints(197, 125));
      if (this.iStaticInnerLeft.IsSelected)
        graphics1.DrawPolygon(pen2, this.GetPoints(78, 102));
      if (this.iStaticInnerRight.IsSelected)
        graphics1.DrawPolygon(pen2, this.GetPoints(124, 148));
      if (this.iStaticOuterBottomLeft.IsSelected)
        graphics1.DrawPolygon(pen2, this.GetPoints(5, 125));
      if (this.iStaticInnerBottomLeft.IsSelected)
        graphics1.DrawPolygon(pen2, this.GetPoints(55, 125));
      if (this.iStaticInnerBottom.IsSelected)
        graphics1.DrawPolygon(pen2, this.GetPoints(78, 148));
      if (this.iStaticInnerBottomRight.IsSelected)
        graphics1.DrawPolygon(pen2, this.GetPoints(101, 171));
      if (this.iStaticOuterBottomRight.IsSelected)
        graphics1.DrawPolygon(pen2, this.GetPoints(101, 221));
      ClsTerrain clsTerrain1 = (ClsTerrain) this.Select_Group_A.SelectedItem;
      string name1;
      if (clsTerrain1 != null)
      {
        Graphics graphics2 = graphics1;
        Bitmap land1 = Art.GetLand((int) clsTerrain1.TileID);
        point1 = new Point(5, 242);
        Point point2 = point1;
        graphics2.DrawImage((Image) land1, point2);
        Graphics graphics3 = graphics1;
        Bitmap land2 = Art.GetLand((int) clsTerrain1.TileID);
        point1 = new Point(101, 125);
        Point point3 = point1;
        graphics3.DrawImage((Image) land2, point3);
        name1 = clsTerrain1.Name;
      }
      ClsTerrain clsTerrain2 = (ClsTerrain) this.Select_Group_B.SelectedItem;
      string name2;
      if (clsTerrain2 != null)
      {
        Graphics graphics2 = graphics1;
        Bitmap land = Art.GetLand((int) clsTerrain2.TileID);
        point1 = new Point(55, 242);
        Point point2 = point1;
        graphics2.DrawImage((Image) land, point2);
        name2 = clsTerrain2.Name;
      }
      this.TextBox1.Text = string.Format("{0} To {1}", (object) name1, (object) name2);
    }

    private Point[] GetPoints(int X, int Y)
    {
      return new Point[5]
      {
        new Point(checked (X + 21), Y),
        new Point(X, checked (Y + 21)),
        new Point(checked (X + 21), checked (Y + 42)),
        new Point(checked (X + 42), checked (Y + 21)),
        new Point(checked (X + 21), Y)
      };
    }

    private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (this.iMapNode.IsSelected)
        this.ViewTiles = false;
      if (this.iStaticNode.IsSelected)
        this.ViewTiles = true;
      this.Panel1.Refresh();
      this.Panel2.Refresh();
    }

    private void MenuItem3_Click(object sender, EventArgs e)
    {
      this.ViewTiles = false;
      this.Panel2.Refresh();
      this.Panel1.Refresh();
    }

    private void MenuItem4_Click(object sender, EventArgs e)
    {
      this.ViewTiles = true;
      this.Panel2.Refresh();
      this.Panel1.Refresh();
    }

    private void Select_Group_A_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Panel2.Refresh();
    }

    private void Select_Group_B_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Panel2.Refresh();
    }

    private void ToolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
    {
      object tag = e.Button.Tag;
      if (ObjectType.ObjTst(tag, (object) "Add", false) == 0)
      {
        this.Add_Tile();
      }
      else
      {
        if (ObjectType.ObjTst(tag, (object) "Delete", false) != 0)
          return;
        this.Delete_Tile();
      }
    }

    private void Delete_Tile()
    {
      TreeNode selectedNode = this.TreeView1.SelectedNode;
      if (selectedNode.Tag == null)
        return;
      this.TreeView1.Nodes.Remove(selectedNode);
      this.Panel2.Refresh();
    }

    private void Add_Tile()
    {
      TreeNode node = new TreeNode(string.Format("Tile:{0}", (object) this.TileID.Value));
      node.Tag = (object) this.TileID.Value;
      if (this.iMapOuterTopLeft.IsSelected)
        this.iMapOuterTopLeft.Nodes.Add(node);
      if (this.iMapInnerTopLeft.IsSelected)
        this.iMapInnerTopLeft.Nodes.Add(node);
      if (this.iMapInnerTop.IsSelected)
        this.iMapInnerTop.Nodes.Add(node);
      if (this.iMapInnerTopRight.IsSelected)
        this.iMapInnerTopRight.Nodes.Add(node);
      if (this.iMapOuterTopRight.IsSelected)
        this.iMapOuterTopRight.Nodes.Add(node);
      if (this.iMapInnerLeft.IsSelected)
        this.iMapInnerLeft.Nodes.Add(node);
      if (this.iMapInnerRight.IsSelected)
        this.iMapInnerRight.Nodes.Add(node);
      if (this.iMapOuterBottomLeft.IsSelected)
        this.iMapOuterBottomLeft.Nodes.Add(node);
      if (this.iMapInnerBottomLeft.IsSelected)
        this.iMapInnerBottomLeft.Nodes.Add(node);
      if (this.iMapInnerBottom.IsSelected)
        this.iMapInnerBottom.Nodes.Add(node);
      if (this.iMapInnerBottomRight.IsSelected)
        this.iMapInnerBottomRight.Nodes.Add(node);
      if (this.iMapOuterBottomRight.IsSelected)
        this.iMapOuterBottomRight.Nodes.Add(node);
      if (this.iStaticOuterTopLeft.IsSelected)
        this.iStaticOuterTopLeft.Nodes.Add(node);
      if (this.iStaticInnerTopLeft.IsSelected)
        this.iStaticInnerTopLeft.Nodes.Add(node);
      if (this.iStaticInnerTop.IsSelected)
        this.iStaticInnerTop.Nodes.Add(node);
      if (this.iStaticInnerTopRight.IsSelected)
        this.iStaticInnerTopRight.Nodes.Add(node);
      if (this.iStaticOuterTopRight.IsSelected)
        this.iStaticOuterTopRight.Nodes.Add(node);
      if (this.iStaticInnerLeft.IsSelected)
        this.iStaticInnerLeft.Nodes.Add(node);
      if (this.iStaticInnerRight.IsSelected)
        this.iStaticInnerRight.Nodes.Add(node);
      if (this.iStaticOuterBottomLeft.IsSelected)
        this.iStaticOuterBottomLeft.Nodes.Add(node);
      if (this.iStaticInnerBottomLeft.IsSelected)
        this.iStaticInnerBottomLeft.Nodes.Add(node);
      if (this.iStaticInnerBottom.IsSelected)
        this.iStaticInnerBottom.Nodes.Add(node);
      if (this.iStaticInnerBottomRight.IsSelected)
        this.iStaticInnerBottomRight.Nodes.Add(node);
      if (this.iStaticOuterBottomRight.IsSelected)
        this.iStaticOuterBottomRight.Nodes.Add(node);
      this.Panel2.Refresh();
    }

    private void MenuItem5_Click(object sender, EventArgs e)
    {
      Transition transition = new Transition();
      TransitionTable transitionTable = new TransitionTable();
      if (this.Select_Group_A == null || this.Select_Group_B == null || ObjectType.ObjTst(LateBinding.LateGet(this.Select_Group_A.SelectedItem, (Type) null, "Name", new object[0], (string[]) null, (bool[]) null), LateBinding.LateGet(this.Select_Group_B.SelectedItem, (Type) null, "Name", new object[0], (string[]) null, (bool[]) null), false) == 0)
        return;
      string iDescription = string.Format("{0} To {1}", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.Select_Group_A.SelectedItem, (Type) null, "Name", new object[0], (string[]) null, (bool[]) null)), RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.Select_Group_B.SelectedItem, (Type) null, "Name", new object[0], (string[]) null, (bool[]) null)));
      string filename = string.Format("{0}Data\\System\\2Way_Template.xml", (object) AppDomain.CurrentDomain.BaseDirectory);
      XmlDocument xmlDocument = new XmlDocument();
      transitionTable.Clear();
      try
      {
        xmlDocument.Load(filename);
        try
        {
          foreach (XmlElement xmlElement in xmlDocument.SelectNodes("//Wizard/Tile"))
          {
            string attribute1 = xmlElement.GetAttribute("Pattern");
            string attribute2 = xmlElement.GetAttribute("MapTile");
            string attribute3 = xmlElement.GetAttribute("StaticTile");
            Transition iValue = new Transition(iDescription, attribute1, (ClsTerrain) this.Select_Group_A.SelectedItem, (ClsTerrain) this.Select_Group_B.SelectedItem, this.Get_MapTiles(attribute2), this.Get_StaticTiles(attribute3));
            transitionTable.Add(iValue);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            ((IDisposable) enumerator).Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.ToString(), MsgBoxStyle.OKOnly, (object) null);
        ProjectData.ClearProjectError();
      }
      transitionTable.Save(string.Format("{0}.xml", (object) iDescription));
    }

    public MapTileCollection Get_MapTile(TreeNodeCollection iTreeNode)
    {
      MapTileCollection mapTileCollection = new MapTileCollection();
      mapTileCollection.Clear();
      try
      {
        foreach (TreeNode treeNode in iTreeNode)
          mapTileCollection.Add(new MapTile(ShortType.FromObject(treeNode.Tag), (short) 0));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
      return mapTileCollection;
    }

    public MapTileCollection Get_MapTile(short iTileID)
    {
      MapTileCollection mapTileCollection = new MapTileCollection();
      mapTileCollection.Clear();
      mapTileCollection.Add(new MapTile(iTileID, (short) 0));
      return mapTileCollection;
    }

    public StaticTileCollection Get_StaticTile(TreeNodeCollection iTreeNode)
    {
      StaticTileCollection staticTileCollection = new StaticTileCollection();
      staticTileCollection.Clear();
      try
      {
        foreach (TreeNode treeNode in iTreeNode)
          staticTileCollection.Add(new Transition.StaticTile(ShortType.FromObject(treeNode.Tag), (short) 0));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
      return staticTileCollection;
    }

    public MapTileCollection Get_MapTiles(string iMapTile)
    {
      MapTileCollection mapTileCollection = new MapTileCollection();
      string sLeft = iMapTile;
      if (StringType.StrCmp(sLeft, "Outer Top Left", false) == 0)
        mapTileCollection = this.Get_MapTile(this.iMapOuterTopLeft.Nodes);
      else if (StringType.StrCmp(sLeft, "Outer Top Right", false) == 0)
        mapTileCollection = this.Get_MapTile(this.iMapOuterTopRight.Nodes);
      else if (StringType.StrCmp(sLeft, "Outer Bottom Left", false) == 0)
        mapTileCollection = this.Get_MapTile(this.iMapOuterBottomLeft.Nodes);
      else if (StringType.StrCmp(sLeft, "Outer Bottom Right", false) == 0)
        mapTileCollection = this.Get_MapTile(this.iMapOuterBottomRight.Nodes);
      else if (StringType.StrCmp(sLeft, "Inner Top Left", false) == 0)
        mapTileCollection = this.Get_MapTile(this.iMapInnerTopLeft.Nodes);
      else if (StringType.StrCmp(sLeft, "Inner Top", false) == 0)
        mapTileCollection = this.Get_MapTile(this.iMapInnerTop.Nodes);
      else if (StringType.StrCmp(sLeft, "Inner Top Right", false) == 0)
        mapTileCollection = this.Get_MapTile(this.iMapInnerTopRight.Nodes);
      else if (StringType.StrCmp(sLeft, "Inner Left", false) == 0)
        mapTileCollection = this.Get_MapTile(this.iMapInnerLeft.Nodes);
      else if (StringType.StrCmp(sLeft, "Inner Right", false) == 0)
        mapTileCollection = this.Get_MapTile(this.iMapInnerRight.Nodes);
      else if (StringType.StrCmp(sLeft, "Inner Bottom Left", false) == 0)
        mapTileCollection = this.Get_MapTile(this.iMapInnerBottomLeft.Nodes);
      else if (StringType.StrCmp(sLeft, "Inner Bottom", false) == 0)
        mapTileCollection = this.Get_MapTile(this.iMapInnerBottom.Nodes);
      else if (StringType.StrCmp(sLeft, "Inner Bottom Right", false) == 0)
        mapTileCollection = this.Get_MapTile(this.iMapInnerBottomRight.Nodes);
      else if (StringType.StrCmp(sLeft, "Autocorrect", false) == 0)
        mapTileCollection = this.Get_MapTile(((ClsTerrain) this.Select_Group_B.SelectedItem).TileID);
      return mapTileCollection;
    }

    public StaticTileCollection Get_StaticTiles(string iStaticTile)
    {
      StaticTileCollection staticTileCollection = new StaticTileCollection();
      string sLeft = iStaticTile;
      if (StringType.StrCmp(sLeft, "Outer Top Left", false) == 0)
        staticTileCollection = this.Get_StaticTile(this.iStaticOuterTopLeft.Nodes);
      else if (StringType.StrCmp(sLeft, "Outer Top Right", false) == 0)
        staticTileCollection = this.Get_StaticTile(this.iStaticOuterTopRight.Nodes);
      else if (StringType.StrCmp(sLeft, "Outer Bottom Left", false) == 0)
        staticTileCollection = this.Get_StaticTile(this.iStaticOuterBottomLeft.Nodes);
      else if (StringType.StrCmp(sLeft, "Outer Bottom Right", false) == 0)
        staticTileCollection = this.Get_StaticTile(this.iStaticOuterBottomRight.Nodes);
      else if (StringType.StrCmp(sLeft, "Inner Top Left", false) == 0)
        staticTileCollection = this.Get_StaticTile(this.iStaticInnerTopLeft.Nodes);
      else if (StringType.StrCmp(sLeft, "Inner Top", false) == 0)
        staticTileCollection = this.Get_StaticTile(this.iStaticInnerTop.Nodes);
      else if (StringType.StrCmp(sLeft, "Inner Top Right", false) == 0)
        staticTileCollection = this.Get_StaticTile(this.iStaticInnerTopRight.Nodes);
      else if (StringType.StrCmp(sLeft, "Inner Left", false) == 0)
        staticTileCollection = this.Get_StaticTile(this.iStaticInnerLeft.Nodes);
      else if (StringType.StrCmp(sLeft, "Inner Right", false) == 0)
        staticTileCollection = this.Get_StaticTile(this.iStaticInnerRight.Nodes);
      else if (StringType.StrCmp(sLeft, "Inner Bottom Left", false) == 0)
        staticTileCollection = this.Get_StaticTile(this.iStaticInnerBottomLeft.Nodes);
      else if (StringType.StrCmp(sLeft, "Inner Bottom", false) == 0)
        staticTileCollection = this.Get_StaticTile(this.iStaticInnerBottom.Nodes);
      else if (StringType.StrCmp(sLeft, "Inner Bottom Right", false) == 0)
        staticTileCollection = this.Get_StaticTile(this.iStaticInnerBottomRight.Nodes);
      else if (StringType.StrCmp(sLeft, "Autocorrect", false) == 0)
        return (StaticTileCollection) null;
      return staticTileCollection;
    }
  }
}
