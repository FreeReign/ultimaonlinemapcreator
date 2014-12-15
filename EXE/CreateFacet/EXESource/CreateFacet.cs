using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Elevation;
using Logger;
using Terrain;
using Transition;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;


namespace CreateFacet
{
    public partial class CreateFacet : Form
    {
        private Bitmap i_Terrain;
        private Bitmap i_Altitude;
        private LoggerForm iLogger;
        private bool i_RandomStatic;

        public CreateFacet()
        {
            CreateFacet uOMapMake = this;
            base.Load += new EventHandler(uOMapMake.Form1_Load);
            this.iLogger = new LoggerForm();
            this.i_RandomStatic = true;
            InitializeComponent();
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
			//this.iLogger.EndTask();
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
			//this.iLogger.EndTask();
			this.iLogger.LogTimeStamp();
			this.iLogger.LogMessage("Creating Master Terrian Table.");
			this.iLogger.StartTask();
			MapCell[,] mapCell = new MapCell[checked(width + 1), checked(height + 1)];
			ClsElevationTable clsAltitudeTable = new ClsElevationTable();
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

						//ClsAltitude getAltitude = clsAltitudeTable[numArray1[num7]];
                        ClsElevation getAltitude = clsAltitudeTable.GetAltitude(numArray1[num7]);

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
			//this.iLogger.EndTask();
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
				//this.iLogger.EndTask();
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

                //Transition transition = new Transition();
				Transition.Transition transition = new Transition.Transition();
                //Transition.Transition mytransition = new Transition.Transition();

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
                            //transition = transitionTable[str1];

                            transition = (Transition.Transition)(transitionTable.GetTransitionTable[str1]);

                            //transitionTable.MassLoad(str1);
                            //transition = (transitionTable.MassLoad(str1));
                            //transition = transitionTable.MassLoad(str1);
                            if (transition == null)
							{
								//ClsTerrain terrianGroup = clsTerrainTable[mapCell[m, n].GroupID];
                                ClsTerrain terrianGroup = clsTerrainTable.TerrianGroup(mapCell[m, n].GroupID);

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
									//ClsTerrain clsTerrain = clsTerrainTable[mapCell[m, n].GroupID];
                                    ClsTerrain clsTerrain = clsTerrainTable.TerrianGroup(mapCell[m, n].GroupID);
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
				//this.iLogger.EndTask();
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

						//if (clsTerrainTable[mapCell[o, p].GroupID].RandAlt)
                        if (clsTerrainTable.TerrianGroup(mapCell[o, p].GroupID).RandAlt)
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
				//this.iLogger.EndTask();
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
				//this.iLogger.EndTask();
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
				//this.iLogger.EndTask();
				this.iLogger.LogTimeStamp();
				this.iLogger.LogMessage("Done.");
			}
			else
			{
				this.iLogger.LogMessage("Unable to find Transition Data files in the following path: ");
				this.iLogger.LogMessage(baseDirectory);
			}
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

        private void MenuMake_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("You are about to create the Mul Files\r\nAre you sure ?", MsgBoxStyle.YesNo, "Make UO Map") == MsgBoxResult.Yes)
			{
				CreateFacet uOMapMake = this;
				(new Thread(new ThreadStart(uOMapMake.Make))).Start();
			}
        }

        private void MenuStaticON_Click(object sender, EventArgs e)
        {
            this.i_RandomStatic = true;
        }

        private void MenuStaticOFF_Click(object sender, EventArgs e)
        {
            this.i_RandomStatic = false;
        }
    }   
}