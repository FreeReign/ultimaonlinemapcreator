// Decompiled with JetBrains decompiler
// Type: Altitude.ClsAltitudeTable
// Assembly: Altitude, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: 65F3880E-4DB6-422D-A918-A47FA074D90A
// Assembly location: W:\JetBrains\UOLandscaper\Altitude.dll

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

namespace Altitude
{
  public class ClsAltitudeTable
  {
    private Hashtable i_AltitudeTable;

    public Hashtable AltitudeHash
    {
      get
      {
        return this.i_AltitudeTable;
      }
    }

    public ClsAltitudeTable()
    {
      this.i_AltitudeTable = new Hashtable();
    }

    public ClsAltitude get_GetAltitude(int Index)
    {
      return (ClsAltitude) this.i_AltitudeTable[(object) Index];
    }

    public void set_GetAltitude(int Index, ClsAltitude Value)
    {
      this.i_AltitudeTable[(object) Index] = (object) Value;
    }

    public void Save()
    {
      XmlTextWriter xmlInfo = new XmlTextWriter(string.Format("{0}Data\\System\\Altitude.xml", (object) AppDomain.CurrentDomain.BaseDirectory), Encoding.UTF8);
      xmlInfo.Indentation = 2;
      xmlInfo.Formatting = Formatting.Indented;
      xmlInfo.WriteStartDocument();
      ((XmlWriter) xmlInfo).WriteStartElement("Altitudes");
      try
      {
        foreach (ClsAltitude clsAltitude in (IEnumerable) this.i_AltitudeTable.Values)
          clsAltitude.Save(xmlInfo);
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

    public void Display(ListBox iList)
    {
      iList.Items.Clear();
      try
      {
        foreach (ClsAltitude clsAltitude in (IEnumerable) this.i_AltitudeTable.Values)
          iList.Items.Add((object) clsAltitude);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
    }

    public void Load()
    {
      string filename = string.Format("{0}Data/System/Altitude.xml", (object) AppDomain.CurrentDomain.BaseDirectory);
      XmlDocument xmlDocument = new XmlDocument();
      try
      {
        xmlDocument.Load(filename);
        this.i_AltitudeTable.Clear();
        try
        {
          foreach (XmlElement xmlElement in xmlDocument.SelectNodes("Altitudes"))
          {
            try
            {
              foreach (XmlElement xmlInfo in xmlElement.SelectNodes("Altitude"))
              {
                ClsAltitude clsAltitude = new ClsAltitude(xmlInfo);
                this.i_AltitudeTable.Add((object) clsAltitude.Key, (object) clsAltitude);
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
        int num = (int) Interaction.MsgBox((object) string.Format("XMLFile:{0}", (object) filename), MsgBoxStyle.OKOnly, (object) null);
        ProjectData.ClearProjectError();
      }
    }

    public ColorPalette GetAltPalette()
    {
      ColorPalette palette = new Bitmap(2, 2, PixelFormat.Format8bppIndexed).Palette;
      try
      {
        foreach (ClsAltitude clsAltitude in (IEnumerable) this.i_AltitudeTable.Values)
          palette.Entries[clsAltitude.Key] = clsAltitude.AltitudeColor;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
      return palette;
    }

    public void SaveACT()
    {
      FileStream fileStream = new FileStream(string.Format("{0}/Data/Photoshop/Altitude.ACT", (object) Directory.GetCurrentDirectory()), FileMode.Create);
      BinaryWriter iACTFile = new BinaryWriter((Stream) fileStream);
      byte num1 = (byte) 0;
      int num2 = 0;
      do
      {
        if (this.i_AltitudeTable[(object) num2] == null)
        {
          iACTFile.Write(num1);
          iACTFile.Write(num1);
          iACTFile.Write(num1);
        }
        else
          ((ClsAltitude) this.i_AltitudeTable[(object) num2]).SaveACT(iACTFile);
        checked { ++num2; }
      }
      while (num2 <= (int) byte.MaxValue);
      iACTFile.Close();
      fileStream.Close();
      int num3 = (int) Interaction.MsgBox((object) "Altitude.ACT Saved", MsgBoxStyle.OKOnly, (object) null);
    }

    public void SaveACO()
    {
      byte num1 = Convert.ToByte(this.i_AltitudeTable.Count);
      FileStream fileStream = new FileStream(string.Format("{0}/Data/Photoshop/Altitude.ACO", (object) Directory.GetCurrentDirectory()), FileMode.Create);
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
        if (this.i_AltitudeTable[(object) num6] != null)
        {
          byte num7 = (byte) 0;
          iACTFile.Write(num7);
          byte num8 = (byte) 0;
          iACTFile.Write(num8);
          ((ClsAltitude) this.i_AltitudeTable[(object) num6]).SaveACO(iACTFile);
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
        if (this.i_AltitudeTable[(object) num13] != null)
        {
          byte num7 = (byte) 0;
          iACTFile.Write(num7);
          byte num8 = (byte) 0;
          iACTFile.Write(num8);
          ((ClsAltitude) this.i_AltitudeTable[(object) num13]).SaveACOText(iACTFile);
        }
        checked { ++num13; }
      }
      while (num13 <= (int) byte.MaxValue);
      iACTFile.Close();
      fileStream.Close();
      int num14 = (int) Interaction.MsgBox((object) "Altitude.ACO Saved", MsgBoxStyle.OKOnly, (object) null);
    }
  }
}
