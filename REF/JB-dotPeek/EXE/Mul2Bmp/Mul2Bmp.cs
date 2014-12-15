// Decompiled with JetBrains decompiler
// Type: Mul2Bmp.Mul2Bmp
// Assembly: Mul2Bmp, Version=1.0.1819.29268, Culture=neutral, PublicKeyToken=null
// MVID: 506024DD-8CAC-40CD-B69F-D3FE368345E8
// Assembly location: W:\JetBrains\UOLandscaper\Mul2Bmp.exe

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

    internal virtual TextBox Path2Image
    {
      get
      {
        return this._Path2Image;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Path2Image == null)
          ;
        this._Path2Image = value;
        if (this._Path2Image != null)
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

    internal virtual TextBox Path2Mul
    {
      get
      {
        return this._Path2Mul;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Path2Mul == null)
          ;
        this._Path2Mul = value;
        if (this._Path2Mul != null)
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

    internal virtual MenuItem MenuMul
    {
      get
      {
        return this._MenuMul;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuMul != null)
          this._MenuMul.Click -= new EventHandler(this.MenuMul_Click);
        this._MenuMul = value;
        if (this._MenuMul == null)
          return;
        this._MenuMul.Click += new EventHandler(this.MenuMul_Click);
      }
    }

    internal virtual MenuItem MenuImage
    {
      get
      {
        return this._MenuImage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuImage != null)
          this._MenuImage.Click -= new EventHandler(this.MenuImage_Click);
        this._MenuImage = value;
        if (this._MenuImage == null)
          return;
        this._MenuImage.Click += new EventHandler(this.MenuImage_Click);
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

    internal virtual FolderBrowserDialog FolderBrowserDialog1
    {
      get
      {
        return this._FolderBrowserDialog1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._FolderBrowserDialog1 == null)
          ;
        this._FolderBrowserDialog1 = value;
        if (this._FolderBrowserDialog1 != null)
          ;
      }
    }

    public Mul2Bmp()
    {
      this.Load += new EventHandler(this.Mul2Bmp_Load);
      this.iLogger = new LoggerForm();
      this.InitializeComponent();
    }

    [STAThread]
    public static void Main()
    {
      Application.Run((Form) new Mul2Bmp());
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
      Label label5_1 = this.Label5;
      Point point1 = new Point(8, 144);
      Point point2 = point1;
      label5_1.Location = point2;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      Size size1 = new Size(89, 16);
      Size size2 = size1;
      label5_2.Size = size2;
      this.Label5.TabIndex = 44;
      this.Label5.Text = "Select Map Size:";
      ComboBox comboBox2_1 = this.ComboBox2;
      point1 = new Point(8, 160);
      Point point3 = point1;
      comboBox2_1.Location = point3;
      this.ComboBox2.Name = "ComboBox2";
      ComboBox comboBox2_2 = this.ComboBox2;
      size1 = new Size(184, 21);
      Size size3 = size1;
      comboBox2_2.Size = size3;
      this.ComboBox2.TabIndex = 43;
      this.Label6.AutoSize = true;
      Label label6_1 = this.Label6;
      point1 = new Point(120, 184);
      Point point4 = point1;
      label6_1.Location = point4;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(102, 16);
      Size size4 = size1;
      label6_2.Size = size4;
      this.Label6.TabIndex = 58;
      this.Label6.Text = "Altitude Image Map";
      this.Label7.AutoSize = true;
      Label label7 = this.Label7;
      point1 = new Point(8, 184);
      Point point5 = point1;
      label7.Location = point5;
      this.Label7.Name = "Label7";
      this.Label7.TabIndex = 57;
      this.Label7.Text = "Terrain Image Map";
      TextBox altitudeFile1 = this.AltitudeFile;
      point1 = new Point(120, 200);
      Point point6 = point1;
      altitudeFile1.Location = point6;
      this.AltitudeFile.Name = "AltitudeFile";
      TextBox altitudeFile2 = this.AltitudeFile;
      size1 = new Size(104, 20);
      Size size5 = size1;
      altitudeFile2.Size = size5;
      this.AltitudeFile.TabIndex = 56;
      this.AltitudeFile.Text = "Altitude.bmp";
      TextBox projectName1 = this.ProjectName;
      point1 = new Point(8, 104);
      Point point7 = point1;
      projectName1.Location = point7;
      this.ProjectName.Name = "ProjectName";
      TextBox projectName2 = this.ProjectName;
      size1 = new Size(152, 20);
      Size size6 = size1;
      projectName2.Size = size6;
      this.ProjectName.TabIndex = 54;
      this.ProjectName.Text = "";
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(8, 88);
      Point point8 = point1;
      label2_1.Location = point8;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(73, 16);
      Size size7 = size1;
      label2_2.Size = size7;
      this.Label2.TabIndex = 53;
      this.Label2.Text = "Project Name";
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(8, 48);
      Point point9 = point1;
      label1_1.Location = point9;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(65, 16);
      Size size8 = size1;
      label1_2.Size = size8;
      this.Label1.TabIndex = 52;
      this.Label1.Text = "Image Path:";
      TextBox path2Image1 = this.Path2Image;
      point1 = new Point(8, 64);
      Point point10 = point1;
      path2Image1.Location = point10;
      this.Path2Image.Name = "Path2Image";
      TextBox path2Image2 = this.Path2Image;
      size1 = new Size(280, 20);
      Size size9 = size1;
      path2Image2.Size = size9;
      this.Path2Image.TabIndex = 51;
      this.Path2Image.Text = "";
      TextBox terrainFile1 = this.TerrainFile;
      point1 = new Point(8, 200);
      Point point11 = point1;
      terrainFile1.Location = point11;
      this.TerrainFile.Name = "TerrainFile";
      TextBox terrainFile2 = this.TerrainFile;
      size1 = new Size(104, 20);
      Size size10 = size1;
      terrainFile2.Size = size10;
      this.TerrainFile.TabIndex = 55;
      this.TerrainFile.Text = "Terrain.bmp";
      this.ProgressBar1.Dock = DockStyle.Bottom;
      ProgressBar progressBar1_1 = this.ProgressBar1;
      point1 = new Point(0, 235);
      Point point12 = point1;
      progressBar1_1.Location = point12;
      this.ProgressBar1.Name = "ProgressBar1";
      ProgressBar progressBar1_2 = this.ProgressBar1;
      size1 = new Size(294, 16);
      Size size11 = size1;
      progressBar1_2.Size = size11;
      this.ProgressBar1.TabIndex = 59;
      this.Label3.AutoSize = true;
      Label label3_1 = this.Label3;
      point1 = new Point(8, 8);
      Point point13 = point1;
      label3_1.Location = point13;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(64, 16);
      Size size12 = size1;
      label3_2.Size = size12;
      this.Label3.TabIndex = 62;
      this.Label3.Text = "Path to Mul:";
      TextBox path2Mul1 = this.Path2Mul;
      point1 = new Point(8, 24);
      Point point14 = point1;
      path2Mul1.Location = point14;
      this.Path2Mul.Name = "Path2Mul";
      TextBox path2Mul2 = this.Path2Mul;
      size1 = new Size(280, 20);
      Size size13 = size1;
      path2Mul2.Size = size13;
      this.Path2Mul.TabIndex = 61;
      this.Path2Mul.Text = "";
      this.MainMenu1.MenuItems.AddRange(new MenuItem[2]
      {
        this.MenuItem1,
        this.MenuMake
      });
      this.MenuItem1.Index = 0;
      this.MenuItem1.MenuItems.AddRange(new MenuItem[2]
      {
        this.MenuMul,
        this.MenuImage
      });
      this.MenuItem1.Text = "File";
      this.MenuMul.Index = 0;
      this.MenuMul.Text = "Mul Path";
      this.MenuImage.Index = 1;
      this.MenuImage.Text = "Image Path";
      this.MenuMake.Index = 1;
      this.MenuMake.Text = "Make";
      this.FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      this.BackColor = Color.FromArgb(224, 224, 224);
      size1 = new Size(294, 251);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Path2Mul);
      this.Controls.Add((Control) this.ProgressBar1);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.Label7);
      this.Controls.Add((Control) this.AltitudeFile);
      this.Controls.Add((Control) this.ProjectName);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Path2Image);
      this.Controls.Add((Control) this.TerrainFile);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.ComboBox2);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Menu = this.MainMenu1;
      this.Name = "Mul2Bmp";
      this.Text = "Make Mul To Bmp";
      this.ResumeLayout(false);
    }

    private void Mul2Bmp_Load(object sender, EventArgs e)
    {
      string filename = string.Format("{0}\\Data\\System\\{1}", (object) Directory.GetCurrentDirectory(), (object) "MapInfo.xml");
      this.Path2Image.Text = Directory.GetCurrentDirectory();
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

    private void MenuMul_Click(object sender, EventArgs e)
    {
      this.FolderBrowserDialog1.SelectedPath = Directory.GetCurrentDirectory();
      if (this.FolderBrowserDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.Path2Mul.Text = this.FolderBrowserDialog1.SelectedPath;
    }

    private void MenuImage_Click(object sender, EventArgs e)
    {
      this.FolderBrowserDialog1.SelectedPath = Directory.GetCurrentDirectory();
      if (this.FolderBrowserDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.Path2Image.Text = this.FolderBrowserDialog1.SelectedPath;
    }

    private void MenuMake_Click(object sender, EventArgs e)
    {
      if (Interaction.MsgBox((object) "It is illegal to convert the OSI maps into BMP using this tool.\r\nDo you wish to continue ?", MsgBoxStyle.OKOnly, (object) null) == MsgBoxResult.OK)
        ;
    }
  }
}
