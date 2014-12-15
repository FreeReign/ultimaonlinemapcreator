// Decompiled with JetBrains decompiler
// Type: DragonConv.DragonConv
// Assembly: DragonConv, Version=1.0.1819.29268, Culture=neutral, PublicKeyToken=null
// MVID: BA7AE34F-ABD8-4700-AE28-2ED5A239CB08
// Assembly location: W:\JetBrains\UOLandscaper\DragonConv.exe

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
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Terrain;

namespace DragonConv
{
  public class DragonConv : Form
  {
    [AccessedThroughProperty("MainMenu1")]
    private MainMenu _MainMenu1;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("MenuItem1")]
    private MenuItem _MenuItem1;
    [AccessedThroughProperty("MenuUOLPath")]
    private MenuItem _MenuUOLPath;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("ProgressBar1")]
    private ProgressBar _ProgressBar1;
    [AccessedThroughProperty("MenuDragonPath")]
    private MenuItem _MenuDragonPath;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("MenuConv")]
    private MenuItem _MenuConv;
    [AccessedThroughProperty("MenuItem2")]
    private MenuItem _MenuItem2;
    [AccessedThroughProperty("MenuDragonFile")]
    private MenuItem _MenuDragonFile;
    [AccessedThroughProperty("AltitudeFile")]
    private TextBox _AltitudeFile;
    [AccessedThroughProperty("TerrainFile")]
    private TextBox _TerrainFile;
    [AccessedThroughProperty("ProjectPath")]
    private TextBox _ProjectPath;
    [AccessedThroughProperty("ProjectName")]
    private TextBox _ProjectName;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("DragonPath")]
    private TextBox _DragonPath;
    [AccessedThroughProperty("DragonImage")]
    private TextBox _DragonImage;
    [AccessedThroughProperty("MenuUOLProjectName")]
    private MenuItem _MenuUOLProjectName;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("ComboBox1")]
    private ComboBox _ComboBox1;
    private Bitmap i_Dragon;
    private Bitmap i_Terrain;
    private Bitmap i_Altitude;
    private ClsTerrainTable iTerrain;
    private ClsAltitudeTable iAltitude;
    private ClsDragonTable iDragon;
    public LoggerForm iLogger;
    private IContainer components;

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

    internal virtual MenuItem MenuItem2
    {
      get
      {
        return this._MenuItem2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem2 == null)
          ;
        this._MenuItem2 = value;
        if (this._MenuItem2 != null)
          ;
      }
    }

    internal virtual MenuItem MenuDragonPath
    {
      get
      {
        return this._MenuDragonPath;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuDragonPath != null)
          this._MenuDragonPath.Click -= new EventHandler(this.MenuDragonPath_Click);
        this._MenuDragonPath = value;
        if (this._MenuDragonPath == null)
          return;
        this._MenuDragonPath.Click += new EventHandler(this.MenuDragonPath_Click);
      }
    }

    internal virtual MenuItem MenuUOLPath
    {
      get
      {
        return this._MenuUOLPath;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuUOLPath != null)
          this._MenuUOLPath.Click -= new EventHandler(this.MenuUOLPath_Click);
        this._MenuUOLPath = value;
        if (this._MenuUOLPath == null)
          return;
        this._MenuUOLPath.Click += new EventHandler(this.MenuUOLPath_Click);
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

    internal virtual GroupBox GroupBox1
    {
      get
      {
        return this._GroupBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GroupBox1 == null)
          ;
        this._GroupBox1 = value;
        if (this._GroupBox1 != null)
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

    internal virtual GroupBox GroupBox2
    {
      get
      {
        return this._GroupBox2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GroupBox2 == null)
          ;
        this._GroupBox2 = value;
        if (this._GroupBox2 != null)
          ;
      }
    }

    internal virtual MenuItem MenuConv
    {
      get
      {
        return this._MenuConv;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuConv != null)
          this._MenuConv.Click -= new EventHandler(this.MenuConv_Click);
        this._MenuConv = value;
        if (this._MenuConv == null)
          return;
        this._MenuConv.Click += new EventHandler(this.MenuConv_Click);
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

    internal virtual ComboBox ComboBox1
    {
      get
      {
        return this._ComboBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ComboBox1 != null)
          this._ComboBox1.SelectedIndexChanged -= new EventHandler(this.ComboBox1_SelectedIndexChanged);
        this._ComboBox1 = value;
        if (this._ComboBox1 == null)
          return;
        this._ComboBox1.SelectedIndexChanged += new EventHandler(this.ComboBox1_SelectedIndexChanged);
      }
    }

    internal virtual MenuItem MenuDragonFile
    {
      get
      {
        return this._MenuDragonFile;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuDragonFile != null)
          this._MenuDragonFile.Click -= new EventHandler(this.MenuDragonFile_Click);
        this._MenuDragonFile = value;
        if (this._MenuDragonFile == null)
          return;
        this._MenuDragonFile.Click += new EventHandler(this.MenuDragonFile_Click);
      }
    }

    internal virtual TextBox DragonPath
    {
      get
      {
        return this._DragonPath;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DragonPath == null)
          ;
        this._DragonPath = value;
        if (this._DragonPath != null)
          ;
      }
    }

    internal virtual TextBox DragonImage
    {
      get
      {
        return this._DragonImage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._DragonImage == null)
          ;
        this._DragonImage = value;
        if (this._DragonImage != null)
          ;
      }
    }

    internal virtual MenuItem MenuUOLProjectName
    {
      get
      {
        return this._MenuUOLProjectName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuUOLProjectName != null)
          this._MenuUOLProjectName.Click -= new EventHandler(this.MenuUOLProjectName_Click);
        this._MenuUOLProjectName = value;
        if (this._MenuUOLProjectName == null)
          return;
        this._MenuUOLProjectName.Click += new EventHandler(this.MenuUOLProjectName_Click);
      }
    }

    public DragonConv()
    {
      this.Load += new EventHandler(this.DragonConv_Load);
      this.iTerrain = new ClsTerrainTable();
      this.iAltitude = new ClsAltitudeTable();
      this.iDragon = new ClsDragonTable();
      this.iLogger = new LoggerForm();
      this.InitializeComponent();
    }

    [STAThread]
    public static void Main()
    {
      Application.Run((Form) new DragonConv());
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
      this.MenuItem1 = new MenuItem();
      this.MenuDragonPath = new MenuItem();
      this.MenuDragonFile = new MenuItem();
      this.MenuItem2 = new MenuItem();
      this.MenuUOLPath = new MenuItem();
      this.MenuUOLProjectName = new MenuItem();
      this.MenuConv = new MenuItem();
      this.Label1 = new Label();
      this.DragonPath = new TextBox();
      this.Label2 = new Label();
      this.DragonImage = new TextBox();
      this.GroupBox1 = new GroupBox();
      this.Label3 = new Label();
      this.ComboBox1 = new ComboBox();
      this.GroupBox2 = new GroupBox();
      this.Label4 = new Label();
      this.ProjectPath = new TextBox();
      this.Label5 = new Label();
      this.ProjectName = new TextBox();
      this.Label7 = new Label();
      this.TerrainFile = new TextBox();
      this.Label6 = new Label();
      this.AltitudeFile = new TextBox();
      this.ProgressBar1 = new ProgressBar();
      this.GroupBox1.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.SuspendLayout();
      this.MainMenu1.MenuItems.AddRange(new MenuItem[3]
      {
        this.MenuItem1,
        this.MenuItem2,
        this.MenuConv
      });
      this.MenuItem1.Index = 0;
      this.MenuItem1.MenuItems.AddRange(new MenuItem[2]
      {
        this.MenuDragonPath,
        this.MenuDragonFile
      });
      this.MenuItem1.Text = "Dragon";
      this.MenuDragonPath.Index = 0;
      this.MenuDragonPath.Text = "Select Path";
      this.MenuDragonFile.Index = 1;
      this.MenuDragonFile.Text = "Select Map File";
      this.MenuItem2.Index = 1;
      this.MenuItem2.MenuItems.AddRange(new MenuItem[2]
      {
        this.MenuUOLPath,
        this.MenuUOLProjectName
      });
      this.MenuItem2.Text = "UO Landscaper";
      this.MenuUOLPath.Index = 0;
      this.MenuUOLPath.Text = "Select Path";
      this.MenuUOLProjectName.Index = 1;
      this.MenuUOLProjectName.Text = "Select Project Name";
      this.MenuConv.Index = 2;
      this.MenuConv.Text = "Convert";
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      Point point1 = new Point(8, 16);
      Point point2 = point1;
      label1_1.Location = point2;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      Size size1 = new Size(27, 16);
      Size size2 = size1;
      label1_2.Size = size2;
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Path";
      TextBox dragonPath1 = this.DragonPath;
      point1 = new Point(24, 32);
      Point point3 = point1;
      dragonPath1.Location = point3;
      this.DragonPath.Name = "DragonPath";
      TextBox dragonPath2 = this.DragonPath;
      size1 = new Size(240, 20);
      Size size3 = size1;
      dragonPath2.Size = size3;
      this.DragonPath.TabIndex = 1;
      this.DragonPath.Text = "";
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(8, 56);
      Point point4 = point1;
      label2_1.Location = point4;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(61, 16);
      Size size4 = size1;
      label2_2.Size = size4;
      this.Label2.TabIndex = 2;
      this.Label2.Text = "Map Image";
      TextBox dragonImage1 = this.DragonImage;
      point1 = new Point(24, 72);
      Point point5 = point1;
      dragonImage1.Location = point5;
      this.DragonImage.Name = "DragonImage";
      TextBox dragonImage2 = this.DragonImage;
      size1 = new Size(104, 20);
      Size size5 = size1;
      dragonImage2.Size = size5;
      this.DragonImage.TabIndex = 3;
      this.DragonImage.Text = "";
      this.GroupBox1.Controls.Add((Control) this.Label3);
      this.GroupBox1.Controls.Add((Control) this.Label1);
      this.GroupBox1.Controls.Add((Control) this.DragonPath);
      this.GroupBox1.Controls.Add((Control) this.DragonImage);
      this.GroupBox1.Controls.Add((Control) this.Label2);
      this.GroupBox1.Controls.Add((Control) this.ComboBox1);
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(8, 8);
      Point point6 = point1;
      groupBox1_1.Location = point6;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(272, 144);
      Size size6 = size1;
      groupBox1_2.Size = size6;
      this.GroupBox1.TabIndex = 4;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Dragon Image Info";
      this.Label3.AutoSize = true;
      Label label3_1 = this.Label3;
      point1 = new Point(8, 96);
      Point point7 = point1;
      label3_1.Location = point7;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(93, 16);
      Size size7 = size1;
      label3_2.Size = size7;
      this.Label3.TabIndex = 4;
      this.Label3.Text = "Select MOD Type";
      ComboBox comboBox1_1 = this.ComboBox1;
      point1 = new Point(24, 112);
      Point point8 = point1;
      comboBox1_1.Location = point8;
      this.ComboBox1.Name = "ComboBox1";
      ComboBox comboBox1_2 = this.ComboBox1;
      size1 = new Size(136, 21);
      Size size8 = size1;
      comboBox1_2.Size = size8;
      this.ComboBox1.TabIndex = 7;
      this.GroupBox2.Controls.Add((Control) this.Label4);
      this.GroupBox2.Controls.Add((Control) this.ProjectPath);
      this.GroupBox2.Controls.Add((Control) this.Label5);
      this.GroupBox2.Controls.Add((Control) this.ProjectName);
      this.GroupBox2.Controls.Add((Control) this.Label7);
      this.GroupBox2.Controls.Add((Control) this.TerrainFile);
      this.GroupBox2.Controls.Add((Control) this.Label6);
      this.GroupBox2.Controls.Add((Control) this.AltitudeFile);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(8, 160);
      Point point9 = point1;
      groupBox2_1.Location = point9;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(272, 184);
      Size size9 = size1;
      groupBox2_2.Size = size9;
      this.GroupBox2.TabIndex = 5;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "UO Landscaper Info";
      this.Label4.AutoSize = true;
      Label label4_1 = this.Label4;
      point1 = new Point(8, 16);
      Point point10 = point1;
      label4_1.Location = point10;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(31, 16);
      Size size10 = size1;
      label4_2.Size = size10;
      this.Label4.TabIndex = 35;
      this.Label4.Text = "Path:";
      TextBox projectPath1 = this.ProjectPath;
      point1 = new Point(24, 32);
      Point point11 = point1;
      projectPath1.Location = point11;
      this.ProjectPath.Name = "ProjectPath";
      TextBox projectPath2 = this.ProjectPath;
      size1 = new Size(240, 20);
      Size size11 = size1;
      projectPath2.Size = size11;
      this.ProjectPath.TabIndex = 34;
      this.ProjectPath.Text = "";
      this.Label5.AutoSize = true;
      Label label5_1 = this.Label5;
      point1 = new Point(8, 56);
      Point point12 = point1;
      label5_1.Location = point12;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(73, 16);
      Size size12 = size1;
      label5_2.Size = size12;
      this.Label5.TabIndex = 51;
      this.Label5.Text = "Project Name";
      TextBox projectName1 = this.ProjectName;
      point1 = new Point(24, 72);
      Point point13 = point1;
      projectName1.Location = point13;
      this.ProjectName.Name = "ProjectName";
      TextBox projectName2 = this.ProjectName;
      size1 = new Size(136, 20);
      Size size13 = size1;
      projectName2.Size = size13;
      this.ProjectName.TabIndex = 52;
      this.ProjectName.Text = "";
      this.Label7.AutoSize = true;
      Label label7 = this.Label7;
      point1 = new Point(8, 96);
      Point point14 = point1;
      label7.Location = point14;
      this.Label7.Name = "Label7";
      this.Label7.TabIndex = 57;
      this.Label7.Text = "Terrain Image Map";
      TextBox terrainFile1 = this.TerrainFile;
      point1 = new Point(24, 112);
      Point point15 = point1;
      terrainFile1.Location = point15;
      this.TerrainFile.Name = "TerrainFile";
      TextBox terrainFile2 = this.TerrainFile;
      size1 = new Size(104, 20);
      Size size14 = size1;
      terrainFile2.Size = size14;
      this.TerrainFile.TabIndex = 54;
      this.TerrainFile.Text = "Terrain.bmp";
      this.Label6.AutoSize = true;
      Label label6_1 = this.Label6;
      point1 = new Point(8, 136);
      Point point16 = point1;
      label6_1.Location = point16;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(102, 16);
      Size size15 = size1;
      label6_2.Size = size15;
      this.Label6.TabIndex = 58;
      this.Label6.Text = "Altitude Image Map";
      TextBox altitudeFile1 = this.AltitudeFile;
      point1 = new Point(24, 152);
      Point point17 = point1;
      altitudeFile1.Location = point17;
      this.AltitudeFile.Name = "AltitudeFile";
      TextBox altitudeFile2 = this.AltitudeFile;
      size1 = new Size(104, 20);
      Size size16 = size1;
      altitudeFile2.Size = size16;
      this.AltitudeFile.TabIndex = 56;
      this.AltitudeFile.Text = "Altitude.bmp";
      this.ProgressBar1.Dock = DockStyle.Bottom;
      ProgressBar progressBar1_1 = this.ProgressBar1;
      point1 = new Point(0, 351);
      Point point18 = point1;
      progressBar1_1.Location = point18;
      this.ProgressBar1.Name = "ProgressBar1";
      ProgressBar progressBar1_2 = this.ProgressBar1;
      size1 = new Size(286, 16);
      Size size17 = size1;
      progressBar1_2.Size = size17;
      this.ProgressBar1.TabIndex = 6;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      this.BackColor = Color.FromArgb(224, 224, 224);
      size1 = new Size(286, 367);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.ProgressBar1);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.GroupBox1);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Menu = this.MainMenu1;
      this.Name = "DragonConv";
      this.Text = "Dragon to UO Landscaper Image Convertor";
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox2.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void MenuConv_Click(object sender, EventArgs e)
    {
      new Thread(new ThreadStart(this.Make)).Start();
    }

    private void MenuDragonPath_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;
      if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
        return;
      this.DragonPath.Text = folderBrowserDialog.SelectedPath;
    }

    private void MenuDragonFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.InitialDirectory = this.DragonPath.Text;
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.DragonImage.Text = new FileInfo(openFileDialog.FileName).Name;
    }

    private void DragonConv_Load(object sender, EventArgs e)
    {
      this.iLogger.Show();
      this.Load_TransMap();
    }

    private void Load_TransMap()
    {
      string filename = string.Format("{0}\\Data\\System\\MapTrans\\{1}", (object) AppDomain.CurrentDomain.BaseDirectory, (object) "TransInfo.xml");
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(filename);
        try
        {
          this.ComboBox1.Items.Clear();
          try
          {
            foreach (XmlElement iElement in xmlDocument.SelectNodes("//Dragon/MapTrans"))
              this.ComboBox1.Items.Add((object) new TransInfo(iElement));
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

    private void MenuUOLPath_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;
      if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
        return;
      this.ProjectPath.Text = folderBrowserDialog.SelectedPath;
    }

    private void MenuUOLProjectName_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.InitialDirectory = this.ProjectPath.Text;
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.DragonImage.Text = new FileInfo(openFileDialog.FileName).Name;
    }

    private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void Make()
    {
      this.iLogger.LogMessage("Dragon to UO Landscaper Conversion");
      this.iLogger.StartTask();
      if (StringType.StrCmp(this.ProjectName.Text, string.Empty, false) == 0)
      {
        this.iLogger.LogMessage("Error: Enter a project Name.");
      }
      else
      {
        this.iLogger.LogMessage("Loading Dragon Image.");
        try
        {
          string str = string.Format("{0}\\{1}", (object) this.DragonPath.Text, (object) this.DragonImage.Text);
          this.iLogger.LogMessage(str);
          this.i_Dragon = new Bitmap(str);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          this.iLogger.LogMessage("Problem with Loading Dragon Image.");
          this.iLogger.LogMessage(exception.Message);
          ProjectData.ClearProjectError();
          return;
        }
        this.iLogger.LogMessage("Preparing Dragon Image.");
        int width = this.i_Dragon.Width;
        int height = this.i_Dragon.Height;
        Rectangle rect = new Rectangle(0, 0, width, height);
        BitmapData bitmapData = this.i_Dragon.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
        IntPtr scan0_1 = bitmapData.Scan0;
        int length1 = checked (bitmapData.Width * bitmapData.Height);
        byte[] destination = new byte[checked (length1 - 1 + 1)];
        Marshal.Copy(scan0_1, destination, 0, length1);
        Bitmap bitmap1 = new Bitmap(width, height, PixelFormat.Format8bppIndexed);
        BitmapData bitmapdata1 = bitmap1.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
        IntPtr scan0_2 = bitmapdata1.Scan0;
        int length2 = checked (bitmapdata1.Width * bitmapdata1.Height);
        byte[] numArray1 = new byte[checked (length2 - 1 + 1)];
        Marshal.Copy(scan0_2, numArray1, 0, length2);
        Bitmap bitmap2 = new Bitmap(width, height, PixelFormat.Format8bppIndexed);
        BitmapData bitmapdata2 = bitmap2.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
        IntPtr scan0_3 = bitmapdata2.Scan0;
        int length3 = checked (bitmapdata2.Width * bitmapdata2.Height);
        byte[] numArray2 = new byte[checked (length3 - 1 + 1)];
        Marshal.Copy(scan0_3, numArray2, 0, length3);
        this.iAltitude.Load();
        this.iTerrain.Load();
        TransInfo transInfo = (TransInfo) this.ComboBox1.SelectedItem;
        if (transInfo == null)
        {
          this.iLogger.LogMessage("Error: Please select which dragon mod to convert from.");
        }
        else
        {
          this.iDragon.Load(string.Format("{0}{1}", (object) AppDomain.CurrentDomain.BaseDirectory, (object) transInfo.Location));
          this.ProgressBar1.Maximum = checked (length1 - 1);
          int num1 = 0;
          int num2 = checked (length1 - 1);
          int index = num1;
          while (index <= num2)
          {
            byte num3 = destination[index];
            ClsDragon clsDragon = this.iDragon.get_GetDragon((int) num3);
            if (clsDragon != null)
            {
              numArray2[index] = clsDragon.AltitudeID;
              numArray1[index] = clsDragon.TerrainID;
            }
            else
            {
              this.iLogger.LogMessage(string.Format("Loc:{0} Color:{1}", (object) index, (object) num3));
              numArray2[index] = (byte) 0;
              numArray1[index] = (byte) 0;
            }
            this.ProgressBar1.Value = index;
            checked { ++index; }
          }
          Marshal.Copy(numArray2, 0, scan0_3, length3);
          bitmap2.UnlockBits(bitmapdata2);
          Marshal.Copy(numArray1, 0, scan0_2, length2);
          bitmap1.UnlockBits(bitmapdata1);
          string path = string.Format("{0}/{1}/Dragon", (object) this.ProjectPath.Text, (object) this.ProjectName.Text);
          if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
          string filename1 = string.Format("{0}/{1}", (object) path, (object) this.TerrainFile.Text);
          this.iTerrain.Load();
          bitmap1.Palette = this.iTerrain.GetPalette();
          bitmap1.Save(filename1, ImageFormat.Bmp);
          bitmap1.Dispose();
          string filename2 = string.Format("{0}/{1}", (object) path, (object) this.AltitudeFile.Text);
          this.iAltitude.Load();
          bitmap2.Palette = this.iAltitude.GetAltPalette();
          bitmap2.Save(filename2, ImageFormat.Bmp);
          bitmap2.Dispose();
          this.iLogger.EndTask();
          this.iLogger.LogTimeStamp();
          this.iLogger.LogMessage("Done.");
        }
      }
    }
  }
}
