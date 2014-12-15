using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Elevation;
using Terrain;
using Ultima;

namespace CreateColorTable
{
    public partial class Viewer : Form
    {
        private int i_Menu;
        private Art i_UOArt;
        private ClsElevationTable i_Altitude;
        private ClsTerrainTable i_Terrain;

        public Viewer()
        {
            Viewer viewer = this;
            base.Load += new EventHandler(viewer.Viewer_Load);
            this.i_Menu = 0;
            this.i_Altitude = new ClsElevationTable();
            this.i_Terrain = new ClsTerrainTable();
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ListBox1.SelectedItem != null)
            {
                switch (this.i_Menu)
                {
                    case 0:
                        {
                            ClsTerrain selectedItem = (ClsTerrain)this.ListBox1.SelectedItem;
                            this.PropertyGrid1.SelectedObject = selectedItem;
                            this.PictureBox1.Image = Art.GetLand(selectedItem.TileID);
                            break;
                        }
                    case 1:
                        {
                            ClsElevation clsAltitude = (ClsElevation)this.ListBox1.SelectedItem;
                            this.PropertyGrid1.SelectedObject = clsAltitude;
                            break;
                        }
                }
            }
        }

        private void MenuItem12_Click(object sender, EventArgs e)
        {
            this.i_Altitude.SaveACT();
        }

        private void MenuItem13_Click(object sender, EventArgs e)
        {
            this.i_Terrain.SaveACO();
        }

        private void MenuItem14_Click(object sender, EventArgs e)
        {
            this.i_Altitude.SaveACO();
        }

        private void MenuItem2_Click(object sender, EventArgs e)
        {
            this.i_Menu = 0;
            this.Label1.Text = "Terrain List";
            this.i_Terrain.Load();
            this.i_Terrain.Display(this.ListBox1);
            this.PictureBox1.Visible = true;
        }

        private void MenuItem3_Click(object sender, EventArgs e)
        {
            this.i_Terrain.Save();
        }

        private void MenuItem5_Click(object sender, EventArgs e)
        {
            this.i_Menu = 1;
            this.Label1.Text = "Altitude List";
            this.i_Altitude.Load();
            this.i_Altitude.Display(this.ListBox1);
            this.PictureBox1.Visible = false;
        }

        private void MenuItem6_Click(object sender, EventArgs e)
        {
            this.i_Terrain.SaveACT();
        }

        private void MenuItem9_Click(object sender, EventArgs e)
        {
            this.i_Terrain.SaveACT();
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            this.i_Menu = 0;
            this.Label1.Text = "Terrain List";
            this.i_Terrain.Load();
            this.PictureBox1.Visible = true;
        }
    }
}
