// Decompiled with JetBrains decompiler
// Type: UOMapMake.UOMapMake
// Assembly: UOMapMake, Version=1.0.1819.29268, Culture=neutral, PublicKeyToken=null
// MVID: 6505317C-3933-4E34-800A-F915B4881A03
// Assembly location: W:\JetBrains\UOLandscaper\UOMapMake.exe

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

    internal virtual TextBox AltitudeFile
    {
      get
      {
        return this._AltitudeFile;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._AltitudeFile == null)
          ;
        this._AltitudeFile = value;
        if (this._AltitudeFile != null)
          ;
      }
    }

    internal virtual TextBox TerrainFile
    {
      get
      {
        return this._TerrainFile;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TerrainFile == null)
          ;
        this._TerrainFile = value;
        if (this._TerrainFile != null)
          ;
      }
    }

    internal virtual TextBox ProjectPath
    {
      get
      {
        return this._ProjectPath;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ProjectPath == null)
          ;
        this._ProjectPath = value;
        if (this._ProjectPath != null)
          ;
      }
    }

    internal virtual ProgressBar ProgressBar1
    {
      get
      {
        return this._ProgressBar1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ProgressBar1 == null)
          ;
        this._ProgressBar1 = value;
        if (this._ProgressBar1 != null)
          ;
      }
    }

    internal virtual MenuItem MenuPath
    {
      get
      {
        return this._MenuPath;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuPath != null)
          this._MenuPath.Click -= new EventHandler(this.MenuPath_Click);
        this._MenuPath = value;
        if (this._MenuPath == null)
          return;
        this._MenuPath.Click += new EventHandler(this.MenuPath_Click);
      }
    }

    internal virtual MenuItem MenuMake
    {
      get
      {
        return this._MenuMake;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuMake != null)
          this._MenuMake.Click -= new EventHandler(this.MenuMake_Click);
        this._MenuMake = value;
        if (this._MenuMake == null)
          return;
        this._MenuMake.Click += new EventHandler(this.MenuMake_Click);
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
        if (this._MenuItem1 == null)
          ;
        this._MenuItem1 = value;
        if (this._MenuItem1 != null)
          ;
      }
    }

    internal virtual MenuItem MenuStaticON
    {
      get
      {
        return this._MenuStaticON;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuStaticON != null)
          this._MenuStaticON.Click -= new EventHandler(this.MenuStaticON_Click);
        this._MenuStaticON = value;
        if (this._MenuStaticON == null)
          return;
        this._MenuStaticON.Click += new EventHandler(this.MenuStaticON_Click);
      }
    }

    internal virtual MenuItem MenuStaticOFF
    {
      get
      {
        return this._MenuStaticOFF;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuStaticOFF != null)
          this._MenuStaticOFF.Click -= new EventHandler(this.MenuStaticOFF_Click);
        this._MenuStaticOFF = value;
        if (this._MenuStaticOFF == null)
          return;
        this._MenuStaticOFF.Click += new EventHandler(this.MenuStaticOFF_Click);
      }
    }

    public UOMapMake()
    {
      this.Load += new EventHandler(this.Form1_Load);
      this.iLogger = new LoggerForm();
      this.i_RandomStatic = true;
      this.InitializeComponent();
    }

    [STAThread]
    public static void Main()
    {
      Application.Run((Form) new UOMapMake());
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
      this.MainMenu1.MenuItems.AddRange(new MenuItem[3]
      {
        this.MenuPath,
        this.MenuMake,
        this.MenuItem1
      });
      this.MenuPath.Index = 0;
      this.MenuPath.Text = "Path";
      this.MenuMake.Index = 1;
      this.MenuMake.Text = "Make UO Map";
      this.MenuItem1.Index = 2;
      this.MenuItem1.MenuItems.AddRange(new MenuItem[2]
      {
        this.MenuStaticON,
        this.MenuStaticOFF
      });
      this.MenuItem1.Text = "Static";
      this.MenuStaticON.Index = 0;
      this.MenuStaticON.Text = "Random Static On";
      this.MenuStaticOFF.Index = 1;
      this.MenuStaticOFF.Text = "Random Static Off";
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      Point point1 = new Point(8, 8);
      Point point2 = point1;
      label1_1.Location = point2;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      Size size1 = new Size(27, 16);
      Size size2 = size1;
      label1_2.Size = size2;
      this.Label1.TabIndex = 22;
      this.Label1.Text = "Path";
      this.Label3.AutoSize = true;
      Label label3_1 = this.Label3;
      point1 = new Point(392, 8);
      Point point3 = point1;
      label3_1.Location = point3;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(102, 16);
      Size size3 = size1;
      label3_2.Size = size3;
      this.Label3.TabIndex = 21;
      this.Label3.Text = "Altitude Image Map";
      this.Label2.AutoSize = true;
      Label label2 = this.Label2;
      point1 = new Point(280, 8);
      Point point4 = point1;
      label2.Location = point4;
      this.Label2.Name = "Label2";
      this.Label2.TabIndex = 20;
      this.Label2.Text = "Terrain Image Map";
      TextBox altitudeFile1 = this.AltitudeFile;
      point1 = new Point(392, 24);
      Point point5 = point1;
      altitudeFile1.Location = point5;
      this.AltitudeFile.Name = "AltitudeFile";
      TextBox altitudeFile2 = this.AltitudeFile;
      size1 = new Size(104, 20);
      Size size4 = size1;
      altitudeFile2.Size = size4;
      this.AltitudeFile.TabIndex = 19;
      this.AltitudeFile.Text = "Altitude.bmp";
      TextBox terrainFile1 = this.TerrainFile;
      point1 = new Point(280, 24);
      Point point6 = point1;
      terrainFile1.Location = point6;
      this.TerrainFile.Name = "TerrainFile";
      TextBox terrainFile2 = this.TerrainFile;
      size1 = new Size(104, 20);
      Size size5 = size1;
      terrainFile2.Size = size5;
      this.TerrainFile.TabIndex = 18;
      this.TerrainFile.Text = "Terrain.bmp";
      TextBox projectPath1 = this.ProjectPath;
      point1 = new Point(8, 24);
      Point point7 = point1;
      projectPath1.Location = point7;
      this.ProjectPath.Name = "ProjectPath";
      TextBox projectPath2 = this.ProjectPath;
      size1 = new Size(264, 20);
      Size size6 = size1;
      projectPath2.Size = size6;
      this.ProjectPath.TabIndex = 17;
      this.ProjectPath.Text = "";
      this.ProgressBar1.Dock = DockStyle.Bottom;
      ProgressBar progressBar1_1 = this.ProgressBar1;
      point1 = new Point(0, 57);
      Point point8 = point1;
      progressBar1_1.Location = point8;
      this.ProgressBar1.Name = "ProgressBar1";
      ProgressBar progressBar1_2 = this.ProgressBar1;
      size1 = new Size(504, 16);
      Size size7 = size1;
      progressBar1_2.Size = size7;
      this.ProgressBar1.TabIndex = 23;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(504, 73);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.ProgressBar1);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.AltitudeFile);
      this.Controls.Add((Control) this.TerrainFile);
      this.Controls.Add((Control) this.ProjectPath);
      this.Menu = this.MainMenu1;
      this.Name = "UOMapMake";
      this.Text = "Ultima Online Map Making Utility";
      this.ResumeLayout(false);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.iLogger.Show();
      this.Location = new Point(checked (this.iLogger.Location.X + 100), checked (this.iLogger.Location.Y + 100));
      this.ProjectPath.Text = AppDomain.CurrentDomain.BaseDirectory;
    }

    private void Make()
    {
      TransitionTable transitionTable = new TransitionTable();
      DateTime now = DateTime.Now;
      this.iLogger.StartTask();
      this.iLogger.LogMessage("Loading Terrain Image.");
      try
      {
        string str = string.Format("{0}\\{1}", (object) this.ProjectPath.Text, (object) this.TerrainFile.Text);
        this.iLogger.LogMessage(str);
        this.i_Terrain = new Bitmap(str);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.iLogger.LogMessage("Problem with Loading Terrain Image.");
        this.iLogger.LogMessage(exception.Message);
        ProjectData.ClearProjectError();
        return;
      }
      this.iLogger.LogMessage("Loading Altitude Image.");
      try
      {
        string str = string.Format("{0}\\{1}", (object) this.ProjectPath.Text, (object) this.AltitudeFile.Text);
        this.iLogger.LogMessage(str);
        this.i_Altitude = new Bitmap(str);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.iLogger.LogMessage("Problem with Loading Altitude Image.");
        this.iLogger.LogMessage(exception.Message);
        ProjectData.ClearProjectError();
        return;
      }
      this.iLogger.EndTask();
      this.iLogger.LogTimeStamp();
      this.iLogger.LogMessage("Preparing Image Files.");
      this.iLogger.StartTask();
      int width = this.i_Terrain.Width;
      int height = this.i_Terrain.Height;
      Rectangle rect = new Rectangle(0, 0, width, height);
      BitmapData bitmapData1 = this.i_Terrain.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
      IntPtr scan0_1 = bitmapData1.Scan0;
      int length1 = checked (bitmapData1.Width * bitmapData1.Height);
      byte[] destination1 = new byte[checked (length1 - 1 + 1)];
      Marshal.Copy(scan0_1, destination1, 0, length1);
      BitmapData bitmapData2 = this.i_Altitude.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
      IntPtr scan0_2 = bitmapData2.Scan0;
      int length2 = checked (bitmapData2.Width * bitmapData2.Height);
      byte[] destination2 = new byte[checked (length2 - 1 + 1)];
      Marshal.Copy(scan0_2, destination2, 0, length2);
      this.iLogger.EndTask();
      this.iLogger.LogTimeStamp();
      this.iLogger.LogMessage("Creating Master Terrian Table.");
      this.iLogger.StartTask();
      MapCell[,] mapCellArray = new MapCell[checked (width + 1), checked (height + 1)];
      ClsAltitudeTable clsAltitudeTable = new ClsAltitudeTable();
      clsAltitudeTable.Load();
      try
      {
        int num1 = 0;
        int num2 = checked (width - 1);
        int index1 = num1;
        while (index1 <= num2)
        {
          int num3 = 0;
          int num4 = checked (height - 1);
          int index2 = num3;
          while (index2 <= num4)
          {
            int index3 = checked (index2 * width + index1);
            ClsAltitude clsAltitude = clsAltitudeTable.get_GetAltitude((int) destination2[index3]);
            mapCellArray[index1, index2] = new MapCell(destination1[index3], clsAltitude.GetAltitude);
            checked { ++index2; }
          }
          checked { ++index1; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.iLogger.LogMessage("Altitude image needs to be rebuilt");
        ProjectData.ClearProjectError();
        return;
      }
      this.i_Terrain.Dispose();
      this.i_Altitude.Dispose();
      this.iLogger.EndTask();
      this.iLogger.LogTimeStamp();
      int num5 = checked (width - 1);
      int num6 = checked (height - 1);
      int num7 = checked ((int) Math.Round(unchecked ((double) num5 / 8.0 - 1.0)));
      int num8 = checked ((int) Math.Round(unchecked ((double) num6 / 8.0 - 1.0)));
      this.iLogger.LogMessage("Load Transition Tables.");
      this.iLogger.StartTask();
      string str1 = AppDomain.CurrentDomain.BaseDirectory + "Data\\Transitions\\";
      if (!Directory.Exists(str1))
      {
        this.iLogger.LogMessage("Unable to find Transition Data files in the following path: ");
        this.iLogger.LogMessage(str1);
      }
      else
      {
        transitionTable.MassLoad(str1);
        this.iLogger.EndTask();
        this.iLogger.LogTimeStamp();
        this.iLogger.LogMessage("Preparing Static Tables");
        Collection[,] StaticMap = new Collection[checked (num7 + 1), checked (num8 + 1)];
        int num1 = 0;
        int num2 = num7;
        int index1 = num1;
        while (index1 <= num2)
        {
          int num3 = 0;
          int num4 = num8;
          int index2 = num3;
          while (index2 <= num4)
          {
            StaticMap[index1, index2] = new Collection();
            checked { ++index2; }
          }
          checked { ++index1; }
        }
        this.iLogger.LogMessage("Applying Transition Tables.");
        this.iLogger.StartTask();
        this.ProgressBar1.Maximum = num5;
        ClsTerrainTable clsTerrainTable = new ClsTerrainTable();
        clsTerrainTable.Load();
        MapTile mapTile1 = new MapTile();
        Transition transition1 = new Transition();
        short[] numArray1 = new short[16];
        int num9 = 0;
        short num10 = checked ((short) num5);
        for (short X = (short) num9; (int) X <= (int) num10; ++X)
        {
          int index2 = (int) X != 0 ? checked ((int) X - 1) : num5;
          int index3 = (int) X != num5 ? checked ((int) X + 1) : 0;
          int num3 = 0;
          short num4 = checked ((short) num6);
          for (short Y = (short) num3; (int) Y <= (int) num4; ++Y)
          {
            int index4 = (int) Y != 0 ? checked ((int) Y - 1) : num6;
            int index5 = (int) Y != num6 ? checked ((int) Y + 1) : 0;
            string iKey = string.Format("{0:X2}{1:X2}{2:X2}{3:X2}{4:X2}{5:X2}{6:X2}{7:X2}{8:X2}", (object) mapCellArray[index2, index4].GroupID, (object) mapCellArray[(int) X, index4].GroupID, (object) mapCellArray[index3, index4].GroupID, (object) mapCellArray[index2, (int) Y].GroupID, (object) mapCellArray[(int) X, (int) Y].GroupID, (object) mapCellArray[index3, (int) Y].GroupID, (object) mapCellArray[index2, index5].GroupID, (object) mapCellArray[(int) X, index5].GroupID, (object) mapCellArray[index3, index5].GroupID);
            short altId;
            try
            {
              Transition transition2 = transitionTable.get_Transition(iKey);
              if (transition2 != null)
              {
                altId = mapCellArray[(int) X, (int) Y].AltID;
                MapTile randomMapTile = transition2.GetRandomMapTile();
                if (randomMapTile != null)
                {
                  MapTile mapTile2 = randomMapTile;
                  mapCellArray[(int) X, (int) Y].TileID = mapTile2.TileID;
                  mapCellArray[(int) X, (int) Y].ChangeAltID(mapTile2.AltIDMod);
                }
                else
                {
                  ClsTerrain clsTerrain = clsTerrainTable.get_TerrianGroup((int) mapCellArray[(int) X, (int) Y].GroupID);
                  mapCellArray[(int) X, (int) Y].TileID = clsTerrain.TileID;
                  mapCellArray[(int) X, (int) Y].ChangeAltID((short) clsTerrain.AltID);
                }
                transition2.GetRandomStaticTiles(X, Y, altId, StaticMap, this.i_RandomStatic);
              }
              else
              {
                ClsTerrain clsTerrain = clsTerrainTable.get_TerrianGroup((int) mapCellArray[(int) X, (int) Y].GroupID);
                mapCellArray[(int) X, (int) Y].TileID = clsTerrain.TileID;
                mapCellArray[(int) X, (int) Y].AltID = altId;
              }
              if ((int) mapCellArray[(int) X, (int) Y].GroupID == 254)
              {
                mapCellArray[(int) X, (int) Y].TileID = (short) 1078;
                mapCellArray[(int) X, (int) Y].AltID = (short) 0;
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Exception exception = ex;
              this.iLogger.LogMessage(string.Format("\r\nLocation: X:{0}, Y:{1}, Z:{2} Hkey:{3}", (object) X, (object) Y, (object) altId, (object) iKey));
              this.iLogger.LogMessage(exception.ToString());
              ProjectData.ClearProjectError();
              return;
            }
          }
          this.ProgressBar1.Value = (int) X;
        }
        this.iLogger.EndTask();
        this.iLogger.LogTimeStamp();
        this.iLogger.LogMessage("Second Pass.");
        this.iLogger.StartTask();
        short[] numArray2 = new short[9];
        RoughEdge roughEdge = new RoughEdge();
        int num11 = 0;
        short num12 = checked ((short) num5);
        for (short index2 = (short) num11; (int) index2 <= (int) num12; ++index2)
        {
          int index3 = (int) index2 != 0 ? checked ((int) index2 - 1) : num5;
          int index4 = (int) index2 != num5 ? checked ((int) index2 + 1) : 0;
          int num3 = 0;
          short num4 = checked ((short) num6);
          for (short index5 = (short) num3; (int) index5 <= (int) num4; ++index5)
          {
            int index6 = (int) index5 != 0 ? checked ((int) index5 - 1) : num6;
            int index7 = (int) index5 != num6 ? checked ((int) index5 + 1) : 0;
            mapCellArray[(int) index2, (int) index5].ChangeAltID(roughEdge.CheckCorner(mapCellArray[index3, index6].TileID));
            mapCellArray[(int) index2, (int) index5].ChangeAltID(roughEdge.CheckLeft(mapCellArray[index3, (int) index5].TileID));
            mapCellArray[(int) index2, (int) index5].ChangeAltID(roughEdge.CheckTop(mapCellArray[(int) index2, index6].TileID));
            if ((int) mapCellArray[(int) index2, (int) index5].GroupID == 20)
            {
              numArray2[0] = mapCellArray[index3, index6].AltID;
              numArray2[1] = mapCellArray[(int) index2, index6].AltID;
              numArray2[2] = mapCellArray[index4, index6].AltID;
              numArray2[3] = mapCellArray[index3, (int) index5].AltID;
              numArray2[4] = mapCellArray[(int) index2, (int) index5].AltID;
              numArray2[5] = mapCellArray[index4, (int) index5].AltID;
              numArray2[6] = mapCellArray[index3, index7].AltID;
              numArray2[7] = mapCellArray[(int) index2, index7].AltID;
              numArray2[8] = mapCellArray[index4, index7].AltID;
              Array.Sort((Array) numArray2);
              float num13 = 10f * VBMath.Rnd();
              if ((double) num13 == 0.0)
                mapCellArray[(int) index2, (int) index5].AltID = checked ((short) ((int) numArray2[8] - 4));
              else if ((double) num13 >= 1.0 && (double) num13 <= 2.0)
                mapCellArray[(int) index2, (int) index5].AltID = checked ((short) ((int) numArray2[8] - 2));
              else if ((double) num13 >= 3.0 && (double) num13 <= 7.0)
                mapCellArray[(int) index2, (int) index5].AltID = numArray2[8];
              else if ((double) num13 >= 8.0 && (double) num13 <= 9.0)
                mapCellArray[(int) index2, (int) index5].AltID = checked ((short) ((int) numArray2[8] + 2));
              else if ((double) num13 == 10.0)
                mapCellArray[(int) index2, (int) index5].AltID = checked ((short) ((int) numArray2[8] + 4));
            }
            if (clsTerrainTable.get_TerrianGroup((int) mapCellArray[(int) index2, (int) index5].GroupID).RandAlt)
            {
              float num13 = 10f * VBMath.Rnd();
              if ((double) num13 == 0.0)
                mapCellArray[(int) index2, (int) index5].ChangeAltID((short) -4);
              else if ((double) num13 >= 1.0 && (double) num13 <= 2.0)
                mapCellArray[(int) index2, (int) index5].ChangeAltID((short) -2);
              else if ((double) num13 >= 8.0 && (double) num13 <= 9.0)
                mapCellArray[(int) index2, (int) index5].ChangeAltID((short) 2);
              else if ((double) num13 == 10.0)
                mapCellArray[(int) index2, (int) index5].ChangeAltID((short) 4);
            }
          }
          this.ProgressBar1.Value = (int) index2;
        }
        this.iLogger.EndTask();
        this.iLogger.LogTimeStamp();
        int num14 = 1;
        byte num15;
        switch (num5)
        {
          case 6143:
            num15 = (byte) 0;
            break;
          case 2303:
            num15 = (byte) 2;
            break;
          case 2559:
            num15 = (byte) 3;
            break;
        }
        this.iLogger.LogMessage("\r\n");
        this.iLogger.LogMessage("Load . . . . . Import Tiles.");
        this.iLogger.StartTask();
        ImportTiles importTiles = new ImportTiles(StaticMap, this.ProjectPath.Text);
        this.iLogger.EndTask();
        this.iLogger.LogTimeStamp();
        this.iLogger.LogMessage("\r\n");
        this.iLogger.LogMessage("Write Mul Files.");
        this.iLogger.StartTask();
        string str2 = string.Format("{0}/Map{1}.mul", (object) this.ProjectPath.Text, (object) num15);
        this.iLogger.LogMessage(str2);
        FileStream fileStream1 = new FileStream(str2, FileMode.Create);
        BinaryWriter i_MapFile = new BinaryWriter((Stream) fileStream1);
        int num16 = 0;
        int num17 = num5;
        int num18 = num16;
        while (num18 <= num17)
        {
          int num3 = 0;
          int num4 = num6;
          int num13 = num3;
          while (num13 <= num4)
          {
            i_MapFile.Write(num14);
            int num19 = 0;
            do
            {
              int num20 = 0;
              do
              {
                mapCellArray[checked (num18 + num20), checked (num13 + num19)].WriteMapMul(i_MapFile);
                checked { ++num20; }
              }
              while (num20 <= 7);
              checked { ++num19; }
            }
            while (num19 <= 7);
            checked { num13 += 8; }
          }
          checked { num18 += 8; }
        }
        i_MapFile.Close();
        fileStream1.Close();
        string str3 = string.Format("{0}/StaIdx{1}.mul", (object) this.ProjectPath.Text, (object) num15);
        FileStream fileStream2 = new FileStream(str3, FileMode.Create);
        this.iLogger.LogMessage(str3);
        string str4 = string.Format("{0}/Statics{1}.mul", (object) this.ProjectPath.Text, (object) num15);
        FileStream fileStream3 = new FileStream(str4, FileMode.Create);
        this.iLogger.LogMessage(str4);
        BinaryWriter binaryWriter = new BinaryWriter((Stream) fileStream2);
        BinaryWriter i_StaticFile = new BinaryWriter((Stream) fileStream3);
        int num21 = 0;
        int num22 = num7;
        int index8 = num21;
        while (index8 <= num22)
        {
          int num3 = 0;
          int num4 = num8;
          int index2 = num3;
          while (index2 <= num4)
          {
            int num13 = 0;
            int num19 = checked ((int) i_StaticFile.BaseStream.Position);
            try
            {
              foreach (StaticCell staticCell in StaticMap[index8, index2])
              {
                staticCell.Write(i_StaticFile);
                checked { num13 += 7; }
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                ((IDisposable) enumerator).Dispose();
            }
            if (num13 == 0)
              num19 = -1;
            binaryWriter.Write(num19);
            binaryWriter.Write(num13);
            binaryWriter.Write(num14);
            checked { ++index2; }
          }
          checked { ++index8; }
        }
        i_StaticFile.Close();
        binaryWriter.Close();
        fileStream3.Close();
        fileStream2.Close();
        this.iLogger.EndTask();
        this.iLogger.LogTimeStamp();
        this.iLogger.LogMessage("Done.");
      }
    }

    private void MenuPath_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.SelectedPath = this.ProjectPath.Text;
      if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
        return;
      this.ProjectPath.Text = folderBrowserDialog.SelectedPath;
    }

    private void MenuMake_Click(object sender, EventArgs e)
    {
      if (Interaction.MsgBox((object) "You are about to create the Mul Files\r\nAre you sure ?", MsgBoxStyle.YesNo, (object) "Make UO Map") != MsgBoxResult.Yes)
        return;
      new Thread(new ThreadStart(this.Make)).Start();
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
