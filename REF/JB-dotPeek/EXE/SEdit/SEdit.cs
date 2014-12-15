// Decompiled with JetBrains decompiler
// Type: SEdit.SEdit
// Assembly: SEdit, Version=1.0.1819.29268, Culture=neutral, PublicKeyToken=null
// MVID: 3B314DBD-B3E0-417A-98DF-D593B12BA0CB
// Assembly location: W:\JetBrains\UOLandscaper\SEdit.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Terrain;
using Transition;
using Ultima;

namespace SEdit
{
  public class SEdit : Form
  {
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("ToolBarButton13")]
    private ToolBarButton _ToolBarButton13;
    [AccessedThroughProperty("VScrollBar2")]
    private VScrollBar _VScrollBar2;
    [AccessedThroughProperty("ToolBarButton6")]
    private ToolBarButton _ToolBarButton6;
    [AccessedThroughProperty("ListBox2")]
    private ListBox _ListBox2;
    [AccessedThroughProperty("ToolBarButton5")]
    private ToolBarButton _ToolBarButton5;
    [AccessedThroughProperty("Panel5")]
    private Panel _Panel5;
    [AccessedThroughProperty("NumericUpDown5")]
    private NumericUpDown _NumericUpDown5;
    [AccessedThroughProperty("TabPage2")]
    private TabPage _TabPage2;
    [AccessedThroughProperty("Panel3")]
    private Panel _Panel3;
    [AccessedThroughProperty("ToolBar3")]
    private ToolBar _ToolBar3;
    [AccessedThroughProperty("TileDesc")]
    private TextBox _TileDesc;
    [AccessedThroughProperty("ImageList1")]
    private ImageList _ImageList1;
    [AccessedThroughProperty("HueID")]
    private TextBox _HueID;
    [AccessedThroughProperty("StaticZoom")]
    private Button _StaticZoom;
    [AccessedThroughProperty("MenuFile")]
    private MenuItem _MenuFile;
    [AccessedThroughProperty("Label10")]
    private Label _Label10;
    [AccessedThroughProperty("MenuNew")]
    private MenuItem _MenuNew;
    [AccessedThroughProperty("ToolBarButton12")]
    private ToolBarButton _ToolBarButton12;
    [AccessedThroughProperty("TextBox1")]
    private TextBox _TextBox1;
    [AccessedThroughProperty("MenuSave")]
    private MenuItem _MenuSave;
    [AccessedThroughProperty("MenuLoad")]
    private MenuItem _MenuLoad;
    [AccessedThroughProperty("Panel2")]
    private Panel _Panel2;
    [AccessedThroughProperty("ToolBarButton4")]
    private ToolBarButton _ToolBarButton4;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("ListBox1")]
    private ListBox _ListBox1;
    [AccessedThroughProperty("PropertyGrid1")]
    private PropertyGrid _PropertyGrid1;
    [AccessedThroughProperty("TileID")]
    private TextBox _TileID;
    [AccessedThroughProperty("VScrollBar1")]
    private VScrollBar _VScrollBar1;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("ToolBarButton11")]
    private ToolBarButton _ToolBarButton11;
    [AccessedThroughProperty("Zaxis")]
    private NumericUpDown _Zaxis;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("HScrollBar1")]
    private HScrollBar _HScrollBar1;
    [AccessedThroughProperty("MainMenu1")]
    private MainMenu _MainMenu1;
    [AccessedThroughProperty("ToolBarButton7")]
    private ToolBarButton _ToolBarButton7;
    [AccessedThroughProperty("ToolBarButton8")]
    private ToolBarButton _ToolBarButton8;
    [AccessedThroughProperty("TabPage3")]
    private TabPage _TabPage3;
    [AccessedThroughProperty("ToolBarButton3")]
    private ToolBarButton _ToolBarButton3;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("ToolBarButton10")]
    private ToolBarButton _ToolBarButton10;
    [AccessedThroughProperty("Yaxis")]
    private NumericUpDown _Yaxis;
    [AccessedThroughProperty("TabControl1")]
    private TabControl _TabControl1;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("TextBox3")]
    private TextBox _TextBox3;
    [AccessedThroughProperty("ToolBarButton9")]
    private ToolBarButton _ToolBarButton9;
    [AccessedThroughProperty("Xaxis")]
    private NumericUpDown _Xaxis;
    [AccessedThroughProperty("GroupSelect")]
    private ComboBox _GroupSelect;
    [AccessedThroughProperty("ToolBar1")]
    private ToolBar _ToolBar1;
    [AccessedThroughProperty("TabPage1")]
    private TabPage _TabPage1;
    [AccessedThroughProperty("Panel6")]
    private Panel _Panel6;
    [AccessedThroughProperty("ToolBar2")]
    private ToolBar _ToolBar2;
    [AccessedThroughProperty("NumericUpDown4")]
    private NumericUpDown _NumericUpDown4;
    [AccessedThroughProperty("ToolBarButton1")]
    private ToolBarButton _ToolBarButton1;
    [AccessedThroughProperty("Label9")]
    private Label _Label9;
    [AccessedThroughProperty("ToolBarButton2")]
    private ToolBarButton _ToolBarButton2;
    private Art UOArt;
    private TileData UOStatic;
    private Point[,] StaticGrid;
    private IContainer components;
    private ClsTerrainTable iTerrain;
    private RandomStatics iRandomStatic;

    internal virtual ToolBarButton ToolBarButton3
    {
      get
      {
        return this._ToolBarButton3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBarButton3 == null)
          ;
        this._ToolBarButton3 = value;
        if (this._ToolBarButton3 != null)
          ;
      }
    }

    internal virtual ToolBarButton ToolBarButton4
    {
      get
      {
        return this._ToolBarButton4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBarButton4 == null)
          ;
        this._ToolBarButton4 = value;
        if (this._ToolBarButton4 != null)
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

    internal virtual ComboBox GroupSelect
    {
      get
      {
        return this._GroupSelect;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GroupSelect != null)
          this._GroupSelect.SelectedIndexChanged -= new EventHandler(this.GroupSelect_SelectedIndexChanged);
        this._GroupSelect = value;
        if (this._GroupSelect == null)
          return;
        this._GroupSelect.SelectedIndexChanged += new EventHandler(this.GroupSelect_SelectedIndexChanged);
      }
    }

    internal virtual ToolBarButton ToolBarButton1
    {
      get
      {
        return this._ToolBarButton1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBarButton1 == null)
          ;
        this._ToolBarButton1 = value;
        if (this._ToolBarButton1 != null)
          ;
      }
    }

    internal virtual ToolBarButton ToolBarButton2
    {
      get
      {
        return this._ToolBarButton2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBarButton2 == null)
          ;
        this._ToolBarButton2 = value;
        if (this._ToolBarButton2 != null)
          ;
      }
    }

    internal virtual TabControl TabControl1
    {
      get
      {
        return this._TabControl1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TabControl1 == null)
          ;
        this._TabControl1 = value;
        if (this._TabControl1 != null)
          ;
      }
    }

    internal virtual TabPage TabPage1
    {
      get
      {
        return this._TabPage1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TabPage1 == null)
          ;
        this._TabPage1 = value;
        if (this._TabPage1 != null)
          ;
      }
    }

    internal virtual Panel Panel6
    {
      get
      {
        return this._Panel6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Panel6 == null)
          ;
        this._Panel6 = value;
        if (this._Panel6 != null)
          ;
      }
    }

    internal virtual ToolBar ToolBar2
    {
      get
      {
        return this._ToolBar2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBar2 != null)
          this._ToolBar2.ButtonClick -= new ToolBarButtonClickEventHandler(this.ToolBar2_ButtonClick);
        this._ToolBar2 = value;
        if (this._ToolBar2 == null)
          return;
        this._ToolBar2.ButtonClick += new ToolBarButtonClickEventHandler(this.ToolBar2_ButtonClick);
      }
    }

    internal virtual NumericUpDown NumericUpDown4
    {
      get
      {
        return this._NumericUpDown4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._NumericUpDown4 != null)
          this._NumericUpDown4.ValueChanged -= new EventHandler(this.NumericUpDown4_ValueChanged);
        this._NumericUpDown4 = value;
        if (this._NumericUpDown4 == null)
          return;
        this._NumericUpDown4.ValueChanged += new EventHandler(this.NumericUpDown4_ValueChanged);
      }
    }

    internal virtual Label Label9
    {
      get
      {
        return this._Label9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label9 == null)
          ;
        this._Label9 = value;
        if (this._Label9 != null)
          ;
      }
    }

    internal virtual TextBox TextBox3
    {
      get
      {
        return this._TextBox3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TextBox3 == null)
          ;
        this._TextBox3 = value;
        if (this._TextBox3 != null)
          ;
      }
    }

    internal virtual Label Label8
    {
      get
      {
        return this._Label8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label8 == null)
          ;
        this._Label8 = value;
        if (this._Label8 != null)
          ;
      }
    }

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

    internal virtual TabPage TabPage3
    {
      get
      {
        return this._TabPage3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TabPage3 == null)
          ;
        this._TabPage3 = value;
        if (this._TabPage3 != null)
          ;
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

    internal virtual TabPage TabPage2
    {
      get
      {
        return this._TabPage2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TabPage2 == null)
          ;
        this._TabPage2 = value;
        if (this._TabPage2 != null)
          ;
      }
    }

    internal virtual Panel Panel5
    {
      get
      {
        return this._Panel5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Panel5 == null)
          ;
        this._Panel5 = value;
        if (this._Panel5 != null)
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

    internal virtual ListBox ListBox2
    {
      get
      {
        return this._ListBox2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ListBox2 != null)
          this._ListBox2.SelectedIndexChanged -= new EventHandler(this.ListBox2_SelectedIndexChanged);
        this._ListBox2 = value;
        if (this._ListBox2 == null)
          return;
        this._ListBox2.SelectedIndexChanged += new EventHandler(this.ListBox2_SelectedIndexChanged);
      }
    }

    internal virtual ToolBarButton ToolBarButton13
    {
      get
      {
        return this._ToolBarButton13;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBarButton13 == null)
          ;
        this._ToolBarButton13 = value;
        if (this._ToolBarButton13 != null)
          ;
      }
    }

    internal virtual VScrollBar VScrollBar2
    {
      get
      {
        return this._VScrollBar2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._VScrollBar2 != null)
          this._VScrollBar2.Scroll -= new ScrollEventHandler(this.VScrollBar2_Scroll);
        this._VScrollBar2 = value;
        if (this._VScrollBar2 == null)
          return;
        this._VScrollBar2.Scroll += new ScrollEventHandler(this.VScrollBar2_Scroll);
      }
    }

    internal virtual HScrollBar HScrollBar1
    {
      get
      {
        return this._HScrollBar1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._HScrollBar1 != null)
          this._HScrollBar1.Scroll -= new ScrollEventHandler(this.HScrollBar1_Scroll);
        this._HScrollBar1 = value;
        if (this._HScrollBar1 == null)
          return;
        this._HScrollBar1.Scroll += new ScrollEventHandler(this.HScrollBar1_Scroll);
      }
    }

    internal virtual ToolBarButton ToolBarButton12
    {
      get
      {
        return this._ToolBarButton12;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBarButton12 == null)
          ;
        this._ToolBarButton12 = value;
        if (this._ToolBarButton12 != null)
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

    internal virtual NumericUpDown Xaxis
    {
      get
      {
        return this._Xaxis;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Xaxis != null)
          this._Xaxis.ValueChanged -= new EventHandler(this.Xaxis_ValueChanged);
        this._Xaxis = value;
        if (this._Xaxis == null)
          return;
        this._Xaxis.ValueChanged += new EventHandler(this.Xaxis_ValueChanged);
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

    internal virtual NumericUpDown Yaxis
    {
      get
      {
        return this._Yaxis;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Yaxis != null)
          this._Yaxis.ValueChanged -= new EventHandler(this.Yaxis_ValueChanged);
        this._Yaxis = value;
        if (this._Yaxis == null)
          return;
        this._Yaxis.ValueChanged += new EventHandler(this.Yaxis_ValueChanged);
      }
    }

    internal virtual Label Label4
    {
      get
      {
        return this._Label4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label4 == null)
          ;
        this._Label4 = value;
        if (this._Label4 != null)
          ;
      }
    }

    internal virtual NumericUpDown Zaxis
    {
      get
      {
        return this._Zaxis;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Zaxis == null)
          ;
        this._Zaxis = value;
        if (this._Zaxis != null)
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

    internal virtual TextBox TileID
    {
      get
      {
        return this._TileID;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TileID == null)
          ;
        this._TileID = value;
        if (this._TileID != null)
          ;
      }
    }

    internal virtual Label Label5
    {
      get
      {
        return this._Label5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label5 == null)
          ;
        this._Label5 = value;
        if (this._Label5 != null)
          ;
      }
    }

    internal virtual TextBox HueID
    {
      get
      {
        return this._HueID;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._HueID == null)
          ;
        this._HueID = value;
        if (this._HueID != null)
          ;
      }
    }

    internal virtual ToolBarButton ToolBarButton11
    {
      get
      {
        return this._ToolBarButton11;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBarButton11 == null)
          ;
        this._ToolBarButton11 = value;
        if (this._ToolBarButton11 != null)
          ;
      }
    }

    internal virtual NumericUpDown NumericUpDown5
    {
      get
      {
        return this._NumericUpDown5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._NumericUpDown5 != null)
          this._NumericUpDown5.ValueChanged -= new EventHandler(this.NumericUpDown5_ValueChanged);
        this._NumericUpDown5 = value;
        if (this._NumericUpDown5 == null)
          return;
        this._NumericUpDown5.ValueChanged += new EventHandler(this.NumericUpDown5_ValueChanged);
      }
    }

    internal virtual ToolBarButton ToolBarButton5
    {
      get
      {
        return this._ToolBarButton5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBarButton5 == null)
          ;
        this._ToolBarButton5 = value;
        if (this._ToolBarButton5 != null)
          ;
      }
    }

    internal virtual ToolBarButton ToolBarButton6
    {
      get
      {
        return this._ToolBarButton6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBarButton6 == null)
          ;
        this._ToolBarButton6 = value;
        if (this._ToolBarButton6 != null)
          ;
      }
    }

    internal virtual ToolBarButton ToolBarButton7
    {
      get
      {
        return this._ToolBarButton7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBarButton7 == null)
          ;
        this._ToolBarButton7 = value;
        if (this._ToolBarButton7 != null)
          ;
      }
    }

    internal virtual ToolBarButton ToolBarButton8
    {
      get
      {
        return this._ToolBarButton8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBarButton8 == null)
          ;
        this._ToolBarButton8 = value;
        if (this._ToolBarButton8 != null)
          ;
      }
    }

    internal virtual ToolBarButton ToolBarButton9
    {
      get
      {
        return this._ToolBarButton9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBarButton9 == null)
          ;
        this._ToolBarButton9 = value;
        if (this._ToolBarButton9 != null)
          ;
      }
    }

    internal virtual ToolBarButton ToolBarButton10
    {
      get
      {
        return this._ToolBarButton10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBarButton10 == null)
          ;
        this._ToolBarButton10 = value;
        if (this._ToolBarButton10 != null)
          ;
      }
    }

    internal virtual Label Label7
    {
      get
      {
        return this._Label7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label7 == null)
          ;
        this._Label7 = value;
        if (this._Label7 != null)
          ;
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
        if (this._Panel1 == null)
          ;
        this._Panel1 = value;
        if (this._Panel1 != null)
          ;
      }
    }

    internal virtual Panel Panel3
    {
      get
      {
        return this._Panel3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Panel3 != null)
          this._Panel3.Paint -= new PaintEventHandler(this.Panel3_Paint);
        this._Panel3 = value;
        if (this._Panel3 == null)
          return;
        this._Panel3.Paint += new PaintEventHandler(this.Panel3_Paint);
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

    internal virtual VScrollBar VScrollBar1
    {
      get
      {
        return this._VScrollBar1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._VScrollBar1 != null)
        {
          this._VScrollBar1.ValueChanged -= new EventHandler(this.VScrollBar1_ValueChanged);
          this._VScrollBar1.Scroll -= new ScrollEventHandler(this.VScrollBar1_Scroll);
        }
        this._VScrollBar1 = value;
        if (this._VScrollBar1 == null)
          return;
        this._VScrollBar1.ValueChanged += new EventHandler(this.VScrollBar1_ValueChanged);
        this._VScrollBar1.Scroll += new ScrollEventHandler(this.VScrollBar1_Scroll);
      }
    }

    internal virtual ToolBar ToolBar3
    {
      get
      {
        return this._ToolBar3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBar3 != null)
          this._ToolBar3.ButtonClick -= new ToolBarButtonClickEventHandler(this.ToolBar3_ButtonClick);
        this._ToolBar3 = value;
        if (this._ToolBar3 == null)
          return;
        this._ToolBar3.ButtonClick += new ToolBarButtonClickEventHandler(this.ToolBar3_ButtonClick);
      }
    }

    internal virtual Label Label6
    {
      get
      {
        return this._Label6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label6 == null)
          ;
        this._Label6 = value;
        if (this._Label6 != null)
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

    internal virtual MenuItem MenuFile
    {
      get
      {
        return this._MenuFile;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuFile == null)
          ;
        this._MenuFile = value;
        if (this._MenuFile != null)
          ;
      }
    }

    internal virtual MenuItem MenuNew
    {
      get
      {
        return this._MenuNew;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuNew != null)
          this._MenuNew.Click -= new EventHandler(this.MenuNew_Click);
        this._MenuNew = value;
        if (this._MenuNew == null)
          return;
        this._MenuNew.Click += new EventHandler(this.MenuNew_Click);
      }
    }

    internal virtual MenuItem MenuLoad
    {
      get
      {
        return this._MenuLoad;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuLoad != null)
          this._MenuLoad.Click -= new EventHandler(this.MenuLoad_Click);
        this._MenuLoad = value;
        if (this._MenuLoad == null)
          return;
        this._MenuLoad.Click += new EventHandler(this.MenuLoad_Click);
      }
    }

    internal virtual MenuItem MenuSave
    {
      get
      {
        return this._MenuSave;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuSave != null)
          this._MenuSave.Click -= new EventHandler(this.MenuSave_Click);
        this._MenuSave = value;
        if (this._MenuSave == null)
          return;
        this._MenuSave.Click += new EventHandler(this.MenuSave_Click);
      }
    }

    internal virtual TextBox TileDesc
    {
      get
      {
        return this._TileDesc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TileDesc == null)
          ;
        this._TileDesc = value;
        if (this._TileDesc != null)
          ;
      }
    }

    internal virtual Button StaticZoom
    {
      get
      {
        return this._StaticZoom;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._StaticZoom != null)
          this._StaticZoom.Click -= new EventHandler(this.StaticZoom_Click);
        this._StaticZoom = value;
        if (this._StaticZoom == null)
          return;
        this._StaticZoom.Click += new EventHandler(this.StaticZoom_Click);
      }
    }

    internal virtual Label Label10
    {
      get
      {
        return this._Label10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Label10 == null)
          ;
        this._Label10 = value;
        if (this._Label10 != null)
          ;
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

    public SEdit()
    {
      this.Load += new EventHandler(this.SEdit_Load);
      this.StaticGrid = new Point[13, 13];
      this.iTerrain = new ClsTerrainTable();
      this.iRandomStatic = new RandomStatics();
      this.InitializeComponent();
      int num1 = 302;
      int num2 = 246;
      int index1 = 0;
      do
      {
        int index2 = 0;
        do
        {
          this.StaticGrid[index2, index1] = new Point(checked (num1 - index2 * 22), checked (num2 + index2 * 22));
          checked { ++index2; }
        }
        while (index2 <= 12);
        checked { num1 += 22; }
        checked { num2 += 22; }
        checked { ++index1; }
      }
      while (index1 <= 12);
    }

    [STAThread]
    public static void Main()
    {
      Application.Run((Form) new SEdit());
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
      ResourceManager resourceManager = new ResourceManager(typeof (SEdit));
      this.ToolBarButton3 = new ToolBarButton();
      this.ToolBarButton4 = new ToolBarButton();
      this.ImageList1 = new ImageList(this.components);
      this.GroupSelect = new ComboBox();
      this.ToolBarButton1 = new ToolBarButton();
      this.ToolBarButton2 = new ToolBarButton();
      this.TabControl1 = new TabControl();
      this.TabPage1 = new TabPage();
      this.Panel6 = new Panel();
      this.ToolBar2 = new ToolBar();
      this.NumericUpDown4 = new NumericUpDown();
      this.Label9 = new Label();
      this.TextBox3 = new TextBox();
      this.Label8 = new Label();
      this.ListBox1 = new ListBox();
      this.TabPage2 = new TabPage();
      this.Panel5 = new Panel();
      this.ToolBar1 = new ToolBar();
      this.ListBox2 = new ListBox();
      this.TabPage3 = new TabPage();
      this.PropertyGrid1 = new PropertyGrid();
      this.ToolBarButton13 = new ToolBarButton();
      this.VScrollBar2 = new VScrollBar();
      this.HScrollBar1 = new HScrollBar();
      this.ToolBarButton12 = new ToolBarButton();
      this.Label2 = new Label();
      this.Xaxis = new NumericUpDown();
      this.Label3 = new Label();
      this.Yaxis = new NumericUpDown();
      this.Label4 = new Label();
      this.Zaxis = new NumericUpDown();
      this.Label1 = new Label();
      this.TileID = new TextBox();
      this.Label5 = new Label();
      this.HueID = new TextBox();
      this.ToolBarButton11 = new ToolBarButton();
      this.NumericUpDown5 = new NumericUpDown();
      this.ToolBarButton5 = new ToolBarButton();
      this.ToolBarButton6 = new ToolBarButton();
      this.ToolBarButton7 = new ToolBarButton();
      this.ToolBarButton8 = new ToolBarButton();
      this.ToolBarButton9 = new ToolBarButton();
      this.ToolBarButton10 = new ToolBarButton();
      this.Label7 = new Label();
      this.Panel1 = new Panel();
      this.Panel3 = new Panel();
      this.Panel2 = new Panel();
      this.StaticZoom = new Button();
      this.TileDesc = new TextBox();
      this.PictureBox1 = new PictureBox();
      this.VScrollBar1 = new VScrollBar();
      this.ToolBar3 = new ToolBar();
      this.Label6 = new Label();
      this.MainMenu1 = new MainMenu();
      this.MenuFile = new MenuItem();
      this.MenuNew = new MenuItem();
      this.MenuLoad = new MenuItem();
      this.MenuSave = new MenuItem();
      this.Label10 = new Label();
      this.TextBox1 = new TextBox();
      this.TabControl1.SuspendLayout();
      this.TabPage1.SuspendLayout();
      this.Panel6.SuspendLayout();
      this.NumericUpDown4.BeginInit();
      this.TabPage2.SuspendLayout();
      this.Panel5.SuspendLayout();
      this.TabPage3.SuspendLayout();
      this.Xaxis.BeginInit();
      this.Yaxis.BeginInit();
      this.Zaxis.BeginInit();
      this.NumericUpDown5.BeginInit();
      this.Panel1.SuspendLayout();
      this.Panel2.SuspendLayout();
      this.SuspendLayout();
      this.ToolBarButton3.ImageIndex = 0;
      this.ToolBarButton3.Tag = (object) "Add";
      this.ToolBarButton4.ImageIndex = 7;
      this.ToolBarButton4.Tag = (object) "Delete";
      ImageList imageList1 = this.ImageList1;
      Size size1 = new Size(24, 24);
      Size size2 = size1;
      imageList1.ImageSize = size2;
      this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
      this.ImageList1.TransparentColor = Color.Transparent;
      ComboBox groupSelect1 = this.GroupSelect;
      Point point1 = new Point(520, 24);
      Point point2 = point1;
      groupSelect1.Location = point2;
      this.GroupSelect.Name = "GroupSelect";
      ComboBox groupSelect2 = this.GroupSelect;
      size1 = new Size(144, 21);
      Size size3 = size1;
      groupSelect2.Size = size3;
      this.GroupSelect.Sorted = true;
      this.GroupSelect.TabIndex = 39;
      this.ToolBarButton1.ImageIndex = 0;
      this.ToolBarButton1.Tag = (object) "Add";
      this.ToolBarButton2.ImageIndex = 7;
      this.ToolBarButton2.Tag = (object) "Delete";
      this.TabControl1.Controls.Add((Control) this.TabPage1);
      this.TabControl1.Controls.Add((Control) this.TabPage2);
      this.TabControl1.Controls.Add((Control) this.TabPage3);
      TabControl tabControl1_1 = this.TabControl1;
      point1 = new Point(584, 56);
      Point point3 = point1;
      tabControl1_1.Location = point3;
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      TabControl tabControl1_2 = this.TabControl1;
      size1 = new Size(264, 448);
      Size size4 = size1;
      tabControl1_2.Size = size4;
      this.TabControl1.TabIndex = 35;
      this.TabPage1.Controls.Add((Control) this.Panel6);
      this.TabPage1.Controls.Add((Control) this.NumericUpDown4);
      this.TabPage1.Controls.Add((Control) this.Label9);
      this.TabPage1.Controls.Add((Control) this.TextBox3);
      this.TabPage1.Controls.Add((Control) this.Label8);
      this.TabPage1.Controls.Add((Control) this.ListBox1);
      TabPage tabPage1_1 = this.TabPage1;
      point1 = new Point(4, 22);
      Point point4 = point1;
      tabPage1_1.Location = point4;
      this.TabPage1.Name = "TabPage1";
      TabPage tabPage1_2 = this.TabPage1;
      size1 = new Size(256, 422);
      Size size5 = size1;
      tabPage1_2.Size = size5;
      this.TabPage1.TabIndex = 0;
      this.TabPage1.Text = "Static List";
      this.Panel6.Controls.Add((Control) this.ToolBar2);
      Panel panel6_1 = this.Panel6;
      point1 = new Point(8, 368);
      Point point5 = point1;
      panel6_1.Location = point5;
      this.Panel6.Name = "Panel6";
      Panel panel6_2 = this.Panel6;
      size1 = new Size(88, 48);
      Size size6 = size1;
      panel6_2.Size = size6;
      this.Panel6.TabIndex = 18;
      this.ToolBar2.Buttons.AddRange(new ToolBarButton[2]
      {
        this.ToolBarButton3,
        this.ToolBarButton4
      });
      ToolBar toolBar2_1 = this.ToolBar2;
      size1 = new Size(40, 40);
      Size size7 = size1;
      toolBar2_1.ButtonSize = size7;
      this.ToolBar2.Divider = false;
      this.ToolBar2.DropDownArrows = true;
      this.ToolBar2.ImageList = this.ImageList1;
      ToolBar toolBar2_2 = this.ToolBar2;
      point1 = new Point(0, 0);
      Point point6 = point1;
      toolBar2_2.Location = point6;
      this.ToolBar2.Name = "ToolBar2";
      this.ToolBar2.ShowToolTips = true;
      ToolBar toolBar2_3 = this.ToolBar2;
      size1 = new Size(88, 44);
      Size size8 = size1;
      toolBar2_3.Size = size8;
      this.ToolBar2.TabIndex = 17;
      NumericUpDown numericUpDown4_1 = this.NumericUpDown4;
      point1 = new Point(72, 48);
      Point point7 = point1;
      numericUpDown4_1.Location = point7;
      this.NumericUpDown4.Name = "NumericUpDown4";
      NumericUpDown numericUpDown4_2 = this.NumericUpDown4;
      size1 = new Size(40, 20);
      Size size9 = size1;
      numericUpDown4_2.Size = size9;
      this.NumericUpDown4.TabIndex = 4;
      this.Label9.AutoSize = true;
      Label label9_1 = this.Label9;
      point1 = new Point(8, 48);
      Point point8 = point1;
      label9_1.Location = point8;
      this.Label9.Name = "Label9";
      Label label9_2 = this.Label9;
      size1 = new Size(58, 16);
      Size size10 = size1;
      label9_2.Size = size10;
      this.Label9.TabIndex = 3;
      this.Label9.Text = "Frequency";
      TextBox textBox3_1 = this.TextBox3;
      point1 = new Point(8, 24);
      Point point9 = point1;
      textBox3_1.Location = point9;
      this.TextBox3.Name = "TextBox3";
      TextBox textBox3_2 = this.TextBox3;
      size1 = new Size(240, 20);
      Size size11 = size1;
      textBox3_2.Size = size11;
      this.TextBox3.TabIndex = 2;
      this.TextBox3.Text = "";
      this.Label8.AutoSize = true;
      Label label8_1 = this.Label8;
      point1 = new Point(8, 8);
      Point point10 = point1;
      label8_1.Location = point10;
      this.Label8.Name = "Label8";
      Label label8_2 = this.Label8;
      size1 = new Size(61, 16);
      Size size12 = size1;
      label8_2.Size = size12;
      this.Label8.TabIndex = 1;
      this.Label8.Text = "Description";
      ListBox listBox1_1 = this.ListBox1;
      point1 = new Point(8, 72);
      Point point11 = point1;
      listBox1_1.Location = point11;
      this.ListBox1.Name = "ListBox1";
      ListBox listBox1_2 = this.ListBox1;
      size1 = new Size(240, 290);
      Size size13 = size1;
      listBox1_2.Size = size13;
      this.ListBox1.TabIndex = 0;
      this.TabPage2.Controls.Add((Control) this.Panel5);
      this.TabPage2.Controls.Add((Control) this.ListBox2);
      TabPage tabPage2_1 = this.TabPage2;
      point1 = new Point(4, 22);
      Point point12 = point1;
      tabPage2_1.Location = point12;
      this.TabPage2.Name = "TabPage2";
      TabPage tabPage2_2 = this.TabPage2;
      size1 = new Size(256, 422);
      Size size14 = size1;
      tabPage2_2.Size = size14;
      this.TabPage2.TabIndex = 1;
      this.TabPage2.Text = "Model Components";
      this.TabPage2.Visible = false;
      this.Panel5.Controls.Add((Control) this.ToolBar1);
      Panel panel5_1 = this.Panel5;
      point1 = new Point(8, 368);
      Point point13 = point1;
      panel5_1.Location = point13;
      this.Panel5.Name = "Panel5";
      Panel panel5_2 = this.Panel5;
      size1 = new Size(200, 48);
      Size size15 = size1;
      panel5_2.Size = size15;
      this.Panel5.TabIndex = 4;
      this.ToolBar1.Buttons.AddRange(new ToolBarButton[2]
      {
        this.ToolBarButton1,
        this.ToolBarButton2
      });
      ToolBar toolBar1_1 = this.ToolBar1;
      size1 = new Size(40, 40);
      Size size16 = size1;
      toolBar1_1.ButtonSize = size16;
      this.ToolBar1.Divider = false;
      this.ToolBar1.DropDownArrows = true;
      this.ToolBar1.ImageList = this.ImageList1;
      ToolBar toolBar1_2 = this.ToolBar1;
      point1 = new Point(0, 0);
      Point point14 = point1;
      toolBar1_2.Location = point14;
      this.ToolBar1.Name = "ToolBar1";
      this.ToolBar1.ShowToolTips = true;
      ToolBar toolBar1_3 = this.ToolBar1;
      size1 = new Size(200, 44);
      Size size17 = size1;
      toolBar1_3.Size = size17;
      this.ToolBar1.TabIndex = 14;
      ListBox listBox2_1 = this.ListBox2;
      point1 = new Point(8, 8);
      Point point15 = point1;
      listBox2_1.Location = point15;
      this.ListBox2.Name = "ListBox2";
      ListBox listBox2_2 = this.ListBox2;
      size1 = new Size(240, 355);
      Size size18 = size1;
      listBox2_2.Size = size18;
      this.ListBox2.TabIndex = 3;
      this.TabPage3.Controls.Add((Control) this.PropertyGrid1);
      TabPage tabPage3_1 = this.TabPage3;
      point1 = new Point(4, 22);
      Point point16 = point1;
      tabPage3_1.Location = point16;
      this.TabPage3.Name = "TabPage3";
      TabPage tabPage3_2 = this.TabPage3;
      size1 = new Size(256, 422);
      Size size19 = size1;
      tabPage3_2.Size = size19;
      this.TabPage3.TabIndex = 2;
      this.TabPage3.Text = "Property";
      this.TabPage3.Visible = false;
      this.PropertyGrid1.CommandsVisibleIfAvailable = true;
      this.PropertyGrid1.HelpVisible = false;
      this.PropertyGrid1.LargeButtons = false;
      this.PropertyGrid1.LineColor = SystemColors.ScrollBar;
      PropertyGrid propertyGrid1_1 = this.PropertyGrid1;
      point1 = new Point(8, 0);
      Point point17 = point1;
      propertyGrid1_1.Location = point17;
      this.PropertyGrid1.Name = "PropertyGrid1";
      PropertyGrid propertyGrid1_2 = this.PropertyGrid1;
      size1 = new Size(240, 408);
      Size size20 = size1;
      propertyGrid1_2.Size = size20;
      this.PropertyGrid1.TabIndex = 0;
      this.PropertyGrid1.Text = "PropertyGrid1";
      this.PropertyGrid1.ToolbarVisible = false;
      this.PropertyGrid1.ViewBackColor = SystemColors.Window;
      this.PropertyGrid1.ViewForeColor = SystemColors.WindowText;
      this.ToolBarButton13.Tag = (object) "9";
      this.VScrollBar2.LargeChange = 8;
      VScrollBar vscrollBar2_1 = this.VScrollBar2;
      point1 = new Point(352, 8);
      Point point18 = point1;
      vscrollBar2_1.Location = point18;
      this.VScrollBar2.Maximum = 256;
      this.VScrollBar2.Name = "VScrollBar2";
      VScrollBar vscrollBar2_2 = this.VScrollBar2;
      size1 = new Size(16, 464);
      Size size21 = size1;
      vscrollBar2_2.Size = size21;
      this.VScrollBar2.TabIndex = 22;
      this.HScrollBar1.LargeChange = 8;
      HScrollBar hscrollBar1_1 = this.HScrollBar1;
      point1 = new Point(8, 472);
      Point point19 = point1;
      hscrollBar1_1.Location = point19;
      this.HScrollBar1.Maximum = 276;
      this.HScrollBar1.Name = "HScrollBar1";
      HScrollBar hscrollBar1_2 = this.HScrollBar1;
      size1 = new Size(344, 16);
      Size size22 = size1;
      hscrollBar1_2.Size = size22;
      this.HScrollBar1.TabIndex = 21;
      this.ToolBarButton12.Tag = (object) "8";
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(96, 496);
      Point point20 = point1;
      label2_1.Location = point20;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(12, 16);
      Size size23 = size1;
      label2_2.Size = size23;
      this.Label2.TabIndex = 26;
      this.Label2.Text = "X";
      NumericUpDown xaxis1 = this.Xaxis;
      point1 = new Point(112, 496);
      Point point21 = point1;
      xaxis1.Location = point21;
      NumericUpDown xaxis2 = this.Xaxis;
      Decimal num1 = new Decimal(new int[4]
      {
        6,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      xaxis2.Maximum = num2;
      NumericUpDown xaxis3 = this.Xaxis;
      num1 = new Decimal(new int[4]
      {
        6,
        0,
        0,
        int.MinValue
      });
      Decimal num3 = num1;
      xaxis3.Minimum = num3;
      this.Xaxis.Name = "Xaxis";
      NumericUpDown xaxis4 = this.Xaxis;
      size1 = new Size(40, 20);
      Size size24 = size1;
      xaxis4.Size = size24;
      this.Xaxis.TabIndex = 28;
      this.Label3.AutoSize = true;
      Label label3_1 = this.Label3;
      point1 = new Point(160, 496);
      Point point22 = point1;
      label3_1.Location = point22;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(12, 16);
      Size size25 = size1;
      label3_2.Size = size25;
      this.Label3.TabIndex = 27;
      this.Label3.Text = "Y";
      NumericUpDown yaxis1 = this.Yaxis;
      point1 = new Point(176, 496);
      Point point23 = point1;
      yaxis1.Location = point23;
      NumericUpDown yaxis2 = this.Yaxis;
      num1 = new Decimal(new int[4]
      {
        6,
        0,
        0,
        0
      });
      Decimal num4 = num1;
      yaxis2.Maximum = num4;
      NumericUpDown yaxis3 = this.Yaxis;
      num1 = new Decimal(new int[4]
      {
        6,
        0,
        0,
        int.MinValue
      });
      Decimal num5 = num1;
      yaxis3.Minimum = num5;
      this.Yaxis.Name = "Yaxis";
      NumericUpDown yaxis4 = this.Yaxis;
      size1 = new Size(40, 20);
      Size size26 = size1;
      yaxis4.Size = size26;
      this.Yaxis.TabIndex = 31;
      this.Label4.AutoSize = true;
      Label label4_1 = this.Label4;
      point1 = new Point(224, 496);
      Point point24 = point1;
      label4_1.Location = point24;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(11, 16);
      Size size27 = size1;
      label4_2.Size = size27;
      this.Label4.TabIndex = 30;
      this.Label4.Text = "Z";
      NumericUpDown zaxis1 = this.Zaxis;
      point1 = new Point(240, 496);
      Point point25 = point1;
      zaxis1.Location = point25;
      NumericUpDown zaxis2 = this.Zaxis;
      num1 = new Decimal(new int[4]
      {
        6,
        0,
        0,
        0
      });
      Decimal num6 = num1;
      zaxis2.Maximum = num6;
      NumericUpDown zaxis3 = this.Zaxis;
      num1 = new Decimal(new int[4]
      {
        6,
        0,
        0,
        int.MinValue
      });
      Decimal num7 = num1;
      zaxis3.Minimum = num7;
      this.Zaxis.Name = "Zaxis";
      NumericUpDown zaxis4 = this.Zaxis;
      size1 = new Size(40, 20);
      Size size28 = size1;
      zaxis4.Size = size28;
      this.Zaxis.TabIndex = 32;
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(8, 496);
      Point point26 = point1;
      label1_1.Location = point26;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(34, 16);
      Size size29 = size1;
      label1_2.Size = size29;
      this.Label1.TabIndex = 24;
      this.Label1.Text = "TileID";
      TextBox tileId1 = this.TileID;
      point1 = new Point(48, 496);
      Point point27 = point1;
      tileId1.Location = point27;
      this.TileID.Name = "TileID";
      TextBox tileId2 = this.TileID;
      size1 = new Size(40, 20);
      Size size30 = size1;
      tileId2.Size = size30;
      this.TileID.TabIndex = 29;
      this.TileID.Text = "0";
      this.TileID.TextAlign = HorizontalAlignment.Right;
      this.Label5.AutoSize = true;
      Label label5_1 = this.Label5;
      point1 = new Point(288, 496);
      Point point28 = point1;
      label5_1.Location = point28;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(25, 16);
      Size size31 = size1;
      label5_2.Size = size31;
      this.Label5.TabIndex = 33;
      this.Label5.Text = "Hue";
      TextBox hueId1 = this.HueID;
      point1 = new Point(320, 496);
      Point point29 = point1;
      hueId1.Location = point29;
      this.HueID.Name = "HueID";
      this.HueID.ReadOnly = true;
      TextBox hueId2 = this.HueID;
      size1 = new Size(40, 20);
      Size size32 = size1;
      hueId2.Size = size32;
      this.HueID.TabIndex = 34;
      this.HueID.Text = "0";
      this.HueID.TextAlign = HorizontalAlignment.Right;
      this.ToolBarButton11.Tag = (object) "7";
      NumericUpDown numericUpDown5_1 = this.NumericUpDown5;
      point1 = new Point(672, 24);
      Point point30 = point1;
      numericUpDown5_1.Location = point30;
      this.NumericUpDown5.Name = "NumericUpDown5";
      NumericUpDown numericUpDown5_2 = this.NumericUpDown5;
      size1 = new Size(40, 20);
      Size size33 = size1;
      numericUpDown5_2.Size = size33;
      this.NumericUpDown5.TabIndex = 37;
      this.ToolBarButton5.Tag = (object) "1";
      this.ToolBarButton6.Tag = (object) "2";
      this.ToolBarButton7.Tag = (object) "3";
      this.ToolBarButton8.Tag = (object) "4";
      this.ToolBarButton9.Tag = (object) "5";
      this.ToolBarButton10.Tag = (object) "6";
      this.Label7.AutoSize = true;
      Label label7_1 = this.Label7;
      point1 = new Point(520, 8);
      Point point31 = point1;
      label7_1.Location = point31;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(50, 16);
      Size size34 = size1;
      label7_2.Size = size34;
      this.Label7.TabIndex = 38;
      this.Label7.Text = "Group ID";
      this.Panel1.BorderStyle = BorderStyle.FixedSingle;
      this.Panel1.Controls.Add((Control) this.Panel3);
      Panel panel1_1 = this.Panel1;
      point1 = new Point(8, 8);
      Point point32 = point1;
      panel1_1.Location = point32;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      size1 = new Size(344, 464);
      Size size35 = size1;
      panel1_2.Size = size35;
      this.Panel1.TabIndex = 23;
      this.Panel3.BorderStyle = BorderStyle.FixedSingle;
      Panel panel3_1 = this.Panel3;
      point1 = new Point(0, 0);
      Point point33 = point1;
      panel3_1.Location = point33;
      this.Panel3.Name = "Panel3";
      Panel panel3_2 = this.Panel3;
      size1 = new Size(620, 820);
      Size size36 = size1;
      panel3_2.Size = size36;
      this.Panel3.TabIndex = 2;
      this.Panel2.Controls.Add((Control) this.StaticZoom);
      this.Panel2.Controls.Add((Control) this.TileDesc);
      this.Panel2.Controls.Add((Control) this.PictureBox1);
      this.Panel2.Controls.Add((Control) this.VScrollBar1);
      this.Panel2.Controls.Add((Control) this.ToolBar3);
      Panel panel2_1 = this.Panel2;
      point1 = new Point(368, 56);
      Point point34 = point1;
      panel2_1.Location = point34;
      this.Panel2.Name = "Panel2";
      Panel panel2_2 = this.Panel2;
      size1 = new Size(208, 456);
      Size size37 = size1;
      panel2_2.Size = size37;
      this.Panel2.TabIndex = 25;
      Button staticZoom1 = this.StaticZoom;
      point1 = new Point(104, 360);
      Point point35 = point1;
      staticZoom1.Location = point35;
      this.StaticZoom.Name = "StaticZoom";
      Button staticZoom2 = this.StaticZoom;
      size1 = new Size(56, 23);
      Size size38 = size1;
      staticZoom2.Size = size38;
      this.StaticZoom.TabIndex = 17;
      this.StaticZoom.Text = "Zoom";
      TextBox tileDesc1 = this.TileDesc;
      point1 = new Point(8, 336);
      Point point36 = point1;
      tileDesc1.Location = point36;
      this.TileDesc.Name = "TileDesc";
      TextBox tileDesc2 = this.TileDesc;
      size1 = new Size(176, 20);
      Size size39 = size1;
      tileDesc2.Size = size39;
      this.TileDesc.TabIndex = 16;
      this.TileDesc.Text = "";
      this.PictureBox1.BorderStyle = BorderStyle.FixedSingle;
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(8, 8);
      Point point37 = point1;
      pictureBox1_1.Location = point37;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(176, 328);
      Size size40 = size1;
      pictureBox1_2.Size = size40;
      this.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
      this.PictureBox1.TabIndex = 1;
      this.PictureBox1.TabStop = false;
      this.VScrollBar1.Dock = DockStyle.Right;
      this.VScrollBar1.LargeChange = 16;
      VScrollBar vscrollBar1_1 = this.VScrollBar1;
      point1 = new Point(192, 0);
      Point point38 = point1;
      vscrollBar1_1.Location = point38;
      this.VScrollBar1.Maximum = 16535;
      this.VScrollBar1.Name = "VScrollBar1";
      VScrollBar vscrollBar1_2 = this.VScrollBar1;
      size1 = new Size(16, 456);
      Size size41 = size1;
      vscrollBar1_2.Size = size41;
      this.VScrollBar1.TabIndex = 0;
      this.ToolBar3.Buttons.AddRange(new ToolBarButton[9]
      {
        this.ToolBarButton5,
        this.ToolBarButton6,
        this.ToolBarButton7,
        this.ToolBarButton8,
        this.ToolBarButton9,
        this.ToolBarButton10,
        this.ToolBarButton11,
        this.ToolBarButton12,
        this.ToolBarButton13
      });
      ToolBar toolBar3_1 = this.ToolBar3;
      size1 = new Size(30, 30);
      Size size42 = size1;
      toolBar3_1.ButtonSize = size42;
      this.ToolBar3.Divider = false;
      this.ToolBar3.Dock = DockStyle.None;
      this.ToolBar3.DropDownArrows = true;
      ToolBar toolBar3_2 = this.ToolBar3;
      point1 = new Point(8, 360);
      Point point39 = point1;
      toolBar3_2.Location = point39;
      this.ToolBar3.Name = "ToolBar3";
      this.ToolBar3.ShowToolTips = true;
      ToolBar toolBar3_3 = this.ToolBar3;
      size1 = new Size(96, 94);
      Size size43 = size1;
      toolBar3_3.Size = size43;
      this.ToolBar3.TabIndex = 0;
      this.Label6.AutoSize = true;
      Label label6_1 = this.Label6;
      point1 = new Point(672, 8);
      Point point40 = point1;
      label6_1.Location = point40;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(27, 16);
      Size size44 = size1;
      label6_2.Size = size44;
      this.Label6.TabIndex = 36;
      this.Label6.Text = "Freq";
      this.MainMenu1.MenuItems.AddRange(new MenuItem[1]
      {
        this.MenuFile
      });
      this.MenuFile.Index = 0;
      this.MenuFile.MenuItems.AddRange(new MenuItem[3]
      {
        this.MenuNew,
        this.MenuLoad,
        this.MenuSave
      });
      this.MenuFile.Text = "File";
      this.MenuNew.Index = 0;
      this.MenuNew.Text = "New Random Static Table";
      this.MenuLoad.Index = 1;
      this.MenuLoad.Text = "Load Random Static Table";
      this.MenuSave.Index = 2;
      this.MenuSave.Text = "Save Random Static Table";
      this.Label10.AutoSize = true;
      Label label10_1 = this.Label10;
      point1 = new Point(376, 8);
      Point point41 = point1;
      label10_1.Location = point41;
      this.Label10.Name = "Label10";
      Label label10_2 = this.Label10;
      size1 = new Size(51, 16);
      Size size45 = size1;
      label10_2.Size = size45;
      this.Label10.TabIndex = 40;
      this.Label10.Text = "Filename";
      TextBox textBox1_1 = this.TextBox1;
      point1 = new Point(376, 24);
      Point point42 = point1;
      textBox1_1.Location = point42;
      this.TextBox1.Name = "TextBox1";
      TextBox textBox1_2 = this.TextBox1;
      size1 = new Size(136, 20);
      Size size46 = size1;
      textBox1_2.Size = size46;
      this.TextBox1.TabIndex = 41;
      this.TextBox1.Text = "";
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(856, 525);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.TextBox1);
      this.Controls.Add((Control) this.Label10);
      this.Controls.Add((Control) this.TabControl1);
      this.Controls.Add((Control) this.VScrollBar2);
      this.Controls.Add((Control) this.HScrollBar1);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Xaxis);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Yaxis);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Zaxis);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.TileID);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.HueID);
      this.Controls.Add((Control) this.NumericUpDown5);
      this.Controls.Add((Control) this.Label7);
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.Panel2);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.GroupSelect);
      this.Menu = this.MainMenu1;
      this.Name = "SEdit";
      this.Text = "Random Static Editor";
      this.TabControl1.ResumeLayout(false);
      this.TabPage1.ResumeLayout(false);
      this.Panel6.ResumeLayout(false);
      this.NumericUpDown4.EndInit();
      this.TabPage2.ResumeLayout(false);
      this.Panel5.ResumeLayout(false);
      this.TabPage3.ResumeLayout(false);
      this.Xaxis.EndInit();
      this.Yaxis.EndInit();
      this.Zaxis.EndInit();
      this.NumericUpDown5.EndInit();
      this.Panel1.ResumeLayout(false);
      this.Panel2.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void SEdit_Load(object sender, EventArgs e)
    {
      this.iTerrain.Load();
      this.iTerrain.Display(this.GroupSelect);
    }

    private void Panel3_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      Pen pen1 = new Pen(Color.Gray);
      ClsTerrain clsTerrain = (ClsTerrain) this.GroupSelect.SelectedItem;
      int num1 = 0;
      do
      {
        int num2 = 0;
        do
        {
          int index1 = num2;
          int index2 = num1;
          if (clsTerrain != null)
            e.Graphics.DrawImage((Image) Art.GetLand((int) clsTerrain.TileID), checked (this.StaticGrid[index1, index2].X - 22), checked (this.StaticGrid[index1, index2].Y - 22));
          e.Graphics.DrawLine(pen1, checked (this.StaticGrid[index1, index2].X - 22), this.StaticGrid[index1, index2].Y, this.StaticGrid[index1, index2].X, checked (this.StaticGrid[index1, index2].Y + 22));
          e.Graphics.DrawLine(pen1, this.StaticGrid[index1, index2].X, checked (this.StaticGrid[index1, index2].Y + 22), checked (this.StaticGrid[index1, index2].X + 22), this.StaticGrid[index1, index2].Y);
          e.Graphics.DrawLine(pen1, checked (this.StaticGrid[index1, index2].X + 22), this.StaticGrid[index1, index2].Y, this.StaticGrid[index1, index2].X, checked (this.StaticGrid[index1, index2].Y - 22));
          e.Graphics.DrawLine(pen1, this.StaticGrid[index1, index2].X, checked (this.StaticGrid[index1, index2].Y - 22), checked (this.StaticGrid[index1, index2].X - 22), this.StaticGrid[index1, index2].Y);
          checked { ++num2; }
        }
        while (num2 <= 12);
        checked { ++num1; }
      }
      while (num1 <= 12);
      Pen pen2 = new Pen(Color.Red);
      int index3 = Convert.ToInt32(Decimal.Add(new Decimal(6L), this.Yaxis.Value));
      int index4 = Convert.ToInt32(Decimal.Add(new Decimal(6L), this.Xaxis.Value));
      e.Graphics.DrawLine(pen2, checked (this.StaticGrid[index3, index4].X - 22), this.StaticGrid[index3, index4].Y, this.StaticGrid[index3, index4].X, checked (this.StaticGrid[index3, index4].Y + 22));
      e.Graphics.DrawLine(pen2, this.StaticGrid[index3, index4].X, checked (this.StaticGrid[index3, index4].Y + 22), checked (this.StaticGrid[index3, index4].X + 22), this.StaticGrid[index3, index4].Y);
      e.Graphics.DrawLine(pen2, checked (this.StaticGrid[index3, index4].X + 22), this.StaticGrid[index3, index4].Y, this.StaticGrid[index3, index4].X, checked (this.StaticGrid[index3, index4].Y - 22));
      e.Graphics.DrawLine(pen2, this.StaticGrid[index3, index4].X, checked (this.StaticGrid[index3, index4].Y - 22), checked (this.StaticGrid[index3, index4].X - 22), this.StaticGrid[index3, index4].Y);
      try
      {
        foreach (RandomStatic randomStatic in this.ListBox2.Items)
        {
          int index1 = checked (6 + (int) randomStatic.Y);
          int index2 = checked (6 + (int) randomStatic.X);
          Bitmap @static = Art.GetStatic((int) randomStatic.TileID);
          Point point = new Point(checked ((int) Math.Round(unchecked ((double) this.StaticGrid[index1, index2].X - (double) @static.Width / 2.0))), checked (this.StaticGrid[index1, index2].Y - @static.Height + 22));
          e.Graphics.DrawImage((Image) @static, point);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
      graphics = (Graphics) null;
    }

    private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
    {
      this.UpdatePanel();
    }

    private void VScrollBar2_Scroll(object sender, ScrollEventArgs e)
    {
      this.UpdatePanel();
    }

    private void UpdatePanel()
    {
      this.Panel3.Location = new Point(checked (this.HScrollBar1.Value * -1), checked (this.VScrollBar2.Value * -1));
    }

    private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
    {
      if (Art.GetStatic(this.VScrollBar1.Value) == null)
        return;
      this.TileID.Text = this.VScrollBar1.Value.ToString();
      this.PictureBox1.Image = (Image) Art.GetStatic(this.VScrollBar1.Value);
      this.PropertyGrid1.SelectedObject = (object) TileData.ItemTable[this.VScrollBar1.Value];
      this.TileDesc.Text = string.Format("{0} ({1})", (object) TileData.ItemTable[this.VScrollBar1.Value].Name, (object) this.VScrollBar1.Value);
    }

    private void GroupSelect_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Panel3.Refresh();
    }

    private void ToolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
    {
      RandomStaticCollection staticCollection = (RandomStaticCollection) this.ListBox1.SelectedItem;
      if (staticCollection == null)
        return;
      object tag = e.Button.Tag;
      if (ObjectType.ObjTst(tag, (object) "Add", false) == 0)
      {
        staticCollection.Add(new RandomStatic(ShortType.FromString(this.TileID.Text), Convert.ToInt16(this.Xaxis.Value), Convert.ToInt16(this.Yaxis.Value), Convert.ToInt16(this.Zaxis.Value), ShortType.FromString(this.HueID.Text)));
        staticCollection.Display(this.ListBox2);
        this.Panel3.Refresh();
      }
      else if (ObjectType.ObjTst(tag, (object) "Delete", false) == 0)
      {
        staticCollection.Remove((RandomStatic) this.ListBox2.SelectedItem);
        staticCollection.Display(this.ListBox2);
        this.Panel3.Refresh();
      }
    }

    private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.PictureBox1.Image = (Image) null;
      RandomStaticCollection staticCollection = (RandomStaticCollection) this.ListBox1.SelectedItem;
      if (staticCollection == null)
        return;
      this.TextBox3.Text = staticCollection.Description;
      this.NumericUpDown4.Value = new Decimal(staticCollection.Freq);
      staticCollection.Display(this.ListBox2);
      this.Panel3.Refresh();
    }

    private void ToolBar2_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
    {
      object tag = e.Button.Tag;
      if (ObjectType.ObjTst(tag, (object) "Add", false) == 0)
      {
        if (StringType.StrCmp(this.TextBox3.Text, string.Empty, false) == 0)
          return;
        this.iRandomStatic.Add(new RandomStaticCollection(this.TextBox3.Text, Convert.ToInt32(this.NumericUpDown4.Value)));
        this.iRandomStatic.Display(this.ListBox1);
        this.Panel3.Refresh();
      }
      else if (ObjectType.ObjTst(tag, (object) "Delete", false) == 0)
      {
        this.iRandomStatic.Remove((RandomStaticCollection) this.ListBox1.SelectedItem);
        this.iRandomStatic.Display(this.ListBox1);
        this.Panel3.Refresh();
      }
    }

    private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      RandomStatic randomStatic1 = (RandomStatic) this.ListBox2.SelectedItem;
      if (randomStatic1 == null)
        return;
      RandomStatic randomStatic2 = randomStatic1;
      this.VScrollBar1.Value = (int) randomStatic2.TileID;
      if (Art.GetStatic((int) randomStatic2.TileID) != null)
      {
        this.PictureBox1.Image = (Image) Art.GetStatic((int) randomStatic2.TileID);
        this.PropertyGrid1.SelectedObject = (object) TileData.ItemTable[(int) randomStatic2.TileID];
      }
      this.TileID.Text = StringType.FromInteger((int) randomStatic2.TileID);
      this.Xaxis.Value = new Decimal((int) randomStatic2.X);
      this.Yaxis.Value = new Decimal((int) randomStatic2.Y);
      this.Zaxis.Value = new Decimal((int) randomStatic2.Z);
      this.HueID.Text = StringType.FromInteger((int) randomStatic2.Hue);
    }

    private void Xaxis_ValueChanged(object sender, EventArgs e)
    {
      this.Panel3.Refresh();
    }

    private void Yaxis_ValueChanged(object sender, EventArgs e)
    {
      this.Panel3.Refresh();
    }

    private void ToolBar3_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
    {
      short num1 = Convert.ToInt16(this.Xaxis.Value);
      short num2 = Convert.ToInt16(this.Yaxis.Value);
      RandomStatic randomStatic = (RandomStatic) this.ListBox2.SelectedItem;
      if (randomStatic != null)
      {
        num1 = randomStatic.X;
        num2 = randomStatic.Y;
      }
      object tag = e.Button.Tag;
      if (ObjectType.ObjTst(tag, (object) 1, false) == 0)
      {
        checked { --num2; }
        checked { --num1; }
      }
      else if (ObjectType.ObjTst(tag, (object) 2, false) == 0)
        checked { --num2; }
      else if (ObjectType.ObjTst(tag, (object) 3, false) == 0)
      {
        checked { --num2; }
        checked { ++num1; }
      }
      else if (ObjectType.ObjTst(tag, (object) 4, false) == 0)
        checked { --num1; }
      else if (ObjectType.ObjTst(tag, (object) 5, false) != 0)
      {
        if (ObjectType.ObjTst(tag, (object) 6, false) == 0)
          checked { ++num1; }
        else if (ObjectType.ObjTst(tag, (object) 7, false) == 0)
        {
          checked { ++num2; }
          checked { --num1; }
        }
        else if (ObjectType.ObjTst(tag, (object) 8, false) == 0)
          checked { ++num2; }
        else if (ObjectType.ObjTst(tag, (object) 9, false) == 0)
        {
          checked { ++num2; }
          checked { ++num1; }
        }
      }
      this.Xaxis.Value = new Decimal((int) num1);
      this.Yaxis.Value = new Decimal((int) num2);
      if (randomStatic != null)
      {
        randomStatic.X = num1;
        randomStatic.Y = num2;
      }
      this.Panel3.Refresh();
    }

    private void NumericUpDown4_ValueChanged(object sender, EventArgs e)
    {
      RandomStaticCollection staticCollection = (RandomStaticCollection) this.ListBox1.SelectedItem;
      if (staticCollection == null)
        return;
      staticCollection.Freq = Convert.ToInt32(this.NumericUpDown4.Value);
    }

    private void MenuLoad_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.InitialDirectory = string.Format("{0}Data/Statics", (object) AppDomain.CurrentDomain.BaseDirectory);
      openFileDialog.Filter = "xml files (*.xml)|*.xml";
      openFileDialog.FilterIndex = 2;
      openFileDialog.RestoreDirectory = true;
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
      this.TextBox1.Text = fileInfo.Name;
      this.iRandomStatic = new RandomStatics(fileInfo.Name);
      this.iRandomStatic.Display(this.ListBox1);
      this.Panel3.Refresh();
    }

    private void MenuSave_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.InitialDirectory = string.Format("{0}Data/Statics", (object) AppDomain.CurrentDomain.BaseDirectory);
      saveFileDialog.Filter = "xml files (*.xml)|*.xml";
      saveFileDialog.FileName = this.TextBox1.Text;
      saveFileDialog.FilterIndex = 2;
      saveFileDialog.RestoreDirectory = true;
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.iRandomStatic.Save(saveFileDialog.FileName);
    }

    private void MenuNew_Click(object sender, EventArgs e)
    {
      this.iRandomStatic = new RandomStatics();
    }

    private void StaticZoom_Click(object sender, EventArgs e)
    {
      RStaticZoom rstaticZoom = new RStaticZoom();
      rstaticZoom.Tag = (object) this.VScrollBar1;
      rstaticZoom.Show();
    }

    private void VScrollBar1_ValueChanged(object sender, EventArgs e)
    {
      if (Art.GetStatic(this.VScrollBar1.Value) == null)
        return;
      this.TileID.Text = this.VScrollBar1.Value.ToString();
      this.PictureBox1.Image = (Image) Art.GetStatic(this.VScrollBar1.Value);
      this.PropertyGrid1.SelectedObject = (object) TileData.ItemTable[this.VScrollBar1.Value];
      this.TileDesc.Text = string.Format("{0} ({1})", (object) TileData.ItemTable[this.VScrollBar1.Value].Name, (object) this.VScrollBar1.Value);
    }

    private void NumericUpDown5_ValueChanged(object sender, EventArgs e)
    {
      this.iRandomStatic.Freq = Convert.ToInt32(this.NumericUpDown5.Value);
    }

    private void Panel2_Paint(object sender, PaintEventArgs e)
    {
    }
  }
}
