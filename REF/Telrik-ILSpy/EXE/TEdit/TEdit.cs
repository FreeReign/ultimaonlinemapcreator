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

		internal virtual TextBox Box_Description
		{
			get
			{
				return this._Box_Description;
			}
			set
			{
				if (this._Box_Description != null)
				{
					TEdit tEdit = this;
					this._Box_Description.Leave -= new EventHandler(tEdit.Box_Description_Leave);
				}
				this._Box_Description = value;
				if (this._Box_Description != null)
				{
					TEdit tEdit1 = this;
					this._Box_Description.Leave += new EventHandler(tEdit1.Box_Description_Leave);
				}
			}
		}

		internal virtual TextBox Box_TileID
		{
			get
			{
				return this._Box_TileID;
			}
			set
			{
				this._Box_TileID == null;
				this._Box_TileID = value;
				this._Box_TileID == null;
			}
		}

		internal virtual TextBox Box_TileID_Hex
		{
			get
			{
				return this._Box_TileID_Hex;
			}
			set
			{
				this._Box_TileID_Hex == null;
				this._Box_TileID_Hex = value;
				this._Box_TileID_Hex == null;
			}
		}

		internal virtual TextBox BoxFileName
		{
			get
			{
				return this._BoxFileName;
			}
			set
			{
				if (this._BoxFileName != null)
				{
					TEdit tEdit = this;
					this._BoxFileName.TextChanged -= new EventHandler(tEdit.BoxFileName_TextChanged);
				}
				this._BoxFileName = value;
				if (this._BoxFileName != null)
				{
					TEdit tEdit1 = this;
					this._BoxFileName.TextChanged += new EventHandler(tEdit1.BoxFileName_TextChanged);
				}
			}
		}

		internal virtual Button Btn_Land
		{
			get
			{
				return this._Btn_Land;
			}
			set
			{
				if (this._Btn_Land != null)
				{
					TEdit tEdit = this;
					this._Btn_Land.Click -= new EventHandler(tEdit.Btn_Land_Click);
				}
				this._Btn_Land = value;
				if (this._Btn_Land != null)
				{
					TEdit tEdit1 = this;
					this._Btn_Land.Click += new EventHandler(tEdit1.Btn_Land_Click);
				}
			}
		}

		internal virtual Button Btn_Land_Hex
		{
			get
			{
				return this._Btn_Land_Hex;
			}
			set
			{
				if (this._Btn_Land_Hex != null)
				{
					TEdit tEdit = this;
					this._Btn_Land_Hex.Click -= new EventHandler(tEdit.Btn_Land_Hex_Click);
				}
				this._Btn_Land_Hex = value;
				if (this._Btn_Land_Hex != null)
				{
					TEdit tEdit1 = this;
					this._Btn_Land_Hex.Click += new EventHandler(tEdit1.Btn_Land_Hex_Click);
				}
			}
		}

		internal virtual Button Btn_Static
		{
			get
			{
				return this._Btn_Static;
			}
			set
			{
				this._Btn_Static == null;
				this._Btn_Static = value;
				this._Btn_Static == null;
			}
		}

		internal virtual Button Btn_Static_Hex
		{
			get
			{
				return this._Btn_Static_Hex;
			}
			set
			{
				this._Btn_Static_Hex == null;
				this._Btn_Static_Hex = value;
				this._Btn_Static_Hex == null;
			}
		}

		internal virtual Button Btn_StaticFile
		{
			get
			{
				return this._Btn_StaticFile;
			}
			set
			{
				if (this._Btn_StaticFile != null)
				{
					TEdit tEdit = this;
					this._Btn_StaticFile.Click -= new EventHandler(tEdit.Btn_StaticFile_Click);
				}
				this._Btn_StaticFile = value;
				if (this._Btn_StaticFile != null)
				{
					TEdit tEdit1 = this;
					this._Btn_StaticFile.Click += new EventHandler(tEdit1.Btn_StaticFile_Click);
				}
			}
		}

		internal virtual ComboBox GroupSelect
		{
			get
			{
				return this._GroupSelect;
			}
			set
			{
				if (this._GroupSelect != null)
				{
					TEdit tEdit = this;
					this._GroupSelect.SelectedIndexChanged -= new EventHandler(tEdit.GroupSelect_SelectedIndexChanged);
				}
				this._GroupSelect = value;
				if (this._GroupSelect != null)
				{
					TEdit tEdit1 = this;
					this._GroupSelect.SelectedIndexChanged += new EventHandler(tEdit1.GroupSelect_SelectedIndexChanged);
				}
			}
		}

		internal virtual ImageList ImageList1
		{
			get
			{
				return this._ImageList1;
			}
			set
			{
				this._ImageList1 == null;
				this._ImageList1 = value;
				this._ImageList1 == null;
			}
		}

		internal virtual Label Label1
		{
			get
			{
				return this._Label1;
			}
			set
			{
				this._Label1 == null;
				this._Label1 = value;
				this._Label1 == null;
			}
		}

		internal virtual Label Label2
		{
			get
			{
				return this._Label2;
			}
			set
			{
				this._Label2 == null;
				this._Label2 = value;
				this._Label2 == null;
			}
		}

		internal virtual Label Label3
		{
			get
			{
				return this._Label3;
			}
			set
			{
				this._Label3 == null;
				this._Label3 = value;
				this._Label3 == null;
			}
		}

		internal virtual Label Label4
		{
			get
			{
				return this._Label4;
			}
			set
			{
				this._Label4 == null;
				this._Label4 = value;
				this._Label4 == null;
			}
		}

		internal virtual Label Label5
		{
			get
			{
				return this._Label5;
			}
			set
			{
				this._Label5 == null;
				this._Label5 = value;
				this._Label5 == null;
			}
		}

		internal virtual Label Label6
		{
			get
			{
				return this._Label6;
			}
			set
			{
				this._Label6 == null;
				this._Label6 = value;
				this._Label6 == null;
			}
		}

		internal virtual Label Label7
		{
			get
			{
				return this._Label7;
			}
			set
			{
				this._Label7 == null;
				this._Label7 = value;
				this._Label7 == null;
			}
		}

		internal virtual Label Label8
		{
			get
			{
				return this._Label8;
			}
			set
			{
				this._Label8 == null;
				this._Label8 = value;
				this._Label8 == null;
			}
		}

		internal virtual PictureBox LandImage
		{
			get
			{
				return this._LandImage;
			}
			set
			{
				this._LandImage == null;
				this._LandImage = value;
				this._LandImage == null;
			}
		}

		internal virtual VScrollBar LandItems
		{
			get
			{
				return this._LandItems;
			}
			set
			{
				if (this._LandItems != null)
				{
					TEdit tEdit = this;
					this._LandItems.ValueChanged -= new EventHandler(tEdit.LandItems_ValueChanged);
					TEdit tEdit1 = this;
					this._LandItems.Scroll -= new ScrollEventHandler(tEdit1.LandItems_Scroll);
				}
				this._LandItems = value;
				if (this._LandItems != null)
				{
					TEdit tEdit2 = this;
					this._LandItems.ValueChanged += new EventHandler(tEdit2.LandItems_ValueChanged);
					TEdit tEdit3 = this;
					this._LandItems.Scroll += new ScrollEventHandler(tEdit3.LandItems_Scroll);
				}
			}
		}

		internal virtual TextBox Lbl_HashKey
		{
			get
			{
				return this._Lbl_HashKey;
			}
			set
			{
				this._Lbl_HashKey == null;
				this._Lbl_HashKey = value;
				this._Lbl_HashKey == null;
			}
		}

		internal virtual ListBox ListBox1
		{
			get
			{
				return this._ListBox1;
			}
			set
			{
				if (this._ListBox1 != null)
				{
					TEdit tEdit = this;
					this._ListBox1.SelectedIndexChanged -= new EventHandler(tEdit.ListBox1_SelectedIndexChanged);
				}
				this._ListBox1 = value;
				if (this._ListBox1 != null)
				{
					TEdit tEdit1 = this;
					this._ListBox1.SelectedIndexChanged += new EventHandler(tEdit1.ListBox1_SelectedIndexChanged);
				}
			}
		}

		internal virtual MainMenu MainMenu1
		{
			get
			{
				return this._MainMenu1;
			}
			set
			{
				this._MainMenu1 == null;
				this._MainMenu1 = value;
				this._MainMenu1 == null;
			}
		}

		internal virtual NumericUpDown Map_AltIDMod
		{
			get
			{
				return this._Map_AltIDMod;
			}
			set
			{
				this._Map_AltIDMod == null;
				this._Map_AltIDMod = value;
				this._Map_AltIDMod == null;
			}
		}

		internal virtual TextBox Map_TileID
		{
			get
			{
				return this._Map_TileID;
			}
			set
			{
				this._Map_TileID == null;
				this._Map_TileID = value;
				this._Map_TileID == null;
			}
		}

		internal virtual TextBox Map_TileID_Hex
		{
			get
			{
				return this._Map_TileID_Hex;
			}
			set
			{
				this._Map_TileID_Hex == null;
				this._Map_TileID_Hex = value;
				this._Map_TileID_Hex == null;
			}
		}

		internal virtual ListBox MapTileList
		{
			get
			{
				return this._MapTileList;
			}
			set
			{
				if (this._MapTileList != null)
				{
					TEdit tEdit = this;
					this._MapTileList.SelectedIndexChanged -= new EventHandler(tEdit.MapTileList_SelectedIndexChanged);
				}
				this._MapTileList = value;
				if (this._MapTileList != null)
				{
					TEdit tEdit1 = this;
					this._MapTileList.SelectedIndexChanged += new EventHandler(tEdit1.MapTileList_SelectedIndexChanged);
				}
			}
		}

		internal virtual ToolBar MapToolBar
		{
			get
			{
				return this._MapToolBar;
			}
			set
			{
				if (this._MapToolBar != null)
				{
					TEdit tEdit = this;
					this._MapToolBar.ButtonClick -= new ToolBarButtonClickEventHandler(tEdit.MapToolBar_ButtonClick);
				}
				this._MapToolBar = value;
				if (this._MapToolBar != null)
				{
					TEdit tEdit1 = this;
					this._MapToolBar.ButtonClick += new ToolBarButtonClickEventHandler(tEdit1.MapToolBar_ButtonClick);
				}
			}
		}

		internal virtual MenuItem Menu_CloneGroupA
		{
			get
			{
				return this._Menu_CloneGroupA;
			}
			set
			{
				if (this._Menu_CloneGroupA != null)
				{
					TEdit tEdit = this;
					this._Menu_CloneGroupA.Click -= new EventHandler(tEdit.Menu_CloneGroupA_Click);
				}
				this._Menu_CloneGroupA = value;
				if (this._Menu_CloneGroupA != null)
				{
					TEdit tEdit1 = this;
					this._Menu_CloneGroupA.Click += new EventHandler(tEdit1.Menu_CloneGroupA_Click);
				}
			}
		}

		internal virtual MenuItem Menu_CloneGroupB
		{
			get
			{
				return this._Menu_CloneGroupB;
			}
			set
			{
				if (this._Menu_CloneGroupB != null)
				{
					TEdit tEdit = this;
					this._Menu_CloneGroupB.Click -= new EventHandler(tEdit.Menu_CloneGroupB_Click);
				}
				this._Menu_CloneGroupB = value;
				if (this._Menu_CloneGroupB != null)
				{
					TEdit tEdit1 = this;
					this._Menu_CloneGroupB.Click += new EventHandler(tEdit1.Menu_CloneGroupB_Click);
				}
			}
		}

		internal virtual MenuItem Menu2Way
		{
			get
			{
				return this._Menu2Way;
			}
			set
			{
				if (this._Menu2Way != null)
				{
					TEdit tEdit = this;
					this._Menu2Way.Click -= new EventHandler(tEdit.Menu2Way_Click);
				}
				this._Menu2Way = value;
				if (this._Menu2Way != null)
				{
					TEdit tEdit1 = this;
					this._Menu2Way.Click += new EventHandler(tEdit1.Menu2Way_Click);
				}
			}
		}

		internal virtual MenuItem Menu3Way
		{
			get
			{
				return this._Menu3Way;
			}
			set
			{
				if (this._Menu3Way != null)
				{
					TEdit tEdit = this;
					this._Menu3Way.Click -= new EventHandler(tEdit.Menu3Way_Click);
				}
				this._Menu3Way = value;
				if (this._Menu3Way != null)
				{
					TEdit tEdit1 = this;
					this._Menu3Way.Click += new EventHandler(tEdit1.Menu3Way_Click);
				}
			}
		}

		internal virtual MenuItem MenuAddKey
		{
			get
			{
				return this._MenuAddKey;
			}
			set
			{
				if (this._MenuAddKey != null)
				{
					TEdit tEdit = this;
					this._MenuAddKey.Click -= new EventHandler(tEdit.MenuAddKey_Click);
				}
				this._MenuAddKey = value;
				if (this._MenuAddKey != null)
				{
					TEdit tEdit1 = this;
					this._MenuAddKey.Click += new EventHandler(tEdit1.MenuAddKey_Click);
				}
			}
		}

		internal virtual MenuItem MenuCopyKey
		{
			get
			{
				return this._MenuCopyKey;
			}
			set
			{
				if (this._MenuCopyKey != null)
				{
					TEdit tEdit = this;
					this._MenuCopyKey.Click -= new EventHandler(tEdit.MenuCopyKey_Click);
				}
				this._MenuCopyKey = value;
				if (this._MenuCopyKey != null)
				{
					TEdit tEdit1 = this;
					this._MenuCopyKey.Click += new EventHandler(tEdit1.MenuCopyKey_Click);
				}
			}
		}

		internal virtual MenuItem MenuDelKey
		{
			get
			{
				return this._MenuDelKey;
			}
			set
			{
				if (this._MenuDelKey != null)
				{
					TEdit tEdit = this;
					this._MenuDelKey.Click -= new EventHandler(tEdit.MenuDelKey_Click);
				}
				this._MenuDelKey = value;
				if (this._MenuDelKey != null)
				{
					TEdit tEdit1 = this;
					this._MenuDelKey.Click += new EventHandler(tEdit1.MenuDelKey_Click);
				}
			}
		}

		internal virtual MenuItem MenuFile
		{
			get
			{
				return this._MenuFile;
			}
			set
			{
				this._MenuFile == null;
				this._MenuFile = value;
				this._MenuFile == null;
			}
		}

		internal virtual MenuItem MenuItem1
		{
			get
			{
				return this._MenuItem1;
			}
			set
			{
				if (this._MenuItem1 != null)
				{
					TEdit tEdit = this;
					this._MenuItem1.Click -= new EventHandler(tEdit.MenuItem1_Click);
				}
				this._MenuItem1 = value;
				if (this._MenuItem1 != null)
				{
					TEdit tEdit1 = this;
					this._MenuItem1.Click += new EventHandler(tEdit1.MenuItem1_Click);
				}
			}
		}

		internal virtual MenuItem MenuItem10
		{
			get
			{
				return this._MenuItem10;
			}
			set
			{
				if (this._MenuItem10 != null)
				{
					TEdit tEdit = this;
					this._MenuItem10.Click -= new EventHandler(tEdit.MenuItem10_Click);
				}
				this._MenuItem10 = value;
				if (this._MenuItem10 != null)
				{
					TEdit tEdit1 = this;
					this._MenuItem10.Click += new EventHandler(tEdit1.MenuItem10_Click);
				}
			}
		}

		internal virtual MenuItem MenuItem11
		{
			get
			{
				return this._MenuItem11;
			}
			set
			{
				this._MenuItem11 == null;
				this._MenuItem11 = value;
				this._MenuItem11 == null;
			}
		}

		internal virtual MenuItem MenuItem12
		{
			get
			{
				return this._MenuItem12;
			}
			set
			{
				this._MenuItem12 == null;
				this._MenuItem12 = value;
				this._MenuItem12 == null;
			}
		}

		internal virtual MenuItem MenuItem2
		{
			get
			{
				return this._MenuItem2;
			}
			set
			{
				this._MenuItem2 == null;
				this._MenuItem2 = value;
				this._MenuItem2 == null;
			}
		}

		internal virtual MenuItem MenuItem3
		{
			get
			{
				return this._MenuItem3;
			}
			set
			{
				if (this._MenuItem3 != null)
				{
					TEdit tEdit = this;
					this._MenuItem3.Click -= new EventHandler(tEdit.MenuItem3_Click);
				}
				this._MenuItem3 = value;
				if (this._MenuItem3 != null)
				{
					TEdit tEdit1 = this;
					this._MenuItem3.Click += new EventHandler(tEdit1.MenuItem3_Click);
				}
			}
		}

		internal virtual MenuItem MenuItem4
		{
			get
			{
				return this._MenuItem4;
			}
			set
			{
				this._MenuItem4 == null;
				this._MenuItem4 = value;
				this._MenuItem4 == null;
			}
		}

		internal virtual MenuItem MenuItem5
		{
			get
			{
				return this._MenuItem5;
			}
			set
			{
				this._MenuItem5 == null;
				this._MenuItem5 = value;
				this._MenuItem5 == null;
			}
		}

		internal virtual MenuItem MenuItem6
		{
			get
			{
				return this._MenuItem6;
			}
			set
			{
				this._MenuItem6 == null;
				this._MenuItem6 = value;
				this._MenuItem6 == null;
			}
		}

		internal virtual MenuItem MenuItem9
		{
			get
			{
				return this._MenuItem9;
			}
			set
			{
				this._MenuItem9 == null;
				this._MenuItem9 = value;
				this._MenuItem9 == null;
			}
		}

		internal virtual MenuItem MenuLoad
		{
			get
			{
				return this._MenuLoad;
			}
			set
			{
				if (this._MenuLoad != null)
				{
					TEdit tEdit = this;
					this._MenuLoad.Click -= new EventHandler(tEdit.MenuLoad_Click);
				}
				this._MenuLoad = value;
				if (this._MenuLoad != null)
				{
					TEdit tEdit1 = this;
					this._MenuLoad.Click += new EventHandler(tEdit1.MenuLoad_Click);
				}
			}
		}

		internal virtual MenuItem MenuMakeTable
		{
			get
			{
				return this._MenuMakeTable;
			}
			set
			{
				this._MenuMakeTable == null;
				this._MenuMakeTable = value;
				this._MenuMakeTable == null;
			}
		}

		internal virtual MenuItem MenuNew
		{
			get
			{
				return this._MenuNew;
			}
			set
			{
				if (this._MenuNew != null)
				{
					TEdit tEdit = this;
					this._MenuNew.Click -= new EventHandler(tEdit.MenuNew_Click);
				}
				this._MenuNew = value;
				if (this._MenuNew != null)
				{
					TEdit tEdit1 = this;
					this._MenuNew.Click += new EventHandler(tEdit1.MenuNew_Click);
				}
			}
		}

		internal virtual MenuItem MenuSave
		{
			get
			{
				return this._MenuSave;
			}
			set
			{
				if (this._MenuSave != null)
				{
					TEdit tEdit = this;
					this._MenuSave.Click -= new EventHandler(tEdit.MenuSave_Click);
				}
				this._MenuSave = value;
				if (this._MenuSave != null)
				{
					TEdit tEdit1 = this;
					this._MenuSave.Click += new EventHandler(tEdit1.MenuSave_Click);
				}
			}
		}

		internal virtual MenuItem MenuTerrainA
		{
			get
			{
				return this._MenuTerrainA;
			}
			set
			{
				if (this._MenuTerrainA != null)
				{
					TEdit tEdit = this;
					this._MenuTerrainA.Click -= new EventHandler(tEdit.MenuTerrainA_Click);
				}
				this._MenuTerrainA = value;
				if (this._MenuTerrainA != null)
				{
					TEdit tEdit1 = this;
					this._MenuTerrainA.Click += new EventHandler(tEdit1.MenuTerrainA_Click);
				}
			}
		}

		internal virtual MenuItem MenuTerrainB
		{
			get
			{
				return this._MenuTerrainB;
			}
			set
			{
				if (this._MenuTerrainB != null)
				{
					TEdit tEdit = this;
					this._MenuTerrainB.Click -= new EventHandler(tEdit.MenuSelectB_Click);
				}
				this._MenuTerrainB = value;
				if (this._MenuTerrainB != null)
				{
					TEdit tEdit1 = this;
					this._MenuTerrainB.Click += new EventHandler(tEdit1.MenuSelectB_Click);
				}
			}
		}

		internal virtual MenuItem MenuTerrainC
		{
			get
			{
				return this._MenuTerrainC;
			}
			set
			{
				if (this._MenuTerrainC != null)
				{
					TEdit tEdit = this;
					this._MenuTerrainC.Click -= new EventHandler(tEdit.MenuTerrainC_Click);
				}
				this._MenuTerrainC = value;
				if (this._MenuTerrainC != null)
				{
					TEdit tEdit1 = this;
					this._MenuTerrainC.Click += new EventHandler(tEdit1.MenuTerrainC_Click);
				}
			}
		}

		internal virtual PictureBox PictureBox1
		{
			get
			{
				return this._PictureBox1;
			}
			set
			{
				if (this._PictureBox1 != null)
				{
					TEdit tEdit = this;
					this._PictureBox1.Paint -= new PaintEventHandler(tEdit.PictureBox1_Paint);
				}
				this._PictureBox1 = value;
				if (this._PictureBox1 != null)
				{
					TEdit tEdit1 = this;
					this._PictureBox1.Paint += new PaintEventHandler(tEdit1.PictureBox1_Paint);
				}
			}
		}

		internal virtual PictureBox PictureBox3
		{
			get
			{
				return this._PictureBox3;
			}
			set
			{
				this._PictureBox3 == null;
				this._PictureBox3 = value;
				this._PictureBox3 == null;
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

		internal virtual NumericUpDown Static_AltIDMod
		{
			get
			{
				return this._Static_AltIDMod;
			}
			set
			{
				this._Static_AltIDMod == null;
				this._Static_AltIDMod = value;
				this._Static_AltIDMod == null;
			}
		}

		internal virtual TextBox Static_TileID
		{
			get
			{
				return this._Static_TileID;
			}
			set
			{
				this._Static_TileID == null;
				this._Static_TileID = value;
				this._Static_TileID == null;
			}
		}

		internal virtual TextBox Static_TileID_Hex
		{
			get
			{
				return this._Static_TileID_Hex;
			}
			set
			{
				this._Static_TileID_Hex == null;
				this._Static_TileID_Hex = value;
				this._Static_TileID_Hex == null;
			}
		}

		internal virtual PictureBox StaticImage
		{
			get
			{
				return this._StaticImage;
			}
			set
			{
				this._StaticImage == null;
				this._StaticImage = value;
				this._StaticImage == null;
			}
		}

		internal virtual VScrollBar StaticItems
		{
			get
			{
				return this._StaticItems;
			}
			set
			{
				if (this._StaticItems != null)
				{
					TEdit tEdit = this;
					this._StaticItems.ValueChanged -= new EventHandler(tEdit.StaticItems_ValueChanged);
					TEdit tEdit1 = this;
					this._StaticItems.Scroll -= new ScrollEventHandler(tEdit1.StaticItems_Scroll);
				}
				this._StaticItems = value;
				if (this._StaticItems != null)
				{
					TEdit tEdit2 = this;
					this._StaticItems.ValueChanged += new EventHandler(tEdit2.StaticItems_ValueChanged);
					TEdit tEdit3 = this;
					this._StaticItems.Scroll += new ScrollEventHandler(tEdit3.StaticItems_Scroll);
				}
			}
		}

		internal virtual ListBox StaticTileList
		{
			get
			{
				return this._StaticTileList;
			}
			set
			{
				if (this._StaticTileList != null)
				{
					TEdit tEdit = this;
					this._StaticTileList.SelectedIndexChanged -= new EventHandler(tEdit.StaticTileList_SelectedIndexChanged);
				}
				this._StaticTileList = value;
				if (this._StaticTileList != null)
				{
					TEdit tEdit1 = this;
					this._StaticTileList.SelectedIndexChanged += new EventHandler(tEdit1.StaticTileList_SelectedIndexChanged);
				}
			}
		}

		internal virtual ToolBar StaticToolBar
		{
			get
			{
				return this._StaticToolBar;
			}
			set
			{
				if (this._StaticToolBar != null)
				{
					TEdit tEdit = this;
					this._StaticToolBar.ButtonClick -= new ToolBarButtonClickEventHandler(tEdit.StaticToolBar_ButtonClick);
				}
				this._StaticToolBar = value;
				if (this._StaticToolBar != null)
				{
					TEdit tEdit1 = this;
					this._StaticToolBar.ButtonClick += new ToolBarButtonClickEventHandler(tEdit1.StaticToolBar_ButtonClick);
				}
			}
		}

		internal virtual TabControl TabControl1
		{
			get
			{
				return this._TabControl1;
			}
			set
			{
				this._TabControl1 == null;
				this._TabControl1 = value;
				this._TabControl1 == null;
			}
		}

		internal virtual TabPage TabDraw
		{
			get
			{
				return this._TabDraw;
			}
			set
			{
				this._TabDraw == null;
				this._TabDraw = value;
				this._TabDraw == null;
			}
		}

		internal virtual TabPage TabMap
		{
			get
			{
				return this._TabMap;
			}
			set
			{
				this._TabMap == null;
				this._TabMap = value;
				this._TabMap == null;
			}
		}

		internal virtual TabPage TabStatic
		{
			get
			{
				return this._TabStatic;
			}
			set
			{
				this._TabStatic == null;
				this._TabStatic = value;
				this._TabStatic == null;
			}
		}

		internal virtual ToolBar ToolBar1
		{
			get
			{
				return this._ToolBar1;
			}
			set
			{
				if (this._ToolBar1 != null)
				{
					TEdit tEdit = this;
					this._ToolBar1.ButtonClick -= new ToolBarButtonClickEventHandler(tEdit.ToolBar1_ButtonClick);
				}
				this._ToolBar1 = value;
				if (this._ToolBar1 != null)
				{
					TEdit tEdit1 = this;
					this._ToolBar1.ButtonClick += new ToolBarButtonClickEventHandler(tEdit1.ToolBar1_ButtonClick);
				}
			}
		}

		internal virtual ToolBarButton ToolBarButton1
		{
			get
			{
				return this._ToolBarButton1;
			}
			set
			{
				this._ToolBarButton1 == null;
				this._ToolBarButton1 = value;
				this._ToolBarButton1 == null;
			}
		}

		internal virtual ToolBarButton ToolBarButton10
		{
			get
			{
				return this._ToolBarButton10;
			}
			set
			{
				this._ToolBarButton10 == null;
				this._ToolBarButton10 = value;
				this._ToolBarButton10 == null;
			}
		}

		internal virtual ToolBarButton ToolBarButton11
		{
			get
			{
				return this._ToolBarButton11;
			}
			set
			{
				this._ToolBarButton11 == null;
				this._ToolBarButton11 = value;
				this._ToolBarButton11 == null;
			}
		}

		internal virtual ToolBarButton ToolBarButton12
		{
			get
			{
				return this._ToolBarButton12;
			}
			set
			{
				this._ToolBarButton12 == null;
				this._ToolBarButton12 = value;
				this._ToolBarButton12 == null;
			}
		}

		internal virtual ToolBarButton ToolBarButton13
		{
			get
			{
				return this._ToolBarButton13;
			}
			set
			{
				this._ToolBarButton13 == null;
				this._ToolBarButton13 = value;
				this._ToolBarButton13 == null;
			}
		}

		internal virtual ToolBarButton ToolBarButton14
		{
			get
			{
				return this._ToolBarButton14;
			}
			set
			{
				this._ToolBarButton14 == null;
				this._ToolBarButton14 = value;
				this._ToolBarButton14 == null;
			}
		}

		internal virtual ToolBarButton ToolBarButton15
		{
			get
			{
				return this._ToolBarButton15;
			}
			set
			{
				this._ToolBarButton15 == null;
				this._ToolBarButton15 = value;
				this._ToolBarButton15 == null;
			}
		}

		internal virtual ToolBarButton ToolBarButton16
		{
			get
			{
				return this._ToolBarButton16;
			}
			set
			{
				this._ToolBarButton16 == null;
				this._ToolBarButton16 = value;
				this._ToolBarButton16 == null;
			}
		}

		internal virtual ToolBarButton ToolBarButton2
		{
			get
			{
				return this._ToolBarButton2;
			}
			set
			{
				this._ToolBarButton2 == null;
				this._ToolBarButton2 = value;
				this._ToolBarButton2 == null;
			}
		}

		internal virtual ToolBarButton ToolBarButton3
		{
			get
			{
				return this._ToolBarButton3;
			}
			set
			{
				this._ToolBarButton3 == null;
				this._ToolBarButton3 = value;
				this._ToolBarButton3 == null;
			}
		}

		internal virtual ToolBarButton ToolBarButton4
		{
			get
			{
				return this._ToolBarButton4;
			}
			set
			{
				this._ToolBarButton4 == null;
				this._ToolBarButton4 = value;
				this._ToolBarButton4 == null;
			}
		}

		internal virtual ToolBarButton ToolBarButton5
		{
			get
			{
				return this._ToolBarButton5;
			}
			set
			{
				this._ToolBarButton5 == null;
				this._ToolBarButton5 = value;
				this._ToolBarButton5 == null;
			}
		}

		internal virtual ToolBarButton ToolBarButton6
		{
			get
			{
				return this._ToolBarButton6;
			}
			set
			{
				this._ToolBarButton6 == null;
				this._ToolBarButton6 = value;
				this._ToolBarButton6 == null;
			}
		}

		internal virtual ToolBarButton ToolBarButton7
		{
			get
			{
				return this._ToolBarButton7;
			}
			set
			{
				this._ToolBarButton7 == null;
				this._ToolBarButton7 = value;
				this._ToolBarButton7 == null;
			}
		}

		internal virtual ToolBarButton ToolBarButton8
		{
			get
			{
				return this._ToolBarButton8;
			}
			set
			{
				this._ToolBarButton8 == null;
				this._ToolBarButton8 = value;
				this._ToolBarButton8 == null;
			}
		}

		internal virtual ToolBarButton ToolBarButton9
		{
			get
			{
				return this._ToolBarButton9;
			}
			set
			{
				this._ToolBarButton9 == null;
				this._ToolBarButton9 = value;
				this._ToolBarButton9 == null;
			}
		}

		public TEdit()
		{
			TEdit tEdit = this;
			base.Load += new EventHandler(tEdit.TEdit_Load);
			this.ImageTest = false;
			this.iGroups = new ClsTerrainTable();
			this.iSelected = false;
			this.iTransition = new Transition();
			this.iTransitionTable = new TransitionTable();
			this.InitializeComponent();
		}

		private void Box_Description_Leave(object sender, EventArgs e)
		{
			this.iTransition.Description = this.Box_Description.Text;
			this.iTransitionTable.Display(this.ListBox1);
		}

		private void BoxFileName_TextChanged(object sender, EventArgs e)
		{
			this.iTransition.File = this.BoxFileName.Text;
			this.iTransitionTable.Display(this.ListBox1);
		}

		private void Btn_Land_Click(object sender, EventArgs e)
		{
			try
			{
				int num = IntegerType.FromString(this.Map_TileID.Text);
				this.LandItems.Value = num;
				if (Art.GetLand(num) != null)
				{
					this.LandImage.Image = Art.GetLand(num);
				}
				else
				{
					this.LandImage.Image = null;
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Interaction.MsgBox(this.ErrorMessage(this.Map_TileID.Text, "1", "16535"), MsgBoxStyle.OKOnly, null);
				ProjectData.ClearProjectError();
			}
		}

		private void Btn_Land_Hex_Click(object sender, EventArgs e)
		{
			try
			{
				int num = IntegerType.FromString(this.Map_TileID_Hex.Text);
				this.LandItems.Value = num;
				this.Map_TileID.Text = num.ToString();
				if (Art.GetLand(num) != null)
				{
					this.LandImage.Image = Art.GetLand(num);
				}
				else
				{
					this.LandImage.Image = null;
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Interaction.MsgBox(this.ErrorMessage(this.Map_TileID_Hex.Text, "&H0000", "&H3FFF"), MsgBoxStyle.OKOnly, null);
				ProjectData.ClearProjectError();
			}
		}

		private void Btn_StaticFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog()
			{
				InitialDirectory = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "Data\\Statics"),
				Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*",
				FilterIndex = 2,
				RestoreDirectory = true
			};
			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
				this.BoxFileName.Text = fileInfo.Name;
			}
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

		private string ErrorMessage(string iValue, string iMin, string iMax)
		{
			return string.Format("{0} is outside the range\r\nPlease enter a value between {1} and {2}", iValue, iMin, iMax);
		}

		private void GroupSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.iSelectedGroup = (ClsTerrain)this.GroupSelect.SelectedItem;
			this.PictureBox3.Image = Art.GetLand(this.iSelectedGroup.TileID);
			this.Box_TileID.Text = StringType.FromInteger(this.iSelectedGroup.TileID);
			this.Box_TileID_Hex.Text = string.Format("{0:X4}", this.iSelectedGroup.TileID);
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ResourceManager resourceManager = new ResourceManager(typeof(TEdit));
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
			((ISupportInitialize)this.Map_AltIDMod).BeginInit();
			this.TabStatic.SuspendLayout();
			((ISupportInitialize)this.Static_AltIDMod).BeginInit();
			this.SuspendLayout();
			this.ListBox1.BorderStyle = BorderStyle.FixedSingle;
			ListBox listBox1 = this.ListBox1;
			Point point = new Point(8, 8);
			listBox1.Location = point;
			this.ListBox1.Name = "ListBox1";
			ListBox listBox = this.ListBox1;
			System.Drawing.Size size = new System.Drawing.Size(336, 535);
			listBox.Size = size;
			this.ListBox1.Sorted = true;
			this.ListBox1.TabIndex = 1;
			System.Windows.Forms.Menu.MenuItemCollection menuItems = this.MainMenu1.MenuItems;
			MenuItem[] menuFile = new MenuItem[] { this.MenuFile, this.MenuItem5, this.MenuItem9 };
			menuItems.AddRange(menuFile);
			this.MenuFile.Index = 0;
			System.Windows.Forms.Menu.MenuItemCollection menuItemCollections = this.MenuFile.MenuItems;
			menuFile = new MenuItem[] { this.MenuNew, this.MenuSave, this.MenuLoad, this.MenuItem4, this.MenuItem6 };
			menuItemCollections.AddRange(menuFile);
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
			System.Windows.Forms.Menu.MenuItemCollection menuItems1 = this.MenuItem6.MenuItems;
			menuFile = new MenuItem[] { this.Menu_CloneGroupA, this.Menu_CloneGroupB, this.MenuItem11, this.MenuItem10 };
			menuItems1.AddRange(menuFile);
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
			System.Windows.Forms.Menu.MenuItemCollection menuItemCollections1 = this.MenuItem5.MenuItems;
			menuFile = new MenuItem[] { this.MenuItem1, this.MenuAddKey, this.MenuDelKey, this.MenuCopyKey };
			menuItemCollections1.AddRange(menuFile);
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
			System.Windows.Forms.Menu.MenuItemCollection menuItems2 = this.MenuItem9.MenuItems;
			menuFile = new MenuItem[] { this.MenuTerrainA, this.MenuTerrainB, this.MenuTerrainC, this.MenuItem12, this.MenuMakeTable, this.MenuItem2, this.MenuItem3 };
			menuItems2.AddRange(menuFile);
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
			System.Windows.Forms.Menu.MenuItemCollection menuItemCollections2 = this.MenuMakeTable.MenuItems;
			menuFile = new MenuItem[] { this.Menu2Way, this.Menu3Way };
			menuItemCollections2.AddRange(menuFile);
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
			TextBox boxDescription = this.Box_Description;
			point = new Point(392, 32);
			boxDescription.Location = point;
			this.Box_Description.Name = "Box_Description";
			TextBox textBox = this.Box_Description;
			size = new System.Drawing.Size(144, 20);
			textBox.Size = size;
			this.Box_Description.TabIndex = 2;
			this.Box_Description.Text = "";
			this.Lbl_HashKey.BorderStyle = BorderStyle.FixedSingle;
			TextBox lblHashKey = this.Lbl_HashKey;
			point = new Point(392, 56);
			lblHashKey.Location = point;
			this.Lbl_HashKey.Name = "Lbl_HashKey";
			TextBox lblHashKey1 = this.Lbl_HashKey;
			size = new System.Drawing.Size(144, 20);
			lblHashKey1.Size = size;
			this.Lbl_HashKey.TabIndex = 3;
			this.Lbl_HashKey.Text = "";
			this.PictureBox1.BorderStyle = BorderStyle.FixedSingle;
			PictureBox pictureBox1 = this.PictureBox1;
			point = new Point(360, 88);
			pictureBox1.Location = point;
			this.PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = this.PictureBox1;
			size = new System.Drawing.Size(168, 168);
			pictureBox.Size = size;
			this.PictureBox1.TabIndex = 4;
			this.PictureBox1.TabStop = false;
			this.TabControl1.Controls.Add(this.TabDraw);
			this.TabControl1.Controls.Add(this.TabMap);
			this.TabControl1.Controls.Add(this.TabStatic);
			TabControl tabControl1 = this.TabControl1;
			point = new Point(352, 264);
			tabControl1.Location = point;
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			TabControl tabControl = this.TabControl1;
			size = new System.Drawing.Size(184, 288);
			tabControl.Size = size;
			this.TabControl1.TabIndex = 51;
			this.TabDraw.Controls.Add(this.PictureBox3);
			this.TabDraw.Controls.Add(this.Box_TileID_Hex);
			this.TabDraw.Controls.Add(this.Box_TileID);
			this.TabDraw.Controls.Add(this.Label7);
			this.TabDraw.Controls.Add(this.GroupSelect);
			this.TabDraw.Controls.Add(this.ToolBar1);
			TabPage tabDraw = this.TabDraw;
			point = new Point(4, 22);
			tabDraw.Location = point;
			this.TabDraw.Name = "TabDraw";
			TabPage tabPage = this.TabDraw;
			size = new System.Drawing.Size(176, 262);
			tabPage.Size = size;
			this.TabDraw.TabIndex = 2;
			this.TabDraw.Text = "Draw";
			this.PictureBox3.BorderStyle = BorderStyle.FixedSingle;
			PictureBox pictureBox3 = this.PictureBox3;
			point = new Point(8, 184);
			pictureBox3.Location = point;
			this.PictureBox3.Name = "PictureBox3";
			PictureBox pictureBox31 = this.PictureBox3;
			size = new System.Drawing.Size(48, 50);
			pictureBox31.Size = size;
			this.PictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
			this.PictureBox3.TabIndex = 60;
			this.PictureBox3.TabStop = false;
			this.Box_TileID_Hex.BorderStyle = BorderStyle.FixedSingle;
			TextBox boxTileIDHex = this.Box_TileID_Hex;
			point = new Point(64, 224);
			boxTileIDHex.Location = point;
			this.Box_TileID_Hex.Name = "Box_TileID_Hex";
			TextBox boxTileIDHex1 = this.Box_TileID_Hex;
			size = new System.Drawing.Size(48, 20);
			boxTileIDHex1.Size = size;
			this.Box_TileID_Hex.TabIndex = 59;
			this.Box_TileID_Hex.Text = "";
			this.Box_TileID_Hex.TextAlign = HorizontalAlignment.Right;
			this.Box_TileID.BorderStyle = BorderStyle.FixedSingle;
			TextBox boxTileID = this.Box_TileID;
			point = new Point(64, 200);
			boxTileID.Location = point;
			this.Box_TileID.Name = "Box_TileID";
			TextBox boxTileID1 = this.Box_TileID;
			size = new System.Drawing.Size(48, 20);
			boxTileID1.Size = size;
			this.Box_TileID.TabIndex = 49;
			this.Box_TileID.Text = "";
			this.Box_TileID.TextAlign = HorizontalAlignment.Right;
			this.Label7.AutoSize = true;
			Label label7 = this.Label7;
			point = new Point(64, 184);
			label7.Location = point;
			this.Label7.Name = "Label7";
			Label label = this.Label7;
			size = new System.Drawing.Size(37, 16);
			label.Size = size;
			this.Label7.TabIndex = 48;
			this.Label7.Text = "Tile ID";
			ComboBox groupSelect = this.GroupSelect;
			point = new Point(8, 152);
			groupSelect.Location = point;
			this.GroupSelect.Name = "GroupSelect";
			ComboBox comboBox = this.GroupSelect;
			size = new System.Drawing.Size(160, 21);
			comboBox.Size = size;
			this.GroupSelect.Sorted = true;
			this.GroupSelect.TabIndex = 47;
			ToolBar.ToolBarButtonCollection buttons = this.ToolBar1.Buttons;
			ToolBarButton[] toolBarButton1 = new ToolBarButton[] { this.ToolBarButton1, this.ToolBarButton2, this.ToolBarButton3, this.ToolBarButton4, this.ToolBarButton5, this.ToolBarButton6, this.ToolBarButton7, this.ToolBarButton8, this.ToolBarButton9 };
			buttons.AddRange(toolBarButton1);
			ToolBar toolBar1 = this.ToolBar1;
			size = new System.Drawing.Size(45, 45);
			toolBar1.ButtonSize = size;
			this.ToolBar1.Divider = false;
			this.ToolBar1.Dock = DockStyle.None;
			this.ToolBar1.DropDownArrows = true;
			this.ToolBar1.Font = new System.Drawing.Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			ToolBar toolBar = this.ToolBar1;
			point = new Point(8, 8);
			toolBar.Location = point;
			this.ToolBar1.Name = "ToolBar1";
			this.ToolBar1.ShowToolTips = true;
			ToolBar toolBar11 = this.ToolBar1;
			size = new System.Drawing.Size(144, 139);
			toolBar11.Size = size;
			this.ToolBar1.TabIndex = 53;
			this.ToolBarButton1.ImageIndex = 0;
			this.ToolBarButton1.Tag = "0";
			this.ToolBarButton1.Text = "1";
			this.ToolBarButton2.ImageIndex = 1;
			this.ToolBarButton2.Tag = "1";
			this.ToolBarButton2.Text = "2";
			this.ToolBarButton3.Tag = "2";
			this.ToolBarButton3.Text = "3";
			this.ToolBarButton4.Tag = "3";
			this.ToolBarButton4.Text = "4";
			this.ToolBarButton5.Tag = "4";
			this.ToolBarButton5.Text = "5";
			this.ToolBarButton6.Tag = "5";
			this.ToolBarButton6.Text = "6";
			this.ToolBarButton7.Tag = "6";
			this.ToolBarButton7.Text = "7";
			this.ToolBarButton8.Tag = "7";
			this.ToolBarButton8.Text = "8";
			this.ToolBarButton9.Tag = "8";
			this.ToolBarButton9.Text = "9";
			this.TabMap.Controls.Add(this.MapToolBar);
			this.TabMap.Controls.Add(this.MapTileList);
			this.TabMap.Controls.Add(this.LandItems);
			this.TabMap.Controls.Add(this.LandImage);
			this.TabMap.Controls.Add(this.Btn_Land);
			this.TabMap.Controls.Add(this.Label5);
			this.TabMap.Controls.Add(this.Btn_Land_Hex);
			this.TabMap.Controls.Add(this.Map_TileID_Hex);
			this.TabMap.Controls.Add(this.Label6);
			this.TabMap.Controls.Add(this.Map_TileID);
			this.TabMap.Controls.Add(this.Map_AltIDMod);
			TabPage tabMap = this.TabMap;
			point = new Point(4, 22);
			tabMap.Location = point;
			this.TabMap.Name = "TabMap";
			TabPage tabMap1 = this.TabMap;
			size = new System.Drawing.Size(176, 262);
			tabMap1.Size = size;
			this.TabMap.TabIndex = 0;
			this.TabMap.Text = "Map";
			this.TabMap.Visible = false;
			ToolBar.ToolBarButtonCollection toolBarButtonCollections = this.MapToolBar.Buttons;
			toolBarButton1 = new ToolBarButton[] { this.ToolBarButton10, this.ToolBarButton11, this.ToolBarButton12, this.ToolBarButton13 };
			toolBarButtonCollections.AddRange(toolBarButton1);
			ToolBar mapToolBar = this.MapToolBar;
			size = new System.Drawing.Size(32, 32);
			mapToolBar.ButtonSize = size;
			this.MapToolBar.Divider = false;
			this.MapToolBar.Dock = DockStyle.Bottom;
			this.MapToolBar.DropDownArrows = true;
			this.MapToolBar.ImageList = this.ImageList1;
			ToolBar mapToolBar1 = this.MapToolBar;
			point = new Point(0, 226);
			mapToolBar1.Location = point;
			this.MapToolBar.Name = "MapToolBar";
			this.MapToolBar.ShowToolTips = true;
			ToolBar mapToolBar2 = this.MapToolBar;
			size = new System.Drawing.Size(160, 36);
			mapToolBar2.Size = size;
			this.MapToolBar.TabIndex = 25;
			this.ToolBarButton10.ImageIndex = 0;
			this.ToolBarButton10.Tag = "Add";
			this.ToolBarButton10.ToolTipText = "Add Map ID to List.";
			this.ToolBarButton11.ImageIndex = 4;
			this.ToolBarButton11.Tag = "Delete";
			this.ToolBarButton11.ToolTipText = "Delete Map ID from List.";
			this.ToolBarButton12.ImageIndex = 2;
			this.ToolBarButton12.Style = ToolBarButtonStyle.ToggleButton;
			this.ToolBarButton12.Tag = "Test";
			this.ToolBarButton12.ToolTipText = "Test the Map ID image.";
			this.ToolBarButton13.ImageIndex = 5;
			this.ToolBarButton13.Tag = "Select";
			this.ToolBarButton13.ToolTipText = "Select from Selection Screen.";
			ImageList imageList1 = this.ImageList1;
			size = new System.Drawing.Size(16, 16);
			imageList1.ImageSize = size;
			this.ImageList1.ImageStream = (ImageListStreamer)resourceManager.GetObject("ImageList1.ImageStream");
			this.ImageList1.TransparentColor = Color.Transparent;
			this.MapTileList.BorderStyle = BorderStyle.FixedSingle;
			ListBox mapTileList = this.MapTileList;
			point = new Point(88, 8);
			mapTileList.Location = point;
			this.MapTileList.Name = "MapTileList";
			ListBox mapTileList1 = this.MapTileList;
			size = new System.Drawing.Size(64, 132);
			mapTileList1.Size = size;
			this.MapTileList.TabIndex = 10;
			this.LandItems.Dock = DockStyle.Right;
			this.LandItems.LargeChange = 32;
			VScrollBar landItems = this.LandItems;
			point = new Point(160, 0);
			landItems.Location = point;
			this.LandItems.Maximum = 16535;
			this.LandItems.Name = "LandItems";
			VScrollBar vScrollBar = this.LandItems;
			size = new System.Drawing.Size(16, 262);
			vScrollBar.Size = size;
			this.LandItems.TabIndex = 19;
			this.LandImage.BorderStyle = BorderStyle.FixedSingle;
			PictureBox landImage = this.LandImage;
			point = new Point(8, 8);
			landImage.Location = point;
			this.LandImage.Name = "LandImage";
			PictureBox landImage1 = this.LandImage;
			size = new System.Drawing.Size(56, 56);
			landImage1.Size = size;
			this.LandImage.SizeMode = PictureBoxSizeMode.CenterImage;
			this.LandImage.TabIndex = 20;
			this.LandImage.TabStop = false;
			Button btnLand = this.Btn_Land;
			point = new Point(64, 160);
			btnLand.Location = point;
			this.Btn_Land.Name = "Btn_Land";
			Button button = this.Btn_Land;
			size = new System.Drawing.Size(32, 20);
			button.Size = size;
			this.Btn_Land.TabIndex = 16;
			this.Btn_Land.Text = "Go";
			this.Label5.AutoSize = true;
			Label label5 = this.Label5;
			point = new Point(104, 144);
			label5.Location = point;
			this.Label5.Name = "Label5";
			Label label51 = this.Label5;
			size = new System.Drawing.Size(43, 16);
			label51.Size = size;
			this.Label5.TabIndex = 15;
			this.Label5.Text = "Alt Mod";
			Button btnLandHex = this.Btn_Land_Hex;
			point = new Point(64, 184);
			btnLandHex.Location = point;
			this.Btn_Land_Hex.Name = "Btn_Land_Hex";
			Button btnLandHex1 = this.Btn_Land_Hex;
			size = new System.Drawing.Size(32, 20);
			btnLandHex1.Size = size;
			this.Btn_Land_Hex.TabIndex = 22;
			this.Btn_Land_Hex.Text = "Go";
			this.Map_TileID_Hex.BorderStyle = BorderStyle.FixedSingle;
			TextBox mapTileIDHex = this.Map_TileID_Hex;
			point = new Point(8, 184);
			mapTileIDHex.Location = point;
			this.Map_TileID_Hex.Name = "Map_TileID_Hex";
			TextBox mapTileIDHex1 = this.Map_TileID_Hex;
			size = new System.Drawing.Size(48, 20);
			mapTileIDHex1.Size = size;
			this.Map_TileID_Hex.TabIndex = 21;
			this.Map_TileID_Hex.Text = "";
			this.Map_TileID_Hex.TextAlign = HorizontalAlignment.Right;
			this.Label6.AutoSize = true;
			Label label6 = this.Label6;
			point = new Point(8, 144);
			label6.Location = point;
			this.Label6.Name = "Label6";
			Label label61 = this.Label6;
			size = new System.Drawing.Size(37, 16);
			label61.Size = size;
			this.Label6.TabIndex = 12;
			this.Label6.Text = "Tile ID";
			this.Map_TileID.BorderStyle = BorderStyle.FixedSingle;
			TextBox mapTileID = this.Map_TileID;
			point = new Point(8, 160);
			mapTileID.Location = point;
			this.Map_TileID.Name = "Map_TileID";
			TextBox mapTileID1 = this.Map_TileID;
			size = new System.Drawing.Size(48, 20);
			mapTileID1.Size = size;
			this.Map_TileID.TabIndex = 13;
			this.Map_TileID.Text = "";
			this.Map_TileID.TextAlign = HorizontalAlignment.Right;
			this.Map_AltIDMod.BorderStyle = BorderStyle.FixedSingle;
			NumericUpDown mapAltIDMod = this.Map_AltIDMod;
			point = new Point(104, 160);
			mapAltIDMod.Location = point;
			NumericUpDown numericUpDown = this.Map_AltIDMod;
			int[] numArray = new int[] { 127, 0, 0, 0 };
			decimal num = new decimal(numArray);
			numericUpDown.Maximum = num;
			NumericUpDown mapAltIDMod1 = this.Map_AltIDMod;
			numArray = new int[] { 127, 0, 0, -2147483648 };
			num = new decimal(numArray);
			mapAltIDMod1.Minimum = num;
			this.Map_AltIDMod.Name = "Map_AltIDMod";
			NumericUpDown numericUpDown1 = this.Map_AltIDMod;
			size = new System.Drawing.Size(48, 20);
			numericUpDown1.Size = size;
			this.Map_AltIDMod.TabIndex = 14;
			this.TabStatic.Controls.Add(this.StaticToolBar);
			this.TabStatic.Controls.Add(this.StaticImage);
			this.TabStatic.Controls.Add(this.StaticTileList);
			this.TabStatic.Controls.Add(this.Btn_Static_Hex);
			this.TabStatic.Controls.Add(this.Static_TileID_Hex);
			this.TabStatic.Controls.Add(this.Label1);
			this.TabStatic.Controls.Add(this.Static_TileID);
			this.TabStatic.Controls.Add(this.Btn_Static);
			this.TabStatic.Controls.Add(this.Label2);
			this.TabStatic.Controls.Add(this.Static_AltIDMod);
			this.TabStatic.Controls.Add(this.StaticItems);
			TabPage tabStatic = this.TabStatic;
			point = new Point(4, 22);
			tabStatic.Location = point;
			this.TabStatic.Name = "TabStatic";
			TabPage tabStatic1 = this.TabStatic;
			size = new System.Drawing.Size(176, 262);
			tabStatic1.Size = size;
			this.TabStatic.TabIndex = 1;
			this.TabStatic.Text = "Static";
			this.TabStatic.Visible = false;
			ToolBar.ToolBarButtonCollection buttons1 = this.StaticToolBar.Buttons;
			toolBarButton1 = new ToolBarButton[] { this.ToolBarButton14, this.ToolBarButton15, this.ToolBarButton16 };
			buttons1.AddRange(toolBarButton1);
			ToolBar staticToolBar = this.StaticToolBar;
			size = new System.Drawing.Size(32, 32);
			staticToolBar.ButtonSize = size;
			this.StaticToolBar.Divider = false;
			this.StaticToolBar.Dock = DockStyle.Bottom;
			this.StaticToolBar.DropDownArrows = true;
			this.StaticToolBar.ImageList = this.ImageList1;
			ToolBar staticToolBar1 = this.StaticToolBar;
			point = new Point(0, 226);
			staticToolBar1.Location = point;
			this.StaticToolBar.Name = "StaticToolBar";
			this.StaticToolBar.ShowToolTips = true;
			ToolBar staticToolBar2 = this.StaticToolBar;
			size = new System.Drawing.Size(160, 36);
			staticToolBar2.Size = size;
			this.StaticToolBar.TabIndex = 33;
			this.ToolBarButton14.ImageIndex = 0;
			this.ToolBarButton14.Tag = "Add";
			this.ToolBarButton14.ToolTipText = "Add Static ID to List";
			this.ToolBarButton15.ImageIndex = 4;
			this.ToolBarButton15.Tag = "Delete";
			this.ToolBarButton15.ToolTipText = "Delete Static ID from the List.";
			this.ToolBarButton16.ImageIndex = 5;
			this.ToolBarButton16.Tag = "Select";
			this.ToolBarButton16.ToolTipText = "Select from Selection Screen.";
			this.StaticImage.BorderStyle = BorderStyle.FixedSingle;
			PictureBox staticImage = this.StaticImage;
			point = new Point(8, 8);
			staticImage.Location = point;
			this.StaticImage.Name = "StaticImage";
			PictureBox staticImage1 = this.StaticImage;
			size = new System.Drawing.Size(72, 144);
			staticImage1.Size = size;
			this.StaticImage.SizeMode = PictureBoxSizeMode.CenterImage;
			this.StaticImage.TabIndex = 30;
			this.StaticImage.TabStop = false;
			this.StaticTileList.BorderStyle = BorderStyle.FixedSingle;
			ListBox staticTileList = this.StaticTileList;
			point = new Point(88, 8);
			staticTileList.Location = point;
			this.StaticTileList.Name = "StaticTileList";
			ListBox staticTileList1 = this.StaticTileList;
			size = new System.Drawing.Size(64, 145);
			staticTileList1.Size = size;
			this.StaticTileList.TabIndex = 20;
			Button btnStaticHex = this.Btn_Static_Hex;
			point = new Point(64, 200);
			btnStaticHex.Location = point;
			this.Btn_Static_Hex.Name = "Btn_Static_Hex";
			Button btnStaticHex1 = this.Btn_Static_Hex;
			size = new System.Drawing.Size(32, 20);
			btnStaticHex1.Size = size;
			this.Btn_Static_Hex.TabIndex = 32;
			this.Btn_Static_Hex.Text = "Go";
			this.Static_TileID_Hex.BorderStyle = BorderStyle.FixedSingle;
			TextBox staticTileIDHex = this.Static_TileID_Hex;
			point = new Point(8, 200);
			staticTileIDHex.Location = point;
			this.Static_TileID_Hex.Name = "Static_TileID_Hex";
			TextBox staticTileIDHex1 = this.Static_TileID_Hex;
			size = new System.Drawing.Size(48, 20);
			staticTileIDHex1.Size = size;
			this.Static_TileID_Hex.TabIndex = 31;
			this.Static_TileID_Hex.Text = "";
			this.Static_TileID_Hex.TextAlign = HorizontalAlignment.Right;
			this.Label1.AutoSize = true;
			Label label1 = this.Label1;
			point = new Point(8, 160);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label11 = this.Label1;
			size = new System.Drawing.Size(37, 16);
			label11.Size = size;
			this.Label1.TabIndex = 22;
			this.Label1.Text = "Tile ID";
			this.Static_TileID.BorderStyle = BorderStyle.FixedSingle;
			TextBox staticTileID = this.Static_TileID;
			point = new Point(8, 176);
			staticTileID.Location = point;
			this.Static_TileID.Name = "Static_TileID";
			TextBox staticTileID1 = this.Static_TileID;
			size = new System.Drawing.Size(48, 20);
			staticTileID1.Size = size;
			this.Static_TileID.TabIndex = 23;
			this.Static_TileID.Text = "";
			this.Static_TileID.TextAlign = HorizontalAlignment.Right;
			Button btnStatic = this.Btn_Static;
			point = new Point(64, 176);
			btnStatic.Location = point;
			this.Btn_Static.Name = "Btn_Static";
			Button btnStatic1 = this.Btn_Static;
			size = new System.Drawing.Size(32, 20);
			btnStatic1.Size = size;
			this.Btn_Static.TabIndex = 26;
			this.Btn_Static.Text = "Go";
			this.Label2.AutoSize = true;
			Label label2 = this.Label2;
			point = new Point(104, 160);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new System.Drawing.Size(43, 16);
			label21.Size = size;
			this.Label2.TabIndex = 25;
			this.Label2.Text = "Alt Mod";
			this.Static_AltIDMod.BorderStyle = BorderStyle.FixedSingle;
			NumericUpDown staticAltIDMod = this.Static_AltIDMod;
			point = new Point(104, 176);
			staticAltIDMod.Location = point;
			NumericUpDown staticAltIDMod1 = this.Static_AltIDMod;
			numArray = new int[] { 127, 0, 0, 0 };
			num = new decimal(numArray);
			staticAltIDMod1.Maximum = num;
			NumericUpDown staticAltIDMod2 = this.Static_AltIDMod;
			numArray = new int[] { 127, 0, 0, -2147483648 };
			num = new decimal(numArray);
			staticAltIDMod2.Minimum = num;
			this.Static_AltIDMod.Name = "Static_AltIDMod";
			NumericUpDown numericUpDown2 = this.Static_AltIDMod;
			size = new System.Drawing.Size(48, 20);
			numericUpDown2.Size = size;
			this.Static_AltIDMod.TabIndex = 24;
			this.StaticItems.Dock = DockStyle.Right;
			this.StaticItems.LargeChange = 32;
			VScrollBar staticItems = this.StaticItems;
			point = new Point(160, 0);
			staticItems.Location = point;
			this.StaticItems.Maximum = 16535;
			this.StaticItems.Name = "StaticItems";
			VScrollBar staticItems1 = this.StaticItems;
			size = new System.Drawing.Size(16, 262);
			staticItems1.Size = size;
			this.StaticItems.TabIndex = 29;
			this.BoxFileName.BorderStyle = BorderStyle.FixedSingle;
			TextBox boxFileName = this.BoxFileName;
			point = new Point(392, 8);
			boxFileName.Location = point;
			this.BoxFileName.Name = "BoxFileName";
			TextBox boxFileName1 = this.BoxFileName;
			size = new System.Drawing.Size(112, 20);
			boxFileName1.Size = size;
			this.BoxFileName.TabIndex = 52;
			this.BoxFileName.Text = "";
			this.Label3.AutoSize = true;
			Label label3 = this.Label3;
			point = new Point(352, 8);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label31 = this.Label3;
			size = new System.Drawing.Size(23, 16);
			label31.Size = size;
			this.Label3.TabIndex = 53;
			this.Label3.Text = "File";
			this.Label4.AutoSize = true;
			Label label4 = this.Label4;
			point = new Point(352, 32);
			label4.Location = point;
			this.Label4.Name = "Label4";
			Label label41 = this.Label4;
			size = new System.Drawing.Size(30, 16);
			label41.Size = size;
			this.Label4.TabIndex = 54;
			this.Label4.Text = "Desc";
			this.Label8.AutoSize = true;
			Label label8 = this.Label8;
			point = new Point(352, 56);
			label8.Location = point;
			this.Label8.Name = "Label8";
			Label label81 = this.Label8;
			size = new System.Drawing.Size(24, 16);
			label81.Size = size;
			this.Label8.TabIndex = 55;
			this.Label8.Text = "Key";
			Button btnStaticFile = this.Btn_StaticFile;
			point = new Point(504, 8);
			btnStaticFile.Location = point;
			this.Btn_StaticFile.Name = "Btn_StaticFile";
			Button btnStaticFile1 = this.Btn_StaticFile;
			size = new System.Drawing.Size(32, 20);
			btnStaticFile1.Size = size;
			this.Btn_StaticFile.TabIndex = 56;
			this.Btn_StaticFile.Text = "...";
			size = new System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new System.Drawing.Size(538, 555);
			this.ClientSize = size;
			this.Controls.Add(this.Btn_StaticFile);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.BoxFileName);
			this.Controls.Add(this.TabControl1);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.Lbl_HashKey);
			this.Controls.Add(this.Box_Description);
			this.Controls.Add(this.ListBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Menu = this.MainMenu1;
			this.Name = "TEdit";
			this.Text = "Transition Editor";
			this.TabControl1.ResumeLayout(false);
			this.TabDraw.ResumeLayout(false);
			this.TabMap.ResumeLayout(false);
			((ISupportInitialize)this.Map_AltIDMod).EndInit();
			this.TabStatic.ResumeLayout(false);
			((ISupportInitialize)this.Static_AltIDMod).EndInit();
			this.ResumeLayout(false);
		}

		private void LandItems_Scroll(object sender, ScrollEventArgs e)
		{
			this.Map_TileID.Text = this.LandItems.Value.ToString();
			this.Map_TileID_Hex.Text = string.Concat("&H", Conversion.Hex(this.LandItems.Value));
			if (Art.GetLand(this.LandItems.Value) != null)
			{
				this.LandImage.Image = Art.GetLand(this.LandItems.Value);
			}
			else
			{
				this.LandImage.Image = null;
			}
		}

		private void LandItems_ValueChanged(object sender, EventArgs e)
		{
			this.Map_TileID.Text = this.LandItems.Value.ToString();
			this.Map_TileID_Hex.Text = string.Concat("&H", Conversion.Hex(this.LandItems.Value));
			if (Art.GetLand(this.LandItems.Value) != null)
			{
				this.LandImage.Image = Art.GetLand(this.LandItems.Value);
			}
			else
			{
				this.LandImage.Image = null;
			}
		}

		private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Transition selectedItem = (Transition)this.ListBox1.SelectedItem;
			if (selectedItem != null)
			{
				this.iTransition = selectedItem;
				this.PictureBox1.Refresh();
			}
		}

		[STAThread]
		public static void Main()
		{
			Application.Run(new TEdit());
		}

		private void MapTileList_SelectedIndexChanged(object sender, EventArgs e)
		{
			MapTile selectedItem = (MapTile)this.MapTileList.SelectedItem;
			if (selectedItem != null)
			{
				this.Map_TileID.Text = selectedItem.TileID.ToString();
				this.Map_TileID_Hex.Text = string.Concat("&H", Conversion.Hex(selectedItem.TileID));
				this.LandItems.Value = selectedItem.TileID;
				if (Art.GetLand(selectedItem.TileID) != null)
				{
					this.LandImage.Image = Art.GetLand(selectedItem.TileID);
				}
				else
				{
					this.LandImage.Image = null;
				}
			}
		}

		private void MapToolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			object tag = e.Button.Tag;
			if (ObjectType.ObjTst(tag, "Add", false) == 0)
			{
				if (StringType.StrCmp(this.Map_TileID.Text, string.Empty, false) == 0)
				{
					return;
				}
				this.iTransition.AddMapTile(ShortType.FromString(this.Map_TileID.Text), Convert.ToInt16(this.Map_AltIDMod.Value));
				this.iTransition.GetMapTiles.Display(this.MapTileList);
			}
			else if (ObjectType.ObjTst(tag, "Delete", false) == 0)
			{
				MapTile selectedItem = (MapTile)this.MapTileList.SelectedItem;
				if (selectedItem == null)
				{
					return;
				}
				this.LandImage.Image = null;
				this.iTransition.RemoveMapTile(selectedItem);
				this.iTransition.GetMapTiles.Display(this.MapTileList);
			}
			else if (ObjectType.ObjTst(tag, "Test", false) == 0)
			{
				if (StringType.StrCmp(this.Map_TileID.Text, string.Empty, false) == 0)
				{
					return;
				}
				if (!this.ImageTest)
				{
					this.ImageTest = true;
				}
				else
				{
					this.ImageTest = false;
				}
				this.PictureBox1.Refresh();
				if (Art.GetLand(IntegerType.FromString(this.Map_TileID.Text)) != null)
				{
					this.LandImage.Image = Art.GetLand(IntegerType.FromString(this.Map_TileID.Text));
				}
				else
				{
					this.LandImage.Image = null;
				}
			}
			else if (ObjectType.ObjTst(tag, "Select", false) == 0)
			{
				(new MapZoom()
				{
					Tag = this.LandItems
				}).Show();
			}
		}

		private void Menu_CloneGroupA_Click(object sender, EventArgs e)
		{
			TEdit.GroupSelect groupSelect = new TEdit.GroupSelect();
			groupSelect.SelectGroupName.Text = "Clone Group A";
			groupSelect.Tag = this;
			groupSelect.Show();
		}

		private void Menu_CloneGroupB_Click(object sender, EventArgs e)
		{
			TEdit.GroupSelect groupSelect = new TEdit.GroupSelect();
			groupSelect.SelectGroupName.Text = "Clone Group B";
			groupSelect.Tag = this;
			groupSelect.Show();
		}

		private void Menu2Way_Click(object sender, EventArgs e)
		{
			IEnumerator enumerator = null;
			if (this.m_SelectedGroupA != null)
			{
				if (this.m_SelectedGroupB != null)
				{
					if (StringType.StrCmp(this.m_SelectedGroupA.Name, this.m_SelectedGroupB.Name, false) != 0)
					{
						string str = string.Format("{0} To {1}", this.m_SelectedGroupA.Name, this.m_SelectedGroupB.Name);
						string str1 = string.Format("{0}Data\\System\\2Way_Template.xml", AppDomain.CurrentDomain.BaseDirectory);
						XmlDocument xmlDocument = new XmlDocument();
						this.iTransitionTable.Clear();
						try
						{
							xmlDocument.Load(str1);
							try
							{
								enumerator = xmlDocument.SelectNodes("//Wizard/Tile").GetEnumerator();
								while (enumerator.MoveNext())
								{
									string attribute = ((XmlElement)enumerator.Current).GetAttribute("Pattern");
									Transition transition = new Transition(str, this.m_SelectedGroupA, this.m_SelectedGroupB, attribute);
									this.iTransitionTable.Add(transition);
								}
							}
							finally
							{
								if (enumerator is IDisposable)
								{
									((IDisposable)enumerator).Dispose();
								}
							}
						}
						catch (Exception exception)
						{
							ProjectData.SetProjectError(exception);
							Interaction.MsgBox(string.Format("XMLFile:{0}", str1), MsgBoxStyle.OKOnly, null);
							ProjectData.ClearProjectError();
						}
						this.iTransitionTable.Display(this.ListBox1);
					}
				}
			}
		}

		private void Menu3Way_Click(object sender, EventArgs e)
		{
			IEnumerator enumerator = null;
			if (this.m_SelectedGroupA != null)
			{
				if (this.m_SelectedGroupB != null)
				{
					if (this.m_SelectedGroupC != null)
					{
						if (StringType.StrCmp(this.m_SelectedGroupA.Name, this.m_SelectedGroupB.Name, false) != 0)
						{
							string str = string.Format("{0}-{1}-{2}", this.m_SelectedGroupA.Name, this.m_SelectedGroupB.Name, this.m_SelectedGroupC.Name);
							string str1 = string.Format("{0}Data\\System\\3Way_Template.xml", AppDomain.CurrentDomain.BaseDirectory);
							XmlDocument xmlDocument = new XmlDocument();
							this.iTransitionTable.Clear();
							try
							{
								xmlDocument.Load(str1);
								try
								{
									enumerator = xmlDocument.SelectNodes("//Wizard/Tile").GetEnumerator();
									while (enumerator.MoveNext())
									{
										string attribute = ((XmlElement)enumerator.Current).GetAttribute("Pattern");
										Transition transition = new Transition(str, this.m_SelectedGroupA, this.m_SelectedGroupB, this.m_SelectedGroupC, attribute);
										this.iTransitionTable.Add(transition);
									}
								}
								finally
								{
									if (enumerator is IDisposable)
									{
										((IDisposable)enumerator).Dispose();
									}
								}
							}
							catch (Exception exception)
							{
								ProjectData.SetProjectError(exception);
								Interaction.MsgBox(string.Format("XMLFile:{0}", str1), MsgBoxStyle.OKOnly, null);
								ProjectData.ClearProjectError();
							}
							this.iTransitionTable.Display(this.ListBox1);
						}
					}
				}
			}
		}

		private void MenuAddKey_Click(object sender, EventArgs e)
		{
			this.iTransitionTable.Add(this.iTransition);
			this.iTransition = new Transition();
			this.iTransitionTable.Display(this.ListBox1);
			this.PictureBox1.Refresh();
		}

		private void MenuCopyKey_Click(object sender, EventArgs e)
		{
			this.iTransitionTable.Add(this.iTransition);
			this.iTransitionTable.Display(this.ListBox1);
			this.PictureBox1.Refresh();
		}

		private void MenuDelKey_Click(object sender, EventArgs e)
		{
			Transition selectedItem = (Transition)this.ListBox1.SelectedItem;
			if (selectedItem != null)
			{
				this.iTransitionTable.Remove(selectedItem);
				this.iTransitionTable.Display(this.ListBox1);
			}
		}

		private void MenuItem1_Click(object sender, EventArgs e)
		{
			this.iTransition = new Transition();
			this.PictureBox1.Refresh();
		}

		private void MenuItem10_Click(object sender, EventArgs e)
		{
			IEnumerator enumerator = null;
			if (this.m_SelectedGroupA != null)
			{
				if (this.m_SelectedGroupB != null)
				{
					this.iTransitionTable.Clear();
					OpenFileDialog openFileDialog = new OpenFileDialog();
					if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
					{
						this.iTransitionTable.Load(openFileDialog.FileName);
					}
					try
					{
						enumerator = this.iTransitionTable.TransitionTable.Values.GetEnumerator();
						while (enumerator.MoveNext())
						{
							((Transition)enumerator.Current).Clone(this.m_SelectedGroupA, this.m_SelectedGroupB);
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					string fileName = openFileDialog.FileName;
					this.iTransitionTable.Save(fileName.Replace(this.m_SelectedGroupA.Name, this.m_SelectedGroupB.Name));
				}
			}
		}

		private void MenuItem3_Click(object sender, EventArgs e)
		{
			PrintTransition printTransition = new PrintTransition();
		}

		private void MenuLoad_Click(object sender, EventArgs e)
		{
			this.iTransitionTable.Clear();
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				this.iTransitionTable.Load(openFileDialog.FileName);
				this.iTransitionTable.Display(this.ListBox1);
			}
		}

		private void MenuNew_Click(object sender, EventArgs e)
		{
			this.iTransitionTable.Clear();
			this.iTransitionTable.Display(this.ListBox1);
			this.iTransition = new Transition();
			this.PictureBox1.Refresh();
		}

		private void MenuSave_Click(object sender, EventArgs e)
		{
			this.iTransitionTable.Save(this.Box_Description.Text);
		}

		private void MenuSelectB_Click(object sender, EventArgs e)
		{
			TEdit.GroupSelect groupSelect = new TEdit.GroupSelect();
			groupSelect.SelectGroupName.Text = "Select Group B";
			groupSelect.Tag = this;
			groupSelect.Show();
		}

		private void MenuTerrainA_Click(object sender, EventArgs e)
		{
			TEdit.GroupSelect groupSelect = new TEdit.GroupSelect();
			groupSelect.SelectGroupName.Text = "Select Group A";
			groupSelect.Tag = this;
			groupSelect.Show();
		}

		private void MenuTerrainC_Click(object sender, EventArgs e)
		{
			TEdit.GroupSelect groupSelect = new TEdit.GroupSelect();
			groupSelect.SelectGroupName.Text = "Select Group C";
			groupSelect.Tag = this;
			groupSelect.Show();
		}

		private void PictureBox1_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			this.LandImage.Image = null;
			this.StaticImage.Image = null;
			this.Box_Description.Text = this.iTransition.Description;
			this.Lbl_HashKey.Text = this.iTransition.HashKey;
			this.BoxFileName.Text = this.iTransition.File;
			this.iTransition.GetStaticTiles.Display(this.StaticTileList);
			this.iTransition.GetMapTiles.Display(this.MapTileList);
			graphics.Clear(Color.LightGray);
			Bitmap land = Art.GetLand(this.iGroups[this.iTransition[0]].TileID);
			Point point = new Point(61, 15);
			graphics.DrawImage(land, point);
			Bitmap bitmap = Art.GetLand(this.iGroups[this.iTransition[1]].TileID);
			point = new Point(84, 38);
			graphics.DrawImage(bitmap, point);
			Bitmap land1 = Art.GetLand(this.iGroups[this.iTransition[2]].TileID);
			point = new Point(107, 61);
			graphics.DrawImage(land1, point);
			Bitmap bitmap1 = Art.GetLand(this.iGroups[this.iTransition[3]].TileID);
			point = new Point(38, 38);
			graphics.DrawImage(bitmap1, point);
			if (!this.ImageTest)
			{
				Bitmap land2 = Art.GetLand(this.iGroups[this.iTransition[4]].TileID);
				point = new Point(61, 61);
				graphics.DrawImage(land2, point);
			}
			else
			{
				Bitmap bitmap2 = Art.GetLand(IntegerType.FromString(this.Map_TileID.Text));
				point = new Point(61, 61);
				graphics.DrawImage(bitmap2, point);
			}
			Bitmap land3 = Art.GetLand(this.iGroups[this.iTransition[5]].TileID);
			point = new Point(84, 84);
			graphics.DrawImage(land3, point);
			Bitmap bitmap3 = Art.GetLand(this.iGroups[this.iTransition[6]].TileID);
			point = new Point(15, 61);
			graphics.DrawImage(bitmap3, point);
			Bitmap land4 = Art.GetLand(this.iGroups[this.iTransition[7]].TileID);
			point = new Point(38, 84);
			graphics.DrawImage(land4, point);
			Bitmap bitmap4 = Art.GetLand(this.iGroups[this.iTransition[8]].TileID);
			point = new Point(61, 107);
			graphics.DrawImage(bitmap4, point);
			Pen pen = new Pen(Color.Red, 1f);
			point = new Point(82, 60);
			Point point1 = new Point(60, 82);
			graphics.DrawLine(pen, point, point1);
			Pen pen1 = new Pen(Color.Red, 1f);
			point1 = new Point(60, 83);
			point = new Point(82, 105);
			graphics.DrawLine(pen1, point1, point);
			Pen pen2 = new Pen(Color.Red, 1f);
			point1 = new Point(83, 105);
			point = new Point(105, 83);
			graphics.DrawLine(pen2, point1, point);
			Pen pen3 = new Pen(Color.Red, 1f);
			point1 = new Point(105, 82);
			point = new Point(83, 60);
			graphics.DrawLine(pen3, point1, point);
			graphics = null;
		}

		private void StaticItems_Scroll(object sender, ScrollEventArgs e)
		{
			this.Static_TileID.Text = this.StaticItems.Value.ToString();
			this.Static_TileID_Hex.Text = string.Concat("&H", Conversion.Hex(this.StaticItems.Value));
			if (Art.GetStatic(this.StaticItems.Value) != null)
			{
				this.StaticImage.Image = Art.GetStatic(this.StaticItems.Value);
			}
			else
			{
				this.StaticImage.Image = null;
			}
		}

		private void StaticItems_ValueChanged(object sender, EventArgs e)
		{
			this.Static_TileID.Text = this.StaticItems.Value.ToString();
			this.Static_TileID_Hex.Text = string.Concat("&H", Conversion.Hex(this.StaticItems.Value));
			if (Art.GetStatic(this.StaticItems.Value) != null)
			{
				this.StaticImage.Image = Art.GetStatic(this.StaticItems.Value);
			}
			else
			{
				this.StaticImage.Image = null;
			}
		}

		private void StaticTileList_SelectedIndexChanged(object sender, EventArgs e)
		{
			Transition.StaticTile selectedItem = (Transition.StaticTile)this.StaticTileList.SelectedItem;
			if (selectedItem != null)
			{
				this.Static_TileID.Text = selectedItem.TileID.ToString();
				this.Static_TileID_Hex.Text = string.Concat("&H", Conversion.Hex(selectedItem.TileID));
				this.StaticItems.Value = selectedItem.TileID;
				if (Art.GetStatic(selectedItem.TileID) != null)
				{
					this.StaticImage.Image = Art.GetStatic(selectedItem.TileID);
				}
				else
				{
					this.StaticImage.Image = null;
				}
			}
		}

		private void StaticToolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			object tag = e.Button.Tag;
			if (ObjectType.ObjTst(tag, "Add", false) == 0)
			{
				if (StringType.StrCmp(this.Static_TileID.Text, string.Empty, false) == 0)
				{
					return;
				}
				this.iTransition.AddStaticTile(ShortType.FromString(this.Static_TileID.Text), Convert.ToInt16(this.Static_AltIDMod.Value));
				this.iTransition.GetStaticTiles.Display(this.StaticTileList);
			}
			else if (ObjectType.ObjTst(tag, "Delete", false) == 0)
			{
				Transition.StaticTile selectedItem = (Transition.StaticTile)this.StaticTileList.SelectedItem;
				if (selectedItem == null)
				{
					return;
				}
				this.StaticImage.Image = null;
				this.iTransition.RemoveStaticTile(selectedItem);
				this.iTransition.GetStaticTiles.Display(this.StaticTileList);
			}
			else if (ObjectType.ObjTst(tag, "Select", false) == 0)
			{
				(new StaticZoom()
				{
					Tag = this.StaticItems
				}).Show();
			}
		}

		private void TEdit_Load(object sender, EventArgs e)
		{
			this.iGroups.Load();
			this.iGroups.Display(this.GroupSelect);
		}

		private void ToolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			ClsTerrain selectedItem = (ClsTerrain)this.GroupSelect.SelectedItem;
			if (selectedItem != null)
			{
				this.iTransition.SetHashKey(IntegerType.FromObject(e.Button.Tag), checked((byte)selectedItem.GroupID));
				this.PictureBox1.Refresh();
			}
		}
	}
}