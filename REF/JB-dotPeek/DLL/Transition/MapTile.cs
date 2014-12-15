// Decompiled with JetBrains decompiler
// Type: Transition.MapTile
// Assembly: Transition, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: D3B0804F-08F3-42BB-B2B3-B2AAA4B5AE51
// Assembly location: W:\JetBrains\UOLandscaper\Transition.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace Transition
{
  public class MapTile
  {
    private short m_TileID;
    private short m_AltID;

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
        return this.m_AltID;
      }
      set
      {
        this.m_AltID = value;
      }
    }

    public MapTile(short TileID, short AltID)
    {
      this.m_TileID = TileID;
      this.m_AltID = AltID;
    }

    public MapTile()
    {
    }

    public MapTile(XmlElement xmlInfo)
    {
      try
      {
        this.m_TileID = XmlConvert.ToInt16(xmlInfo.GetAttribute("TileID"));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.m_TileID = ShortType.FromString("&H" + xmlInfo.GetAttribute("TileID"));
        ProjectData.ClearProjectError();
      }
      this.m_AltID = XmlConvert.ToInt16(xmlInfo.GetAttribute("AltIDMod"));
    }

    public override string ToString()
    {
      return string.Format("{0:X4} [{1}]", (object) this.m_TileID, (object) this.m_AltID);
    }

    public void Save(XmlTextWriter xmlInfo)
    {
      ((XmlWriter) xmlInfo).WriteStartElement("MapTile");
      xmlInfo.WriteAttributeString("TileID", StringType.FromInteger((int) this.m_TileID));
      xmlInfo.WriteAttributeString("AltIDMod", StringType.FromInteger((int) this.m_AltID));
      xmlInfo.WriteEndElement();
    }
  }
}
