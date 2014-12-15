using Altitude;
using Logger;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using Terrain;

namespace NewMapImage
{
	public class MakeMapImage : Form
	{
		[AccessedThroughProperty("ComboBox2")]
		private ComboBox _ComboBox2;

		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		[AccessedThroughProperty("ProjectName")]
		private TextBox _ProjectName;

		[AccessedThroughProperty("AltitudeFile")]
		private TextBox _AltitudeFile;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("MenuPath")]
		private MenuItem _MenuPath;

		[AccessedThroughProperty("MenuTerrain")]
		private MenuItem _MenuTerrain;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("ProjectPath")]
		private TextBox _ProjectPath;

		[AccessedThroughProperty("MainMenu1")]
		private MainMenu _MainMenu1;

		[AccessedThroughProperty("Dungeon")]
		private CheckBox _Dungeon;

		[AccessedThroughProperty("TerrainFile")]
		private TextBox _TerrainFile;

		private IContainer components;

		private ClsTerrainTable iTerrain;

		private ClsAltitudeTable iAltitude;

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

		internal virtual ComboBox ComboBox1
		{
			get
			{
				return this._ComboBox1;
			}
			set
			{
				this._ComboBox1 == null;
				this._ComboBox1 = value;
				this._ComboBox1 == null;
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

		internal virtual CheckBox Dungeon
		{
			get
			{
				return this._Dungeon;
			}
			set
			{
				this._Dungeon == null;
				this._Dungeon = value;
				this._Dungeon == null;
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

		internal virtual MenuItem MenuPath
		{
			get
			{
				return this._MenuPath;
			}
			set
			{
				if (this._MenuPath != null)
				{
					MakeMapImage makeMapImage = this;
					this._MenuPath.Click -= new EventHandler(makeMapImage.MenuPath_Click);
				}
				this._MenuPath = value;
				if (this._MenuPath != null)
				{
					MakeMapImage makeMapImage1 = this;
					this._MenuPath.Click += new EventHandler(makeMapImage1.MenuPath_Click);
				}
			}
		}

		internal virtual MenuItem MenuTerrain
		{
			get
			{
				return this._MenuTerrain;
			}
			set
			{
				if (this._MenuTerrain != null)
				{
					MakeMapImage makeMapImage = this;
					this._MenuTerrain.Click -= new EventHandler(makeMapImage.MenuTerrain_Click);
				}
				this._MenuTerrain = value;
				if (this._MenuTerrain != null)
				{
					MakeMapImage makeMapImage1 = this;
					this._MenuTerrain.Click += new EventHandler(makeMapImage1.MenuTerrain_Click);
				}
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

		internal virtual TextBox ProjectPath
		{
			get
			{
				return this._ProjectPath;
			}
			set
			{
				this._ProjectPath == null;
				this._ProjectPath = value;
				this._ProjectPath == null;
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

		public MakeMapImage()
		{
			MakeMapImage makeMapImage = this;
			base.Load += new EventHandler(makeMapImage.MakeMapImage_Load);
			this.iTerrain = new ClsTerrainTable();
			this.iAltitude = new ClsAltitudeTable();
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
			this.ComboBox1 = new ComboBox();
			this.Label3 = new Label();
			this.Dungeon = new CheckBox();
			this.ProjectName = new TextBox();
			this.Label2 = new Label();
			this.Label1 = new Label();
			this.ProjectPath = new TextBox();
			this.TerrainFile = new TextBox();
			this.ComboBox2 = new ComboBox();
			this.Label5 = new Label();
			this.AltitudeFile = new TextBox();
			this.MainMenu1 = new MainMenu();
			this.MenuPath = new MenuItem();
			this.MenuTerrain = new MenuItem();
			this.Label4 = new Label();
			this.Label6 = new Label();
			this.Label7 = new Label();
			this.ProgressBar1 = new ProgressBar();
			this.SuspendLayout();
			ComboBox comboBox1 = this.ComboBox1;
			Point point = new Point(200, 72);
			comboBox1.Location = point;
			this.ComboBox1.Name = "ComboBox1";
			ComboBox comboBox = this.ComboBox1;
			System.Drawing.Size size = new System.Drawing.Size(144, 21);
			comboBox.Size = size;
			this.ComboBox1.Sorted = true;
			this.ComboBox1.TabIndex = 38;
			this.Label3.AutoSize = true;
			Label label3 = this.Label3;
			point = new Point(200, 56);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label = this.Label3;
			size = new System.Drawing.Size(79, 16);
			label.Size = size;
			this.Label3.TabIndex = 37;
			this.Label3.Text = "Default Terrain";
			CheckBox dungeon = this.Dungeon;
			point = new Point(352, 72);
			dungeon.Location = point;
			this.Dungeon.Name = "Dungeon";
			CheckBox checkBox = this.Dungeon;
			size = new System.Drawing.Size(24, 24);
			checkBox.Size = size;
			this.Dungeon.TabIndex = 36;
			TextBox projectName = this.ProjectName;
			point = new Point(272, 24);
			projectName.Location = point;
			this.ProjectName.Name = "ProjectName";
			TextBox textBox = this.ProjectName;
			size = new System.Drawing.Size(152, 20);
			textBox.Size = size;
			this.ProjectName.TabIndex = 35;
			this.ProjectName.Text = "";
			this.Label2.AutoSize = true;
			Label label2 = this.Label2;
			point = new Point(272, 8);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new System.Drawing.Size(73, 16);
			label21.Size = size;
			this.Label2.TabIndex = 34;
			this.Label2.Text = "Project Name";
			this.Label1.AutoSize = true;
			Label label1 = this.Label1;
			point = new Point(8, 8);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label11 = this.Label1;
			size = new System.Drawing.Size(31, 16);
			label11.Size = size;
			this.Label1.TabIndex = 33;
			this.Label1.Text = "Path:";
			TextBox projectPath = this.ProjectPath;
			point = new Point(8, 24);
			projectPath.Location = point;
			this.ProjectPath.Name = "ProjectPath";
			TextBox projectPath1 = this.ProjectPath;
			size = new System.Drawing.Size(256, 20);
			projectPath1.Size = size;
			this.ProjectPath.TabIndex = 32;
			this.ProjectPath.Text = "";
			TextBox terrainFile = this.TerrainFile;
			point = new Point(8, 120);
			terrainFile.Location = point;
			this.TerrainFile.Name = "TerrainFile";
			TextBox terrainFile1 = this.TerrainFile;
			size = new System.Drawing.Size(104, 20);
			terrainFile1.Size = size;
			this.TerrainFile.TabIndex = 41;
			this.TerrainFile.Text = "Terrain.bmp";
			ComboBox comboBox2 = this.ComboBox2;
			point = new Point(8, 72);
			comboBox2.Location = point;
			this.ComboBox2.Name = "ComboBox2";
			ComboBox comboBox21 = this.ComboBox2;
			size = new System.Drawing.Size(184, 21);
			comboBox21.Size = size;
			this.ComboBox2.TabIndex = 40;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = Color.Black;
			Label label5 = this.Label5;
			point = new Point(8, 56);
			label5.Location = point;
			this.Label5.Name = "Label5";
			Label label51 = this.Label5;
			size = new System.Drawing.Size(89, 16);
			label51.Size = size;
			this.Label5.TabIndex = 42;
			this.Label5.Text = "Select Map Size:";
			TextBox altitudeFile = this.AltitudeFile;
			point = new Point(120, 120);
			altitudeFile.Location = point;
			this.AltitudeFile.Name = "AltitudeFile";
			TextBox altitudeFile1 = this.AltitudeFile;
			size = new System.Drawing.Size(104, 20);
			altitudeFile1.Size = size;
			this.AltitudeFile.TabIndex = 47;
			this.AltitudeFile.Text = "Altitude.bmp";
			System.Windows.Forms.Menu.MenuItemCollection menuItems = this.MainMenu1.MenuItems;
			MenuItem[] menuPath = new MenuItem[] { this.MenuPath, this.MenuTerrain };
			menuItems.AddRange(menuPath);
			this.MenuPath.Index = 0;
			this.MenuPath.Text = "Path";
			this.MenuTerrain.Index = 1;
			this.MenuTerrain.Text = "Make Terrain/Altitude Image";
			this.Label4.AutoSize = true;
			Label label4 = this.Label4;
			point = new Point(352, 56);
			label4.Location = point;
			this.Label4.Name = "Label4";
			Label label41 = this.Label4;
			size = new System.Drawing.Size(77, 16);
			label41.Size = size;
			this.Label4.TabIndex = 48;
			this.Label4.Text = "Dungeon Area";
			this.Label6.AutoSize = true;
			Label label6 = this.Label6;
			point = new Point(120, 104);
			label6.Location = point;
			this.Label6.Name = "Label6";
			Label label61 = this.Label6;
			size = new System.Drawing.Size(102, 16);
			label61.Size = size;
			this.Label6.TabIndex = 50;
			this.Label6.Text = "Altitude Image Map";
			this.Label7.AutoSize = true;
			Label label7 = this.Label7;
			point = new Point(8, 104);
			label7.Location = point;
			this.Label7.Name = "Label7";
			this.Label7.TabIndex = 49;
			this.Label7.Text = "Terrain Image Map";
			this.ProgressBar1.Dock = DockStyle.Bottom;
			ProgressBar progressBar1 = this.ProgressBar1;
			point = new Point(0, 151);
			progressBar1.Location = point;
			this.ProgressBar1.Name = "ProgressBar1";
			ProgressBar progressBar = this.ProgressBar1;
			size = new System.Drawing.Size(430, 16);
			progressBar.Size = size;
			this.ProgressBar1.TabIndex = 51;
			size = new System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = size;
			this.BackColor = Color.FromArgb(224, 224, 224);
			size = new System.Drawing.Size(430, 167);
			this.ClientSize = size;
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.AltitudeFile);
			this.Controls.Add(this.ProjectName);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.ProjectPath);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.ComboBox2);
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Dungeon);
			this.Controls.Add(this.TerrainFile);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Menu = this.MainMenu1;
			this.Name = "MakeMapImage";
			this.Text = "Make New Image Map";
			this.ResumeLayout(false);
		}

		[STAThread]
		public static void Main()
		{
			Application.Run(new MakeMapImage());
		}

		public Bitmap MakeAltMap(int xSize, int ySize, byte DefaultAlt, bool Dungeon)
		{
			Bitmap bitmap = new Bitmap(xSize, ySize, PixelFormat.Format8bppIndexed)
			{
				Palette = this.iAltitude.GetAltPalette()
			};
			Rectangle rectangle = new Rectangle(0, 0, xSize, ySize);
			BitmapData bitmapDatum = bitmap.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
			IntPtr scan0 = bitmapDatum.Scan0;
			int width = checked(bitmapDatum.Width * bitmapDatum.Height);
			byte[] defaultAlt = new byte[checked(checked(width - 1) + 1)];
			Marshal.Copy(scan0, defaultAlt, 0, width);
			if (!Dungeon)
			{
				int num = checked(xSize - 1);
				for (int i = 0; i <= num; i++)
				{
					int num1 = checked(ySize - 1);
					for (int j = 0; j <= num1; j++)
					{
						defaultAlt[checked(checked(j * xSize) + i)] = DefaultAlt;
					}
				}
			}
			else
			{
				int num2 = checked(xSize - 1);
				for (int k = 0; k <= num2; k++)
				{
					int num3 = checked(ySize - 1);
					for (int l = 0; l <= num3; l++)
					{
						if (k <= 5119)
						{
							defaultAlt[checked(checked(l * xSize) + k)] = DefaultAlt;
						}
						else
						{
							defaultAlt[checked(checked(l * xSize) + k)] = 72;
						}
					}
				}
			}
			Marshal.Copy(defaultAlt, 0, scan0, width);
			bitmap.UnlockBits(bitmapDatum);
			return bitmap;
		}

		private void MakeMapImage_Load(object sender, EventArgs e)
		{
			IEnumerator enumerator = null;
			this.iLogger.Show();
			int x = checked(this.iLogger.Location.X + 100);
			Point location = this.iLogger.Location;
			Point point = new Point(x, checked(location.Y + 100));
			this.Location = point;
			this.iTerrain.Load();
			this.iAltitude.Load();
			string str = string.Format("{0}\\Data\\System\\{1}", Directory.GetCurrentDirectory(), "MapInfo.xml");
			this.ProjectPath.Text = Directory.GetCurrentDirectory();
			this.iTerrain.Display(this.ComboBox1);
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

		public Bitmap MakeTerrainMap(int xSize, int ySize, byte DefaultTerrain, bool Dungeon)
		{
			Bitmap bitmap = new Bitmap(xSize, ySize, PixelFormat.Format8bppIndexed)
			{
				Palette = this.iTerrain.GetPalette()
			};
			Rectangle rectangle = new Rectangle(0, 0, xSize, ySize);
			BitmapData bitmapDatum = bitmap.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
			IntPtr scan0 = bitmapDatum.Scan0;
			int width = checked(bitmapDatum.Width * bitmapDatum.Height);
			byte[] defaultTerrain = new byte[checked(checked(width - 1) + 1)];
			Marshal.Copy(scan0, defaultTerrain, 0, width);
			if (!Dungeon)
			{
				int num = checked(xSize - 1);
				for (int i = 0; i <= num; i++)
				{
					int num1 = checked(ySize - 1);
					for (int j = 0; j <= num1; j++)
					{
						defaultTerrain[checked(checked(j * xSize) + i)] = DefaultTerrain;
					}
				}
			}
			else
			{
				int num2 = checked(xSize - 1);
				for (int k = 0; k <= num2; k++)
				{
					int num3 = checked(ySize - 1);
					for (int l = 0; l <= num3; l++)
					{
						if (k <= 5119)
						{
							defaultTerrain[checked(checked(l * xSize) + k)] = DefaultTerrain;
						}
						else
						{
							defaultTerrain[checked(checked(l * xSize) + k)] = 19;
						}
					}
				}
			}
			Marshal.Copy(defaultTerrain, 0, scan0, width);
			bitmap.UnlockBits(bitmapDatum);
			return bitmap;
		}

		private void MenuPath_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
			{
				SelectedPath = this.ProjectPath.Text
			};
			if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				this.ProjectPath.Text = folderBrowserDialog.SelectedPath;
			}
		}

		private void MenuTerrain_Click(object sender, EventArgs e)
		{
			byte altID;
			byte groupID;
			MapInfo selectedItem = (MapInfo)this.ComboBox2.SelectedItem;
			if (selectedItem == null)
			{
				this.iLogger.LogMessage("Error: Select a Map Type.");
			}
			else if (StringType.StrCmp(this.ProjectName.Text, string.Empty, false) != 0)
			{
				string str = string.Format("{0}/{1}/Map{2}", this.ProjectPath.Text, this.ProjectName.Text, selectedItem.MapNumber);
				if (!Directory.Exists(str))
				{
					Directory.CreateDirectory(str);
				}
				if (this.ComboBox1.SelectedItem != null)
				{
					ClsTerrain clsTerrain = (ClsTerrain)this.ComboBox1.SelectedItem;
					groupID = checked((byte)clsTerrain.GroupID);
					altID = clsTerrain.AltID;
				}
				else
				{
					groupID = 9;
					altID = 66;
				}
				this.iLogger.LogMessage("Creating Terrain Image.");
				this.iLogger.StartTask();
				try
				{
					string str1 = string.Format("{0}/{1}", str, this.TerrainFile.Text);
					Bitmap palette = this.MakeTerrainMap(selectedItem.XSize, selectedItem.YSize, groupID, this.Dungeon.Checked);
					palette.Palette = this.iTerrain.GetPalette();
					palette.Save(str1, ImageFormat.Bmp);
					palette.Dispose();
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					this.iLogger.LogMessage("Error: Problem creating Terrain Image.");
					ProjectData.ClearProjectError();
				}
				this.iLogger.EndTask();
				this.iLogger.LogTimeStamp();
				this.iLogger.LogMessage("Creating Altitude Image.");
				this.iLogger.StartTask();
				try
				{
					string str2 = string.Format("{0}/{1}", str, this.AltitudeFile.Text);
					Bitmap altPalette = this.MakeAltMap(selectedItem.XSize, selectedItem.YSize, altID, this.Dungeon.Checked);
					altPalette.Palette = this.iAltitude.GetAltPalette();
					altPalette.Save(str2, ImageFormat.Bmp);
					altPalette.Dispose();
				}
				catch (Exception exception2)
				{
					ProjectData.SetProjectError(exception2);
					Exception exception1 = exception2;
					this.iLogger.LogMessage("Error: Problem creating Altitude Image.");
					this.iLogger.LogMessage(exception1.Message);
					ProjectData.ClearProjectError();
				}
				this.iLogger.EndTask();
				this.iLogger.LogTimeStamp();
				this.iLogger.LogMessage("Done.");
			}
			else
			{
				this.iLogger.LogMessage("Error: Enter a project Name.");
			}
		}
	}
}