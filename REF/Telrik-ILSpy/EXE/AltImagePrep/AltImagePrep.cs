using Altitude;
using Logger;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Terrain;

namespace AltImagePrep
{
	public class AltImagePrep : Form
	{
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		[AccessedThroughProperty("MenuPath")]
		private MenuItem _MenuPath;

		[AccessedThroughProperty("AltitudeFile")]
		private TextBox _AltitudeFile;

		[AccessedThroughProperty("TerrainFile")]
		private TextBox _TerrainFile;

		[AccessedThroughProperty("MenuMake")]
		private MenuItem _MenuMake;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("ProjectPath")]
		private TextBox _ProjectPath;

		[AccessedThroughProperty("MainMenu1")]
		private MainMenu _MainMenu1;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

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
					AltImagePrep altImagePrep = this;
					this._MenuMake.Click -= new EventHandler(altImagePrep.MenuMake_Click);
				}
				this._MenuMake = value;
				if (this._MenuMake != null)
				{
					AltImagePrep altImagePrep1 = this;
					this._MenuMake.Click += new EventHandler(altImagePrep1.MenuMake_Click);
				}
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
					AltImagePrep altImagePrep = this;
					this._MenuPath.Click -= new EventHandler(altImagePrep.MenuPath_Click);
				}
				this._MenuPath = value;
				if (this._MenuPath != null)
				{
					AltImagePrep altImagePrep1 = this;
					this._MenuPath.Click += new EventHandler(altImagePrep1.MenuPath_Click);
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

		public AltImagePrep()
		{
			AltImagePrep altImagePrep = this;
			base.Load += new EventHandler(altImagePrep.AltImagePrep_Load);
			this.iTerrain = new ClsTerrainTable();
			this.iAltitude = new ClsAltitudeTable();
			this.iLogger = new LoggerForm();
			this.InitializeComponent();
		}

		private void AltImagePrep_Load(object sender, EventArgs e)
		{
			this.iLogger.Show();
			int x = checked(this.iLogger.Location.X + 100);
			Point location = this.iLogger.Location;
			Point point = new Point(x, checked(location.Y + 100));
			this.Location = point;
			this.ProjectPath.Text = Directory.GetCurrentDirectory();
			this.iTerrain.Load();
			this.iAltitude.Load();
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
			this.Label3 = new Label();
			this.Label2 = new Label();
			this.AltitudeFile = new TextBox();
			this.TerrainFile = new TextBox();
			this.ProjectPath = new TextBox();
			this.MainMenu1 = new MainMenu();
			this.MenuPath = new MenuItem();
			this.MenuMake = new MenuItem();
			this.Label1 = new Label();
			this.ProgressBar1 = new ProgressBar();
			this.SuspendLayout();
			this.Label3.AutoSize = true;
			Label label3 = this.Label3;
			Point point = new Point(392, 8);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label = this.Label3;
			System.Drawing.Size size = new System.Drawing.Size(102, 16);
			label.Size = size;
			this.Label3.TabIndex = 15;
			this.Label3.Text = "Altitude Image Map";
			this.Label2.AutoSize = true;
			Label label2 = this.Label2;
			point = new Point(280, 8);
			label2.Location = point;
			this.Label2.Name = "Label2";
			this.Label2.TabIndex = 14;
			this.Label2.Text = "Terrain Image Map";
			TextBox altitudeFile = this.AltitudeFile;
			point = new Point(392, 24);
			altitudeFile.Location = point;
			this.AltitudeFile.Name = "AltitudeFile";
			TextBox textBox = this.AltitudeFile;
			size = new System.Drawing.Size(104, 20);
			textBox.Size = size;
			this.AltitudeFile.TabIndex = 11;
			this.AltitudeFile.Text = "Altitude.bmp";
			TextBox terrainFile = this.TerrainFile;
			point = new Point(280, 24);
			terrainFile.Location = point;
			this.TerrainFile.Name = "TerrainFile";
			TextBox terrainFile1 = this.TerrainFile;
			size = new System.Drawing.Size(104, 20);
			terrainFile1.Size = size;
			this.TerrainFile.TabIndex = 10;
			this.TerrainFile.Text = "Terrain.bmp";
			TextBox projectPath = this.ProjectPath;
			point = new Point(8, 24);
			projectPath.Location = point;
			this.ProjectPath.Name = "ProjectPath";
			TextBox projectPath1 = this.ProjectPath;
			size = new System.Drawing.Size(264, 20);
			projectPath1.Size = size;
			this.ProjectPath.TabIndex = 8;
			this.ProjectPath.Text = "";
			System.Windows.Forms.Menu.MenuItemCollection menuItems = this.MainMenu1.MenuItems;
			MenuItem[] menuPath = new MenuItem[] { this.MenuPath, this.MenuMake };
			menuItems.AddRange(menuPath);
			this.MenuPath.Index = 0;
			this.MenuPath.Text = "Path";
			this.MenuMake.Index = 1;
			this.MenuMake.Text = "Make Altitude Image";
			this.Label1.AutoSize = true;
			Label label1 = this.Label1;
			point = new Point(8, 8);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label11 = this.Label1;
			size = new System.Drawing.Size(27, 16);
			label11.Size = size;
			this.Label1.TabIndex = 16;
			this.Label1.Text = "Path";
			this.ProgressBar1.Dock = DockStyle.Bottom;
			ProgressBar progressBar1 = this.ProgressBar1;
			point = new Point(0, 55);
			progressBar1.Location = point;
			this.ProgressBar1.Name = "ProgressBar1";
			ProgressBar progressBar = this.ProgressBar1;
			size = new System.Drawing.Size(502, 16);
			progressBar.Size = size;
			this.ProgressBar1.Step = 1;
			this.ProgressBar1.TabIndex = 17;
			size = new System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = size;
			this.BackColor = Color.FromArgb(224, 224, 224);
			size = new System.Drawing.Size(502, 71);
			this.ClientSize = size;
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.AltitudeFile);
			this.Controls.Add(this.TerrainFile);
			this.Controls.Add(this.ProjectPath);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Menu = this.MainMenu1;
			this.Name = "AltImagePrep";
			this.Text = "UO Altitude Map Set";
			this.ResumeLayout(false);
		}

		[STAThread]
		public static void Main()
		{
			Application.Run(new AltImagePrep());
		}

		private void MenuMake_Click(object sender, EventArgs e)
		{
			Bitmap bitmap = null;
			Bitmap bitmap1 = null;
			try
			{
				this.iLogger.LogMessage("Load Terrain Image Map.");
				bitmap1 = new Bitmap(string.Format("{0}\\{1}", this.ProjectPath.Text, this.TerrainFile.Text));
				bitmap = new Bitmap(bitmap1.Width, bitmap1.Height, PixelFormat.Format8bppIndexed);
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				this.iLogger.LogMessage("Error in loading image maps.\r\n");
				this.iLogger.LogMessage(exception.Message);
				ProjectData.ClearProjectError();
			}
			bitmap.Palette = this.iAltitude.GetAltPalette();
			int width = bitmap1.Width;
			Rectangle rectangle = new Rectangle(0, 0, width, bitmap1.Height);
			BitmapData bitmapDatum = bitmap1.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
			IntPtr scan0 = bitmapDatum.Scan0;
			int num = checked(bitmapDatum.Width * bitmapDatum.Height);
			byte[] numArray = new byte[checked(checked(num - 1) + 1)];
			Marshal.Copy(scan0, numArray, 0, num);
			BitmapData bitmapDatum1 = bitmap.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
			IntPtr intPtr = bitmapDatum1.Scan0;
			int width1 = checked(bitmapDatum1.Width * bitmapDatum1.Height);
			byte[] numArray1 = new byte[checked(checked(width1 - 1) + 1)];
			Marshal.Copy(intPtr, numArray1, 0, width1);
			this.iLogger.LogMessage("Creating Altitude Image Map.");
			this.ProgressBar1.Maximum = width1;
			int num1 = checked(num - 1);
			for (int i = 0; i <= num1; i++)
			{
				this.ProgressBar1.Value = i;
				byte altID = this.iTerrain[numArray[i]].AltID;
				numArray1[i] = altID;
			}
			Marshal.Copy(numArray1, 0, intPtr, width1);
			bitmap.UnlockBits(bitmapDatum1);
			try
			{
				string str = string.Format("{0}\\{1}", this.ProjectPath.Text, this.AltitudeFile.Text);
				this.iLogger.LogMessage("Saving Altitude Image Map.\r\n");
				this.iLogger.LogMessage(str);
				bitmap.Save(str, ImageFormat.Bmp);
			}
			catch (Exception exception3)
			{
				ProjectData.SetProjectError(exception3);
				Exception exception2 = exception3;
				this.iLogger.LogMessage("Error in saving image.\r\n");
				this.iLogger.LogMessage(exception2.Message);
				ProjectData.ClearProjectError();
			}
			bitmap.Dispose();
			bitmap1.Dispose();
			this.iLogger.LogMessage("Done.");
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
	}
}