using Altitude;
using Logger;
using Microsoft.VisualBasic;
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
using System.Threading;
using System.Windows.Forms;
using Terrain;
using Transition;

namespace UOMapMake
{
	public class UOMapMake : Form
	{
		[AccessedThroughProperty("MenuStaticOFF")]
		private MenuItem _MenuStaticOFF;

		[AccessedThroughProperty("MainMenu1")]
		private MainMenu _MainMenu1;

		[AccessedThroughProperty("MenuStaticON")]
		private MenuItem _MenuStaticON;

		[AccessedThroughProperty("ProjectPath")]
		private TextBox _ProjectPath;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		[AccessedThroughProperty("MenuMake")]
		private MenuItem _MenuMake;

		[AccessedThroughProperty("TerrainFile")]
		private TextBox _TerrainFile;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("AltitudeFile")]
		private TextBox _AltitudeFile;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("MenuPath")]
		private MenuItem _MenuPath;

		[AccessedThroughProperty("MenuItem1")]
		private MenuItem _MenuItem1;

		private IContainer components;

		private Bitmap i_Terrain;

		private Bitmap i_Altitude;

		private LoggerForm iLogger;

		private bool i_RandomStatic;

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
					UOMapMake uOMapMake = this;
					this._MenuMake.Click -= new EventHandler(uOMapMake.MenuMake_Click);
				}
				this._MenuMake = value;
				if (this._MenuMake != null)
				{
					UOMapMake uOMapMake1 = this;
					this._MenuMake.Click += new EventHandler(uOMapMake1.MenuMake_Click);
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
					UOMapMake uOMapMake = this;
					this._MenuPath.Click -= new EventHandler(uOMapMake.MenuPath_Click);
				}
				this._MenuPath = value;
				if (this._MenuPath != null)
				{
					UOMapMake uOMapMake1 = this;
					this._MenuPath.Click += new EventHandler(uOMapMake1.MenuPath_Click);
				}
			}
		}

		internal virtual MenuItem MenuStaticOFF
		{
			get
			{
				return this._MenuStaticOFF;
			}
			set
			{
				if (this._MenuStaticOFF != null)
				{
					UOMapMake uOMapMake = this;
					this._MenuStaticOFF.Click -= new EventHandler(uOMapMake.MenuStaticOFF_Click);
				}
				this._MenuStaticOFF = value;
				if (this._MenuStaticOFF != null)
				{
					UOMapMake uOMapMake1 = this;
					this._MenuStaticOFF.Click += new EventHandler(uOMapMake1.MenuStaticOFF_Click);
				}
			}
		}

		internal virtual MenuItem MenuStaticON
		{
			get
			{
				return this._MenuStaticON;
			}
			set
			{
				if (this._MenuStaticON != null)
				{
					UOMapMake uOMapMake = this;
					this._MenuStaticON.Click -= new EventHandler(uOMapMake.MenuStaticON_Click);
				}
				this._MenuStaticON = value;
				if (this._MenuStaticON != null)
				{
					UOMapMake uOMapMake1 = this;
					this._MenuStaticON.Click += new EventHandler(uOMapMake1.MenuStaticON_Click);
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

		public UOMapMake()
		{
			UOMapMake uOMapMake = this;
			base.Load += new EventHandler(uOMapMake.Form1_Load);
			this.iLogger = new LoggerForm();
			this.i_RandomStatic = true;
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

		private void Form1_Load(object sender, EventArgs e)
		{
			this.iLogger.Show();
			int x = checked(this.iLogger.Location.X + 100);
			Point location = this.iLogger.Location;
			Point point = new Point(x, checked(location.Y + 100));
			this.Location = point;
			this.ProjectPath.Text = AppDomain.CurrentDomain.BaseDirectory;
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.MainMenu1 = new MainMenu();
			this.MenuPath = new MenuItem();
			this.MenuMake = new MenuItem();
			this.MenuItem1 = new MenuItem();
			this.MenuStaticON = new MenuItem();
			this.MenuStaticOFF = new MenuItem();
			this.Label1 = new Label();
			this.Label3 = new Label();
			this.Label2 = new Label();
			this.AltitudeFile = new TextBox();
			this.TerrainFile = new TextBox();
			this.ProjectPath = new TextBox();
			this.ProgressBar1 = new ProgressBar();
			this.SuspendLayout();
			System.Windows.Forms.Menu.MenuItemCollection menuItems = this.MainMenu1.MenuItems;
			MenuItem[] menuPath = new MenuItem[] { this.MenuPath, this.MenuMake, this.MenuItem1 };
			menuItems.AddRange(menuPath);
			this.MenuPath.Index = 0;
			this.MenuPath.Text = "Path";
			this.MenuMake.Index = 1;
			this.MenuMake.Text = "Make UO Map";
			this.MenuItem1.Index = 2;
			System.Windows.Forms.Menu.MenuItemCollection menuItemCollections = this.MenuItem1.MenuItems;
			menuPath = new MenuItem[] { this.MenuStaticON, this.MenuStaticOFF };
			menuItemCollections.AddRange(menuPath);
			this.MenuItem1.Text = "Static";
			this.MenuStaticON.Index = 0;
			this.MenuStaticON.Text = "Random Static On";
			this.MenuStaticOFF.Index = 1;
			this.MenuStaticOFF.Text = "Random Static Off";
			this.Label1.AutoSize = true;
			Label label1 = this.Label1;
			Point point = new Point(8, 8);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label = this.Label1;
			System.Drawing.Size size = new System.Drawing.Size(27, 16);
			label.Size = size;
			this.Label1.TabIndex = 22;
			this.Label1.Text = "Path";
			this.Label3.AutoSize = true;
			Label label3 = this.Label3;
			point = new Point(392, 8);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label31 = this.Label3;
			size = new System.Drawing.Size(102, 16);
			label31.Size = size;
			this.Label3.TabIndex = 21;
			this.Label3.Text = "Altitude Image Map";
			this.Label2.AutoSize = true;
			Label label2 = this.Label2;
			point = new Point(280, 8);
			label2.Location = point;
			this.Label2.Name = "Label2";
			this.Label2.TabIndex = 20;
			this.Label2.Text = "Terrain Image Map";
			TextBox altitudeFile = this.AltitudeFile;
			point = new Point(392, 24);
			altitudeFile.Location = point;
			this.AltitudeFile.Name = "AltitudeFile";
			TextBox textBox = this.AltitudeFile;
			size = new System.Drawing.Size(104, 20);
			textBox.Size = size;
			this.AltitudeFile.TabIndex = 19;
			this.AltitudeFile.Text = "Altitude.bmp";
			TextBox terrainFile = this.TerrainFile;
			point = new Point(280, 24);
			terrainFile.Location = point;
			this.TerrainFile.Name = "TerrainFile";
			TextBox terrainFile1 = this.TerrainFile;
			size = new System.Drawing.Size(104, 20);
			terrainFile1.Size = size;
			this.TerrainFile.TabIndex = 18;
			this.TerrainFile.Text = "Terrain.bmp";
			TextBox projectPath = this.ProjectPath;
			point = new Point(8, 24);
			projectPath.Location = point;
			this.ProjectPath.Name = "ProjectPath";
			TextBox projectPath1 = this.ProjectPath;
			size = new System.Drawing.Size(264, 20);
			projectPath1.Size = size;
			this.ProjectPath.TabIndex = 17;
			this.ProjectPath.Text = "";
			this.ProgressBar1.Dock = DockStyle.Bottom;
			ProgressBar progressBar1 = this.ProgressBar1;
			point = new Point(0, 57);
			progressBar1.Location = point;
			this.ProgressBar1.Name = "ProgressBar1";
			ProgressBar progressBar = this.ProgressBar1;
			size = new System.Drawing.Size(504, 16);
			progressBar.Size = size;
			this.ProgressBar1.TabIndex = 23;
			size = new System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new System.Drawing.Size(504, 73);
			this.ClientSize = size;
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.AltitudeFile);
			this.Controls.Add(this.TerrainFile);
			this.Controls.Add(this.ProjectPath);
			this.Menu = this.MainMenu1;
			this.Name = "UOMapMake";
			this.Text = "Ultima Online Map Making Utility";
			this.ResumeLayout(false);
		}

		[STAThread]
		public static void Main()
		{
			Application.Run(new UOMapMake());
		}

		private void Make()
		{
			short altID = 0;
			string str;
			byte num = 0;
			int num1;
			int num2;
			int num3;
			int num4;
			IEnumerator enumerator = null;
			TransitionTable transitionTable = new TransitionTable();
			DateTime now = DateTime.Now;
			this.iLogger.StartTask();
			this.iLogger.LogMessage("Loading Terrain Image.");
			try
			{
				str = string.Format("{0}\\{1}", this.ProjectPath.Text, this.TerrainFile.Text);
				this.iLogger.LogMessage(str);
				this.i_Terrain = new Bitmap(str);
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				this.iLogger.LogMessage("Problem with Loading Terrain Image.");
				this.iLogger.LogMessage(exception.Message);
				ProjectData.ClearProjectError();
				return;
			}
			this.iLogger.LogMessage("Loading Altitude Image.");
			try
			{
				str = string.Format("{0}\\{1}", this.ProjectPath.Text, this.AltitudeFile.Text);
				this.iLogger.LogMessage(str);
				this.i_Altitude = new Bitmap(str);
			}
			catch (Exception exception3)
			{
				ProjectData.SetProjectError(exception3);
				Exception exception2 = exception3;
				this.iLogger.LogMessage("Problem with Loading Altitude Image.");
				this.iLogger.LogMessage(exception2.Message);
				ProjectData.ClearProjectError();
				return;
			}
			this.iLogger.EndTask();
			this.iLogger.LogTimeStamp();
			this.iLogger.LogMessage("Preparing Image Files.");
			this.iLogger.StartTask();
			int width = this.i_Terrain.Width;
			int height = this.i_Terrain.Height;
			Rectangle rectangle = new Rectangle(0, 0, width, height);
			BitmapData bitmapDatum = this.i_Terrain.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
			IntPtr scan0 = bitmapDatum.Scan0;
			int width1 = checked(bitmapDatum.Width * bitmapDatum.Height);
			byte[] numArray = new byte[checked(checked(width1 - 1) + 1)];
			Marshal.Copy(scan0, numArray, 0, width1);
			BitmapData bitmapDatum1 = this.i_Altitude.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
			IntPtr intPtr = bitmapDatum1.Scan0;
			int width2 = checked(bitmapDatum1.Width * bitmapDatum1.Height);
			byte[] numArray1 = new byte[checked(checked(width2 - 1) + 1)];
			Marshal.Copy(intPtr, numArray1, 0, width2);
			this.iLogger.EndTask();
			this.iLogger.LogTimeStamp();
			this.iLogger.LogMessage("Creating Master Terrian Table.");
			this.iLogger.StartTask();
			MapCell[,] mapCell = new MapCell[checked(width + 1), checked(height + 1)];
			ClsAltitudeTable clsAltitudeTable = new ClsAltitudeTable();
			clsAltitudeTable.Load();
			try
			{
				int num5 = checked(width - 1);
				for (int i = 0; i <= num5; i++)
				{
					int num6 = checked(height - 1);
					for (int j = 0; j <= num6; j++)
					{
						int num7 = checked(checked(j * width) + i);
						ClsAltitude getAltitude = clsAltitudeTable[numArray1[num7]];
						mapCell[i, j] = new MapCell(numArray[num7], getAltitude.GetAltitude);
					}
				}
			}
			catch (Exception exception4)
			{
				ProjectData.SetProjectError(exception4);
				this.iLogger.LogMessage("Altitude image needs to be rebuilt");
				ProjectData.ClearProjectError();
				return;
			}
			this.i_Terrain.Dispose();
			this.i_Altitude.Dispose();
			this.iLogger.EndTask();
			this.iLogger.LogTimeStamp();
			width--;
			height--;
			int num8 = checked((int)Math.Round((double)width / 8 - 1));
			int num9 = checked((int)Math.Round((double)height / 8 - 1));
			this.iLogger.LogMessage("Load Transition Tables.");
			this.iLogger.StartTask();
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			baseDirectory = string.Concat(baseDirectory, "Data\\Transitions\\");
			if (Directory.Exists(baseDirectory))
			{
				transitionTable.MassLoad(baseDirectory);
				this.iLogger.EndTask();
				this.iLogger.LogTimeStamp();
				this.iLogger.LogMessage("Preparing Static Tables");
				Collection[,] collections = new Collection[checked(num8 + 1), checked(num9 + 1)];
				int num10 = num8;
				for (int k = 0; k <= num10; k++)
				{
					int num11 = num9;
					for (int l = 0; l <= num11; l++)
					{
						collections[k, l] = new Collection();
					}
				}
				this.iLogger.LogMessage("Applying Transition Tables.");
				this.iLogger.StartTask();
				this.ProgressBar1.Maximum = width;
				ClsTerrainTable clsTerrainTable = new ClsTerrainTable();
				clsTerrainTable.Load();
				MapTile mapTile = new MapTile();
				Transition transition = new Transition();
				short[] numArray2 = new short[16];
				short num12 = checked((short)width);
				for (short m = 0; m <= num12; m = checked((short)(m + 1)))
				{
					num1 = (m != 0 ? checked(m - 1) : width);
					num2 = (m != width ? checked(m + 1) : 0);
					short num13 = checked((short)height);
					for (short n = 0; n <= num13; n = checked((short)(n + 1)))
					{
						num4 = (n != 0 ? checked(n - 1) : height);
						num3 = (n != height ? checked(n + 1) : 0);
						object[] groupID = new object[] { mapCell[num1, num4].GroupID, mapCell[m, num4].GroupID, mapCell[num2, num4].GroupID, mapCell[num1, n].GroupID, mapCell[m, n].GroupID, mapCell[num2, n].GroupID, mapCell[num1, num3].GroupID, mapCell[m, num3].GroupID, mapCell[num2, num3].GroupID };
						string str1 = string.Format("{0:X2}{1:X2}{2:X2}{3:X2}{4:X2}{5:X2}{6:X2}{7:X2}{8:X2}", groupID);
						try
						{
							transition = transitionTable[str1];
							if (transition == null)
							{
								ClsTerrain terrianGroup = clsTerrainTable[mapCell[m, n].GroupID];
								mapCell[m, n].TileID = terrianGroup.TileID;
								mapCell[m, n].AltID = altID;
								terrianGroup = null;
							}
							else
							{
								altID = mapCell[m, n].AltID;
								mapTile = transition.GetRandomMapTile();
								if (mapTile == null)
								{
									ClsTerrain clsTerrain = clsTerrainTable[mapCell[m, n].GroupID];
									mapCell[m, n].TileID = clsTerrain.TileID;
									mapCell[m, n].ChangeAltID((short)clsTerrain.AltID);
									clsTerrain = null;
								}
								else
								{
									MapTile mapTile1 = mapTile;
									mapCell[m, n].TileID = mapTile1.TileID;
									mapCell[m, n].ChangeAltID(mapTile1.AltIDMod);
									mapTile1 = null;
								}
								transition.GetRandomStaticTiles(m, n, altID, collections, this.i_RandomStatic);
							}
							if (mapCell[m, n].GroupID == 254)
							{
								mapCell[m, n].TileID = 1078;
								mapCell[m, n].AltID = 0;
							}
						}
						catch (Exception exception6)
						{
							ProjectData.SetProjectError(exception6);
							Exception exception5 = exception6;
							LoggerForm loggerForm = this.iLogger;
							groupID = new object[] { m, n, altID, str1 };
							loggerForm.LogMessage(string.Format("\r\nLocation: X:{0}, Y:{1}, Z:{2} Hkey:{3}", groupID));
							this.iLogger.LogMessage(exception5.ToString());
							ProjectData.ClearProjectError();
							return;
						}
					}
					this.ProgressBar1.Value = m;
				}
				this.iLogger.EndTask();
				this.iLogger.LogTimeStamp();
				this.iLogger.LogMessage("Second Pass.");
				this.iLogger.StartTask();
				short[] altID1 = new short[9];
				RoughEdge roughEdge = new RoughEdge();
				short num14 = checked((short)width);
				for (short o = 0; o <= num14; o = checked((short)(o + 1)))
				{
					num1 = (o != 0 ? checked(o - 1) : width);
					num2 = (o != width ? checked(o + 1) : 0);
					short num15 = checked((short)height);
					for (short p = 0; p <= num15; p = checked((short)(p + 1)))
					{
						num4 = (p != 0 ? checked(p - 1) : height);
						num3 = (p != height ? checked(p + 1) : 0);
						mapCell[o, p].ChangeAltID(roughEdge.CheckCorner(mapCell[num1, num4].TileID));
						mapCell[o, p].ChangeAltID(roughEdge.CheckLeft(mapCell[num1, p].TileID));
						mapCell[o, p].ChangeAltID(roughEdge.CheckTop(mapCell[o, num4].TileID));
						if (mapCell[o, p].GroupID == 20)
						{
							altID1[0] = mapCell[num1, num4].AltID;
							altID1[1] = mapCell[o, num4].AltID;
							altID1[2] = mapCell[num2, num4].AltID;
							altID1[3] = mapCell[num1, p].AltID;
							altID1[4] = mapCell[o, p].AltID;
							altID1[5] = mapCell[num2, p].AltID;
							altID1[6] = mapCell[num1, num3].AltID;
							altID1[7] = mapCell[o, num3].AltID;
							altID1[8] = mapCell[num2, num3].AltID;
							Array.Sort(altID1);
							float single = 10f * VBMath.Rnd();
							if (single == 0f)
							{
								mapCell[o, p].AltID = checked((short)(checked(altID1[8] - 4)));
							}
							else if (single >= 1f && single <= 2f)
							{
								mapCell[o, p].AltID = checked((short)(checked(altID1[8] - 2)));
							}
							else if (single >= 3f && single <= 7f)
							{
								mapCell[o, p].AltID = altID1[8];
							}
							else if (single >= 8f && single <= 9f)
							{
								mapCell[o, p].AltID = checked((short)(checked(altID1[8] + 2)));
							}
							else if (single == 10f)
							{
								mapCell[o, p].AltID = checked((short)(checked(altID1[8] + 4)));
							}
						}
						if (clsTerrainTable[mapCell[o, p].GroupID].RandAlt)
						{
							float single1 = 10f * VBMath.Rnd();
							if (single1 == 0f)
							{
								mapCell[o, p].ChangeAltID(-4);
							}
							else if (single1 >= 1f && single1 <= 2f)
							{
								mapCell[o, p].ChangeAltID(-2);
							}
							else if (single1 >= 8f && single1 <= 9f)
							{
								mapCell[o, p].ChangeAltID(2);
							}
							else if (single1 == 10f)
							{
								mapCell[o, p].ChangeAltID(4);
							}
						}
					}
					this.ProgressBar1.Value = o;
				}
				this.iLogger.EndTask();
				this.iLogger.LogTimeStamp();
				int num16 = 1;
				int num17 = width;
				if (num17 == 6143)
				{
					num = 0;
				}
				else if (num17 == 2303)
				{
					num = 2;
				}
				else if (num17 == 2559)
				{
					num = 3;
				}
				this.iLogger.LogMessage("\r\n");
				this.iLogger.LogMessage("Load . . . . . Import Tiles.");
				this.iLogger.StartTask();
				ImportTiles importTile = new ImportTiles(collections, this.ProjectPath.Text);
				this.iLogger.EndTask();
				this.iLogger.LogTimeStamp();
				this.iLogger.LogMessage("\r\n");
				this.iLogger.LogMessage("Write Mul Files.");
				this.iLogger.StartTask();
				str = string.Format("{0}/Map{1}.mul", this.ProjectPath.Text, num);
				this.iLogger.LogMessage(str);
				FileStream fileStream = new FileStream(str, FileMode.Create);
				BinaryWriter binaryWriter = new BinaryWriter(fileStream);
				int num18 = width;
				for (int q = 0; q <= num18; q = checked(q + 8))
				{
					int num19 = height;
					for (int r = 0; r <= num19; r = checked(r + 8))
					{
						binaryWriter.Write(num16);
						int num20 = 0;
						do
						{
							int num21 = 0;
							do
							{
								mapCell[checked(q + num21), checked(r + num20)].WriteMapMul(binaryWriter);
								num21++;
							}
							while (num21 <= 7);
							num20++;
						}
						while (num20 <= 7);
					}
				}
				binaryWriter.Close();
				fileStream.Close();
				str = string.Format("{0}/StaIdx{1}.mul", this.ProjectPath.Text, num);
				FileStream fileStream1 = new FileStream(str, FileMode.Create);
				this.iLogger.LogMessage(str);
				str = string.Format("{0}/Statics{1}.mul", this.ProjectPath.Text, num);
				FileStream fileStream2 = new FileStream(str, FileMode.Create);
				this.iLogger.LogMessage(str);
				BinaryWriter binaryWriter1 = new BinaryWriter(fileStream1);
				BinaryWriter binaryWriter2 = new BinaryWriter(fileStream2);
				int num22 = num8;
				for (int s = 0; s <= num22; s++)
				{
					int num23 = num9;
					for (int t = 0; t <= num23; t++)
					{
						int num24 = 0;
						int position = checked((int)binaryWriter2.BaseStream.Position);
						try
						{
							enumerator = collections[s, t].GetEnumerator();
							while (enumerator.MoveNext())
							{
								((StaticCell)enumerator.Current).Write(binaryWriter2);
								num24 = checked(num24 + 7);
							}
						}
						finally
						{
							if (enumerator is IDisposable)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						if (num24 == 0)
						{
							position = -1;
						}
						binaryWriter1.Write(position);
						binaryWriter1.Write(num24);
						binaryWriter1.Write(num16);
					}
				}
				binaryWriter2.Close();
				binaryWriter1.Close();
				fileStream2.Close();
				fileStream1.Close();
				this.iLogger.EndTask();
				this.iLogger.LogTimeStamp();
				this.iLogger.LogMessage("Done.");
			}
			else
			{
				this.iLogger.LogMessage("Unable to find Transition Data files in the following path: ");
				this.iLogger.LogMessage(baseDirectory);
			}
		}

		private void MenuMake_Click(object sender, EventArgs e)
		{
			if (Interaction.MsgBox("You are about to create the Mul Files\r\nAre you sure ?", MsgBoxStyle.YesNo, "Make UO Map") == MsgBoxResult.Yes)
			{
				UOMapMake uOMapMake = this;
				(new Thread(new ThreadStart(uOMapMake.Make))).Start();
			}
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

		private void MenuStaticOFF_Click(object sender, EventArgs e)
		{
			this.i_RandomStatic = false;
		}

		private void MenuStaticON_Click(object sender, EventArgs e)
		{
			this.i_RandomStatic = true;
		}
	}
}