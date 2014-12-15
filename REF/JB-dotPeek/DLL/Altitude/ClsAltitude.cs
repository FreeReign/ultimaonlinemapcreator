// Decompiled with JetBrains decompiler
// Type: Altitude.ClsAltitude
// Assembly: Altitude, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: 65F3880E-4DB6-422D-A918-A47FA074D90A
// Assembly location: W:\JetBrains\UOLandscaper\Altitude.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Xml;

namespace Altitude
{
  public class ClsAltitude
  {
    private int m_Key;
    private Color m_AltColor;
    private string m_Type;
    private short m_Alt;

    [Category("Key")]
    public int Key
    {
      get
      {
        return this.m_Key;
      }
      set
      {
        this.m_Key = value;
      }
    }

    [Category("ID")]
    public Color AltitudeColor
    {
      get
      {
        return this.m_AltColor;
      }
      set
      {
        this.m_AltColor = value;
      }
    }

    [Category("ID")]
    public string Type
    {
      get
      {
        return this.m_Type;
      }
      set
      {
        this.m_Type = value;
      }
    }

    [Category("Method")]
    public short GetAltitude
    {
      get
      {
        return this.m_Alt;
      }
      set
      {
        this.m_Alt = value;
      }
    }

    public ClsAltitude(int iKey, string iType, short iAlt, Color iAltColor)
    {
      this.m_Key = iKey;
      this.m_Type = iType;
      this.m_Alt = iAlt;
      this.m_AltColor = iAltColor;
    }

    public ClsAltitude(XmlElement xmlInfo)
    {
      this.m_Key = XmlConvert.ToInt32(xmlInfo.GetAttribute("Key"));
      this.m_Type = xmlInfo.GetAttribute("Type");
      this.m_Alt = XmlConvert.ToInt16(xmlInfo.GetAttribute("Altitude"));
      this.m_AltColor = Color.FromArgb((int) XmlConvert.ToByte(xmlInfo.GetAttribute("R")), (int) XmlConvert.ToByte(xmlInfo.GetAttribute("G")), (int) XmlConvert.ToByte(xmlInfo.GetAttribute("B")));
    }

    public override string ToString()
    {
      return string.Format("[{0:X3}] {1} {2}", (object) this.m_Key, (object) this.m_Type, (object) this.m_Alt);
    }

    public void Save(XmlTextWriter xmlInfo)
    {
      ((XmlWriter) xmlInfo).WriteStartElement("Altitude");
      xmlInfo.WriteAttributeString("Key", StringType.FromInteger(this.m_Key));
      xmlInfo.WriteAttributeString("Type", this.m_Type);
      xmlInfo.WriteAttributeString("Altitude", StringType.FromInteger((int) this.m_Alt));
      xmlInfo.WriteAttributeString("R", StringType.FromByte(this.m_AltColor.R));
      xmlInfo.WriteAttributeString("G", StringType.FromByte(this.m_AltColor.G));
      xmlInfo.WriteAttributeString("B", StringType.FromByte(this.m_AltColor.B));
      xmlInfo.WriteEndElement();
    }

    public void SaveACT(BinaryWriter iACTFile)
    {
      iACTFile.Write(this.m_AltColor.R);
      iACTFile.Write(this.m_AltColor.G);
      iACTFile.Write(this.m_AltColor.B);
    }

    public void SaveACO(BinaryWriter iACTFile)
    {
      byte num = (byte) 0;
      iACTFile.Write(this.m_AltColor.R);
      iACTFile.Write(this.m_AltColor.R);
      iACTFile.Write(this.m_AltColor.G);
      iACTFile.Write(this.m_AltColor.G);
      iACTFile.Write(this.m_AltColor.B);
      iACTFile.Write(this.m_AltColor.B);
      iACTFile.Write(num);
      iACTFile.Write(num);
    }

    public void SaveACOText(BinaryWriter iACTFile)
    {
      byte num1 = (byte) 0;
      iACTFile.Write(this.m_AltColor.R);
      iACTFile.Write(this.m_AltColor.R);
      iACTFile.Write(this.m_AltColor.G);
      iACTFile.Write(this.m_AltColor.G);
      iACTFile.Write(this.m_AltColor.B);
      iACTFile.Write(this.m_AltColor.B);
      iACTFile.Write(num1);
      iACTFile.Write(num1);
      iACTFile.Write(num1);
      iACTFile.Write(num1);
      byte[] bytes = new UnicodeEncoding(true, true).GetBytes(string.Format("{0} {1}", (object) this.m_Type, (object) this.m_Alt));
      byte num2 = checked ((byte) Math.Round(unchecked ((double) Convert.ToByte(bytes.Length) / 2.0 + 1.0)));
      iACTFile.Write(num1);
      iACTFile.Write(num2);
      byte[] numArray = bytes;
      int index = 0;
      while (index < numArray.Length)
      {
        byte num3 = numArray[index];
        iACTFile.Write(num3);
        checked { ++index; }
      }
      iACTFile.Write(num1);
      iACTFile.Write(num1);
    }
  }
}
