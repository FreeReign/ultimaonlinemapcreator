using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Terrain;

namespace TEdit
{
	public class GroupSelect : Form
	{
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("SelectGroup")]
		private ComboBox _SelectGroup;

		[AccessedThroughProperty("SelectGroupName")]
		private Label _SelectGroupName;

		[AccessedThroughProperty("PropertyGrid1")]
		private PropertyGrid _PropertyGrid1;

		private IContainer components;

		private ClsTerrainTable iTerrain;

		internal virtual Button Button1
		{
			get
			{
				return this._Button1;
			}
			set
			{
				if (this._Button1 != null)
				{
					GroupSelect groupSelect = this;
					this._Button1.Click -= new EventHandler(groupSelect.Button1_Click);
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					GroupSelect groupSelect1 = this;
					this._Button1.Click += new EventHandler(groupSelect1.Button1_Click);
				}
			}
		}

		internal virtual PropertyGrid PropertyGrid1
		{
			get
			{
				return this._PropertyGrid1;
			}
			set
			{
				this._PropertyGrid1 == null;
				this._PropertyGrid1 = value;
				this._PropertyGrid1 == null;
			}
		}

		internal virtual ComboBox SelectGroup
		{
			get
			{
				return this._SelectGroup;
			}
			set
			{
				if (this._SelectGroup != null)
				{
					GroupSelect groupSelect = this;
					this._SelectGroup.SelectedIndexChanged -= new EventHandler(groupSelect.SelectGroup_SelectedIndexChanged);
				}
				this._SelectGroup = value;
				if (this._SelectGroup != null)
				{
					GroupSelect groupSelect1 = this;
					this._SelectGroup.SelectedIndexChanged += new EventHandler(groupSelect1.SelectGroup_SelectedIndexChanged);
				}
			}
		}

		internal virtual Label SelectGroupName
		{
			get
			{
				return this._SelectGroupName;
			}
			set
			{
				this._SelectGroupName == null;
				this._SelectGroupName = value;
				this._SelectGroupName == null;
			}
		}

		public GroupSelect()
		{
			GroupSelect groupSelect = this;
			base.Load += new EventHandler(groupSelect.GroupSelect_Load);
			this.iTerrain = new ClsTerrainTable();
			this.InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			string text = this.SelectGroupName.Text;
			if (StringType.StrCmp(text, "Select Group A", false) == 0)
			{
				TEdit tag = (TEdit)this.Tag;
				tag.Selected_Terrain_A = (ClsTerrain)this.SelectGroup.SelectedItem;
				tag.MenuTerrainA.Text = string.Format("Select Terrain A - {0}", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.SelectGroup.SelectedItem, null, "Name", new object[0], null, null)));
				tag = null;
			}
			else if (StringType.StrCmp(text, "Select Group B", false) == 0)
			{
				TEdit selectedItem = (TEdit)this.Tag;
				selectedItem.Selected_Terrain_B = (ClsTerrain)this.SelectGroup.SelectedItem;
				selectedItem.MenuTerrainB.Text = string.Format("Select Terrain B - {0}", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.SelectGroup.SelectedItem, null, "Name", new object[0], null, null)));
				selectedItem = null;
			}
			else if (StringType.StrCmp(text, "Select Group C", false) == 0)
			{
				TEdit tEdit = (TEdit)this.Tag;
				tEdit.Selected_Terrain_C = (ClsTerrain)this.SelectGroup.SelectedItem;
				tEdit.MenuTerrainC.Text = string.Format("Select Terrain C - {0}", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.SelectGroup.SelectedItem, null, "Name", new object[0], null, null)));
				tEdit = null;
			}
			else if (StringType.StrCmp(text, "Clone Group A", false) == 0)
			{
				TEdit tag1 = (TEdit)this.Tag;
				tag1.Selected_Terrain_A = (ClsTerrain)this.SelectGroup.SelectedItem;
				tag1.Menu_CloneGroupA.Text = string.Format("Select Terrain A - {0}", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.SelectGroup.SelectedItem, null, "Name", new object[0], null, null)));
				tag1 = null;
			}
			else if (StringType.StrCmp(text, "Clone Group B", false) == 0)
			{
				TEdit selectedItem1 = (TEdit)this.Tag;
				selectedItem1.Selected_Terrain_B = (ClsTerrain)this.SelectGroup.SelectedItem;
				selectedItem1.Menu_CloneGroupB.Text = string.Format("Select Terrain B - {0}", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.SelectGroup.SelectedItem, null, "Name", new object[0], null, null)));
				selectedItem1 = null;
			}
			this.Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.components != null)
				{
					this.components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		private void GroupSelect_Load(object sender, EventArgs e)
		{
			this.iTerrain.Load();
			this.iTerrain.Display(this.SelectGroup);
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.PropertyGrid1 = new PropertyGrid();
			this.SelectGroup = new ComboBox();
			this.SelectGroupName = new Label();
			this.Button1 = new Button();
			this.SuspendLayout();
			this.PropertyGrid1.CommandsVisibleIfAvailable = true;
			this.PropertyGrid1.HelpVisible = false;
			this.PropertyGrid1.LargeButtons = false;
			this.PropertyGrid1.LineColor = SystemColors.ScrollBar;
			PropertyGrid propertyGrid1 = this.PropertyGrid1;
			Point point = new Point(8, 48);
			propertyGrid1.Location = point;
			this.PropertyGrid1.Name = "PropertyGrid1";
			PropertyGrid propertyGrid = this.PropertyGrid1;
			System.Drawing.Size size = new System.Drawing.Size(184, 256);
			propertyGrid.Size = size;
			this.PropertyGrid1.TabIndex = 0;
			this.PropertyGrid1.Text = "PropertyGrid1";
			this.PropertyGrid1.ViewBackColor = SystemColors.Window;
			this.PropertyGrid1.ViewForeColor = SystemColors.WindowText;
			ComboBox selectGroup = this.SelectGroup;
			point = new Point(8, 24);
			selectGroup.Location = point;
			this.SelectGroup.Name = "SelectGroup";
			ComboBox comboBox = this.SelectGroup;
			size = new System.Drawing.Size(184, 21);
			comboBox.Size = size;
			this.SelectGroup.Sorted = true;
			this.SelectGroup.TabIndex = 1;
			this.SelectGroupName.AutoSize = true;
			Label selectGroupName = this.SelectGroupName;
			point = new Point(8, 8);
			selectGroupName.Location = point;
			this.SelectGroupName.Name = "SelectGroupName";
			Label label = this.SelectGroupName;
			size = new System.Drawing.Size(81, 16);
			label.Size = size;
			this.SelectGroupName.TabIndex = 2;
			this.SelectGroupName.Text = "Select Group X";
			Button button1 = this.Button1;
			point = new Point(8, 312);
			button1.Location = point;
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 3;
			this.Button1.Text = "Select";
			size = new System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new System.Drawing.Size(200, 341);
			this.ClientSize = size;
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.SelectGroupName);
			this.Controls.Add(this.SelectGroup);
			this.Controls.Add(this.PropertyGrid1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GroupSelect";
			this.Text = "GroupSelect";
			this.ResumeLayout(false);
		}

		private void SelectGroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.PropertyGrid1.SelectedObject = RuntimeHelpers.GetObjectValue(this.SelectGroup.SelectedItem);
		}
	}
}