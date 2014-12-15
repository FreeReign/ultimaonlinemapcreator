using Logger;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace Mul2Bmp
{
	public class Mul2Bmp : Form
	{
		[AccessedThroughProperty("ComboBox2")]
		private ComboBox _ComboBox2;

		[AccessedThroughProperty("AltitudeFile")]
		private TextBox _AltitudeFile;

		[AccessedThroughProperty("MenuMake")]
		private MenuItem _MenuMake;

		[AccessedThroughProperty("Path2Image")]
		private TextBox _Path2Image;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("FolderBrowserDialog1")]
		private FolderBrowserDialog _FolderBrowserDialog1;

		[AccessedThroughProperty("TerrainFile")]
		private TextBox _TerrainFile;

		[AccessedThroughProperty("MenuImage")]
		private MenuItem _MenuImage;

		[AccessedThroughProperty("MenuItem1")]
		private MenuItem _MenuItem1;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[AccessedThroughProperty("MenuMul")]
		private MenuItem _MenuMul;

		[AccessedThroughProperty("ProjectName")]
		private TextBox _ProjectName;

		[AccessedThroughProperty("MainMenu1")]
		private MainMenu _MainMenu1;

		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		[AccessedThroughProperty("Path2Mul")]
		private TextBox _Path2Mul;

		private IContainer components;

		private LoggerForm iLogger;

		internal virtual TextBox AltitudeFile
		{
			get
			{
				return this._AltitudeFile;
			}
			set
			{
				this._AltitudeFile == null;
				this._AltitudeFile = value;
				this._AltitudeFile == null;
			}
		}

		internal virtual ComboBox ComboBox2
		{
			get
			{
				return this._ComboBox2;
			}
			set
			{
				this._ComboBox2 == null;
				this._ComboBox2 = value;
				this._ComboBox2 == null;
			}
		}

		internal virtual FolderBrowserDialog FolderBrowserDialog1
		{
			get
			{
				return this._FolderBrowserDialog1;
			}
			set
			{
				this._FolderBrowserDialog1 == null;
				this._FolderBrowserDialog1 = value;
				this._FolderBrowserDialog1 == null;
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

		internal virtual MenuItem MenuImage
		{
			get
			{
				return this._MenuImage;
			}
			set
			{
				if (this._MenuImage != null)
				{
					Mul2Bmp mul2Bmp = this;
					this._MenuImage.Click -= new EventHandler(mul2Bmp.MenuImage_Click);
				}
				this._MenuImage = value;
				if (this._MenuImage != null)
				{
					Mul2Bmp mul2Bmp1 = this;
					this._MenuImage.Click += new EventHandler(mul2Bmp1.MenuImage_Click);
				}
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
				this._MenuItem1 == null;
				this._MenuItem1 = value;
				this._MenuItem1 == null;
			}
		}

		internal virtual MenuItem MenuMake
		{
			get
			{
				return this._MenuMake;
			}
			set
			{
				if (this._MenuMake != null)
				{
					Mul2Bmp mul2Bmp = this;
					this._MenuMake.Click -= new EventHandler(mul2Bmp.MenuMake_Click);
				}
				this._MenuMake = value;
				if (this._MenuMake != null)
				{
					Mul2Bmp mul2Bmp1 = this;
					this._MenuMake.Click += new EventHandler(mul2Bmp1.MenuMake_Click);
				}
			}
		}

		internal virtual MenuItem MenuMul
		{
			get
			{
				return this._MenuMul;
			}
			set
			{
				if (this._MenuMul != null)
				{
					Mul2Bmp mul2Bmp = this;
					this._MenuMul.Click -= new EventHandler(mul2Bmp.MenuMul_Click);
				}
				this._MenuMul = value;
				if (this._MenuMul != null)
				{
					Mul2Bmp mul2Bmp1 = this;
					this._MenuMul.Click += new EventHandler(mul2Bmp1.MenuMul_Click);
				}
			}
		}

		internal virtual TextBox Path2Image
		{
			get
			{
				return this._Path2Image;
			}
			set
			{
				this._Path2Image == null;
				this._Path2Image = value;
				this._Path2Image == null;
			}
		}

		internal virtual TextBox Path2Mul
		{
			get
			{
				return this._Path2Mul;
			}
			set
			{
				this._Path2Mul == null;
				this._Path2Mul = value;
				this._Path2Mul == null;
			}
		}

		internal virtual ProgressBar ProgressBar1
		{
			get
			{
				return this._ProgressBar1;
			}
			set
			{
				this._ProgressBar1 == null;
				this._ProgressBar1 = value;
				this._ProgressBar1 == null;
			}
		}

		internal virtual TextBox ProjectName
		{
			get
			{
				return this._ProjectName;
			}
			set
			{
				this._ProjectName == null;
				this._ProjectName = value;
				this._ProjectName == null;
			}
		}

		internal virtual TextBox TerrainFile
		{
			get
			{
				return this._TerrainFile;
			}
			set
			{
				this._TerrainFile == null;
				this._TerrainFile = value;
				this._TerrainFile == null;
			}
		}

		public Mul2Bmp()
		{
			Mul2Bmp mul2Bmp = this;
			base.Load += new EventHandler(mul2Bmp.Mul2Bmp_Load);
			this.iLogger = new LoggerForm();
			this.InitializeComponent();
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

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label5 = new Label();
			this.ComboBox2 = new ComboBox();
			this.Label6 = new Label();
			this.Label7 = new Label();
			this.AltitudeFile = new TextBox();
			this.ProjectName = new TextBox();
			this.Label2 = new Label();
			this.Label1 = new Label();
			this.Path2Image = new TextBox();
			this.TerrainFile = new TextBox();
			this.ProgressBar1 = new ProgressBar();
			this.Label3 = new Label();
			this.Path2Mul = new TextBox();
			this.MainMenu1 = new MainMenu();
			this.MenuItem1 = new MenuItem();
			this.MenuMul = new MenuItem();
			this.MenuImage = new MenuItem();
			this.MenuMake = new MenuItem();
			this.FolderBrowserDialog1 = new FolderBrowserDialog();
			this.SuspendLayout();
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = Color.Black;
			Label label5 = this.Label5;
			Point point = new Point(8, 144);
			label5.Location = point;
			this.Label5.Name = "Label5";
			Label label = this.Label5;
			System.Drawing.Size size = new System.Drawing.Size(89, 16);
			label.Size = size;
			this.Label5.TabIndex = 44;
			this.Label5.Text = "Select Map Size:";
			ComboBox comboBox2 = this.ComboBox2;
			point = new Point(8, 160);
			comboBox2.Location = point;
			this.ComboBox2.Name = "ComboBox2";
			ComboBox comboBox = this.ComboBox2;
			size = new System.Drawing.Size(184, 21);
			comboBox.Size = size;
			this.ComboBox2.TabIndex = 43;
			this.Label6.AutoSize = true;
			Label label6 = this.Label6;
			point = new Point(120, 184);
			label6.Location = point;
			this.Label6.Name = "Label6";
			Label label61 = this.Label6;
			size = new System.Drawing.Size(102, 16);
			label61.Size = size;
			this.Label6.TabIndex = 58;
			this.Label6.Text = "Altitude Image Map";
			this.Label7.AutoSize = true;
			Label label7 = this.Label7;
			point = new Point(8, 184);
			label7.Location = point;
			this.Label7.Name = "Label7";
			this.Label7.TabIndex = 57;
			this.Label7.Text = "Terrain Image Map";
			TextBox altitudeFile = this.AltitudeFile;
			point = new Point(120, 200);
			altitudeFile.Location = point;
			this.AltitudeFile.Name = "AltitudeFile";
			TextBox textBox = this.AltitudeFile;
			size = new System.Drawing.Size(104, 20);
			textBox.Size = size;
			this.AltitudeFile.TabIndex = 56;
			this.AltitudeFile.Text = "Altitude.bmp";
			TextBox projectName = this.ProjectName;
			point = new Point(8, 104);
			projectName.Location = point;
			this.ProjectName.Name = "ProjectName";
			TextBox projectName1 = this.ProjectName;
			size = new System.Drawing.Size(152, 20);
			projectName1.Size = size;
			this.ProjectName.TabIndex = 54;
			this.ProjectName.Text = "";
			this.Label2.AutoSize = true;
			Label label2 = this.Label2;
			point = new Point(8, 88);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new System.Drawing.Size(73, 16);
			label21.Size = size;
			this.Label2.TabIndex = 53;
			this.Label2.Text = "Project Name";
			this.Label1.AutoSize = true;
			Label label1 = this.Label1;
			point = new Point(8, 48);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label11 = this.Label1;
			size = new System.Drawing.Size(65, 16);
			label11.Size = size;
			this.Label1.TabIndex = 52;
			this.Label1.Text = "Image Path:";
			TextBox path2Image = this.Path2Image;
			point = new Point(8, 64);
			path2Image.Location = point;
			this.Path2Image.Name = "Path2Image";
			TextBox path2Image1 = this.Path2Image;
			size = new System.Drawing.Size(280, 20);
			path2Image1.Size = size;
			this.Path2Image.TabIndex = 51;
			this.Path2Image.Text = "";
			TextBox terrainFile = this.TerrainFile;
			point = new Point(8, 200);
			terrainFile.Location = point;
			this.TerrainFile.Name = "TerrainFile";
			TextBox terrainFile1 = this.TerrainFile;
			size = new System.Drawing.Size(104, 20);
			terrainFile1.Size = size;
			this.TerrainFile.TabIndex = 55;
			this.TerrainFile.Text = "Terrain.bmp";
			this.ProgressBar1.Dock = DockStyle.Bottom;
			ProgressBar progressBar1 = this.ProgressBar1;
			point = new Point(0, 235);
			progressBar1.Location = point;
			this.ProgressBar1.Name = "ProgressBar1";
			ProgressBar progressBar = this.ProgressBar1;
			size = new System.Drawing.Size(294, 16);
			progressBar.Size = size;
			this.ProgressBar1.TabIndex = 59;
			this.Label3.AutoSize = true;
			Label label3 = this.Label3;
			point = new Point(8, 8);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label31 = this.Label3;
			size = new System.Drawing.Size(64, 16);
			label31.Size = size;
			this.Label3.TabIndex = 62;
			this.Label3.Text = "Path to Mul:";
			TextBox path2Mul = this.Path2Mul;
			point = new Point(8, 24);
			path2Mul.Location = point;
			this.Path2Mul.Name = "Path2Mul";
			TextBox path2Mul1 = this.Path2Mul;
			size = new System.Drawing.Size(280, 20);
			path2Mul1.Size = size;
			this.Path2Mul.TabIndex = 61;
			this.Path2Mul.Text = "";
			System.Windows.Forms.Menu.MenuItemCollection menuItems = this.MainMenu1.MenuItems;
			MenuItem[] menuItem1 = new MenuItem[] { this.MenuItem1, this.MenuMake };
			menuItems.AddRange(menuItem1);
			this.MenuItem1.Index = 0;
			System.Windows.Forms.Menu.MenuItemCollection menuItemCollections = this.MenuItem1.MenuItems;
			menuItem1 = new MenuItem[] { this.MenuMul, this.MenuImage };
			menuItemCollections.AddRange(menuItem1);
			this.MenuItem1.Text = "File";
			this.MenuMul.Index = 0;
			this.MenuMul.Text = "Mul Path";
			this.MenuImage.Index = 1;
			this.MenuImage.Text = "Image Path";
			this.MenuMake.Index = 1;
			this.MenuMake.Text = "Make";
			this.FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
			size = new System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = size;
			this.BackColor = Color.FromArgb(224, 224, 224);
			size = new System.Drawing.Size(294, 251);
			this.ClientSize = size;
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Path2Mul);
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.AltitudeFile);
			this.Controls.Add(this.ProjectName);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Path2Image);
			this.Controls.Add(this.TerrainFile);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.ComboBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Menu = this.MainMenu1;
			this.Name = "Mul2Bmp";
			this.Text = "Make Mul To Bmp";
			this.ResumeLayout(false);
		}

		[STAThread]
		public static void Main()
		{
			Application.Run(new Mul2Bmp());
		}

		private void MenuImage_Click(object sender, EventArgs e)
		{
			this.FolderBrowserDialog1.SelectedPath = Directory.GetCurrentDirectory();
			if (this.FolderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				this.Path2Image.Text = this.FolderBrowserDialog1.SelectedPath;
			}
		}

		private void MenuMake_Click(object sender, EventArgs e)
		{
			Interaction.MsgBox("It is illegal to convert the OSI maps into BMP using this tool.\r\nDo you wish to continue ?", MsgBoxStyle.OKOnly, null) != MsgBoxResult.OK;
		}

		private void MenuMul_Click(object sender, EventArgs e)
		{
			this.FolderBrowserDialog1.SelectedPath = Directory.GetCurrentDirectory();
			if (this.FolderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				this.Path2Mul.Text = this.FolderBrowserDialog1.SelectedPath;
			}
		}

		private void Mul2Bmp_Load(object sender, EventArgs e)
		{
			IEnumerator enumerator = null;
			string str = string.Format("{0}\\Data\\System\\{1}", Directory.GetCurrentDirectory(), "MapInfo.xml");
			this.Path2Image.Text = Directory.GetCurrentDirectory();
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(str);
				try
				{
					this.ComboBox2.Items.Clear();
					try
					{
						enumerator = xmlDocument.SelectNodes("//Maps/Map").GetEnumerator();
						while (enumerator.MoveNext())
						{
							MapInfo mapInfo = new MapInfo((XmlElement)enumerator.Current);
							this.ComboBox2.Items.Add(mapInfo);
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
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					Exception exception = exception1;
					this.iLogger.LogMessage(string.Format("XML Error:{0}", exception.Message));
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception exception2)
			{
				ProjectData.SetProjectError(exception2);
				this.iLogger.LogMessage(string.Format("Unable to find:{0}", str));
				ProjectData.ClearProjectError();
			}
		}
	}
}