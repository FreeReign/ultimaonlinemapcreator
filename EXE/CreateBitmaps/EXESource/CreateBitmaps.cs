using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;

using Elevation;
using Terrain;
using Logger;
using Microsoft.VisualBasic.CompilerServices;

namespace CreateBitmaps
{
    public partial class CreateBitmaps : Form
    {
        private ClsTerrainTable iTerrain;
        private ClsElevationTable iAltitude;
        private LoggerForm iLogger;

        public CreateBitmaps()
        {
            CreateBitmaps makeMapImage = this;
            base.Load += new EventHandler(makeMapImage.MakeMapImage_Load);
            this.iTerrain = new ClsTerrainTable();
            this.iAltitude = new ClsElevationTable();
            this.iLogger = new LoggerForm();
            InitializeComponent();
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
				//this.iLogger.EndTask();
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
				//this.iLogger.EndTask();
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
