// Decompiled with JetBrains decompiler
// Type: NewMapImage.MakeMapImage
// Assembly: NewMapImage, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: D5109B56-C280-4F7E-8021-67D531DD1A49
// Assembly location: W:\JetBrains\UOLandscaper\NewMapImage.exe

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

    internal virtual ComboBox ComboBox1
    {
      get
      {
        return this._ComboBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ComboBox1 == null)
          ;
        this._ComboBox1 = value;
        if (this._ComboBox1 != null)
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

    internal virtual ComboBox ComboBox2
    {
      get
      {
        return this._ComboBox2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ComboBox2 == null)
          ;
        this._ComboBox2 = value;
        if (this._ComboBox2 != null)
          ;
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

    internal virtual TextBox ProjectName
    {
      get
      {
        return this._ProjectName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ProjectName == null)
          ;
        this._ProjectName = value;
        if (this._ProjectName != null)
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

    internal virtual CheckBox Dungeon
    {
      get
      {
        return this._Dungeon;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Dungeon == null)
          ;
        this._Dungeon = value;
        if (this._Dungeon != null)
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

    internal virtual MenuItem MenuTerrain
    {
      get
      {
        return this._MenuTerrain;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuTerrain != null)
          this._MenuTerrain.Click -= new EventHandler(this.MenuTerrain_Click);
        this._MenuTerrain = value;
        if (this._MenuTerrain == null)
          return;
        this._MenuTerrain.Click += new EventHandler(this.MenuTerrain_Click);
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

    public MakeMapImage()
    {
      this.Load += new EventHandler(this.MakeMapImage_Load);
      this.iTerrain = new ClsTerrainTable();
      this.iAltitude = new ClsAltitudeTable();
      this.iLogger = new LoggerForm();
      this.InitializeComponent();
    }

    [STAThread]
    public static void Main()
    {
      Application.Run((Form) new MakeMapImage());
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
      ComboBox comboBox1_1 = this.ComboBox1;
      Point point1 = new Point(200, 72);
      Point point2 = point1;
      comboBox1_1.Location = point2;
      this.ComboBox1.Name = "ComboBox1";
      ComboBox comboBox1_2 = this.ComboBox1;
      Size size1 = new Size(144, 21);
      Size size2 = size1;
      comboBox1_2.Size = size2;
      this.ComboBox1.Sorted = true;
      this.ComboBox1.TabIndex = 38;
      this.Label3.AutoSize = true;
      Label label3_1 = this.Label3;
      point1 = new Point(200, 56);
      Point point3 = point1;
      label3_1.Location = point3;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(79, 16);
      Size size3 = size1;
      label3_2.Size = size3;
      this.Label3.TabIndex = 37;
      this.Label3.Text = "Default Terrain";
      CheckBox dungeon1 = this.Dungeon;
      point1 = new Point(352, 72);
      Point point4 = point1;
      dungeon1.Location = point4;
      this.Dungeon.Name = "Dungeon";
      CheckBox dungeon2 = this.Dungeon;
      size1 = new Size(24, 24);
      Size size4 = size1;
      dungeon2.Size = size4;
      this.Dungeon.TabIndex = 36;
      TextBox projectName1 = this.ProjectName;
      point1 = new Point(272, 24);
      Point point5 = point1;
      projectName1.Location = point5;
      this.ProjectName.Name = "ProjectName";
      TextBox projectName2 = this.ProjectName;
      size1 = new Size(152, 20);
      Size size5 = size1;
      projectName2.Size = size5;
      this.ProjectName.TabIndex = 35;
      this.ProjectName.Text = "";
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(272, 8);
      Point point6 = point1;
      label2_1.Location = point6;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(73, 16);
      Size size6 = size1;
      label2_2.Size = size6;
      this.Label2.TabIndex = 34;
      this.Label2.Text = "Project Name";
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(8, 8);
      Point point7 = point1;
      label1_1.Location = point7;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(31, 16);
      Size size7 = size1;
      label1_2.Size = size7;
      this.Label1.TabIndex = 33;
      this.Label1.Text = "Path:";
      TextBox projectPath1 = this.ProjectPath;
      point1 = new Point(8, 24);
      Point point8 = point1;
      projectPath1.Location = point8;
      this.ProjectPath.Name = "ProjectPath";
      TextBox projectPath2 = this.ProjectPath;
      size1 = new Size(256, 20);
      Size size8 = size1;
      projectPath2.Size = size8;
      this.ProjectPath.TabIndex = 32;
      this.ProjectPath.Text = "";
      TextBox terrainFile1 = this.TerrainFile;
      point1 = new Point(8, 120);
      Point point9 = point1;
      terrainFile1.Location = point9;
      this.TerrainFile.Name = "TerrainFile";
      TextBox terrainFile2 = this.TerrainFile;
      size1 = new Size(104, 20);
      Size size9 = size1;
      terrainFile2.Size = size9;
      this.TerrainFile.TabIndex = 41;
      this.TerrainFile.Text = "Terrain.bmp";
      ComboBox comboBox2_1 = this.ComboBox2;
      point1 = new Point(8, 72);
      Point point10 = point1;
      comboBox2_1.Location = point10;
      this.ComboBox2.Name = "ComboBox2";
      ComboBox comboBox2_2 = this.ComboBox2;
      size1 = new Size(184, 21);
      Size size10 = size1;
      comboBox2_2.Size = size10;
      this.ComboBox2.TabIndex = 40;
      this.Label5.AutoSize = true;
      this.Label5.ForeColor = Color.Black;
      Label label5_1 = this.Label5;
      point1 = new Point(8, 56);
      Point point11 = point1;
      label5_1.Location = point11;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(89, 16);
      Size size11 = size1;
      label5_2.Size = size11;
      this.Label5.TabIndex = 42;
      this.Label5.Text = "Select Map Size:";
      TextBox altitudeFile1 = this.AltitudeFile;
      point1 = new Point(120, 120);
      Point point12 = point1;
      altitudeFile1.Location = point12;
      this.AltitudeFile.Name = "AltitudeFile";
      TextBox altitudeFile2 = this.AltitudeFile;
      size1 = new Size(104, 20);
      Size size12 = size1;
      altitudeFile2.Size = size12;
      this.AltitudeFile.TabIndex = 47;
      this.AltitudeFile.Text = "Altitude.bmp";
      this.MainMenu1.MenuItems.AddRange(new MenuItem[2]
      {
        this.MenuPath,
        this.MenuTerrain
      });
      this.MenuPath.Index = 0;
      this.MenuPath.Text = "Path";
      this.MenuTerrain.Index = 1;
      this.MenuTerrain.Text = "Make Terrain/Altitude Image";
      this.Label4.AutoSize = true;
      Label label4_1 = this.Label4;
      point1 = new Point(352, 56);
      Point point13 = point1;
      label4_1.Location = point13;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(77, 16);
      Size size13 = size1;
      label4_2.Size = size13;
      this.Label4.TabIndex = 48;
      this.Label4.Text = "Dungeon Area";
      this.Label6.AutoSize = true;
      Label label6_1 = this.Label6;
      point1 = new Point(120, 104);
      Point point14 = point1;
      label6_1.Location = point14;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(102, 16);
      Size size14 = size1;
      label6_2.Size = size14;
      this.Label6.TabIndex = 50;
      this.Label6.Text = "Altitude Image Map";
      this.Label7.AutoSize = true;
      Label label7 = this.Label7;
      point1 = new Point(8, 104);
      Point point15 = point1;
      label7.Location = point15;
      this.Label7.Name = "Label7";
      this.Label7.TabIndex = 49;
      this.Label7.Text = "Terrain Image Map";
      this.ProgressBar1.Dock = DockStyle.Bottom;
      ProgressBar progressBar1_1 = this.ProgressBar1;
      point1 = new Point(0, 151);
      Point point16 = point1;
      progressBar1_1.Location = point16;
      this.ProgressBar1.Name = "ProgressBar1";
      ProgressBar progressBar1_2 = this.ProgressBar1;
      size1 = new Size(430, 16);
      Size size15 = size1;
      progressBar1_2.Size = size15;
      this.ProgressBar1.TabIndex = 51;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      this.BackColor = Color.FromArgb(224, 224, 224);
      size1 = new Size(430, 167);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.ProgressBar1);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.Label7);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.AltitudeFile);
      this.Controls.Add((Control) this.ProjectName);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.ProjectPath);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.ComboBox2);
      this.Controls.Add((Control) this.ComboBox1);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Dungeon);
      this.Controls.Add((Control) this.TerrainFile);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Menu = this.MainMenu1;
      this.Name = "MakeMapImage";
      this.Text = "Make New Image Map";
      this.ResumeLayout(false);
    }

    private void MakeMapImage_Load(object sender, EventArgs e)
    {
      this.iLogger.Show();
      this.Location = new Point(checked (this.iLogger.Location.X + 100), checked (this.iLogger.Location.Y + 100));
      this.iTerrain.Load();
      this.iAltitude.Load();
      string filename = string.Format("{0}\\Data\\System\\{1}", (object) Directory.GetCurrentDirectory(), (object) "MapInfo.xml");
      this.ProjectPath.Text = Directory.GetCurrentDirectory();
      this.iTerrain.Display(this.ComboBox1);
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(filename);
        try
        {
          this.ComboBox2.Items.Clear();
          try
          {
            foreach (XmlElement iXml in xmlDocument.SelectNodes("//Maps/Map"))
              this.ComboBox2.Items.Add((object) new MapInfo(iXml));
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
          this.iLogger.LogMessage(string.Format("XML Error:{0}", (object) ex.Message));
          ProjectData.ClearProjectError();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.iLogger.LogMessage(string.Format("Unable to find:{0}", (object) filename));
        ProjectData.ClearProjectError();
      }
    }

    public Bitmap MakeAltMap(int xSize, int ySize, byte DefaultAlt, bool Dungeon)
    {
      Bitmap bitmap = new Bitmap(xSize, ySize, PixelFormat.Format8bppIndexed);
      bitmap.Palette = this.iAltitude.GetAltPalette();
      Rectangle rect = new Rectangle(0, 0, xSize, ySize);
      BitmapData bitmapdata = bitmap.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
      IntPtr scan0 = bitmapdata.Scan0;
      int length = checked (bitmapdata.Width * bitmapdata.Height);
      byte[] numArray = new byte[checked (length - 1 + 1)];
      Marshal.Copy(scan0, numArray, 0, length);
      if (Dungeon)
      {
        int num1 = 0;
        int num2 = checked (xSize - 1);
        int num3 = num1;
        while (num3 <= num2)
        {
          int num4 = 0;
          int num5 = checked (ySize - 1);
          int num6 = num4;
          while (num6 <= num5)
          {
            numArray[checked (num6 * xSize + num3)] = num3 <= 5119 ? DefaultAlt : (byte) 72;
            checked { ++num6; }
          }
          checked { ++num3; }
        }
      }
      else
      {
        int num1 = 0;
        int num2 = checked (xSize - 1);
        int num3 = num1;
        while (num3 <= num2)
        {
          int num4 = 0;
          int num5 = checked (ySize - 1);
          int num6 = num4;
          while (num6 <= num5)
          {
            numArray[checked (num6 * xSize + num3)] = DefaultAlt;
            checked { ++num6; }
          }
          checked { ++num3; }
        }
      }
      Marshal.Copy(numArray, 0, scan0, length);
      bitmap.UnlockBits(bitmapdata);
      return bitmap;
    }

    public Bitmap MakeTerrainMap(int xSize, int ySize, byte DefaultTerrain, bool Dungeon)
    {
      Bitmap bitmap = new Bitmap(xSize, ySize, PixelFormat.Format8bppIndexed);
      bitmap.Palette = this.iTerrain.GetPalette();
      Rectangle rect = new Rectangle(0, 0, xSize, ySize);
      BitmapData bitmapdata = bitmap.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
      IntPtr scan0 = bitmapdata.Scan0;
      int length = checked (bitmapdata.Width * bitmapdata.Height);
      byte[] numArray = new byte[checked (length - 1 + 1)];
      Marshal.Copy(scan0, numArray, 0, length);
      if (Dungeon)
      {
        int num1 = 0;
        int num2 = checked (xSize - 1);
        int num3 = num1;
        while (num3 <= num2)
        {
          int num4 = 0;
          int num5 = checked (ySize - 1);
          int num6 = num4;
          while (num6 <= num5)
          {
            numArray[checked (num6 * xSize + num3)] = num3 <= 5119 ? DefaultTerrain : (byte) 19;
            checked { ++num6; }
          }
          checked { ++num3; }
        }
      }
      else
      {
        int num1 = 0;
        int num2 = checked (xSize - 1);
        int num3 = num1;
        while (num3 <= num2)
        {
          int num4 = 0;
          int num5 = checked (ySize - 1);
          int num6 = num4;
          while (num6 <= num5)
          {
            numArray[checked (num6 * xSize + num3)] = DefaultTerrain;
            checked { ++num6; }
          }
          checked { ++num3; }
        }
      }
      Marshal.Copy(numArray, 0, scan0, length);
      bitmap.UnlockBits(bitmapdata);
      return bitmap;
    }

    private void MenuPath_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.SelectedPath = this.ProjectPath.Text;
      if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
        return;
      this.ProjectPath.Text = folderBrowserDialog.SelectedPath;
    }

    private void MenuTerrain_Click(object sender, EventArgs e)
    {
      MapInfo mapInfo = (MapInfo) this.ComboBox2.SelectedItem;
      if (mapInfo == null)
        this.iLogger.LogMessage("Error: Select a Map Type.");
      else if (StringType.StrCmp(this.ProjectName.Text, string.Empty, false) == 0)
      {
        this.iLogger.LogMessage("Error: Enter a project Name.");
      }
      else
      {
        string path = string.Format("{0}/{1}/Map{2}", (object) this.ProjectPath.Text, (object) this.ProjectName.Text, (object) mapInfo.MapNumber);
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
        byte DefaultTerrain;
        byte DefaultAlt;
        if (this.ComboBox1.SelectedItem == null)
        {
          DefaultTerrain = (byte) 9;
          DefaultAlt = (byte) 66;
        }
        else
        {
          ClsTerrain clsTerrain = (ClsTerrain) this.ComboBox1.SelectedItem;
          DefaultTerrain = checked ((byte) clsTerrain.GroupID);
          DefaultAlt = clsTerrain.AltID;
        }
        this.iLogger.LogMessage("Creating Terrain Image.");
        this.iLogger.StartTask();
        try
        {
          string filename = string.Format("{0}/{1}", (object) path, (object) this.TerrainFile.Text);
          Bitmap bitmap = this.MakeTerrainMap(mapInfo.XSize, mapInfo.YSize, DefaultTerrain, this.Dungeon.Checked);
          bitmap.Palette = this.iTerrain.GetPalette();
          bitmap.Save(filename, ImageFormat.Bmp);
          bitmap.Dispose();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          this.iLogger.LogMessage("Error: Problem creating Terrain Image.");
          ProjectData.ClearProjectError();
        }
        this.iLogger.EndTask();
        this.iLogger.LogTimeStamp();
        this.iLogger.LogMessage("Creating Altitude Image.");
        this.iLogger.StartTask();
        try
        {
          string filename = string.Format("{0}/{1}", (object) path, (object) this.AltitudeFile.Text);
          Bitmap bitmap = this.MakeAltMap(mapInfo.XSize, mapInfo.YSize, DefaultAlt, this.Dungeon.Checked);
          bitmap.Palette = this.iAltitude.GetAltPalette();
          bitmap.Save(filename, ImageFormat.Bmp);
          bitmap.Dispose();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          this.iLogger.LogMessage("Error: Problem creating Altitude Image.");
          this.iLogger.LogMessage(exception.Message);
          ProjectData.ClearProjectError();
        }
        this.iLogger.EndTask();
        this.iLogger.LogTimeStamp();
        this.iLogger.LogMessage("Done.");
      }
    }
  }
}
