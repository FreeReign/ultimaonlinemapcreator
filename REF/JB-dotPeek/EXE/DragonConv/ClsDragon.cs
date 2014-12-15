// Decompiled with JetBrains decompiler
// Type: DragonConv.ClsDragon
// Assembly: DragonConv, Version=1.0.1819.29268, Culture=neutral, PublicKeyToken=null
// MVID: BA7AE34F-ABD8-4700-AE28-2ED5A239CB08
// Assembly location: W:\JetBrains\UOLandscaper\DragonConv.exe

using Microsoft.VisualBasic.CompilerServices;
using System.Xml;

namespace DragonConv
{
  public class ClsDragon
  {
    private int m_GroupID;
    private byte m_TerrainID;
    private byte m_AltitudeID;

    public int GroupID
    {
      get
      {
        return this.m_GroupID;
      }
      set
      {
        this.m_GroupID = value;
      }
    }

    public byte TerrainID
    {
      get
      {
        return this.m_TerrainID;
      }
      set
      {
        this.m_TerrainID = value;
      }
    }

    public byte AltitudeID
    {
      get
      {
        return this.m_AltitudeID;
      }
      set
      {
        this.m_AltitudeID = value;
      }
    }

    public ClsDragon(XmlElement xmlInfo)
    {
      this.m_GroupID = IntegerType.FromString("&H" + xmlInfo.GetAttribute("GroupID"));
      this.m_TerrainID = ByteType.FromString("&H" + xmlInfo.GetAttribute("Terrain"));
      this.m_AltitudeID = ByteType.FromString("&H" + xmlInfo.GetAttribute("Alt"));
    }

    public void Save(XmlTextWriter xmlInfo)
    {
      ((XmlWriter) xmlInfo).WriteStartElement("HoxCode");
      xmlInfo.WriteAttributeString("GroupID", StringType.FromInteger(this.m_GroupID));
      xmlInfo.WriteAttributeString("Alt", StringType.FromByte(this.m_AltitudeID));
      xmlInfo.WriteAttributeString("Terrain", StringType.FromByte(this.m_TerrainID));
      xmlInfo.WriteEndElement();
    }
  }
}
