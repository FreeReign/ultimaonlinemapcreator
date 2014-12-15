// Decompiled with JetBrains decompiler
// Type: Transition.StaticTile
// Assembly: Transition, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: D3B0804F-08F3-42BB-B2B3-B2AAA4B5AE51
// Assembly location: W:\JetBrains\UOLandscaper\Transition.dll

using Microsoft.VisualBasic.CompilerServices;
using System.Xml;

namespace Transition
{
  public class StaticTile
  {
    private short m_TileID;
    private short m_AltIDMod;

    public short TileID
    {
      get
      {
        return this.m_TileID;
      }
      set
      {
        this.m_TileID = value;
      }
    }

    public short AltIDMod
    {
      get
      {
        return this.m_AltIDMod;
      }
      set
      {
        this.m_AltIDMod = value;
      }
    }

    public StaticTile()
    {
    }

    public StaticTile(short TileID, short AltIDMod)
    {
      this.m_TileID = TileID;
      this.m_AltIDMod = AltIDMod;
    }

    public StaticTile(XmlElement xmlInfo)
    {
      this.m_TileID = XmlConvert.ToInt16(xmlInfo.GetAttribute("TileID"));
      this.m_AltIDMod = XmlConvert.ToInt16(xmlInfo.GetAttribute("AltIDMod"));
    }

    public override string ToString()
    {
      return string.Format("{0:X4} [{1}]", (object) this.m_TileID, (object) this.m_AltIDMod);
    }

    public void Save(XmlTextWriter xmlInfo)
    {
      ((XmlWriter) xmlInfo).WriteStartElement("StaticTile");
      xmlInfo.WriteAttributeString("TileID", StringType.FromInteger((int) this.m_TileID));
      xmlInfo.WriteAttributeString("AltIDMod", StringType.FromInteger((int) this.m_AltIDMod));
      xmlInfo.WriteEndElement();
    }
  }
}
