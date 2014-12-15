// Decompiled with JetBrains decompiler
// Type: Ultima.TileList
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

namespace Ultima
{
  public class TileList
  {
    private Tile[] m_Tiles;
    private int m_Count;

    public int Count
    {
      get
      {
        return this.m_Count;
      }
    }

    public TileList()
    {
      this.m_Tiles = new Tile[8];
      this.m_Count = 0;
    }

    public void Add(short id, sbyte z)
    {
      if (this.m_Count + 1 > this.m_Tiles.Length)
      {
        Tile[] tileArray = this.m_Tiles;
        this.m_Tiles = new Tile[tileArray.Length * 2];
        for (int index = 0; index < tileArray.Length; ++index)
          this.m_Tiles[index] = tileArray[index];
      }
      this.m_Tiles[this.m_Count++].Set(id, z);
    }

    public Tile[] ToArray()
    {
      Tile[] tileArray = new Tile[this.m_Count];
      for (int index = 0; index < this.m_Count; ++index)
        tileArray[index] = this.m_Tiles[index];
      this.m_Count = 0;
      return tileArray;
    }
  }
}
