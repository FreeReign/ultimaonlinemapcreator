// Decompiled with JetBrains decompiler
// Type: Ultima.HuedTileList
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

namespace Ultima
{
  public class HuedTileList
  {
    private HuedTile[] m_Tiles;
    private int m_Count;

    public int Count
    {
      get
      {
        return this.m_Count;
      }
    }

    public HuedTileList()
    {
      this.m_Tiles = new HuedTile[8];
      this.m_Count = 0;
    }

    public void Add(short id, short hue, sbyte z)
    {
      if (this.m_Count + 1 > this.m_Tiles.Length)
      {
        HuedTile[] huedTileArray = this.m_Tiles;
        this.m_Tiles = new HuedTile[huedTileArray.Length * 2];
        for (int index = 0; index < huedTileArray.Length; ++index)
          this.m_Tiles[index] = huedTileArray[index];
      }
      this.m_Tiles[this.m_Count++].Set(id, hue, z);
    }

    public HuedTile[] ToArray()
    {
      HuedTile[] huedTileArray = new HuedTile[this.m_Count];
      for (int index = 0; index < this.m_Count; ++index)
        huedTileArray[index] = this.m_Tiles[index];
      this.m_Count = 0;
      return huedTileArray;
    }
  }
}
