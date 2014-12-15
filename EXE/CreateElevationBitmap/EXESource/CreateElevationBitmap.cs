using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;
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
using Terrain;
using Elevation;
using Logger;
using System.Threading;

namespace CreateElevationBitmap
{
    public partial class CreateElevationBitmap : Form
    {
        private ClsTerrainTable iTerrain;
        private ClsElevationTable iAltitude;
        private LoggerForm iLogger;

        public CreateElevationBitmap()
        {
            CreateElevationBitmap altImagePrep = this;
            base.Load += new EventHandler(altImagePrep.AltImagePrep_Load);
            this.iTerrain = new ClsTerrainTable();
            this.iAltitude = new ClsElevationTable();
            this.iLogger = new LoggerForm();
            InitializeComponent();
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

        private async void MenuMake_Click(object sender, EventArgs e)
        {
            Progress<int> progress = new Progress<int> ( i => { ProgressBar1.Value = i; } );
            Progress<string> logger = new Progress<string>(i => { iLogger.LogMessage(i); });
            Task resetProgress = new Task(() => {Thread.Sleep(1000); ((IProgress<int>)progress).Report(0);});
            await Task.Run(() => CreateElevationBitmapHelper.MakeAltitudeImage(ProjectPath.Text, TerrainFile.Text, AltitudeFile.Text, iAltitude, iTerrain, progress, logger)).ContinueWith(c => resetProgress.Start());         
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
    }
}
