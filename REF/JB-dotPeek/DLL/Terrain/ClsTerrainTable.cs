// Decompiled with JetBrains decompiler
// Type: Terrain.ClsTerrainTable
// Assembly: Terrain, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: 83B71B94-FA85-4D19-A756-B540C66ECA87
// Assembly location: W:\JetBrains\UOLandscaper\Terrain.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Terrain
{
  public class ClsTerrainTable
  {
    private Hashtable i_TerrainTable;

    public Hashtable TerrainHash
    {
      get
      {
        return this.i_TerrainTable;
      }
    }

    public ClsTerrainTable()
    {
      this.i_TerrainTable = new Hashtable();
    }

    public ClsTerrain get_TerrianGroup(int iKey)
    {
      return (ClsTerrain) this.i_TerrainTable[(object) iKey];
    }

    public void Load()
    {
      string filename = string.Format("{0}\\Data\\System\\Terrain.xml", (object) AppDomain.CurrentDomain.BaseDirectory);
      XmlDocument xmlDocument = new XmlDocument();
      try
      {
        xmlDocument.Load(filename);
        this.i_TerrainTable.Clear();
        try
        {
          foreach (XmlElement xmlElement in xmlDocument.SelectNodes("Terrains"))
          {
            try
            {
              foreach (XmlElement xmlInfo in xmlElement.SelectNodes("Terrain"))
              {
                ClsTerrain clsTerrain = new ClsTerrain(xmlInfo);
                this.i_TerrainTable.Add((object) clsTerrain.GroupID, (object) clsTerrain);
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                ((IDisposable) enumerator).Dispose();
            }
          }
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
        int num1 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.OKOnly, (object) null);
        int num2 = (int) Interaction.MsgBox((object) string.Format("XMLFile:{0}", (object) filename), MsgBoxStyle.OKOnly, (object) null);
        ProjectData.ClearProjectError();
      }
    }

    public void Display(ListBox iList)
    {
      iList.Items.Clear();
      try
      {
        foreach (ClsTerrain clsTerrain in (IEnumerable) this.i_TerrainTable.Values)
          iList.Items.Add((object) clsTerrain);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
    }

    public void Display(ComboBox iCombo)
    {
      iCombo.Items.Clear();
      try
      {
        foreach (ClsTerrain clsTerrain in (IEnumerable) this.i_TerrainTable.Values)
          iCombo.Items.Add((object) clsTerrain);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
    }

    public ColorPalette GetPalette()
    {
      ColorPalette palette = new Bitmap(2, 2, PixelFormat.Format8bppIndexed).Palette;
      byte num = (byte) 0;
      do
      {
        palette.Entries[(int) num] = this.get_TerrianGroup((int) num) == null ? Color.Black : this.get_TerrianGroup((int) num).Colour;
        ++num;
      }
      while ((int) num <= 254);
      palette.Entries[(int) byte.MaxValue] = this.get_TerrianGroup((int) byte.MaxValue).Colour;
      return palette;
    }

    public void Save()
    {
      XmlTextWriter xmlInfo = new XmlTextWriter(string.Format("{0}/Data/System/Terrain.xml", (object) Directory.GetCurrentDirectory()), Encoding.UTF8);
      xmlInfo.Indentation = 2;
      xmlInfo.Formatting = Formatting.Indented;
      xmlInfo.WriteStartDocument();
      ((XmlWriter) xmlInfo).WriteStartElement("Terrains");
      try
      {
        foreach (ClsTerrain clsTerrain in (IEnumerable) this.i_TerrainTable.Values)
          clsTerrain.Save(xmlInfo);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
      xmlInfo.WriteEndElement();
      xmlInfo.WriteEndDocument();
      xmlInfo.Close();
    }

    public void SaveACT()
    {
      FileStream fileStream = new FileStream(string.Format("{0}/Data/Photoshop/Terrain.ACT", (object) Directory.GetCurrentDirectory()), FileMode.Create);
      BinaryWriter iACTFile = new BinaryWriter((Stream) fileStream);
      byte num1 = (byte) 0;
      int num2 = 0;
      do
      {
        if (this.i_TerrainTable[(object) num2] == null)
        {
          iACTFile.Write(num1);
          iACTFile.Write(num1);
          iACTFile.Write(num1);
        }
        else
          ((ClsTerrain) this.i_TerrainTable[(object) num2]).SaveACT(iACTFile);
        checked { ++num2; }
      }
      while (num2 <= (int) byte.MaxValue);
      iACTFile.Close();
      fileStream.Close();
      int num3 = (int) Interaction.MsgBox((object) "Terrain.ACT Saved", MsgBoxStyle.OKOnly, (object) null);
    }

    public void SaveACO()
    {
      byte num1 = Convert.ToByte(this.i_TerrainTable.Count);
      FileStream fileStream = new FileStream(string.Format("{0}/Data/Photoshop/Terrain.ACO", (object) Directory.GetCurrentDirectory()), FileMode.Create);
      BinaryWriter iACTFile = new BinaryWriter((Stream) fileStream);
      byte num2 = (byte) 0;
      iACTFile.Write(num2);
      byte num3 = (byte) 1;
      iACTFile.Write(num3);
      byte num4 = (byte) 0;
      iACTFile.Write(num4);
      byte num5 = num1;
      iACTFile.Write(num5);
      int num6 = 0;
      do
      {
        if (this.i_TerrainTable[(object) num6] != null)
        {
          byte num7 = (byte) 0;
          iACTFile.Write(num7);
          byte num8 = (byte) 0;
          iACTFile.Write(num8);
          ((ClsTerrain) this.i_TerrainTable[(object) num6]).SaveACO(iACTFile);
        }
        checked { ++num6; }
      }
      while (num6 <= (int) byte.MaxValue);
      byte num9 = (byte) 0;
      iACTFile.Write(num9);
      byte num10 = (byte) 2;
      iACTFile.Write(num10);
      byte num11 = (byte) 0;
      iACTFile.Write(num11);
      byte num12 = num1;
      iACTFile.Write(num12);
      int num13 = 0;
      do
      {
        if (this.i_TerrainTable[(object) num13] != null)
        {
          byte num7 = (byte) 0;
          iACTFile.Write(num7);
          byte num8 = (byte) 0;
          iACTFile.Write(num8);
          ((ClsTerrain) this.i_TerrainTable[(object) num13]).SaveACOText(iACTFile);
        }
        checked { ++num13; }
      }
      while (num13 <= (int) byte.MaxValue);
      iACTFile.Close();
      fileStream.Close();
      int num14 = (int) Interaction.MsgBox((object) "Terrain.ACO Saved", MsgBoxStyle.OKOnly, (object) null);
    }
  }
}
