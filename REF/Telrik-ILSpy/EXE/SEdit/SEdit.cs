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
					SEdit sEdit = this;
					this._GroupSelect.SelectedIndexChanged -= new EventHandler(sEdit.GroupSelect_SelectedIndexChanged);
				}
				this._GroupSelect = value;
				if (this._GroupSelect != null)
				{
					SEdit sEdit1 = this;
					this._GroupSelect.SelectedIndexChanged += new EventHandler(sEdit1.GroupSelect_SelectedIndexChanged);
				}
			}
		}

		internal virtual HScrollBar HScrollBar1
		{
			get
			{
				return this._HScrollBar1;
			}
			set
			{
				if (this._HScrollBar1 != null)
				{
					SEdit sEdit = this;
					this._HScrollBar1.Scroll -= new ScrollEventHandler(sEdit.HScrollBar1_Scroll);
				}
				this._HScrollBar1 = value;
				if (this._HScrollBar1 != null)
				{
					SEdit sEdit1 = this;
					this._HScrollBar1.Scroll += new ScrollEventHandler(sEdit1.HScrollBar1_Scroll);
				}
			}
		}

		internal virtual TextBox HueID
		{
			get
			{
				return this._HueID;
			}
			set
			{
				this._HueID == null;
				this._HueID = value;
				this._HueID == null;
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

		internal virtual Label Label10
		{
			get
			{
				return this._Label10;
			}
			set
			{
				this._Label10 == null;
				this._Label10 = value;
				this._Label10 == null;
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

		internal virtual Label Label9
		{
			get
			{
				return this._Label9;
			}
			set
			{
				this._Label9 == null;
				this._Label9 = value;
				this._Label9 == null;
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
					SEdit sEdit = this;
					this._ListBox1.SelectedIndexChanged -= new EventHandler(sEdit.ListBox1_SelectedIndexChanged);
				}
				this._ListBox1 = value;
				if (this._ListBox1 != null)
				{
					SEdit sEdit1 = this;
					this._ListBox1.SelectedIndexChanged += new EventHandler(sEdit1.ListBox1_SelectedIndexChanged);
				}
			}
		}

		internal virtual ListBox ListBox2
		{
			get
			{
				return this._ListBox2;
			}
			set
			{
				if (this._ListBox2 != null)
				{
					SEdit sEdit = this;
					this._ListBox2.SelectedIndexChanged -= new EventHandler(sEdit.ListBox2_SelectedIndexChanged);
				}
				this._ListBox2 = value;
				if (this._ListBox2 != null)
				{
					SEdit sEdit1 = this;
					this._ListBox2.SelectedIndexChanged += new EventHandler(sEdit1.ListBox2_SelectedIndexChanged);
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
					SEdit sEdit = this;
					this._MenuLoad.Click -= new EventHandler(sEdit.MenuLoad_Click);
				}
				this._MenuLoad = value;
				if (this._MenuLoad != null)
				{
					SEdit sEdit1 = this;
					this._MenuLoad.Click += new EventHandler(sEdit1.MenuLoad_Click);
				}
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
					SEdit sEdit = this;
					this._MenuNew.Click -= new EventHandler(sEdit.MenuNew_Click);
				}
				this._MenuNew = value;
				if (this._MenuNew != null)
				{
					SEdit sEdit1 = this;
					this._MenuNew.Click += new EventHandler(sEdit1.MenuNew_Click);
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
					SEdit sEdit = this;
					this._MenuSave.Click -= new EventHandler(sEdit.MenuSave_Click);
				}
				this._MenuSave = value;
				if (this._MenuSave != null)
				{
					SEdit sEdit1 = this;
					this._MenuSave.Click += new EventHandler(sEdit1.MenuSave_Click);
				}
			}
		}

		internal virtual NumericUpDown NumericUpDown4
		{
			get
			{
				return this._NumericUpDown4;
			}
			set
			{
				if (this._NumericUpDown4 != null)
				{
					SEdit sEdit = this;
					this._NumericUpDown4.ValueChanged -= new EventHandler(sEdit.NumericUpDown4_ValueChanged);
				}
				this._NumericUpDown4 = value;
				if (this._NumericUpDown4 != null)
				{
					SEdit sEdit1 = this;
					this._NumericUpDown4.ValueChanged += new EventHandler(sEdit1.NumericUpDown4_ValueChanged);
				}
			}
		}

		internal virtual NumericUpDown NumericUpDown5
		{
			get
			{
				return this._NumericUpDown5;
			}
			set
			{
				if (this._NumericUpDown5 != null)
				{
					SEdit sEdit = this;
					this._NumericUpDown5.ValueChanged -= new EventHandler(sEdit.NumericUpDown5_ValueChanged);
				}
				this._NumericUpDown5 = value;
				if (this._NumericUpDown5 != null)
				{
					SEdit sEdit1 = this;
					this._NumericUpDown5.ValueChanged += new EventHandler(sEdit1.NumericUpDown5_ValueChanged);
				}
			}
		}

		internal virtual Panel Panel1
		{
			get
			{
				return this._Panel1;
			}
			set
			{
				this._Panel1 == null;
				this._Panel1 = value;
				this._Panel1 == null;
			}
		}

		internal virtual Panel Panel2
		{
			get
			{
				return this._Panel2;
			}
			set
			{
				if (this._Panel2 != null)
				{
					SEdit sEdit = this;
					this._Panel2.Paint -= new PaintEventHandler(sEdit.Panel2_Paint);
				}
				this._Panel2 = value;
				if (this._Panel2 != null)
				{
					SEdit sEdit1 = this;
					this._Panel2.Paint += new PaintEventHandler(sEdit1.Panel2_Paint);
				}
			}
		}

		internal virtual Panel Panel3
		{
			get
			{
				return this._Panel3;
			}
			set
			{
				if (this._Panel3 != null)
				{
					SEdit sEdit = this;
					this._Panel3.Paint -= new PaintEventHandler(sEdit.Panel3_Paint);
				}
				this._Panel3 = value;
				if (this._Panel3 != null)
				{
					SEdit sEdit1 = this;
					this._Panel3.Paint += new PaintEventHandler(sEdit1.Panel3_Paint);
				}
			}
		}

		internal virtual Panel Panel5
		{
			get
			{
				return this._Panel5;
			}
			set
			{
				this._Panel5 == null;
				this._Panel5 = value;
				this._Panel5 == null;
			}
		}

		internal virtual Panel Panel6
		{
			get
			{
				return this._Panel6;
			}
			set
			{
				this._Panel6 == null;
				this._Panel6 = value;
				this._Panel6 == null;
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
				this._PictureBox1 == null;
				this._PictureBox1 = value;
				this._PictureBox1 == null;
			}
		}

		internal virtual PropertyGrid PropertyGrid1
		{
			get
			{
				return this._PropertyGrid1;
			}
			set
			{
				this._PropertyGrid1 == null;
				this._PropertyGrid1 = value;
				this._PropertyGrid1 == null;
			}
		}

		internal virtual Button StaticZoom
		{
			get
			{
				return this._StaticZoom;
			}
			set
			{
				if (this._StaticZoom != null)
				{
					SEdit sEdit = this;
					this._StaticZoom.Click -= new EventHandler(sEdit.StaticZoom_Click);
				}
				this._StaticZoom = value;
				if (this._StaticZoom != null)
				{
					SEdit sEdit1 = this;
					this._StaticZoom.Click += new EventHandler(sEdit1.StaticZoom_Click);
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

		internal virtual TabPage TabPage1
		{
			get
			{
				return this._TabPage1;
			}
			set
			{
				this._TabPage1 == null;
				this._TabPage1 = value;
				this._TabPage1 == null;
			}
		}

		internal virtual TabPage TabPage2
		{
			get
			{
				return this._TabPage2;
			}
			set
			{
				this._TabPage2 == null;
				this._TabPage2 = value;
				this._TabPage2 == null;
			}
		}

		internal virtual TabPage TabPage3
		{
			get
			{
				return this._TabPage3;
			}
			set
			{
				this._TabPage3 == null;
				this._TabPage3 = value;
				this._TabPage3 == null;
			}
		}

		internal virtual TextBox TextBox1
		{
			get
			{
				return this._TextBox1;
			}
			set
			{
				this._TextBox1 == null;
				this._TextBox1 = value;
				this._TextBox1 == null;
			}
		}

		internal virtual TextBox TextBox3
		{
			get
			{
				return this._TextBox3;
			}
			set
			{
				this._TextBox3 == null;
				this._TextBox3 = value;
				this._TextBox3 == null;
			}
		}

		internal virtual TextBox TileDesc
		{
			get
			{
				return this._TileDesc;
			}
			set
			{
				this._TileDesc == null;
				this._TileDesc = value;
				this._TileDesc == null;
			}
		}

		internal virtual TextBox TileID
		{
			get
			{
				return this._TileID;
			}
			set
			{
				this._TileID == null;
				this._TileID = value;
				this._TileID == null;
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
					SEdit sEdit = this;
					this._ToolBar1.ButtonClick -= new ToolBarButtonClickEventHandler(sEdit.ToolBar1_ButtonClick);
				}
				this._ToolBar1 = value;
				if (this._ToolBar1 != null)
				{
					SEdit sEdit1 = this;
					this._ToolBar1.ButtonClick += new ToolBarButtonClickEventHandler(sEdit1.ToolBar1_ButtonClick);
				}
			}
		}

		internal virtual ToolBar ToolBar2
		{
			get
			{
				return this._ToolBar2;
			}
			set
			{
				if (this._ToolBar2 != null)
				{
					SEdit sEdit = this;
					this._ToolBar2.ButtonClick -= new ToolBarButtonClickEventHandler(sEdit.ToolBar2_ButtonClick);
				}
				this._ToolBar2 = value;
				if (this._ToolBar2 != null)
				{
					SEdit sEdit1 = this;
					this._ToolBar2.ButtonClick += new ToolBarButtonClickEventHandler(sEdit1.ToolBar2_ButtonClick);
				}
			}
		}

		internal virtual ToolBar ToolBar3
		{
			get
			{
				return this._ToolBar3;
			}
			set
			{
				if (this._ToolBar3 != null)
				{
					SEdit sEdit = this;
					this._ToolBar3.ButtonClick -= new ToolBarButtonClickEventHandler(sEdit.ToolBar3_ButtonClick);
				}
				this._ToolBar3 = value;
				if (this._ToolBar3 != null)
				{
					SEdit sEdit1 = this;
					this._ToolBar3.ButtonClick += new ToolBarButtonClickEventHandler(sEdit1.ToolBar3_ButtonClick);
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
					SEdit sEdit = this;
					this._VScrollBar1.ValueChanged -= new EventHandler(sEdit.VScrollBar1_ValueChanged);
					SEdit sEdit1 = this;
					this._VScrollBar1.Scroll -= new ScrollEventHandler(sEdit1.VScrollBar1_Scroll);
				}
				this._VScrollBar1 = value;
				if (this._VScrollBar1 != null)
				{
					SEdit sEdit2 = this;
					this._VScrollBar1.ValueChanged += new EventHandler(sEdit2.VScrollBar1_ValueChanged);
					SEdit sEdit3 = this;
					this._VScrollBar1.Scroll += new ScrollEventHandler(sEdit3.VScrollBar1_Scroll);
				}
			}
		}

		internal virtual VScrollBar VScrollBar2
		{
			get
			{
				return this._VScrollBar2;
			}
			set
			{
				if (this._VScrollBar2 != null)
				{
					SEdit sEdit = this;
					this._VScrollBar2.Scroll -= new ScrollEventHandler(sEdit.VScrollBar2_Scroll);
				}
				this._VScrollBar2 = value;
				if (this._VScrollBar2 != null)
				{
					SEdit sEdit1 = this;
					this._VScrollBar2.Scroll += new ScrollEventHandler(sEdit1.VScrollBar2_Scroll);
				}
			}
		}

		internal virtual NumericUpDown Xaxis
		{
			get
			{
				return this._Xaxis;
			}
			set
			{
				if (this._Xaxis != null)
				{
					SEdit sEdit = this;
					this._Xaxis.ValueChanged -= new EventHandler(sEdit.Xaxis_ValueChanged);
				}
				this._Xaxis = value;
				if (this._Xaxis != null)
				{
					SEdit sEdit1 = this;
					this._Xaxis.ValueChanged += new EventHandler(sEdit1.Xaxis_ValueChanged);
				}
			}
		}

		internal virtual NumericUpDown Yaxis
		{
			get
			{
				return this._Yaxis;
			}
			set
			{
				if (this._Yaxis != null)
				{
					SEdit sEdit = this;
					this._Yaxis.ValueChanged -= new EventHandler(sEdit.Yaxis_ValueChanged);
				}
				this._Yaxis = value;
				if (this._Yaxis != null)
				{
					SEdit sEdit1 = this;
					this._Yaxis.ValueChanged += new EventHandler(sEdit1.Yaxis_ValueChanged);
				}
			}
		}

		internal virtual NumericUpDown Zaxis
		{
			get
			{
				return this._Zaxis;
			}
			set
			{
				this._Zaxis == null;
				this._Zaxis = value;
				this._Zaxis == null;
			}
		}

		public SEdit()
		{
			SEdit sEdit = this;
			base.Load += new EventHandler(sEdit.SEdit_Load);
			this.StaticGrid = new Point[13, 13];
			this.iTerrain = new ClsTerrainTable();
			this.iRandomStatic = new RandomStatics();
			this.InitializeComponent();
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

		private void GroupSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.Panel3.Refresh();
		}

		private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
			this.UpdatePanel();
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ResourceManager resourceManager = new ResourceManager(typeof(SEdit));
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
			((ISupportInitialize)this.NumericUpDown4).BeginInit();
			this.TabPage2.SuspendLayout();
			this.Panel5.SuspendLayout();
			this.TabPage3.SuspendLayout();
			((ISupportInitialize)this.Xaxis).BeginInit();
			((ISupportInitialize)this.Yaxis).BeginInit();
			((ISupportInitialize)this.Zaxis).BeginInit();
			((ISupportInitialize)this.NumericUpDown5).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.SuspendLayout();
			this.ToolBarButton3.ImageIndex = 0;
			this.ToolBarButton3.Tag = "Add";
			this.ToolBarButton4.ImageIndex = 7;
			this.ToolBarButton4.Tag = "Delete";
			ImageList imageList1 = this.ImageList1;
			System.Drawing.Size size = new System.Drawing.Size(24, 24);
			imageList1.ImageSize = size;
			this.ImageList1.ImageStream = (ImageListStreamer)resourceManager.GetObject("ImageList1.ImageStream");
			this.ImageList1.TransparentColor = Color.Transparent;
			ComboBox groupSelect = this.GroupSelect;
			Point point = new Point(520, 24);
			groupSelect.Location = point;
			this.GroupSelect.Name = "GroupSelect";
			ComboBox comboBox = this.GroupSelect;
			size = new System.Drawing.Size(144, 21);
			comboBox.Size = size;
			this.GroupSelect.Sorted = true;
			this.GroupSelect.TabIndex = 39;
			this.ToolBarButton1.ImageIndex = 0;
			this.ToolBarButton1.Tag = "Add";
			this.ToolBarButton2.ImageIndex = 7;
			this.ToolBarButton2.Tag = "Delete";
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Controls.Add(this.TabPage3);
			TabControl tabControl1 = this.TabControl1;
			point = new Point(584, 56);
			tabControl1.Location = point;
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			TabControl tabControl = this.TabControl1;
			size = new System.Drawing.Size(264, 448);
			tabControl.Size = size;
			this.TabControl1.TabIndex = 35;
			this.TabPage1.Controls.Add(this.Panel6);
			this.TabPage1.Controls.Add(this.NumericUpDown4);
			this.TabPage1.Controls.Add(this.Label9);
			this.TabPage1.Controls.Add(this.TextBox3);
			this.TabPage1.Controls.Add(this.Label8);
			this.TabPage1.Controls.Add(this.ListBox1);
			TabPage tabPage1 = this.TabPage1;
			point = new Point(4, 22);
			tabPage1.Location = point;
			this.TabPage1.Name = "TabPage1";
			TabPage tabPage = this.TabPage1;
			size = new System.Drawing.Size(256, 422);
			tabPage.Size = size;
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Static List";
			this.Panel6.Controls.Add(this.ToolBar2);
			Panel panel6 = this.Panel6;
			point = new Point(8, 368);
			panel6.Location = point;
			this.Panel6.Name = "Panel6";
			Panel panel = this.Panel6;
			size = new System.Drawing.Size(88, 48);
			panel.Size = size;
			this.Panel6.TabIndex = 18;
			ToolBar.ToolBarButtonCollection buttons = this.ToolBar2.Buttons;
			ToolBarButton[] toolBarButton3 = new ToolBarButton[] { this.ToolBarButton3, this.ToolBarButton4 };
			buttons.AddRange(toolBarButton3);
			ToolBar toolBar2 = this.ToolBar2;
			size = new System.Drawing.Size(40, 40);
			toolBar2.ButtonSize = size;
			this.ToolBar2.Divider = false;
			this.ToolBar2.DropDownArrows = true;
			this.ToolBar2.ImageList = this.ImageList1;
			ToolBar toolBar = this.ToolBar2;
			point = new Point(0, 0);
			toolBar.Location = point;
			this.ToolBar2.Name = "ToolBar2";
			this.ToolBar2.ShowToolTips = true;
			ToolBar toolBar21 = this.ToolBar2;
			size = new System.Drawing.Size(88, 44);
			toolBar21.Size = size;
			this.ToolBar2.TabIndex = 17;
			NumericUpDown numericUpDown4 = this.NumericUpDown4;
			point = new Point(72, 48);
			numericUpDown4.Location = point;
			this.NumericUpDown4.Name = "NumericUpDown4";
			NumericUpDown numericUpDown = this.NumericUpDown4;
			size = new System.Drawing.Size(40, 20);
			numericUpDown.Size = size;
			this.NumericUpDown4.TabIndex = 4;
			this.Label9.AutoSize = true;
			Label label9 = this.Label9;
			point = new Point(8, 48);
			label9.Location = point;
			this.Label9.Name = "Label9";
			Label label = this.Label9;
			size = new System.Drawing.Size(58, 16);
			label.Size = size;
			this.Label9.TabIndex = 3;
			this.Label9.Text = "Frequency";
			TextBox textBox3 = this.TextBox3;
			point = new Point(8, 24);
			textBox3.Location = point;
			this.TextBox3.Name = "TextBox3";
			TextBox textBox = this.TextBox3;
			size = new System.Drawing.Size(240, 20);
			textBox.Size = size;
			this.TextBox3.TabIndex = 2;
			this.TextBox3.Text = "";
			this.Label8.AutoSize = true;
			Label label8 = this.Label8;
			point = new Point(8, 8);
			label8.Location = point;
			this.Label8.Name = "Label8";
			Label label81 = this.Label8;
			size = new System.Drawing.Size(61, 16);
			label81.Size = size;
			this.Label8.TabIndex = 1;
			this.Label8.Text = "Description";
			ListBox listBox1 = this.ListBox1;
			point = new Point(8, 72);
			listBox1.Location = point;
			this.ListBox1.Name = "ListBox1";
			ListBox listBox = this.ListBox1;
			size = new System.Drawing.Size(240, 290);
			listBox.Size = size;
			this.ListBox1.TabIndex = 0;
			this.TabPage2.Controls.Add(this.Panel5);
			this.TabPage2.Controls.Add(this.ListBox2);
			TabPage tabPage2 = this.TabPage2;
			point = new Point(4, 22);
			tabPage2.Location = point;
			this.TabPage2.Name = "TabPage2";
			TabPage tabPage21 = this.TabPage2;
			size = new System.Drawing.Size(256, 422);
			tabPage21.Size = size;
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Model Components";
			this.TabPage2.Visible = false;
			this.Panel5.Controls.Add(this.ToolBar1);
			Panel panel5 = this.Panel5;
			point = new Point(8, 368);
			panel5.Location = point;
			this.Panel5.Name = "Panel5";
			Panel panel51 = this.Panel5;
			size = new System.Drawing.Size(200, 48);
			panel51.Size = size;
			this.Panel5.TabIndex = 4;
			ToolBar.ToolBarButtonCollection toolBarButtonCollections = this.ToolBar1.Buttons;
			toolBarButton3 = new ToolBarButton[] { this.ToolBarButton1, this.ToolBarButton2 };
			toolBarButtonCollections.AddRange(toolBarButton3);
			ToolBar toolBar1 = this.ToolBar1;
			size = new System.Drawing.Size(40, 40);
			toolBar1.ButtonSize = size;
			this.ToolBar1.Divider = false;
			this.ToolBar1.DropDownArrows = true;
			this.ToolBar1.ImageList = this.ImageList1;
			ToolBar toolBar11 = this.ToolBar1;
			point = new Point(0, 0);
			toolBar11.Location = point;
			this.ToolBar1.Name = "ToolBar1";
			this.ToolBar1.ShowToolTips = true;
			ToolBar toolBar12 = this.ToolBar1;
			size = new System.Drawing.Size(200, 44);
			toolBar12.Size = size;
			this.ToolBar1.TabIndex = 14;
			ListBox listBox2 = this.ListBox2;
			point = new Point(8, 8);
			listBox2.Location = point;
			this.ListBox2.Name = "ListBox2";
			ListBox listBox21 = this.ListBox2;
			size = new System.Drawing.Size(240, 355);
			listBox21.Size = size;
			this.ListBox2.TabIndex = 3;
			this.TabPage3.Controls.Add(this.PropertyGrid1);
			TabPage tabPage3 = this.TabPage3;
			point = new Point(4, 22);
			tabPage3.Location = point;
			this.TabPage3.Name = "TabPage3";
			TabPage tabPage31 = this.TabPage3;
			size = new System.Drawing.Size(256, 422);
			tabPage31.Size = size;
			this.TabPage3.TabIndex = 2;
			this.TabPage3.Text = "Property";
			this.TabPage3.Visible = false;
			this.PropertyGrid1.CommandsVisibleIfAvailable = true;
			this.PropertyGrid1.HelpVisible = false;
			this.PropertyGrid1.LargeButtons = false;
			this.PropertyGrid1.LineColor = SystemColors.ScrollBar;
			PropertyGrid propertyGrid1 = this.PropertyGrid1;
			point = new Point(8, 0);
			propertyGrid1.Location = point;
			this.PropertyGrid1.Name = "PropertyGrid1";
			PropertyGrid propertyGrid = this.PropertyGrid1;
			size = new System.Drawing.Size(240, 408);
			propertyGrid.Size = size;
			this.PropertyGrid1.TabIndex = 0;
			this.PropertyGrid1.Text = "PropertyGrid1";
			this.PropertyGrid1.ToolbarVisible = false;
			this.PropertyGrid1.ViewBackColor = SystemColors.Window;
			this.PropertyGrid1.ViewForeColor = SystemColors.WindowText;
			this.ToolBarButton13.Tag = "9";
			this.VScrollBar2.LargeChange = 8;
			VScrollBar vScrollBar2 = this.VScrollBar2;
			point = new Point(352, 8);
			vScrollBar2.Location = point;
			this.VScrollBar2.Maximum = 256;
			this.VScrollBar2.Name = "VScrollBar2";
			VScrollBar vScrollBar = this.VScrollBar2;
			size = new System.Drawing.Size(16, 464);
			vScrollBar.Size = size;
			this.VScrollBar2.TabIndex = 22;
			this.HScrollBar1.LargeChange = 8;
			HScrollBar hScrollBar1 = this.HScrollBar1;
			point = new Point(8, 472);
			hScrollBar1.Location = point;
			this.HScrollBar1.Maximum = 276;
			this.HScrollBar1.Name = "HScrollBar1";
			HScrollBar hScrollBar = this.HScrollBar1;
			size = new System.Drawing.Size(344, 16);
			hScrollBar.Size = size;
			this.HScrollBar1.TabIndex = 21;
			this.ToolBarButton12.Tag = "8";
			this.Label2.AutoSize = true;
			Label label2 = this.Label2;
			point = new Point(96, 496);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new System.Drawing.Size(12, 16);
			label21.Size = size;
			this.Label2.TabIndex = 26;
			this.Label2.Text = "X";
			NumericUpDown xaxis = this.Xaxis;
			point = new Point(112, 496);
			xaxis.Location = point;
			NumericUpDown xaxis1 = this.Xaxis;
			int[] numArray = new int[] { 6, 0, 0, 0 };
			decimal num = new decimal(numArray);
			xaxis1.Maximum = num;
			NumericUpDown numericUpDown1 = this.Xaxis;
			numArray = new int[] { 6, 0, 0, -2147483648 };
			num = new decimal(numArray);
			numericUpDown1.Minimum = num;
			this.Xaxis.Name = "Xaxis";
			NumericUpDown xaxis2 = this.Xaxis;
			size = new System.Drawing.Size(40, 20);
			xaxis2.Size = size;
			this.Xaxis.TabIndex = 28;
			this.Label3.AutoSize = true;
			Label label3 = this.Label3;
			point = new Point(160, 496);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label31 = this.Label3;
			size = new System.Drawing.Size(12, 16);
			label31.Size = size;
			this.Label3.TabIndex = 27;
			this.Label3.Text = "Y";
			NumericUpDown yaxis = this.Yaxis;
			point = new Point(176, 496);
			yaxis.Location = point;
			NumericUpDown yaxis1 = this.Yaxis;
			numArray = new int[] { 6, 0, 0, 0 };
			num = new decimal(numArray);
			yaxis1.Maximum = num;
			NumericUpDown yaxis2 = this.Yaxis;
			numArray = new int[] { 6, 0, 0, -2147483648 };
			num = new decimal(numArray);
			yaxis2.Minimum = num;
			this.Yaxis.Name = "Yaxis";
			NumericUpDown numericUpDown2 = this.Yaxis;
			size = new System.Drawing.Size(40, 20);
			numericUpDown2.Size = size;
			this.Yaxis.TabIndex = 31;
			this.Label4.AutoSize = true;
			Label label4 = this.Label4;
			point = new Point(224, 496);
			label4.Location = point;
			this.Label4.Name = "Label4";
			Label label41 = this.Label4;
			size = new System.Drawing.Size(11, 16);
			label41.Size = size;
			this.Label4.TabIndex = 30;
			this.Label4.Text = "Z";
			NumericUpDown zaxis = this.Zaxis;
			point = new Point(240, 496);
			zaxis.Location = point;
			NumericUpDown zaxis1 = this.Zaxis;
			numArray = new int[] { 6, 0, 0, 0 };
			num = new decimal(numArray);
			zaxis1.Maximum = num;
			NumericUpDown zaxis2 = this.Zaxis;
			numArray = new int[] { 6, 0, 0, -2147483648 };
			num = new decimal(numArray);
			zaxis2.Minimum = num;
			this.Zaxis.Name = "Zaxis";
			NumericUpDown zaxis3 = this.Zaxis;
			size = new System.Drawing.Size(40, 20);
			zaxis3.Size = size;
			this.Zaxis.TabIndex = 32;
			this.Label1.AutoSize = true;
			Label label1 = this.Label1;
			point = new Point(8, 496);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label11 = this.Label1;
			size = new System.Drawing.Size(34, 16);
			label11.Size = size;
			this.Label1.TabIndex = 24;
			this.Label1.Text = "TileID";
			TextBox tileID = this.TileID;
			point = new Point(48, 496);
			tileID.Location = point;
			this.TileID.Name = "TileID";
			TextBox tileID1 = this.TileID;
			size = new System.Drawing.Size(40, 20);
			tileID1.Size = size;
			this.TileID.TabIndex = 29;
			this.TileID.Text = "0";
			this.TileID.TextAlign = HorizontalAlignment.Right;
			this.Label5.AutoSize = true;
			Label label5 = this.Label5;
			point = new Point(288, 496);
			label5.Location = point;
			this.Label5.Name = "Label5";
			Label label51 = this.Label5;
			size = new System.Drawing.Size(25, 16);
			label51.Size = size;
			this.Label5.TabIndex = 33;
			this.Label5.Text = "Hue";
			TextBox hueID = this.HueID;
			point = new Point(320, 496);
			hueID.Location = point;
			this.HueID.Name = "HueID";
			this.HueID.ReadOnly = true;
			TextBox hueID1 = this.HueID;
			size = new System.Drawing.Size(40, 20);
			hueID1.Size = size;
			this.HueID.TabIndex = 34;
			this.HueID.Text = "0";
			this.HueID.TextAlign = HorizontalAlignment.Right;
			this.ToolBarButton11.Tag = "7";
			NumericUpDown numericUpDown5 = this.NumericUpDown5;
			point = new Point(672, 24);
			numericUpDown5.Location = point;
			this.NumericUpDown5.Name = "NumericUpDown5";
			NumericUpDown numericUpDown51 = this.NumericUpDown5;
			size = new System.Drawing.Size(40, 20);
			numericUpDown51.Size = size;
			this.NumericUpDown5.TabIndex = 37;
			this.ToolBarButton5.Tag = "1";
			this.ToolBarButton6.Tag = "2";
			this.ToolBarButton7.Tag = "3";
			this.ToolBarButton8.Tag = "4";
			this.ToolBarButton9.Tag = "5";
			this.ToolBarButton10.Tag = "6";
			this.Label7.AutoSize = true;
			Label label7 = this.Label7;
			point = new Point(520, 8);
			label7.Location = point;
			this.Label7.Name = "Label7";
			Label label71 = this.Label7;
			size = new System.Drawing.Size(50, 16);
			label71.Size = size;
			this.Label7.TabIndex = 38;
			this.Label7.Text = "Group ID";
			this.Panel1.BorderStyle = BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.Panel3);
			Panel panel1 = this.Panel1;
			point = new Point(8, 8);
			panel1.Location = point;
			this.Panel1.Name = "Panel1";
			Panel panel11 = this.Panel1;
			size = new System.Drawing.Size(344, 464);
			panel11.Size = size;
			this.Panel1.TabIndex = 23;
			this.Panel3.BorderStyle = BorderStyle.FixedSingle;
			Panel panel3 = this.Panel3;
			point = new Point(0, 0);
			panel3.Location = point;
			this.Panel3.Name = "Panel3";
			Panel panel31 = this.Panel3;
			size = new System.Drawing.Size(620, 820);
			panel31.Size = size;
			this.Panel3.TabIndex = 2;
			this.Panel2.Controls.Add(this.StaticZoom);
			this.Panel2.Controls.Add(this.TileDesc);
			this.Panel2.Controls.Add(this.PictureBox1);
			this.Panel2.Controls.Add(this.VScrollBar1);
			this.Panel2.Controls.Add(this.ToolBar3);
			Panel panel2 = this.Panel2;
			point = new Point(368, 56);
			panel2.Location = point;
			this.Panel2.Name = "Panel2";
			Panel panel21 = this.Panel2;
			size = new System.Drawing.Size(208, 456);
			panel21.Size = size;
			this.Panel2.TabIndex = 25;
			Button staticZoom = this.StaticZoom;
			point = new Point(104, 360);
			staticZoom.Location = point;
			this.StaticZoom.Name = "StaticZoom";
			Button button = this.StaticZoom;
			size = new System.Drawing.Size(56, 23);
			button.Size = size;
			this.StaticZoom.TabIndex = 17;
			this.StaticZoom.Text = "Zoom";
			TextBox tileDesc = this.TileDesc;
			point = new Point(8, 336);
			tileDesc.Location = point;
			this.TileDesc.Name = "TileDesc";
			TextBox tileDesc1 = this.TileDesc;
			size = new System.Drawing.Size(176, 20);
			tileDesc1.Size = size;
			this.TileDesc.TabIndex = 16;
			this.TileDesc.Text = "";
			this.PictureBox1.BorderStyle = BorderStyle.FixedSingle;
			PictureBox pictureBox1 = this.PictureBox1;
			point = new Point(8, 8);
			pictureBox1.Location = point;
			this.PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = this.PictureBox1;
			size = new System.Drawing.Size(176, 328);
			pictureBox.Size = size;
			this.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			this.PictureBox1.TabIndex = 1;
			this.PictureBox1.TabStop = false;
			this.VScrollBar1.Dock = DockStyle.Right;
			this.VScrollBar1.LargeChange = 16;
			VScrollBar vScrollBar1 = this.VScrollBar1;
			point = new Point(192, 0);
			vScrollBar1.Location = point;
			this.VScrollBar1.Maximum = 16535;
			this.VScrollBar1.Name = "VScrollBar1";
			VScrollBar vScrollBar11 = this.VScrollBar1;
			size = new System.Drawing.Size(16, 456);
			vScrollBar11.Size = size;
			this.VScrollBar1.TabIndex = 0;
			ToolBar.ToolBarButtonCollection buttons1 = this.ToolBar3.Buttons;
			toolBarButton3 = new ToolBarButton[] { this.ToolBarButton5, this.ToolBarButton6, this.ToolBarButton7, this.ToolBarButton8, this.ToolBarButton9, this.ToolBarButton10, this.ToolBarButton11, this.ToolBarButton12, this.ToolBarButton13 };
			buttons1.AddRange(toolBarButton3);
			ToolBar toolBar3 = this.ToolBar3;
			size = new System.Drawing.Size(30, 30);
			toolBar3.ButtonSize = size;
			this.ToolBar3.Divider = false;
			this.ToolBar3.Dock = DockStyle.None;
			this.ToolBar3.DropDownArrows = true;
			ToolBar toolBar31 = this.ToolBar3;
			point = new Point(8, 360);
			toolBar31.Location = point;
			this.ToolBar3.Name = "ToolBar3";
			this.ToolBar3.ShowToolTips = true;
			ToolBar toolBar32 = this.ToolBar3;
			size = new System.Drawing.Size(96, 94);
			toolBar32.Size = size;
			this.ToolBar3.TabIndex = 0;
			this.Label6.AutoSize = true;
			Label label6 = this.Label6;
			point = new Point(672, 8);
			label6.Location = point;
			this.Label6.Name = "Label6";
			Label label61 = this.Label6;
			size = new System.Drawing.Size(27, 16);
			label61.Size = size;
			this.Label6.TabIndex = 36;
			this.Label6.Text = "Freq";
			System.Windows.Forms.Menu.MenuItemCollection menuItems = this.MainMenu1.MenuItems;
			MenuItem[] menuFile = new MenuItem[] { this.MenuFile };
			menuItems.AddRange(menuFile);
			this.MenuFile.Index = 0;
			System.Windows.Forms.Menu.MenuItemCollection menuItemCollections = this.MenuFile.MenuItems;
			menuFile = new MenuItem[] { this.MenuNew, this.MenuLoad, this.MenuSave };
			menuItemCollections.AddRange(menuFile);
			this.MenuFile.Text = "File";
			this.MenuNew.Index = 0;
			this.MenuNew.Text = "New Random Static Table";
			this.MenuLoad.Index = 1;
			this.MenuLoad.Text = "Load Random Static Table";
			this.MenuSave.Index = 2;
			this.MenuSave.Text = "Save Random Static Table";
			this.Label10.AutoSize = true;
			Label label10 = this.Label10;
			point = new Point(376, 8);
			label10.Location = point;
			this.Label10.Name = "Label10";
			Label label101 = this.Label10;
			size = new System.Drawing.Size(51, 16);
			label101.Size = size;
			this.Label10.TabIndex = 40;
			this.Label10.Text = "Filename";
			TextBox textBox1 = this.TextBox1;
			point = new Point(376, 24);
			textBox1.Location = point;
			this.TextBox1.Name = "TextBox1";
			TextBox textBox11 = this.TextBox1;
			size = new System.Drawing.Size(136, 20);
			textBox11.Size = size;
			this.TextBox1.TabIndex = 41;
			this.TextBox1.Text = "";
			size = new System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new System.Drawing.Size(856, 525);
			this.ClientSize = size;
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Label10);
			this.Controls.Add(this.TabControl1);
			this.Controls.Add(this.VScrollBar2);
			this.Controls.Add(this.HScrollBar1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Xaxis);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Yaxis);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Zaxis);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TileID);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.HueID);
			this.Controls.Add(this.NumericUpDown5);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.GroupSelect);
			this.Menu = this.MainMenu1;
			this.Name = "SEdit";
			this.Text = "Random Static Editor";
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.Panel6.ResumeLayout(false);
			((ISupportInitialize)this.NumericUpDown4).EndInit();
			this.TabPage2.ResumeLayout(false);
			this.Panel5.ResumeLayout(false);
			this.TabPage3.ResumeLayout(false);
			((ISupportInitialize)this.Xaxis).EndInit();
			((ISupportInitialize)this.Yaxis).EndInit();
			((ISupportInitialize)this.Zaxis).EndInit();
			((ISupportInitialize)this.NumericUpDown5).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.ResumeLayout(false);
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

		[STAThread]
		public static void Main()
		{
			Application.Run(new SEdit());
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
			this.iRandomStatic = new RandomStatics();
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

		private void ToolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			RandomStaticCollection selectedItem = (RandomStaticCollection)this.ListBox1.SelectedItem;
			if (selectedItem != null)
			{
				object tag = e.Button.Tag;
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

		private void ToolBar2_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			object tag = e.Button.Tag;
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

		private void ToolBar3_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			short num = Convert.ToInt16(this.Xaxis.Value);
			short y = Convert.ToInt16(this.Yaxis.Value);
			RandomStatic selectedItem = (RandomStatic)this.ListBox2.SelectedItem;
			if (selectedItem != null)
			{
				num = selectedItem.X;
				y = selectedItem.Y;
			}
			object tag = e.Button.Tag;
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
			if (Art.GetStatic(this.VScrollBar1.Value) != null)
			{
				this.TileID.Text = this.VScrollBar1.Value.ToString();
				this.PictureBox1.Image = Art.GetStatic(this.VScrollBar1.Value);
				this.PropertyGrid1.SelectedObject = TileData.ItemTable[this.VScrollBar1.Value];
				this.TileDesc.Text = string.Format("{0} ({1})", TileData.ItemTable[this.VScrollBar1.Value].Name, this.VScrollBar1.Value);
			}
		}

		private void VScrollBar1_ValueChanged(object sender, EventArgs e)
		{
			if (Art.GetStatic(this.VScrollBar1.Value) != null)
			{
				this.TileID.Text = this.VScrollBar1.Value.ToString();
				this.PictureBox1.Image = Art.GetStatic(this.VScrollBar1.Value);
				this.PropertyGrid1.SelectedObject = TileData.ItemTable[this.VScrollBar1.Value];
				this.TileDesc.Text = string.Format("{0} ({1})", TileData.ItemTable[this.VScrollBar1.Value].Name, this.VScrollBar1.Value);
			}
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