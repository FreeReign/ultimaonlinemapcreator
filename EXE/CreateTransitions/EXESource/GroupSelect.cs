using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Terrain;

using Microsoft.VisualBasic.CompilerServices;

namespace CreateTransitions
{
    public partial class GroupSelect : Form
    {
        private PropertyGrid _PropertyGrid1;
        private ClsTerrainTable iTerrain;

        public GroupSelect()
        {
            this.Load += new EventHandler(this.GroupSelect_Load);
            this.iTerrain = new ClsTerrainTable();
            InitializeComponent();
        }

        private void GroupSelect_Load(object sender, EventArgs e)
        {
            this.iTerrain.Load();
            this.iTerrain.Display(this.SelectGroup);
        }

        private void SelectGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PropertyGrid1.SelectedObject = RuntimeHelpers.GetObjectValue(this.SelectGroup.SelectedItem);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string text = this.SelectGroupName.Text;
            if (StringType.StrCmp(text, "Select Group A", false) == 0)
            {
                CreateTransitions tedit = (CreateTransitions)this.Tag;
                tedit.Selected_Terrain_A = (ClsTerrain)this.SelectGroup.SelectedItem;
                tedit.MenuTerrainA.Text = string.Format("Select Terrain A - {0}", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.SelectGroup.SelectedItem, (Type)null, "Name", new object[0], (string[])null, (bool[])null)));
            }
            else if (StringType.StrCmp(text, "Select Group B", false) == 0)
            {
                CreateTransitions tedit = (CreateTransitions)this.Tag;
                tedit.Selected_Terrain_B = (ClsTerrain)this.SelectGroup.SelectedItem;
                tedit.MenuTerrainB.Text = string.Format("Select Terrain B - {0}", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.SelectGroup.SelectedItem, (Type)null, "Name", new object[0], (string[])null, (bool[])null)));
            }
            else if (StringType.StrCmp(text, "Select Group C", false) == 0)
            {
                CreateTransitions tedit = (CreateTransitions)this.Tag;
                tedit.Selected_Terrain_C = (ClsTerrain)this.SelectGroup.SelectedItem;
                tedit.MenuTerrainC.Text = string.Format("Select Terrain C - {0}", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.SelectGroup.SelectedItem, (Type)null, "Name", new object[0], (string[])null, (bool[])null)));
            }
            else if (StringType.StrCmp(text, "Clone Group A", false) == 0)
            {
                CreateTransitions tedit = (CreateTransitions)this.Tag;
                tedit.Selected_Terrain_A = (ClsTerrain)this.SelectGroup.SelectedItem;
                tedit.Menu_CloneGroupA.Text = string.Format("Select Terrain A - {0}", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.SelectGroup.SelectedItem, (Type)null, "Name", new object[0], (string[])null, (bool[])null)));
            }
            else if (StringType.StrCmp(text, "Clone Group B", false) == 0)
            {
                CreateTransitions tedit = (CreateTransitions)this.Tag;
                tedit.Selected_Terrain_B = (ClsTerrain)this.SelectGroup.SelectedItem;
                tedit.Menu_CloneGroupB.Text = string.Format("Select Terrain B - {0}", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.SelectGroup.SelectedItem, (Type)null, "Name", new object[0], (string[])null, (bool[])null)));
            }
            this.Close();
        }

    }
}
