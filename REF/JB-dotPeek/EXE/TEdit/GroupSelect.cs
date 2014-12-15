// Decompiled with JetBrains decompiler
// Type: TEdit.GroupSelect
// Assembly: TEdit, Version=1.0.1819.29268, Culture=neutral, PublicKeyToken=null
// MVID: 17FAC474-4301-4029-AF6B-D3AA98301AC6
// Assembly location: W:\JetBrains\UOLandscaper\TEdit.exe

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

    internal virtual PropertyGrid PropertyGrid1
    {
      get
      {
        return this._PropertyGrid1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._PropertyGrid1 == null)
          ;
        this._PropertyGrid1 = value;
        if (this._PropertyGrid1 != null)
          ;
      }
    }

    internal virtual ComboBox SelectGroup
    {
      get
      {
        return this._SelectGroup;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._SelectGroup != null)
          this._SelectGroup.SelectedIndexChanged -= new EventHandler(this.SelectGroup_SelectedIndexChanged);
        this._SelectGroup = value;
        if (this._SelectGroup == null)
          return;
        this._SelectGroup.SelectedIndexChanged += new EventHandler(this.SelectGroup_SelectedIndexChanged);
      }
    }

    internal virtual Button Button1
    {
      get
      {
        return this._Button1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Button1 != null)
          this._Button1.Click -= new EventHandler(this.Button1_Click);
        this._Button1 = value;
        if (this._Button1 == null)
          return;
        this._Button1.Click += new EventHandler(this.Button1_Click);
      }
    }

    internal virtual Label SelectGroupName
    {
      get
      {
        return this._SelectGroupName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._SelectGroupName == null)
          ;
        this._SelectGroupName = value;
        if (this._SelectGroupName != null)
          ;
      }
    }

    public GroupSelect()
    {
      this.Load += new EventHandler(this.GroupSelect_Load);
      this.iTerrain = new ClsTerrainTable();
      this.InitializeComponent();
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
      this.PropertyGrid1 = new PropertyGrid();
      this.SelectGroup = new ComboBox();
      this.SelectGroupName = new Label();
      this.Button1 = new Button();
      this.SuspendLayout();
      this.PropertyGrid1.CommandsVisibleIfAvailable = true;
      this.PropertyGrid1.HelpVisible = false;
      this.PropertyGrid1.LargeButtons = false;
      this.PropertyGrid1.LineColor = SystemColors.ScrollBar;
      PropertyGrid propertyGrid1_1 = this.PropertyGrid1;
      Point point1 = new Point(8, 48);
      Point point2 = point1;
      propertyGrid1_1.Location = point2;
      this.PropertyGrid1.Name = "PropertyGrid1";
      PropertyGrid propertyGrid1_2 = this.PropertyGrid1;
      Size size1 = new Size(184, 256);
      Size size2 = size1;
      propertyGrid1_2.Size = size2;
      this.PropertyGrid1.TabIndex = 0;
      this.PropertyGrid1.Text = "PropertyGrid1";
      this.PropertyGrid1.ViewBackColor = SystemColors.Window;
      this.PropertyGrid1.ViewForeColor = SystemColors.WindowText;
      ComboBox selectGroup1 = this.SelectGroup;
      point1 = new Point(8, 24);
      Point point3 = point1;
      selectGroup1.Location = point3;
      this.SelectGroup.Name = "SelectGroup";
      ComboBox selectGroup2 = this.SelectGroup;
      size1 = new Size(184, 21);
      Size size3 = size1;
      selectGroup2.Size = size3;
      this.SelectGroup.Sorted = true;
      this.SelectGroup.TabIndex = 1;
      this.SelectGroupName.AutoSize = true;
      Label selectGroupName1 = this.SelectGroupName;
      point1 = new Point(8, 8);
      Point point4 = point1;
      selectGroupName1.Location = point4;
      this.SelectGroupName.Name = "SelectGroupName";
      Label selectGroupName2 = this.SelectGroupName;
      size1 = new Size(81, 16);
      Size size4 = size1;
      selectGroupName2.Size = size4;
      this.SelectGroupName.TabIndex = 2;
      this.SelectGroupName.Text = "Select Group X";
      Button button1 = this.Button1;
      point1 = new Point(8, 312);
      Point point5 = point1;
      button1.Location = point5;
      this.Button1.Name = "Button1";
      this.Button1.TabIndex = 3;
      this.Button1.Text = "Select";
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(200, 341);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.SelectGroupName);
      this.Controls.Add((Control) this.SelectGroup);
      this.Controls.Add((Control) this.PropertyGrid1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "GroupSelect";
      this.Text = "GroupSelect";
      this.ResumeLayout(false);
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
        TEdit tedit = (TEdit) this.Tag;
        tedit.Selected_Terrain_A = (ClsTerrain) this.SelectGroup.SelectedItem;
        tedit.MenuTerrainA.Text = string.Format("Select Terrain A - {0}", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.SelectGroup.SelectedItem, (Type) null, "Name", new object[0], (string[]) null, (bool[]) null)));
      }
      else if (StringType.StrCmp(text, "Select Group B", false) == 0)
      {
        TEdit tedit = (TEdit) this.Tag;
        tedit.Selected_Terrain_B = (ClsTerrain) this.SelectGroup.SelectedItem;
        tedit.MenuTerrainB.Text = string.Format("Select Terrain B - {0}", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.SelectGroup.SelectedItem, (Type) null, "Name", new object[0], (string[]) null, (bool[]) null)));
      }
      else if (StringType.StrCmp(text, "Select Group C", false) == 0)
      {
        TEdit tedit = (TEdit) this.Tag;
        tedit.Selected_Terrain_C = (ClsTerrain) this.SelectGroup.SelectedItem;
        tedit.MenuTerrainC.Text = string.Format("Select Terrain C - {0}", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.SelectGroup.SelectedItem, (Type) null, "Name", new object[0], (string[]) null, (bool[]) null)));
      }
      else if (StringType.StrCmp(text, "Clone Group A", false) == 0)
      {
        TEdit tedit = (TEdit) this.Tag;
        tedit.Selected_Terrain_A = (ClsTerrain) this.SelectGroup.SelectedItem;
        tedit.Menu_CloneGroupA.Text = string.Format("Select Terrain A - {0}", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.SelectGroup.SelectedItem, (Type) null, "Name", new object[0], (string[]) null, (bool[]) null)));
      }
      else if (StringType.StrCmp(text, "Clone Group B", false) == 0)
      {
        TEdit tedit = (TEdit) this.Tag;
        tedit.Selected_Terrain_B = (ClsTerrain) this.SelectGroup.SelectedItem;
        tedit.Menu_CloneGroupB.Text = string.Format("Select Terrain B - {0}", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.SelectGroup.SelectedItem, (Type) null, "Name", new object[0], (string[]) null, (bool[]) null)));
      }
      this.Close();
    }
  }
}
