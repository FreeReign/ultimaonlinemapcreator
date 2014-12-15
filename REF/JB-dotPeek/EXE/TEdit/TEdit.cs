// Decompiled with JetBrains decompiler
// Type: TEdit.TEdit
// Assembly: TEdit, Version=1.0.1819.29268, Culture=neutral, PublicKeyToken=null
// MVID: 17FAC474-4301-4029-AF6B-D3AA98301AC6
// Assembly location: W:\JetBrains\UOLandscaper\TEdit.exe

using Microsoft.VisualBasic;
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
using System.Xml;
using Terrain;
using Transition;
using Ultima;

namespace TEdit
{
  public class TEdit : Form
  {
    [AccessedThroughProperty("Static_TileID_Hex")]
    private TextBox _Static_TileID_Hex;
    [AccessedThroughProperty("ListBox1")]
    private ListBox _ListBox1;
    [AccessedThroughProperty("Btn_Static_Hex")]
    private Button _Btn_Static_Hex;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("StaticImage")]
    private PictureBox _StaticImage;
    [AccessedThroughProperty("StaticToolBar")]
    private ToolBar _StaticToolBar;
    [AccessedThroughProperty("TabStatic")]
    private TabPage _TabStatic;
    [AccessedThroughProperty("Btn_Static")]
    private Button _Btn_Static;
    [AccessedThroughProperty("Map_AltIDMod")]
    private NumericUpDown _Map_AltIDMod;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Static_AltIDMod")]
    private NumericUpDown _Static_AltIDMod;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("StaticItems")]
    private VScrollBar _StaticItems;
    [AccessedThroughProperty("MainMenu1")]
    private MainMenu _MainMenu1;
    [AccessedThroughProperty("ToolBarButton1")]
    private ToolBarButton _ToolBarButton1;
    [AccessedThroughProperty("ToolBarButton2")]
    private ToolBarButton _ToolBarButton2;
    [AccessedThroughProperty("MenuItem1")]
    private MenuItem _MenuItem1;
    [AccessedThroughProperty("ToolBarButton3")]
    private ToolBarButton _ToolBarButton3;
    [AccessedThroughProperty("MenuItem2")]
    private MenuItem _MenuItem2;
    [AccessedThroughProperty("ToolBarButton4")]
    private ToolBarButton _ToolBarButton4;
    [AccessedThroughProperty("MenuItem3")]
    private MenuItem _MenuItem3;
    [AccessedThroughProperty("Map_TileID")]
    private TextBox _Map_TileID;
    [AccessedThroughProperty("ToolBarButton5")]
    private ToolBarButton _ToolBarButton5;
    [AccessedThroughProperty("MenuItem4")]
    private MenuItem _MenuItem4;
    [AccessedThroughProperty("ToolBarButton6")]
    private ToolBarButton _ToolBarButton6;
    [AccessedThroughProperty("MenuItem5")]
    private MenuItem _MenuItem5;
    [AccessedThroughProperty("ToolBarButton7")]
    private ToolBarButton _ToolBarButton7;
    [AccessedThroughProperty("MenuItem6")]
    private MenuItem _MenuItem6;
    [AccessedThroughProperty("ToolBarButton8")]
    private ToolBarButton _ToolBarButton8;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("ToolBarButton9")]
    private ToolBarButton _ToolBarButton9;
    [AccessedThroughProperty("ToolBarButton10")]
    private ToolBarButton _ToolBarButton10;
    [AccessedThroughProperty("ToolBarButton11")]
    private ToolBarButton _ToolBarButton11;
    [AccessedThroughProperty("MenuItem9")]
    private MenuItem _MenuItem9;
    [AccessedThroughProperty("Map_TileID_Hex")]
    private TextBox _Map_TileID_Hex;
    [AccessedThroughProperty("ToolBarButton12")]
    private ToolBarButton _ToolBarButton12;
    [AccessedThroughProperty("MenuItem10")]
    private MenuItem _MenuItem10;
    [AccessedThroughProperty("ToolBarButton13")]
    private ToolBarButton _ToolBarButton13;
    [AccessedThroughProperty("MenuItem11")]
    private MenuItem _MenuItem11;
    [AccessedThroughProperty("ToolBarButton14")]
    private ToolBarButton _ToolBarButton14;
    [AccessedThroughProperty("MenuItem12")]
    private MenuItem _MenuItem12;
    [AccessedThroughProperty("ToolBarButton15")]
    private ToolBarButton _ToolBarButton15;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("ToolBarButton16")]
    private ToolBarButton _ToolBarButton16;
    [AccessedThroughProperty("ImageList1")]
    private ImageList _ImageList1;
    [AccessedThroughProperty("MenuFile")]
    private MenuItem _MenuFile;
    [AccessedThroughProperty("MenuNew")]
    private MenuItem _MenuNew;
    [AccessedThroughProperty("Btn_Land_Hex")]
    private Button _Btn_Land_Hex;
    [AccessedThroughProperty("MenuSave")]
    private MenuItem _MenuSave;
    [AccessedThroughProperty("MenuLoad")]
    private MenuItem _MenuLoad;
    [AccessedThroughProperty("MenuAddKey")]
    private MenuItem _MenuAddKey;
    [AccessedThroughProperty("MenuDelKey")]
    private MenuItem _MenuDelKey;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("MenuCopyKey")]
    private MenuItem _MenuCopyKey;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("MenuTerrainA")]
    private MenuItem _MenuTerrainA;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("MenuMakeTable")]
    private MenuItem _MenuMakeTable;
    [AccessedThroughProperty("Box_Description")]
    private TextBox _Box_Description;
    [AccessedThroughProperty("Lbl_HashKey")]
    private TextBox _Lbl_HashKey;
    [AccessedThroughProperty("BoxFileName")]
    private TextBox _BoxFileName;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("MapTileList")]
    private ListBox _MapTileList;
    [AccessedThroughProperty("Btn_Land")]
    private Button _Btn_Land;
    [AccessedThroughProperty("StaticTileList")]
    private ListBox _StaticTileList;
    [AccessedThroughProperty("MenuTerrainB")]
    private MenuItem _MenuTerrainB;
    [AccessedThroughProperty("Btn_StaticFile")]
    private Button _Btn_StaticFile;
    [AccessedThroughProperty("Menu2Way")]
    private MenuItem _Menu2Way;
    [AccessedThroughProperty("Menu3Way")]
    private MenuItem _Menu3Way;
    [AccessedThroughProperty("MenuTerrainC")]
    private MenuItem _MenuTerrainC;
    [AccessedThroughProperty("Menu_CloneGroupA")]
    private MenuItem _Menu_CloneGroupA;
    [AccessedThroughProperty("Menu_CloneGroupB")]
    private MenuItem _Menu_CloneGroupB;
    [AccessedThroughProperty("Static_TileID")]
    private TextBox _Static_TileID;
    [AccessedThroughProperty("TabControl1")]
    private TabControl _TabControl1;
    [AccessedThroughProperty("TabDraw")]
    private TabPage _TabDraw;
    [AccessedThroughProperty("LandImage")]
    private PictureBox _LandImage;
    [AccessedThroughProperty("PictureBox3")]
    private PictureBox _PictureBox3;
    [AccessedThroughProperty("Box_TileID_Hex")]
    private TextBox _Box_TileID_Hex;
    [AccessedThroughProperty("Box_TileID")]
    private TextBox _Box_TileID;
    [AccessedThroughProperty("GroupSelect")]
    private ComboBox _GroupSelect;
    [AccessedThroughProperty("ToolBar1")]
    private ToolBar _ToolBar1;
    [AccessedThroughProperty("TabMap")]
    private TabPage _TabMap;
    [AccessedThroughProperty("MapToolBar")]
    private ToolBar _MapToolBar;
    [AccessedThroughProperty("LandItems")]
    private VScrollBar _LandItems;
    private IContainer components;
    private Art UOArt;
    private bool ImageTest;
    private ClsTerrainTable iGroups;
    private ClsTerrain iSelectedGroup;
    private ClsTerrain m_SelectedGroupA;
    private ClsTerrain m_SelectedGroupB;
    private ClsTerrain m_SelectedGroupC;
    private bool iSelected;
    private Transition iTransition;
    private TransitionTable iTransitionTable;

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

    internal virtual PictureBox PictureBox1
    {
      get
      {
        return this._PictureBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox1 != null)
          this._PictureBox1.Paint -= new PaintEventHandler(this.PictureBox1_Paint);
        this._PictureBox1 = value;
        if (this._PictureBox1 == null)
          return;
        this._PictureBox1.Paint += new PaintEventHandler(this.PictureBox1_Paint);
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

    internal virtual TabPage TabDraw
    {
      get
      {
        return this._TabDraw;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TabDraw == null)
          ;
        this._TabDraw = value;
        if (this._TabDraw != null)
          ;
      }
    }

    internal virtual PictureBox PictureBox3
    {
      get
      {
        return this._PictureBox3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PictureBox3 == null)
          ;
        this._PictureBox3 = value;
        if (this._PictureBox3 != null)
          ;
      }
    }

    internal virtual TextBox Box_TileID_Hex
    {
      get
      {
        return this._Box_TileID_Hex;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Box_TileID_Hex == null)
          ;
        this._Box_TileID_Hex = value;
        if (this._Box_TileID_Hex != null)
          ;
      }
    }

    internal virtual TextBox Box_TileID
    {
      get
      {
        return this._Box_TileID;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Box_TileID == null)
          ;
        this._Box_TileID = value;
        if (this._Box_TileID != null)
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

    internal virtual TabPage TabMap
    {
      get
      {
        return this._TabMap;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TabMap == null)
          ;
        this._TabMap = value;
        if (this._TabMap != null)
          ;
      }
    }

    internal virtual ToolBar MapToolBar
    {
      get
      {
        return this._MapToolBar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MapToolBar != null)
          this._MapToolBar.ButtonClick -= new ToolBarButtonClickEventHandler(this.MapToolBar_ButtonClick);
        this._MapToolBar = value;
        if (this._MapToolBar == null)
          return;
        this._MapToolBar.ButtonClick += new ToolBarButtonClickEventHandler(this.MapToolBar_ButtonClick);
      }
    }

    internal virtual VScrollBar LandItems
    {
      get
      {
        return this._LandItems;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._LandItems != null)
        {
          this._LandItems.ValueChanged -= new EventHandler(this.LandItems_ValueChanged);
          this._LandItems.Scroll -= new ScrollEventHandler(this.LandItems_Scroll);
        }
        this._LandItems = value;
        if (this._LandItems == null)
          return;
        this._LandItems.ValueChanged += new EventHandler(this.LandItems_ValueChanged);
        this._LandItems.Scroll += new ScrollEventHandler(this.LandItems_Scroll);
      }
    }

    internal virtual PictureBox LandImage
    {
      get
      {
        return this._LandImage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._LandImage == null)
          ;
        this._LandImage = value;
        if (this._LandImage != null)
          ;
      }
    }

    internal virtual Button Btn_Land
    {
      get
      {
        return this._Btn_Land;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Btn_Land != null)
          this._Btn_Land.Click -= new EventHandler(this.Btn_Land_Click);
        this._Btn_Land = value;
        if (this._Btn_Land == null)
          return;
        this._Btn_Land.Click += new EventHandler(this.Btn_Land_Click);
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

    internal virtual Button Btn_Land_Hex
    {
      get
      {
        return this._Btn_Land_Hex;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Btn_Land_Hex != null)
          this._Btn_Land_Hex.Click -= new EventHandler(this.Btn_Land_Hex_Click);
        this._Btn_Land_Hex = value;
        if (this._Btn_Land_Hex == null)
          return;
        this._Btn_Land_Hex.Click += new EventHandler(this.Btn_Land_Hex_Click);
      }
    }

    internal virtual TextBox Map_TileID_Hex
    {
      get
      {
        return this._Map_TileID_Hex;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Map_TileID_Hex == null)
          ;
        this._Map_TileID_Hex = value;
        if (this._Map_TileID_Hex != null)
          ;
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

    internal virtual TextBox Map_TileID
    {
      get
      {
        return this._Map_TileID;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Map_TileID == null)
          ;
        this._Map_TileID = value;
        if (this._Map_TileID != null)
          ;
      }
    }

    internal virtual NumericUpDown Map_AltIDMod
    {
      get
      {
        return this._Map_AltIDMod;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Map_AltIDMod == null)
          ;
        this._Map_AltIDMod = value;
        if (this._Map_AltIDMod != null)
          ;
      }
    }

    internal virtual TabPage TabStatic
    {
      get
      {
        return this._TabStatic;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TabStatic == null)
          ;
        this._TabStatic = value;
        if (this._TabStatic != null)
          ;
      }
    }

    internal virtual ToolBar StaticToolBar
    {
      get
      {
        return this._StaticToolBar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._StaticToolBar != null)
          this._StaticToolBar.ButtonClick -= new ToolBarButtonClickEventHandler(this.StaticToolBar_ButtonClick);
        this._StaticToolBar = value;
        if (this._StaticToolBar == null)
          return;
        this._StaticToolBar.ButtonClick += new ToolBarButtonClickEventHandler(this.StaticToolBar_ButtonClick);
      }
    }

    internal virtual PictureBox StaticImage
    {
      get
      {
        return this._StaticImage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._StaticImage == null)
          ;
        this._StaticImage = value;
        if (this._StaticImage != null)
          ;
      }
    }

    internal virtual Button Btn_Static_Hex
    {
      get
      {
        return this._Btn_Static_Hex;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Btn_Static_Hex == null)
          ;
        this._Btn_Static_Hex = value;
        if (this._Btn_Static_Hex != null)
          ;
      }
    }

    internal virtual TextBox Static_TileID_Hex
    {
      get
      {
        return this._Static_TileID_Hex;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Static_TileID_Hex == null)
          ;
        this._Static_TileID_Hex = value;
        if (this._Static_TileID_Hex != null)
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

    internal virtual TextBox Static_TileID
    {
      get
      {
        return this._Static_TileID;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Static_TileID == null)
          ;
        this._Static_TileID = value;
        if (this._Static_TileID != null)
          ;
      }
    }

    internal virtual Button Btn_Static
    {
      get
      {
        return this._Btn_Static;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Btn_Static == null)
          ;
        this._Btn_Static = value;
        if (this._Btn_Static != null)
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

    internal virtual NumericUpDown Static_AltIDMod
    {
      get
      {
        return this._Static_AltIDMod;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Static_AltIDMod == null)
          ;
        this._Static_AltIDMod = value;
        if (this._Static_AltIDMod != null)
          ;
      }
    }

    internal virtual VScrollBar StaticItems
    {
      get
      {
        return this._StaticItems;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._StaticItems != null)
        {
          this._StaticItems.ValueChanged -= new EventHandler(this.StaticItems_ValueChanged);
          this._StaticItems.Scroll -= new ScrollEventHandler(this.StaticItems_Scroll);
        }
        this._StaticItems = value;
        if (this._StaticItems == null)
          return;
        this._StaticItems.ValueChanged += new EventHandler(this.StaticItems_ValueChanged);
        this._StaticItems.Scroll += new ScrollEventHandler(this.StaticItems_Scroll);
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

    internal virtual ToolBarButton ToolBarButton14
    {
      get
      {
        return this._ToolBarButton14;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBarButton14 == null)
          ;
        this._ToolBarButton14 = value;
        if (this._ToolBarButton14 != null)
          ;
      }
    }

    internal virtual ToolBarButton ToolBarButton15
    {
      get
      {
        return this._ToolBarButton15;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBarButton15 == null)
          ;
        this._ToolBarButton15 = value;
        if (this._ToolBarButton15 != null)
          ;
      }
    }

    internal virtual ToolBarButton ToolBarButton16
    {
      get
      {
        return this._ToolBarButton16;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ToolBarButton16 == null)
          ;
        this._ToolBarButton16 = value;
        if (this._ToolBarButton16 != null)
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

    internal virtual MenuItem MenuItem5
    {
      get
      {
        return this._MenuItem5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem5 == null)
          ;
        this._MenuItem5 = value;
        if (this._MenuItem5 != null)
          ;
      }
    }

    internal virtual MenuItem MenuAddKey
    {
      get
      {
        return this._MenuAddKey;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuAddKey != null)
          this._MenuAddKey.Click -= new EventHandler(this.MenuAddKey_Click);
        this._MenuAddKey = value;
        if (this._MenuAddKey == null)
          return;
        this._MenuAddKey.Click += new EventHandler(this.MenuAddKey_Click);
      }
    }

    internal virtual MenuItem MenuDelKey
    {
      get
      {
        return this._MenuDelKey;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuDelKey != null)
          this._MenuDelKey.Click -= new EventHandler(this.MenuDelKey_Click);
        this._MenuDelKey = value;
        if (this._MenuDelKey == null)
          return;
        this._MenuDelKey.Click += new EventHandler(this.MenuDelKey_Click);
      }
    }

    internal virtual MenuItem MenuCopyKey
    {
      get
      {
        return this._MenuCopyKey;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuCopyKey != null)
          this._MenuCopyKey.Click -= new EventHandler(this.MenuCopyKey_Click);
        this._MenuCopyKey = value;
        if (this._MenuCopyKey == null)
          return;
        this._MenuCopyKey.Click += new EventHandler(this.MenuCopyKey_Click);
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
        if (this._MenuItem9 == null)
          ;
        this._MenuItem9 = value;
        if (this._MenuItem9 != null)
          ;
      }
    }

    internal virtual MenuItem MenuTerrainA
    {
      get
      {
        return this._MenuTerrainA;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuTerrainA != null)
          this._MenuTerrainA.Click -= new EventHandler(this.MenuTerrainA_Click);
        this._MenuTerrainA = value;
        if (this._MenuTerrainA == null)
          return;
        this._MenuTerrainA.Click += new EventHandler(this.MenuTerrainA_Click);
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
        if (this._MenuItem12 == null)
          ;
        this._MenuItem12 = value;
        if (this._MenuItem12 != null)
          ;
      }
    }

    internal virtual MenuItem MenuMakeTable
    {
      get
      {
        return this._MenuMakeTable;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuMakeTable == null)
          ;
        this._MenuMakeTable = value;
        if (this._MenuMakeTable != null)
          ;
      }
    }

    internal virtual TextBox Box_Description
    {
      get
      {
        return this._Box_Description;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Box_Description != null)
          this._Box_Description.Leave -= new EventHandler(this.Box_Description_Leave);
        this._Box_Description = value;
        if (this._Box_Description == null)
          return;
        this._Box_Description.Leave += new EventHandler(this.Box_Description_Leave);
      }
    }

    internal virtual TextBox Lbl_HashKey
    {
      get
      {
        return this._Lbl_HashKey;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Lbl_HashKey == null)
          ;
        this._Lbl_HashKey = value;
        if (this._Lbl_HashKey != null)
          ;
      }
    }

    internal virtual TextBox BoxFileName
    {
      get
      {
        return this._BoxFileName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._BoxFileName != null)
          this._BoxFileName.TextChanged -= new EventHandler(this.BoxFileName_TextChanged);
        this._BoxFileName = value;
        if (this._BoxFileName == null)
          return;
        this._BoxFileName.TextChanged += new EventHandler(this.BoxFileName_TextChanged);
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

    internal virtual ListBox MapTileList
    {
      get
      {
        return this._MapTileList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MapTileList != null)
          this._MapTileList.SelectedIndexChanged -= new EventHandler(this.MapTileList_SelectedIndexChanged);
        this._MapTileList = value;
        if (this._MapTileList == null)
          return;
        this._MapTileList.SelectedIndexChanged += new EventHandler(this.MapTileList_SelectedIndexChanged);
      }
    }

    internal virtual ListBox StaticTileList
    {
      get
      {
        return this._StaticTileList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._StaticTileList != null)
          this._StaticTileList.SelectedIndexChanged -= new EventHandler(this.StaticTileList_SelectedIndexChanged);
        this._StaticTileList = value;
        if (this._StaticTileList == null)
          return;
        this._StaticTileList.SelectedIndexChanged += new EventHandler(this.StaticTileList_SelectedIndexChanged);
      }
    }

    internal virtual MenuItem MenuTerrainB
    {
      get
      {
        return this._MenuTerrainB;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuTerrainB != null)
          this._MenuTerrainB.Click -= new EventHandler(this.MenuSelectB_Click);
        this._MenuTerrainB = value;
        if (this._MenuTerrainB == null)
          return;
        this._MenuTerrainB.Click += new EventHandler(this.MenuSelectB_Click);
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
        if (this._MenuItem1 != null)
          this._MenuItem1.Click -= new EventHandler(this.MenuItem1_Click);
        this._MenuItem1 = value;
        if (this._MenuItem1 == null)
          return;
        this._MenuItem1.Click += new EventHandler(this.MenuItem1_Click);
      }
    }

    internal virtual Button Btn_StaticFile
    {
      get
      {
        return this._Btn_StaticFile;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Btn_StaticFile != null)
          this._Btn_StaticFile.Click -= new EventHandler(this.Btn_StaticFile_Click);
        this._Btn_StaticFile = value;
        if (this._Btn_StaticFile == null)
          return;
        this._Btn_StaticFile.Click += new EventHandler(this.Btn_StaticFile_Click);
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

    internal virtual MenuItem Menu2Way
    {
      get
      {
        return this._Menu2Way;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Menu2Way != null)
          this._Menu2Way.Click -= new EventHandler(this.Menu2Way_Click);
        this._Menu2Way = value;
        if (this._Menu2Way == null)
          return;
        this._Menu2Way.Click += new EventHandler(this.Menu2Way_Click);
      }
    }

    internal virtual MenuItem Menu3Way
    {
      get
      {
        return this._Menu3Way;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Menu3Way != null)
          this._Menu3Way.Click -= new EventHandler(this.Menu3Way_Click);
        this._Menu3Way = value;
        if (this._Menu3Way == null)
          return;
        this._Menu3Way.Click += new EventHandler(this.Menu3Way_Click);
      }
    }

    internal virtual MenuItem MenuTerrainC
    {
      get
      {
        return this._MenuTerrainC;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuTerrainC != null)
          this._MenuTerrainC.Click -= new EventHandler(this.MenuTerrainC_Click);
        this._MenuTerrainC = value;
        if (this._MenuTerrainC == null)
          return;
        this._MenuTerrainC.Click += new EventHandler(this.MenuTerrainC_Click);
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

    internal virtual MenuItem MenuItem10
    {
      get
      {
        return this._MenuItem10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem10 != null)
          this._MenuItem10.Click -= new EventHandler(this.MenuItem10_Click);
        this._MenuItem10 = value;
        if (this._MenuItem10 == null)
          return;
        this._MenuItem10.Click += new EventHandler(this.MenuItem10_Click);
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

    internal virtual MenuItem Menu_CloneGroupA
    {
      get
      {
        return this._Menu_CloneGroupA;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Menu_CloneGroupA != null)
          this._Menu_CloneGroupA.Click -= new EventHandler(this.Menu_CloneGroupA_Click);
        this._Menu_CloneGroupA = value;
        if (this._Menu_CloneGroupA == null)
          return;
        this._Menu_CloneGroupA.Click += new EventHandler(this.Menu_CloneGroupA_Click);
      }
    }

    internal virtual MenuItem Menu_CloneGroupB
    {
      get
      {
        return this._Menu_CloneGroupB;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Menu_CloneGroupB != null)
          this._Menu_CloneGroupB.Click -= new EventHandler(this.Menu_CloneGroupB_Click);
        this._Menu_CloneGroupB = value;
        if (this._Menu_CloneGroupB == null)
          return;
        this._Menu_CloneGroupB.Click += new EventHandler(this.Menu_CloneGroupB_Click);
      }
    }

    public ClsTerrain Selected_Terrain_A
    {
      get
      {
        return this.m_SelectedGroupA;
      }
      set
      {
        this.m_SelectedGroupA = value;
      }
    }

    public ClsTerrain Selected_Terrain_B
    {
      get
      {
        return this.m_SelectedGroupB;
      }
      set
      {
        this.m_SelectedGroupB = value;
      }
    }

    public ClsTerrain Selected_Terrain_C
    {
      get
      {
        return this.m_SelectedGroupC;
      }
      set
      {
        this.m_SelectedGroupC = value;
      }
    }

    public TEdit()
    {
      this.Load += new EventHandler(this.TEdit_Load);
      this.ImageTest = false;
      this.iGroups = new ClsTerrainTable();
      this.iSelected = false;
      this.iTransition = new Transition();
      this.iTransitionTable = new TransitionTable();
      this.InitializeComponent();
    }

    [STAThread]
    public static void Main()
    {
      Application.Run((Form) new TEdit());
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
      ResourceManager resourceManager = new ResourceManager(typeof (TEdit));
      this.ListBox1 = new ListBox();
      this.MainMenu1 = new MainMenu();
      this.MenuFile = new MenuItem();
      this.MenuNew = new MenuItem();
      this.MenuSave = new MenuItem();
      this.MenuLoad = new MenuItem();
      this.MenuItem4 = new MenuItem();
      this.MenuItem6 = new MenuItem();
      this.Menu_CloneGroupA = new MenuItem();
      this.Menu_CloneGroupB = new MenuItem();
      this.MenuItem11 = new MenuItem();
      this.MenuItem10 = new MenuItem();
      this.MenuItem5 = new MenuItem();
      this.MenuItem1 = new MenuItem();
      this.MenuAddKey = new MenuItem();
      this.MenuDelKey = new MenuItem();
      this.MenuCopyKey = new MenuItem();
      this.MenuItem9 = new MenuItem();
      this.MenuTerrainA = new MenuItem();
      this.MenuTerrainB = new MenuItem();
      this.MenuTerrainC = new MenuItem();
      this.MenuItem12 = new MenuItem();
      this.MenuMakeTable = new MenuItem();
      this.Menu2Way = new MenuItem();
      this.Menu3Way = new MenuItem();
      this.MenuItem2 = new MenuItem();
      this.MenuItem3 = new MenuItem();
      this.Box_Description = new TextBox();
      this.Lbl_HashKey = new TextBox();
      this.PictureBox1 = new PictureBox();
      this.TabControl1 = new TabControl();
      this.TabDraw = new TabPage();
      this.PictureBox3 = new PictureBox();
      this.Box_TileID_Hex = new TextBox();
      this.Box_TileID = new TextBox();
      this.Label7 = new Label();
      this.GroupSelect = new ComboBox();
      this.ToolBar1 = new ToolBar();
      this.ToolBarButton1 = new ToolBarButton();
      this.ToolBarButton2 = new ToolBarButton();
      this.ToolBarButton3 = new ToolBarButton();
      this.ToolBarButton4 = new ToolBarButton();
      this.ToolBarButton5 = new ToolBarButton();
      this.ToolBarButton6 = new ToolBarButton();
      this.ToolBarButton7 = new ToolBarButton();
      this.ToolBarButton8 = new ToolBarButton();
      this.ToolBarButton9 = new ToolBarButton();
      this.TabMap = new TabPage();
      this.MapToolBar = new ToolBar();
      this.ToolBarButton10 = new ToolBarButton();
      this.ToolBarButton11 = new ToolBarButton();
      this.ToolBarButton12 = new ToolBarButton();
      this.ToolBarButton13 = new ToolBarButton();
      this.ImageList1 = new ImageList(this.components);
      this.MapTileList = new ListBox();
      this.LandItems = new VScrollBar();
      this.LandImage = new PictureBox();
      this.Btn_Land = new Button();
      this.Label5 = new Label();
      this.Btn_Land_Hex = new Button();
      this.Map_TileID_Hex = new TextBox();
      this.Label6 = new Label();
      this.Map_TileID = new TextBox();
      this.Map_AltIDMod = new NumericUpDown();
      this.TabStatic = new TabPage();
      this.StaticToolBar = new ToolBar();
      this.ToolBarButton14 = new ToolBarButton();
      this.ToolBarButton15 = new ToolBarButton();
      this.ToolBarButton16 = new ToolBarButton();
      this.StaticImage = new PictureBox();
      this.StaticTileList = new ListBox();
      this.Btn_Static_Hex = new Button();
      this.Static_TileID_Hex = new TextBox();
      this.Label1 = new Label();
      this.Static_TileID = new TextBox();
      this.Btn_Static = new Button();
      this.Label2 = new Label();
      this.Static_AltIDMod = new NumericUpDown();
      this.StaticItems = new VScrollBar();
      this.BoxFileName = new TextBox();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.Label8 = new Label();
      this.Btn_StaticFile = new Button();
      this.TabControl1.SuspendLayout();
      this.TabDraw.SuspendLayout();
      this.TabMap.SuspendLayout();
      this.Map_AltIDMod.BeginInit();
      this.TabStatic.SuspendLayout();
      this.Static_AltIDMod.BeginInit();
      this.SuspendLayout();
      this.ListBox1.BorderStyle = BorderStyle.FixedSingle;
      ListBox listBox1_1 = this.ListBox1;
      Point point1 = new Point(8, 8);
      Point point2 = point1;
      listBox1_1.Location = point2;
      this.ListBox1.Name = "ListBox1";
      ListBox listBox1_2 = this.ListBox1;
      Size size1 = new Size(336, 535);
      Size size2 = size1;
      listBox1_2.Size = size2;
      this.ListBox1.Sorted = true;
      this.ListBox1.TabIndex = 1;
      this.MainMenu1.MenuItems.AddRange(new MenuItem[3]
      {
        this.MenuFile,
        this.MenuItem5,
        this.MenuItem9
      });
      this.MenuFile.Index = 0;
      this.MenuFile.MenuItems.AddRange(new MenuItem[5]
      {
        this.MenuNew,
        this.MenuSave,
        this.MenuLoad,
        this.MenuItem4,
        this.MenuItem6
      });
      this.MenuFile.Text = "File";
      this.MenuNew.Index = 0;
      this.MenuNew.Text = "New Transition Table";
      this.MenuSave.Index = 1;
      this.MenuSave.Text = "Save Transition Table";
      this.MenuLoad.Index = 2;
      this.MenuLoad.Text = "Load Transition Table";
      this.MenuItem4.Index = 3;
      this.MenuItem4.Text = "-";
      this.MenuItem6.Index = 4;
      this.MenuItem6.MenuItems.AddRange(new MenuItem[4]
      {
        this.Menu_CloneGroupA,
        this.Menu_CloneGroupB,
        this.MenuItem11,
        this.MenuItem10
      });
      this.MenuItem6.Text = "Clone Transition Table";
      this.Menu_CloneGroupA.Index = 0;
      this.Menu_CloneGroupA.Text = "Select Group A";
      this.Menu_CloneGroupB.Index = 1;
      this.Menu_CloneGroupB.Text = "Select Group B";
      this.MenuItem11.Index = 2;
      this.MenuItem11.Text = "-";
      this.MenuItem10.Index = 3;
      this.MenuItem10.Text = "Clone";
      this.MenuItem5.Index = 1;
      this.MenuItem5.MenuItems.AddRange(new MenuItem[4]
      {
        this.MenuItem1,
        this.MenuAddKey,
        this.MenuDelKey,
        this.MenuCopyKey
      });
      this.MenuItem5.Text = "Transition";
      this.MenuItem1.Index = 0;
      this.MenuItem1.Text = "Clear";
      this.MenuAddKey.Index = 1;
      this.MenuAddKey.Text = "Add";
      this.MenuDelKey.Index = 2;
      this.MenuDelKey.Text = "Delete";
      this.MenuCopyKey.Index = 3;
      this.MenuCopyKey.Text = "Copy";
      this.MenuItem9.Index = 2;
      this.MenuItem9.MenuItems.AddRange(new MenuItem[7]
      {
        this.MenuTerrainA,
        this.MenuTerrainB,
        this.MenuTerrainC,
        this.MenuItem12,
        this.MenuMakeTable,
        this.MenuItem2,
        this.MenuItem3
      });
      this.MenuItem9.Text = "Wizard";
      this.MenuTerrainA.Index = 0;
      this.MenuTerrainA.Text = "Select Terrain A";
      this.MenuTerrainB.Index = 1;
      this.MenuTerrainB.Text = "Select Terrain B";
      this.MenuTerrainC.Index = 2;
      this.MenuTerrainC.Text = "Select Terrain C";
      this.MenuItem12.Index = 3;
      this.MenuItem12.Text = "-";
      this.MenuMakeTable.Index = 4;
      this.MenuMakeTable.MenuItems.AddRange(new MenuItem[2]
      {
        this.Menu2Way,
        this.Menu3Way
      });
      this.MenuMakeTable.Text = "Make Transition Table";
      this.Menu2Way.Index = 0;
      this.Menu2Way.Text = "2Way Transitions";
      this.Menu3Way.Index = 1;
      this.Menu3Way.Text = "3Way Transitions";
      this.MenuItem2.Index = 5;
      this.MenuItem2.Text = "-";
      this.MenuItem3.Index = 6;
      this.MenuItem3.Text = "Print Table";
      this.Box_Description.BorderStyle = BorderStyle.FixedSingle;
      TextBox boxDescription1 = this.Box_Description;
      point1 = new Point(392, 32);
      Point point3 = point1;
      boxDescription1.Location = point3;
      this.Box_Description.Name = "Box_Description";
      TextBox boxDescription2 = this.Box_Description;
      size1 = new Size(144, 20);
      Size size3 = size1;
      boxDescription2.Size = size3;
      this.Box_Description.TabIndex = 2;
      this.Box_Description.Text = "";
      this.Lbl_HashKey.BorderStyle = BorderStyle.FixedSingle;
      TextBox lblHashKey1 = this.Lbl_HashKey;
      point1 = new Point(392, 56);
      Point point4 = point1;
      lblHashKey1.Location = point4;
      this.Lbl_HashKey.Name = "Lbl_HashKey";
      TextBox lblHashKey2 = this.Lbl_HashKey;
      size1 = new Size(144, 20);
      Size size4 = size1;
      lblHashKey2.Size = size4;
      this.Lbl_HashKey.TabIndex = 3;
      this.Lbl_HashKey.Text = "";
      this.PictureBox1.BorderStyle = BorderStyle.FixedSingle;
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(360, 88);
      Point point5 = point1;
      pictureBox1_1.Location = point5;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(168, 168);
      Size size5 = size1;
      pictureBox1_2.Size = size5;
      this.PictureBox1.TabIndex = 4;
      this.PictureBox1.TabStop = false;
      this.TabControl1.Controls.Add((Control) this.TabDraw);
      this.TabControl1.Controls.Add((Control) this.TabMap);
      this.TabControl1.Controls.Add((Control) this.TabStatic);
      TabControl tabControl1_1 = this.TabControl1;
      point1 = new Point(352, 264);
      Point point6 = point1;
      tabControl1_1.Location = point6;
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      TabControl tabControl1_2 = this.TabControl1;
      size1 = new Size(184, 288);
      Size size6 = size1;
      tabControl1_2.Size = size6;
      this.TabControl1.TabIndex = 51;
      this.TabDraw.Controls.Add((Control) this.PictureBox3);
      this.TabDraw.Controls.Add((Control) this.Box_TileID_Hex);
      this.TabDraw.Controls.Add((Control) this.Box_TileID);
      this.TabDraw.Controls.Add((Control) this.Label7);
      this.TabDraw.Controls.Add((Control) this.GroupSelect);
      this.TabDraw.Controls.Add((Control) this.ToolBar1);
      TabPage tabDraw1 = this.TabDraw;
      point1 = new Point(4, 22);
      Point point7 = point1;
      tabDraw1.Location = point7;
      this.TabDraw.Name = "TabDraw";
      TabPage tabDraw2 = this.TabDraw;
      size1 = new Size(176, 262);
      Size size7 = size1;
      tabDraw2.Size = size7;
      this.TabDraw.TabIndex = 2;
      this.TabDraw.Text = "Draw";
      this.PictureBox3.BorderStyle = BorderStyle.FixedSingle;
      PictureBox pictureBox3_1 = this.PictureBox3;
      point1 = new Point(8, 184);
      Point point8 = point1;
      pictureBox3_1.Location = point8;
      this.PictureBox3.Name = "PictureBox3";
      PictureBox pictureBox3_2 = this.PictureBox3;
      size1 = new Size(48, 50);
      Size size8 = size1;
      pictureBox3_2.Size = size8;
      this.PictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
      this.PictureBox3.TabIndex = 60;
      this.PictureBox3.TabStop = false;
      this.Box_TileID_Hex.BorderStyle = BorderStyle.FixedSingle;
      TextBox boxTileIdHex1 = this.Box_TileID_Hex;
      point1 = new Point(64, 224);
      Point point9 = point1;
      boxTileIdHex1.Location = point9;
      this.Box_TileID_Hex.Name = "Box_TileID_Hex";
      TextBox boxTileIdHex2 = this.Box_TileID_Hex;
      size1 = new Size(48, 20);
      Size size9 = size1;
      boxTileIdHex2.Size = size9;
      this.Box_TileID_Hex.TabIndex = 59;
      this.Box_TileID_Hex.Text = "";
      this.Box_TileID_Hex.TextAlign = HorizontalAlignment.Right;
      this.Box_TileID.BorderStyle = BorderStyle.FixedSingle;
      TextBox boxTileId1 = this.Box_TileID;
      point1 = new Point(64, 200);
      Point point10 = point1;
      boxTileId1.Location = point10;
      this.Box_TileID.Name = "Box_TileID";
      TextBox boxTileId2 = this.Box_TileID;
      size1 = new Size(48, 20);
      Size size10 = size1;
      boxTileId2.Size = size10;
      this.Box_TileID.TabIndex = 49;
      this.Box_TileID.Text = "";
      this.Box_TileID.TextAlign = HorizontalAlignment.Right;
      this.Label7.AutoSize = true;
      Label label7_1 = this.Label7;
      point1 = new Point(64, 184);
      Point point11 = point1;
      label7_1.Location = point11;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(37, 16);
      Size size11 = size1;
      label7_2.Size = size11;
      this.Label7.TabIndex = 48;
      this.Label7.Text = "Tile ID";
      ComboBox groupSelect1 = this.GroupSelect;
      point1 = new Point(8, 152);
      Point point12 = point1;
      groupSelect1.Location = point12;
      this.GroupSelect.Name = "GroupSelect";
      ComboBox groupSelect2 = this.GroupSelect;
      size1 = new Size(160, 21);
      Size size12 = size1;
      groupSelect2.Size = size12;
      this.GroupSelect.Sorted = true;
      this.GroupSelect.TabIndex = 47;
      this.ToolBar1.Buttons.AddRange(new ToolBarButton[9]
      {
        this.ToolBarButton1,
        this.ToolBarButton2,
        this.ToolBarButton3,
        this.ToolBarButton4,
        this.ToolBarButton5,
        this.ToolBarButton6,
        this.ToolBarButton7,
        this.ToolBarButton8,
        this.ToolBarButton9
      });
      ToolBar toolBar1_1 = this.ToolBar1;
      size1 = new Size(45, 45);
      Size size13 = size1;
      toolBar1_1.ButtonSize = size13;
      this.ToolBar1.Divider = false;
      this.ToolBar1.Dock = DockStyle.None;
      this.ToolBar1.DropDownArrows = true;
      this.ToolBar1.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      ToolBar toolBar1_2 = this.ToolBar1;
      point1 = new Point(8, 8);
      Point point13 = point1;
      toolBar1_2.Location = point13;
      this.ToolBar1.Name = "ToolBar1";
      this.ToolBar1.ShowToolTips = true;
      ToolBar toolBar1_3 = this.ToolBar1;
      size1 = new Size(144, 139);
      Size size14 = size1;
      toolBar1_3.Size = size14;
      this.ToolBar1.TabIndex = 53;
      this.ToolBarButton1.ImageIndex = 0;
      this.ToolBarButton1.Tag = (object) "0";
      this.ToolBarButton1.Text = "1";
      this.ToolBarButton2.ImageIndex = 1;
      this.ToolBarButton2.Tag = (object) "1";
      this.ToolBarButton2.Text = "2";
      this.ToolBarButton3.Tag = (object) "2";
      this.ToolBarButton3.Text = "3";
      this.ToolBarButton4.Tag = (object) "3";
      this.ToolBarButton4.Text = "4";
      this.ToolBarButton5.Tag = (object) "4";
      this.ToolBarButton5.Text = "5";
      this.ToolBarButton6.Tag = (object) "5";
      this.ToolBarButton6.Text = "6";
      this.ToolBarButton7.Tag = (object) "6";
      this.ToolBarButton7.Text = "7";
      this.ToolBarButton8.Tag = (object) "7";
      this.ToolBarButton8.Text = "8";
      this.ToolBarButton9.Tag = (object) "8";
      this.ToolBarButton9.Text = "9";
      this.TabMap.Controls.Add((Control) this.MapToolBar);
      this.TabMap.Controls.Add((Control) this.MapTileList);
      this.TabMap.Controls.Add((Control) this.LandItems);
      this.TabMap.Controls.Add((Control) this.LandImage);
      this.TabMap.Controls.Add((Control) this.Btn_Land);
      this.TabMap.Controls.Add((Control) this.Label5);
      this.TabMap.Controls.Add((Control) this.Btn_Land_Hex);
      this.TabMap.Controls.Add((Control) this.Map_TileID_Hex);
      this.TabMap.Controls.Add((Control) this.Label6);
      this.TabMap.Controls.Add((Control) this.Map_TileID);
      this.TabMap.Controls.Add((Control) this.Map_AltIDMod);
      TabPage tabMap1 = this.TabMap;
      point1 = new Point(4, 22);
      Point point14 = point1;
      tabMap1.Location = point14;
      this.TabMap.Name = "TabMap";
      TabPage tabMap2 = this.TabMap;
      size1 = new Size(176, 262);
      Size size15 = size1;
      tabMap2.Size = size15;
      this.TabMap.TabIndex = 0;
      this.TabMap.Text = "Map";
      this.TabMap.Visible = false;
      this.MapToolBar.Buttons.AddRange(new ToolBarButton[4]
      {
        this.ToolBarButton10,
        this.ToolBarButton11,
        this.ToolBarButton12,
        this.ToolBarButton13
      });
      ToolBar mapToolBar1 = this.MapToolBar;
      size1 = new Size(32, 32);
      Size size16 = size1;
      mapToolBar1.ButtonSize = size16;
      this.MapToolBar.Divider = false;
      this.MapToolBar.Dock = DockStyle.Bottom;
      this.MapToolBar.DropDownArrows = true;
      this.MapToolBar.ImageList = this.ImageList1;
      ToolBar mapToolBar2 = this.MapToolBar;
      point1 = new Point(0, 226);
      Point point15 = point1;
      mapToolBar2.Location = point15;
      this.MapToolBar.Name = "MapToolBar";
      this.MapToolBar.ShowToolTips = true;
      ToolBar mapToolBar3 = this.MapToolBar;
      size1 = new Size(160, 36);
      Size size17 = size1;
      mapToolBar3.Size = size17;
      this.MapToolBar.TabIndex = 25;
      this.ToolBarButton10.ImageIndex = 0;
      this.ToolBarButton10.Tag = (object) "Add";
      this.ToolBarButton10.ToolTipText = "Add Map ID to List.";
      this.ToolBarButton11.ImageIndex = 4;
      this.ToolBarButton11.Tag = (object) "Delete";
      this.ToolBarButton11.ToolTipText = "Delete Map ID from List.";
      this.ToolBarButton12.ImageIndex = 2;
      this.ToolBarButton12.Style = ToolBarButtonStyle.ToggleButton;
      this.ToolBarButton12.Tag = (object) "Test";
      this.ToolBarButton12.ToolTipText = "Test the Map ID image.";
      this.ToolBarButton13.ImageIndex = 5;
      this.ToolBarButton13.Tag = (object) "Select";
      this.ToolBarButton13.ToolTipText = "Select from Selection Screen.";
      ImageList imageList1 = this.ImageList1;
      size1 = new Size(16, 16);
      Size size18 = size1;
      imageList1.ImageSize = size18;
      this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
      this.ImageList1.TransparentColor = Color.Transparent;
      this.MapTileList.BorderStyle = BorderStyle.FixedSingle;
      ListBox mapTileList1 = this.MapTileList;
      point1 = new Point(88, 8);
      Point point16 = point1;
      mapTileList1.Location = point16;
      this.MapTileList.Name = "MapTileList";
      ListBox mapTileList2 = this.MapTileList;
      size1 = new Size(64, 132);
      Size size19 = size1;
      mapTileList2.Size = size19;
      this.MapTileList.TabIndex = 10;
      this.LandItems.Dock = DockStyle.Right;
      this.LandItems.LargeChange = 32;
      VScrollBar landItems1 = this.LandItems;
      point1 = new Point(160, 0);
      Point point17 = point1;
      landItems1.Location = point17;
      this.LandItems.Maximum = 16535;
      this.LandItems.Name = "LandItems";
      VScrollBar landItems2 = this.LandItems;
      size1 = new Size(16, 262);
      Size size20 = size1;
      landItems2.Size = size20;
      this.LandItems.TabIndex = 19;
      this.LandImage.BorderStyle = BorderStyle.FixedSingle;
      PictureBox landImage1 = this.LandImage;
      point1 = new Point(8, 8);
      Point point18 = point1;
      landImage1.Location = point18;
      this.LandImage.Name = "LandImage";
      PictureBox landImage2 = this.LandImage;
      size1 = new Size(56, 56);
      Size size21 = size1;
      landImage2.Size = size21;
      this.LandImage.SizeMode = PictureBoxSizeMode.CenterImage;
      this.LandImage.TabIndex = 20;
      this.LandImage.TabStop = false;
      Button btnLand1 = this.Btn_Land;
      point1 = new Point(64, 160);
      Point point19 = point1;
      btnLand1.Location = point19;
      this.Btn_Land.Name = "Btn_Land";
      Button btnLand2 = this.Btn_Land;
      size1 = new Size(32, 20);
      Size size22 = size1;
      btnLand2.Size = size22;
      this.Btn_Land.TabIndex = 16;
      this.Btn_Land.Text = "Go";
      this.Label5.AutoSize = true;
      Label label5_1 = this.Label5;
      point1 = new Point(104, 144);
      Point point20 = point1;
      label5_1.Location = point20;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(43, 16);
      Size size23 = size1;
      label5_2.Size = size23;
      this.Label5.TabIndex = 15;
      this.Label5.Text = "Alt Mod";
      Button btnLandHex1 = this.Btn_Land_Hex;
      point1 = new Point(64, 184);
      Point point21 = point1;
      btnLandHex1.Location = point21;
      this.Btn_Land_Hex.Name = "Btn_Land_Hex";
      Button btnLandHex2 = this.Btn_Land_Hex;
      size1 = new Size(32, 20);
      Size size24 = size1;
      btnLandHex2.Size = size24;
      this.Btn_Land_Hex.TabIndex = 22;
      this.Btn_Land_Hex.Text = "Go";
      this.Map_TileID_Hex.BorderStyle = BorderStyle.FixedSingle;
      TextBox mapTileIdHex1 = this.Map_TileID_Hex;
      point1 = new Point(8, 184);
      Point point22 = point1;
      mapTileIdHex1.Location = point22;
      this.Map_TileID_Hex.Name = "Map_TileID_Hex";
      TextBox mapTileIdHex2 = this.Map_TileID_Hex;
      size1 = new Size(48, 20);
      Size size25 = size1;
      mapTileIdHex2.Size = size25;
      this.Map_TileID_Hex.TabIndex = 21;
      this.Map_TileID_Hex.Text = "";
      this.Map_TileID_Hex.TextAlign = HorizontalAlignment.Right;
      this.Label6.AutoSize = true;
      Label label6_1 = this.Label6;
      point1 = new Point(8, 144);
      Point point23 = point1;
      label6_1.Location = point23;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(37, 16);
      Size size26 = size1;
      label6_2.Size = size26;
      this.Label6.TabIndex = 12;
      this.Label6.Text = "Tile ID";
      this.Map_TileID.BorderStyle = BorderStyle.FixedSingle;
      TextBox mapTileId1 = this.Map_TileID;
      point1 = new Point(8, 160);
      Point point24 = point1;
      mapTileId1.Location = point24;
      this.Map_TileID.Name = "Map_TileID";
      TextBox mapTileId2 = this.Map_TileID;
      size1 = new Size(48, 20);
      Size size27 = size1;
      mapTileId2.Size = size27;
      this.Map_TileID.TabIndex = 13;
      this.Map_TileID.Text = "";
      this.Map_TileID.TextAlign = HorizontalAlignment.Right;
      this.Map_AltIDMod.BorderStyle = BorderStyle.FixedSingle;
      NumericUpDown mapAltIdMod1 = this.Map_AltIDMod;
      point1 = new Point(104, 160);
      Point point25 = point1;
      mapAltIdMod1.Location = point25;
      NumericUpDown mapAltIdMod2 = this.Map_AltIDMod;
      Decimal num1 = new Decimal(new int[4]
      {
        (int) sbyte.MaxValue,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      mapAltIdMod2.Maximum = num2;
      NumericUpDown mapAltIdMod3 = this.Map_AltIDMod;
      num1 = new Decimal(new int[4]
      {
        (int) sbyte.MaxValue,
        0,
        0,
        int.MinValue
      });
      Decimal num3 = num1;
      mapAltIdMod3.Minimum = num3;
      this.Map_AltIDMod.Name = "Map_AltIDMod";
      NumericUpDown mapAltIdMod4 = this.Map_AltIDMod;
      size1 = new Size(48, 20);
      Size size28 = size1;
      mapAltIdMod4.Size = size28;
      this.Map_AltIDMod.TabIndex = 14;
      this.TabStatic.Controls.Add((Control) this.StaticToolBar);
      this.TabStatic.Controls.Add((Control) this.StaticImage);
      this.TabStatic.Controls.Add((Control) this.StaticTileList);
      this.TabStatic.Controls.Add((Control) this.Btn_Static_Hex);
      this.TabStatic.Controls.Add((Control) this.Static_TileID_Hex);
      this.TabStatic.Controls.Add((Control) this.Label1);
      this.TabStatic.Controls.Add((Control) this.Static_TileID);
      this.TabStatic.Controls.Add((Control) this.Btn_Static);
      this.TabStatic.Controls.Add((Control) this.Label2);
      this.TabStatic.Controls.Add((Control) this.Static_AltIDMod);
      this.TabStatic.Controls.Add((Control) this.StaticItems);
      TabPage tabStatic1 = this.TabStatic;
      point1 = new Point(4, 22);
      Point point26 = point1;
      tabStatic1.Location = point26;
      this.TabStatic.Name = "TabStatic";
      TabPage tabStatic2 = this.TabStatic;
      size1 = new Size(176, 262);
      Size size29 = size1;
      tabStatic2.Size = size29;
      this.TabStatic.TabIndex = 1;
      this.TabStatic.Text = "Static";
      this.TabStatic.Visible = false;
      this.StaticToolBar.Buttons.AddRange(new ToolBarButton[3]
      {
        this.ToolBarButton14,
        this.ToolBarButton15,
        this.ToolBarButton16
      });
      ToolBar staticToolBar1 = this.StaticToolBar;
      size1 = new Size(32, 32);
      Size size30 = size1;
      staticToolBar1.ButtonSize = size30;
      this.StaticToolBar.Divider = false;
      this.StaticToolBar.Dock = DockStyle.Bottom;
      this.StaticToolBar.DropDownArrows = true;
      this.StaticToolBar.ImageList = this.ImageList1;
      ToolBar staticToolBar2 = this.StaticToolBar;
      point1 = new Point(0, 226);
      Point point27 = point1;
      staticToolBar2.Location = point27;
      this.StaticToolBar.Name = "StaticToolBar";
      this.StaticToolBar.ShowToolTips = true;
      ToolBar staticToolBar3 = this.StaticToolBar;
      size1 = new Size(160, 36);
      Size size31 = size1;
      staticToolBar3.Size = size31;
      this.StaticToolBar.TabIndex = 33;
      this.ToolBarButton14.ImageIndex = 0;
      this.ToolBarButton14.Tag = (object) "Add";
      this.ToolBarButton14.ToolTipText = "Add Static ID to List";
      this.ToolBarButton15.ImageIndex = 4;
      this.ToolBarButton15.Tag = (object) "Delete";
      this.ToolBarButton15.ToolTipText = "Delete Static ID from the List.";
      this.ToolBarButton16.ImageIndex = 5;
      this.ToolBarButton16.Tag = (object) "Select";
      this.ToolBarButton16.ToolTipText = "Select from Selection Screen.";
      this.StaticImage.BorderStyle = BorderStyle.FixedSingle;
      PictureBox staticImage1 = this.StaticImage;
      point1 = new Point(8, 8);
      Point point28 = point1;
      staticImage1.Location = point28;
      this.StaticImage.Name = "StaticImage";
      PictureBox staticImage2 = this.StaticImage;
      size1 = new Size(72, 144);
      Size size32 = size1;
      staticImage2.Size = size32;
      this.StaticImage.SizeMode = PictureBoxSizeMode.CenterImage;
      this.StaticImage.TabIndex = 30;
      this.StaticImage.TabStop = false;
      this.StaticTileList.BorderStyle = BorderStyle.FixedSingle;
      ListBox staticTileList1 = this.StaticTileList;
      point1 = new Point(88, 8);
      Point point29 = point1;
      staticTileList1.Location = point29;
      this.StaticTileList.Name = "StaticTileList";
      ListBox staticTileList2 = this.StaticTileList;
      size1 = new Size(64, 145);
      Size size33 = size1;
      staticTileList2.Size = size33;
      this.StaticTileList.TabIndex = 20;
      Button btnStaticHex1 = this.Btn_Static_Hex;
      point1 = new Point(64, 200);
      Point point30 = point1;
      btnStaticHex1.Location = point30;
      this.Btn_Static_Hex.Name = "Btn_Static_Hex";
      Button btnStaticHex2 = this.Btn_Static_Hex;
      size1 = new Size(32, 20);
      Size size34 = size1;
      btnStaticHex2.Size = size34;
      this.Btn_Static_Hex.TabIndex = 32;
      this.Btn_Static_Hex.Text = "Go";
      this.Static_TileID_Hex.BorderStyle = BorderStyle.FixedSingle;
      TextBox staticTileIdHex1 = this.Static_TileID_Hex;
      point1 = new Point(8, 200);
      Point point31 = point1;
      staticTileIdHex1.Location = point31;
      this.Static_TileID_Hex.Name = "Static_TileID_Hex";
      TextBox staticTileIdHex2 = this.Static_TileID_Hex;
      size1 = new Size(48, 20);
      Size size35 = size1;
      staticTileIdHex2.Size = size35;
      this.Static_TileID_Hex.TabIndex = 31;
      this.Static_TileID_Hex.Text = "";
      this.Static_TileID_Hex.TextAlign = HorizontalAlignment.Right;
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(8, 160);
      Point point32 = point1;
      label1_1.Location = point32;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(37, 16);
      Size size36 = size1;
      label1_2.Size = size36;
      this.Label1.TabIndex = 22;
      this.Label1.Text = "Tile ID";
      this.Static_TileID.BorderStyle = BorderStyle.FixedSingle;
      TextBox staticTileId1 = this.Static_TileID;
      point1 = new Point(8, 176);
      Point point33 = point1;
      staticTileId1.Location = point33;
      this.Static_TileID.Name = "Static_TileID";
      TextBox staticTileId2 = this.Static_TileID;
      size1 = new Size(48, 20);
      Size size37 = size1;
      staticTileId2.Size = size37;
      this.Static_TileID.TabIndex = 23;
      this.Static_TileID.Text = "";
      this.Static_TileID.TextAlign = HorizontalAlignment.Right;
      Button btnStatic1 = this.Btn_Static;
      point1 = new Point(64, 176);
      Point point34 = point1;
      btnStatic1.Location = point34;
      this.Btn_Static.Name = "Btn_Static";
      Button btnStatic2 = this.Btn_Static;
      size1 = new Size(32, 20);
      Size size38 = size1;
      btnStatic2.Size = size38;
      this.Btn_Static.TabIndex = 26;
      this.Btn_Static.Text = "Go";
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(104, 160);
      Point point35 = point1;
      label2_1.Location = point35;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(43, 16);
      Size size39 = size1;
      label2_2.Size = size39;
      this.Label2.TabIndex = 25;
      this.Label2.Text = "Alt Mod";
      this.Static_AltIDMod.BorderStyle = BorderStyle.FixedSingle;
      NumericUpDown staticAltIdMod1 = this.Static_AltIDMod;
      point1 = new Point(104, 176);
      Point point36 = point1;
      staticAltIdMod1.Location = point36;
      NumericUpDown staticAltIdMod2 = this.Static_AltIDMod;
      num1 = new Decimal(new int[4]
      {
        (int) sbyte.MaxValue,
        0,
        0,
        0
      });
      Decimal num4 = num1;
      staticAltIdMod2.Maximum = num4;
      NumericUpDown staticAltIdMod3 = this.Static_AltIDMod;
      num1 = new Decimal(new int[4]
      {
        (int) sbyte.MaxValue,
        0,
        0,
        int.MinValue
      });
      Decimal num5 = num1;
      staticAltIdMod3.Minimum = num5;
      this.Static_AltIDMod.Name = "Static_AltIDMod";
      NumericUpDown staticAltIdMod4 = this.Static_AltIDMod;
      size1 = new Size(48, 20);
      Size size40 = size1;
      staticAltIdMod4.Size = size40;
      this.Static_AltIDMod.TabIndex = 24;
      this.StaticItems.Dock = DockStyle.Right;
      this.StaticItems.LargeChange = 32;
      VScrollBar staticItems1 = this.StaticItems;
      point1 = new Point(160, 0);
      Point point37 = point1;
      staticItems1.Location = point37;
      this.StaticItems.Maximum = 16535;
      this.StaticItems.Name = "StaticItems";
      VScrollBar staticItems2 = this.StaticItems;
      size1 = new Size(16, 262);
      Size size41 = size1;
      staticItems2.Size = size41;
      this.StaticItems.TabIndex = 29;
      this.BoxFileName.BorderStyle = BorderStyle.FixedSingle;
      TextBox boxFileName1 = this.BoxFileName;
      point1 = new Point(392, 8);
      Point point38 = point1;
      boxFileName1.Location = point38;
      this.BoxFileName.Name = "BoxFileName";
      TextBox boxFileName2 = this.BoxFileName;
      size1 = new Size(112, 20);
      Size size42 = size1;
      boxFileName2.Size = size42;
      this.BoxFileName.TabIndex = 52;
      this.BoxFileName.Text = "";
      this.Label3.AutoSize = true;
      Label label3_1 = this.Label3;
      point1 = new Point(352, 8);
      Point point39 = point1;
      label3_1.Location = point39;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(23, 16);
      Size size43 = size1;
      label3_2.Size = size43;
      this.Label3.TabIndex = 53;
      this.Label3.Text = "File";
      this.Label4.AutoSize = true;
      Label label4_1 = this.Label4;
      point1 = new Point(352, 32);
      Point point40 = point1;
      label4_1.Location = point40;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(30, 16);
      Size size44 = size1;
      label4_2.Size = size44;
      this.Label4.TabIndex = 54;
      this.Label4.Text = "Desc";
      this.Label8.AutoSize = true;
      Label label8_1 = this.Label8;
      point1 = new Point(352, 56);
      Point point41 = point1;
      label8_1.Location = point41;
      this.Label8.Name = "Label8";
      Label label8_2 = this.Label8;
      size1 = new Size(24, 16);
      Size size45 = size1;
      label8_2.Size = size45;
      this.Label8.TabIndex = 55;
      this.Label8.Text = "Key";
      Button btnStaticFile1 = this.Btn_StaticFile;
      point1 = new Point(504, 8);
      Point point42 = point1;
      btnStaticFile1.Location = point42;
      this.Btn_StaticFile.Name = "Btn_StaticFile";
      Button btnStaticFile2 = this.Btn_StaticFile;
      size1 = new Size(32, 20);
      Size size46 = size1;
      btnStaticFile2.Size = size46;
      this.Btn_StaticFile.TabIndex = 56;
      this.Btn_StaticFile.Text = "...";
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(538, 555);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Btn_StaticFile);
      this.Controls.Add((Control) this.Label8);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.BoxFileName);
      this.Controls.Add((Control) this.TabControl1);
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.Lbl_HashKey);
      this.Controls.Add((Control) this.Box_Description);
      this.Controls.Add((Control) this.ListBox1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Menu = this.MainMenu1;
      this.Name = "TEdit";
      this.Text = "Transition Editor";
      this.TabControl1.ResumeLayout(false);
      this.TabDraw.ResumeLayout(false);
      this.TabMap.ResumeLayout(false);
      this.Map_AltIDMod.EndInit();
      this.TabStatic.ResumeLayout(false);
      this.Static_AltIDMod.EndInit();
      this.ResumeLayout(false);
    }

    private void TEdit_Load(object sender, EventArgs e)
    {
      this.iGroups.Load();
      this.iGroups.Display(this.GroupSelect);
    }

    private void GroupSelect_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.iSelectedGroup = (ClsTerrain) this.GroupSelect.SelectedItem;
      this.PictureBox3.Image = (Image) Art.GetLand((int) this.iSelectedGroup.TileID);
      this.Box_TileID.Text = StringType.FromInteger((int) this.iSelectedGroup.TileID);
      this.Box_TileID_Hex.Text = string.Format("{0:X4}", (object) this.iSelectedGroup.TileID);
    }

    private void PictureBox1_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics1 = e.Graphics;
      this.LandImage.Image = (Image) null;
      this.StaticImage.Image = (Image) null;
      this.Box_Description.Text = this.iTransition.Description;
      this.Lbl_HashKey.Text = this.iTransition.HashKey;
      this.BoxFileName.Text = this.iTransition.File;
      this.iTransition.GetStaticTiles.Display(this.StaticTileList);
      this.iTransition.GetMapTiles.Display(this.MapTileList);
      graphics1.Clear(Color.LightGray);
      Graphics graphics2 = graphics1;
      Bitmap land1 = Art.GetLand((int) this.iGroups.get_TerrianGroup((int) this.iTransition.get_GetKey(0)).TileID);
      Point point1 = new Point(61, 15);
      Point point2 = point1;
      graphics2.DrawImage((Image) land1, point2);
      Graphics graphics3 = graphics1;
      Bitmap land2 = Art.GetLand((int) this.iGroups.get_TerrianGroup((int) this.iTransition.get_GetKey(1)).TileID);
      point1 = new Point(84, 38);
      Point point3 = point1;
      graphics3.DrawImage((Image) land2, point3);
      Graphics graphics4 = graphics1;
      Bitmap land3 = Art.GetLand((int) this.iGroups.get_TerrianGroup((int) this.iTransition.get_GetKey(2)).TileID);
      point1 = new Point(107, 61);
      Point point4 = point1;
      graphics4.DrawImage((Image) land3, point4);
      Graphics graphics5 = graphics1;
      Bitmap land4 = Art.GetLand((int) this.iGroups.get_TerrianGroup((int) this.iTransition.get_GetKey(3)).TileID);
      point1 = new Point(38, 38);
      Point point5 = point1;
      graphics5.DrawImage((Image) land4, point5);
      if (this.ImageTest)
      {
        Graphics graphics6 = graphics1;
        Bitmap land5 = Art.GetLand(IntegerType.FromString(this.Map_TileID.Text));
        point1 = new Point(61, 61);
        Point point6 = point1;
        graphics6.DrawImage((Image) land5, point6);
      }
      else
      {
        Graphics graphics6 = graphics1;
        Bitmap land5 = Art.GetLand((int) this.iGroups.get_TerrianGroup((int) this.iTransition.get_GetKey(4)).TileID);
        point1 = new Point(61, 61);
        Point point6 = point1;
        graphics6.DrawImage((Image) land5, point6);
      }
      Graphics graphics7 = graphics1;
      Bitmap land6 = Art.GetLand((int) this.iGroups.get_TerrianGroup((int) this.iTransition.get_GetKey(5)).TileID);
      point1 = new Point(84, 84);
      Point point7 = point1;
      graphics7.DrawImage((Image) land6, point7);
      Graphics graphics8 = graphics1;
      Bitmap land7 = Art.GetLand((int) this.iGroups.get_TerrianGroup((int) this.iTransition.get_GetKey(6)).TileID);
      point1 = new Point(15, 61);
      Point point8 = point1;
      graphics8.DrawImage((Image) land7, point8);
      Graphics graphics9 = graphics1;
      Bitmap land8 = Art.GetLand((int) this.iGroups.get_TerrianGroup((int) this.iTransition.get_GetKey(7)).TileID);
      point1 = new Point(38, 84);
      Point point9 = point1;
      graphics9.DrawImage((Image) land8, point9);
      Graphics graphics10 = graphics1;
      Bitmap land9 = Art.GetLand((int) this.iGroups.get_TerrianGroup((int) this.iTransition.get_GetKey(8)).TileID);
      point1 = new Point(61, 107);
      Point point10 = point1;
      graphics10.DrawImage((Image) land9, point10);
      Graphics graphics11 = graphics1;
      Pen pen1 = new Pen(Color.Red, 1f);
      point1 = new Point(82, 60);
      Point pt1_1 = point1;
      Point point11 = new Point(60, 82);
      Point pt2_1 = point11;
      graphics11.DrawLine(pen1, pt1_1, pt2_1);
      Graphics graphics12 = graphics1;
      Pen pen2 = new Pen(Color.Red, 1f);
      point11 = new Point(60, 83);
      Point pt1_2 = point11;
      point1 = new Point(82, 105);
      Point pt2_2 = point1;
      graphics12.DrawLine(pen2, pt1_2, pt2_2);
      Graphics graphics13 = graphics1;
      Pen pen3 = new Pen(Color.Red, 1f);
      point11 = new Point(83, 105);
      Point pt1_3 = point11;
      point1 = new Point(105, 83);
      Point pt2_3 = point1;
      graphics13.DrawLine(pen3, pt1_3, pt2_3);
      Graphics graphics14 = graphics1;
      Pen pen4 = new Pen(Color.Red, 1f);
      point11 = new Point(105, 82);
      Point pt1_4 = point11;
      point1 = new Point(83, 60);
      Point pt2_4 = point1;
      graphics14.DrawLine(pen4, pt1_4, pt2_4);
    }

    private void ToolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
    {
      ClsTerrain clsTerrain = (ClsTerrain) this.GroupSelect.SelectedItem;
      if (clsTerrain == null)
        return;
      this.iTransition.SetHashKey(IntegerType.FromObject(e.Button.Tag), checked ((byte) clsTerrain.GroupID));
      this.PictureBox1.Refresh();
    }

    private void Btn_Land_Click(object sender, EventArgs e)
    {
      try
      {
        int index = IntegerType.FromString(this.Map_TileID.Text);
        this.LandItems.Value = index;
        if (Art.GetLand(index) == null)
          this.LandImage.Image = (Image) null;
        else
          this.LandImage.Image = (Image) Art.GetLand(index);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) this.ErrorMessage(this.Map_TileID.Text, "1", "16535"), MsgBoxStyle.OKOnly, (object) null);
        ProjectData.ClearProjectError();
      }
    }

    private void Btn_Land_Hex_Click(object sender, EventArgs e)
    {
      try
      {
        int index = IntegerType.FromString(this.Map_TileID_Hex.Text);
        this.LandItems.Value = index;
        this.Map_TileID.Text = index.ToString();
        if (Art.GetLand(index) == null)
          this.LandImage.Image = (Image) null;
        else
          this.LandImage.Image = (Image) Art.GetLand(index);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) this.ErrorMessage(this.Map_TileID_Hex.Text, "&H0000", "&H3FFF"), MsgBoxStyle.OKOnly, (object) null);
        ProjectData.ClearProjectError();
      }
    }

    private string ErrorMessage(string iValue, string iMin, string iMax)
    {
      return string.Format("{0} is outside the range\r\nPlease enter a value between {1} and {2}", (object) iValue, (object) iMin, (object) iMax);
    }

    private void LandItems_Scroll(object sender, ScrollEventArgs e)
    {
      this.Map_TileID.Text = this.LandItems.Value.ToString();
      this.Map_TileID_Hex.Text = "&H" + Conversion.Hex(this.LandItems.Value);
      if (Art.GetLand(this.LandItems.Value) == null)
        this.LandImage.Image = (Image) null;
      else
        this.LandImage.Image = (Image) Art.GetLand(this.LandItems.Value);
    }

    private void LandItems_ValueChanged(object sender, EventArgs e)
    {
      this.Map_TileID.Text = this.LandItems.Value.ToString();
      this.Map_TileID_Hex.Text = "&H" + Conversion.Hex(this.LandItems.Value);
      if (Art.GetLand(this.LandItems.Value) == null)
        this.LandImage.Image = (Image) null;
      else
        this.LandImage.Image = (Image) Art.GetLand(this.LandItems.Value);
    }

    private void StaticItems_Scroll(object sender, ScrollEventArgs e)
    {
      this.Static_TileID.Text = this.StaticItems.Value.ToString();
      this.Static_TileID_Hex.Text = "&H" + Conversion.Hex(this.StaticItems.Value);
      if (Art.GetStatic(this.StaticItems.Value) == null)
        this.StaticImage.Image = (Image) null;
      else
        this.StaticImage.Image = (Image) Art.GetStatic(this.StaticItems.Value);
    }

    private void StaticItems_ValueChanged(object sender, EventArgs e)
    {
      this.Static_TileID.Text = this.StaticItems.Value.ToString();
      this.Static_TileID_Hex.Text = "&H" + Conversion.Hex(this.StaticItems.Value);
      if (Art.GetStatic(this.StaticItems.Value) == null)
        this.StaticImage.Image = (Image) null;
      else
        this.StaticImage.Image = (Image) Art.GetStatic(this.StaticItems.Value);
    }

    private void MapToolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
    {
      object tag = e.Button.Tag;
      if (ObjectType.ObjTst(tag, (object) "Add", false) == 0)
      {
        if (StringType.StrCmp(this.Map_TileID.Text, string.Empty, false) == 0)
          return;
        this.iTransition.AddMapTile(ShortType.FromString(this.Map_TileID.Text), Convert.ToInt16(this.Map_AltIDMod.Value));
        this.iTransition.GetMapTiles.Display(this.MapTileList);
      }
      else if (ObjectType.ObjTst(tag, (object) "Delete", false) == 0)
      {
        MapTile iMapTile = (MapTile) this.MapTileList.SelectedItem;
        if (iMapTile == null)
          return;
        this.LandImage.Image = (Image) null;
        this.iTransition.RemoveMapTile(iMapTile);
        this.iTransition.GetMapTiles.Display(this.MapTileList);
      }
      else if (ObjectType.ObjTst(tag, (object) "Test", false) == 0)
      {
        if (StringType.StrCmp(this.Map_TileID.Text, string.Empty, false) == 0)
          return;
        this.ImageTest = !this.ImageTest;
        this.PictureBox1.Refresh();
        this.LandImage.Image = Art.GetLand(IntegerType.FromString(this.Map_TileID.Text)) != null ? (Image) Art.GetLand(IntegerType.FromString(this.Map_TileID.Text)) : (Image) null;
      }
      else if (ObjectType.ObjTst(tag, (object) "Select", false) == 0)
      {
        MapZoom mapZoom = new MapZoom();
        mapZoom.Tag = (object) this.LandItems;
        mapZoom.Show();
      }
    }

    private void StaticToolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
    {
      object tag = e.Button.Tag;
      if (ObjectType.ObjTst(tag, (object) "Add", false) == 0)
      {
        if (StringType.StrCmp(this.Static_TileID.Text, string.Empty, false) == 0)
          return;
        this.iTransition.AddStaticTile(ShortType.FromString(this.Static_TileID.Text), Convert.ToInt16(this.Static_AltIDMod.Value));
        this.iTransition.GetStaticTiles.Display(this.StaticTileList);
      }
      else if (ObjectType.ObjTst(tag, (object) "Delete", false) == 0)
      {
        Transition.StaticTile iStaticTile = (Transition.StaticTile) this.StaticTileList.SelectedItem;
        if (iStaticTile == null)
          return;
        this.StaticImage.Image = (Image) null;
        this.iTransition.RemoveStaticTile(iStaticTile);
        this.iTransition.GetStaticTiles.Display(this.StaticTileList);
      }
      else if (ObjectType.ObjTst(tag, (object) "Select", false) == 0)
      {
        StaticZoom staticZoom = new StaticZoom();
        staticZoom.Tag = (object) this.StaticItems;
        staticZoom.Show();
      }
    }

    private void MenuTerrainA_Click(object sender, EventArgs e)
    {
      GroupSelect groupSelect = new GroupSelect();
      groupSelect.SelectGroupName.Text = "Select Group A";
      groupSelect.Tag = (object) this;
      groupSelect.Show();
    }

    private void MenuSelectB_Click(object sender, EventArgs e)
    {
      GroupSelect groupSelect = new GroupSelect();
      groupSelect.SelectGroupName.Text = "Select Group B";
      groupSelect.Tag = (object) this;
      groupSelect.Show();
    }

    private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      Transition transition = (Transition) this.ListBox1.SelectedItem;
      if (transition == null)
        return;
      this.iTransition = transition;
      this.PictureBox1.Refresh();
    }

    private void MenuNew_Click(object sender, EventArgs e)
    {
      this.iTransitionTable.Clear();
      this.iTransitionTable.Display(this.ListBox1);
      this.iTransition = new Transition();
      this.PictureBox1.Refresh();
    }

    private void MenuLoad_Click(object sender, EventArgs e)
    {
      this.iTransitionTable.Clear();
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.iTransitionTable.Load(openFileDialog.FileName);
      this.iTransitionTable.Display(this.ListBox1);
    }

    private void MenuSave_Click(object sender, EventArgs e)
    {
      this.iTransitionTable.Save(this.Box_Description.Text);
    }

    private void MapTileList_SelectedIndexChanged(object sender, EventArgs e)
    {
      MapTile mapTile = (MapTile) this.MapTileList.SelectedItem;
      if (mapTile == null)
        return;
      this.Map_TileID.Text = mapTile.TileID.ToString();
      this.Map_TileID_Hex.Text = "&H" + Conversion.Hex(mapTile.TileID);
      this.LandItems.Value = (int) mapTile.TileID;
      this.LandImage.Image = Art.GetLand((int) mapTile.TileID) != null ? (Image) Art.GetLand((int) mapTile.TileID) : (Image) null;
    }

    private void StaticTileList_SelectedIndexChanged(object sender, EventArgs e)
    {
      Transition.StaticTile staticTile = (Transition.StaticTile) this.StaticTileList.SelectedItem;
      if (staticTile == null)
        return;
      this.Static_TileID.Text = staticTile.TileID.ToString();
      this.Static_TileID_Hex.Text = "&H" + Conversion.Hex(staticTile.TileID);
      this.StaticItems.Value = (int) staticTile.TileID;
      this.StaticImage.Image = Art.GetStatic((int) staticTile.TileID) != null ? (Image) Art.GetStatic((int) staticTile.TileID) : (Image) null;
    }

    private void MenuAddKey_Click(object sender, EventArgs e)
    {
      this.iTransitionTable.Add(this.iTransition);
      this.iTransition = new Transition();
      this.iTransitionTable.Display(this.ListBox1);
      this.PictureBox1.Refresh();
    }

    private void MenuDelKey_Click(object sender, EventArgs e)
    {
      Transition iValue = (Transition) this.ListBox1.SelectedItem;
      if (iValue == null)
        return;
      this.iTransitionTable.Remove(iValue);
      this.iTransitionTable.Display(this.ListBox1);
    }

    private void MenuCopyKey_Click(object sender, EventArgs e)
    {
      this.iTransitionTable.Add(this.iTransition);
      this.iTransitionTable.Display(this.ListBox1);
      this.PictureBox1.Refresh();
    }

    private void MenuItem1_Click(object sender, EventArgs e)
    {
      this.iTransition = new Transition();
      this.PictureBox1.Refresh();
    }

    private void BoxFileName_TextChanged(object sender, EventArgs e)
    {
      this.iTransition.File = this.BoxFileName.Text;
      this.iTransitionTable.Display(this.ListBox1);
    }

    private void Btn_StaticFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Data\\Statics";
      openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
      openFileDialog.FilterIndex = 2;
      openFileDialog.RestoreDirectory = true;
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.BoxFileName.Text = new FileInfo(openFileDialog.FileName).Name;
    }

    private void Box_Description_Leave(object sender, EventArgs e)
    {
      this.iTransition.Description = this.Box_Description.Text;
      this.iTransitionTable.Display(this.ListBox1);
    }

    private void Menu2Way_Click(object sender, EventArgs e)
    {
      if (this.m_SelectedGroupA == null || this.m_SelectedGroupB == null || StringType.StrCmp(this.m_SelectedGroupA.Name, this.m_SelectedGroupB.Name, false) == 0)
        return;
      string iDescription = string.Format("{0} To {1}", (object) this.m_SelectedGroupA.Name, (object) this.m_SelectedGroupB.Name);
      string filename = string.Format("{0}Data\\System\\2Way_Template.xml", (object) AppDomain.CurrentDomain.BaseDirectory);
      XmlDocument xmlDocument = new XmlDocument();
      this.iTransitionTable.Clear();
      try
      {
        xmlDocument.Load(filename);
        try
        {
          foreach (XmlElement xmlElement in xmlDocument.SelectNodes("//Wizard/Tile"))
          {
            string attribute = xmlElement.GetAttribute("Pattern");
            this.iTransitionTable.Add(new Transition(iDescription, this.m_SelectedGroupA, this.m_SelectedGroupB, attribute));
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
        int num = (int) Interaction.MsgBox((object) string.Format("XMLFile:{0}", (object) filename), MsgBoxStyle.OKOnly, (object) null);
        ProjectData.ClearProjectError();
      }
      this.iTransitionTable.Display(this.ListBox1);
    }

    private void Menu3Way_Click(object sender, EventArgs e)
    {
      if (this.m_SelectedGroupA == null || this.m_SelectedGroupB == null || (this.m_SelectedGroupC == null || StringType.StrCmp(this.m_SelectedGroupA.Name, this.m_SelectedGroupB.Name, false) == 0))
        return;
      string iDescription = string.Format("{0}-{1}-{2}", (object) this.m_SelectedGroupA.Name, (object) this.m_SelectedGroupB.Name, (object) this.m_SelectedGroupC.Name);
      string filename = string.Format("{0}Data\\System\\3Way_Template.xml", (object) AppDomain.CurrentDomain.BaseDirectory);
      XmlDocument xmlDocument = new XmlDocument();
      this.iTransitionTable.Clear();
      try
      {
        xmlDocument.Load(filename);
        try
        {
          foreach (XmlElement xmlElement in xmlDocument.SelectNodes("//Wizard/Tile"))
          {
            string attribute = xmlElement.GetAttribute("Pattern");
            this.iTransitionTable.Add(new Transition(iDescription, this.m_SelectedGroupA, this.m_SelectedGroupB, this.m_SelectedGroupC, attribute));
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
        int num = (int) Interaction.MsgBox((object) string.Format("XMLFile:{0}", (object) filename), MsgBoxStyle.OKOnly, (object) null);
        ProjectData.ClearProjectError();
      }
      this.iTransitionTable.Display(this.ListBox1);
    }

    private void MenuTerrainC_Click(object sender, EventArgs e)
    {
      GroupSelect groupSelect = new GroupSelect();
      groupSelect.SelectGroupName.Text = "Select Group C";
      groupSelect.Tag = (object) this;
      groupSelect.Show();
    }

    private void MenuItem3_Click(object sender, EventArgs e)
    {
      PrintTransition printTransition = new PrintTransition();
    }

    private void Menu_CloneGroupA_Click(object sender, EventArgs e)
    {
      GroupSelect groupSelect = new GroupSelect();
      groupSelect.SelectGroupName.Text = "Clone Group A";
      groupSelect.Tag = (object) this;
      groupSelect.Show();
    }

    private void Menu_CloneGroupB_Click(object sender, EventArgs e)
    {
      GroupSelect groupSelect = new GroupSelect();
      groupSelect.SelectGroupName.Text = "Clone Group B";
      groupSelect.Tag = (object) this;
      groupSelect.Show();
    }

    private void MenuItem10_Click(object sender, EventArgs e)
    {
      if (this.m_SelectedGroupA == null || this.m_SelectedGroupB == null)
        return;
      this.iTransitionTable.Clear();
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() == DialogResult.OK)
        this.iTransitionTable.Load(openFileDialog.FileName);
      try
      {
        foreach (Transition transition in (IEnumerable) this.iTransitionTable.TransitionTable.Values)
          transition.Clone(this.m_SelectedGroupA, this.m_SelectedGroupB);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
      this.iTransitionTable.Save(openFileDialog.FileName.Replace(this.m_SelectedGroupA.Name, this.m_SelectedGroupB.Name));
    }
  }
}
