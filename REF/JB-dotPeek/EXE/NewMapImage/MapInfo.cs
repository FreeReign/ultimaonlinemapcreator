// Decompiled with JetBrains decompiler
// Type: NewMapImage.MapInfo
// Assembly: NewMapImage, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: D5109B56-C280-4F7E-8021-67D531DD1A49
// Assembly location: W:\JetBrains\UOLandscaper\NewMapImage.exe

using Microsoft.VisualBasic.CompilerServices;
using System.Xml;

namespace NewMapImage
{
  public class MapInfo
  {
    private string m_Name;
    private byte m_Num;
    private int m_XSize;
    private int m_YSize;

    public byte MapNumber
    {
      get
      {
        return this.m_Num;
      }
    }

    public string MapName
    {
      get
      {
        return this.m_Name;
      }
    }

    public int XSize
    {
      get
      {
        return this.m_XSize;
      }
    }

    public int YSize
    {
      get
      {
        return this.m_YSize;
      }
    }

    public MapInfo(XmlElement iXml)
    {
      this.m_Name = iXml.GetAttribute("Name");
      this.m_Num = ByteType.FromString(iXml.GetAttribute("Num"));
      this.m_XSize = IntegerType.FromString(iXml.GetAttribute("XSize"));
      this.m_YSize = IntegerType.FromString(iXml.GetAttribute("YSize"));
    }

    public override string ToString()
    {
      return string.Format("{0}", (object) this.m_Name);
    }
  }
}
