// Decompiled with JetBrains decompiler
// Type: AltImagePrep.AltImagePrep
// Assembly: AltImagePrep, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: C80B9EBF-92D0-4184-8454-3A8074B0C0A1
// Assembly location: W:\JetBrains\UOLandscaper\AltImagePrep.exe

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

    public AltImagePrep()
    {
      this.Load += new EventHandler(this.AltImagePrep_Load);
      this.iTerrain = new ClsTerrainTable();
      this.iAltitude = new ClsAltitudeTable();
      this.iLogger = new LoggerForm();
      this.InitializeComponent();
    }

    [STAThread]
    public static void Main()
    {
      Application.Run((Form) new AltImagePrep());
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
      Label label3_1 = this.Label3;
      Point point1 = new Point(392, 8);
      Point point2 = point1;
      label3_1.Location = point2;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      Size size1 = new Size(102, 16);
      Size size2 = size1;
      label3_2.Size = size2;
      this.Label3.TabIndex = 15;
      this.Label3.Text = "Altitude Image Map";
      this.Label2.AutoSize = true;
      Label label2 = this.Label2;
      point1 = new Point(280, 8);
      Point point3 = point1;
      label2.Location = point3;
      this.Label2.Name = "Label2";
      this.Label2.TabIndex = 14;
      this.Label2.Text = "Terrain Image Map";
      TextBox altitudeFile1 = this.AltitudeFile;
      point1 = new Point(392, 24);
      Point point4 = point1;
      altitudeFile1.Location = point4;
      this.AltitudeFile.Name = "AltitudeFile";
      TextBox altitudeFile2 = this.AltitudeFile;
      size1 = new Size(104, 20);
      Size size3 = size1;
      altitudeFile2.Size = size3;
      this.AltitudeFile.TabIndex = 11;
      this.AltitudeFile.Text = "Altitude.bmp";
      TextBox terrainFile1 = this.TerrainFile;
      point1 = new Point(280, 24);
      Point point5 = point1;
      terrainFile1.Location = point5;
      this.TerrainFile.Name = "TerrainFile";
      TextBox terrainFile2 = this.TerrainFile;
      size1 = new Size(104, 20);
      Size size4 = size1;
      terrainFile2.Size = size4;
      this.TerrainFile.TabIndex = 10;
      this.TerrainFile.Text = "Terrain.bmp";
      TextBox projectPath1 = this.ProjectPath;
      point1 = new Point(8, 24);
      Point point6 = point1;
      projectPath1.Location = point6;
      this.ProjectPath.Name = "ProjectPath";
      TextBox projectPath2 = this.ProjectPath;
      size1 = new Size(264, 20);
      Size size5 = size1;
      projectPath2.Size = size5;
      this.ProjectPath.TabIndex = 8;
      this.ProjectPath.Text = "";
      this.MainMenu1.MenuItems.AddRange(new MenuItem[2]
      {
        this.MenuPath,
        this.MenuMake
      });
      this.MenuPath.Index = 0;
      this.MenuPath.Text = "Path";
      this.MenuMake.Index = 1;
      this.MenuMake.Text = "Make Altitude Image";
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(8, 8);
      Point point7 = point1;
      label1_1.Location = point7;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(27, 16);
      Size size6 = size1;
      label1_2.Size = size6;
      this.Label1.TabIndex = 16;
      this.Label1.Text = "Path";
      this.ProgressBar1.Dock = DockStyle.Bottom;
      ProgressBar progressBar1_1 = this.ProgressBar1;
      point1 = new Point(0, 55);
      Point point8 = point1;
      progressBar1_1.Location = point8;
      this.ProgressBar1.Name = "ProgressBar1";
      ProgressBar progressBar1_2 = this.ProgressBar1;
      size1 = new Size(502, 16);
      Size size7 = size1;
      progressBar1_2.Size = size7;
      this.ProgressBar1.Step = 1;
      this.ProgressBar1.TabIndex = 17;
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      this.BackColor = Color.FromArgb(224, 224, 224);
      size1 = new Size(502, 71);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.ProgressBar1);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.AltitudeFile);
      this.Controls.Add((Control) this.TerrainFile);
      this.Controls.Add((Control) this.ProjectPath);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Menu = this.MainMenu1;
      this.Name = "AltImagePrep";
      this.Text = "UO Altitude Map Set";
      this.ResumeLayout(false);
    }

    private void AltImagePrep_Load(object sender, EventArgs e)
    {
      this.iLogger.Show();
      this.Location = new Point(checked (this.iLogger.Location.X + 100), checked (this.iLogger.Location.Y + 100));
      this.ProjectPath.Text = Directory.GetCurrentDirectory();
      this.iTerrain.Load();
      this.iAltitude.Load();
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
      Bitmap bitmap1;
      Bitmap bitmap2;
      try
      {
        this.iLogger.LogMessage("Load Terrain Image Map.");
        bitmap1 = new Bitmap(string.Format("{0}\\{1}", (object) this.ProjectPath.Text, (object) this.TerrainFile.Text));
        bitmap2 = new Bitmap(bitmap1.Width, bitmap1.Height, PixelFormat.Format8bppIndexed);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.iLogger.LogMessage("Error in loading image maps.\r\n");
        this.iLogger.LogMessage(exception.Message);
        ProjectData.ClearProjectError();
      }
      bitmap2.Palette = this.iAltitude.GetAltPalette();
      Rectangle rect = new Rectangle(0, 0, bitmap1.Width, bitmap1.Height);
      BitmapData bitmapData = bitmap1.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
      IntPtr scan0_1 = bitmapData.Scan0;
      int length1 = checked (bitmapData.Width * bitmapData.Height);
      byte[] destination = new byte[checked (length1 - 1 + 1)];
      Marshal.Copy(scan0_1, destination, 0, length1);
      BitmapData bitmapdata = bitmap2.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
      IntPtr scan0_2 = bitmapdata.Scan0;
      int length2 = checked (bitmapdata.Width * bitmapdata.Height);
      byte[] numArray = new byte[checked (length2 - 1 + 1)];
      Marshal.Copy(scan0_2, numArray, 0, length2);
      this.iLogger.LogMessage("Creating Altitude Image Map.");
      this.ProgressBar1.Maximum = length2;
      int num1 = 0;
      int num2 = checked (length1 - 1);
      int index = num1;
      while (index <= num2)
      {
        this.ProgressBar1.Value = index;
        byte altId = this.iTerrain.get_TerrianGroup((int) destination[index]).AltID;
        numArray[index] = altId;
        checked { ++index; }
      }
      Marshal.Copy(numArray, 0, scan0_2, length2);
      bitmap2.UnlockBits(bitmapdata);
      try
      {
        string str = string.Format("{0}\\{1}", (object) this.ProjectPath.Text, (object) this.AltitudeFile.Text);
        this.iLogger.LogMessage("Saving Altitude Image Map.\r\n");
        this.iLogger.LogMessage(str);
        bitmap2.Save(str, ImageFormat.Bmp);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.iLogger.LogMessage("Error in saving image.\r\n");
        this.iLogger.LogMessage(exception.Message);
        ProjectData.ClearProjectError();
      }
      bitmap2.Dispose();
      bitmap1.Dispose();
      this.iLogger.LogMessage("Done.");
    }
  }
}
