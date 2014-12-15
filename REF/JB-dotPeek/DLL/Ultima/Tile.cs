// Decompiled with JetBrains decompiler
// Type: Ultima.Tile
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System;
using System.Runtime.InteropServices;

namespace Ultima
{
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  public struct Tile : IComparable
  {
    internal short m_ID;
    internal sbyte m_Z;

    public int ID
    {
      get
      {
        return (int) this.m_ID;
      }
    }

    public int Z
    {
      get
      {
        return (int) this.m_Z;
      }
      set
      {
        this.m_Z = (sbyte) value;
      }
    }

    public bool Ignored
    {
      get
      {
        if ((int) this.m_ID == 2 || (int) this.m_ID == 475)
          return true;
        if ((int) this.m_ID >= 430)
          return (int) this.m_ID <= 437;
        else
          return false;
      }
    }

    public Tile(short id, sbyte z)
    {
      this.m_ID = id;
      this.m_Z = z;
    }

    public void Set(short id, sbyte z)
    {
      this.m_ID = id;
      this.m_Z = z;
    }

    public int CompareTo(object x)
    {
      if (x == null)
        return 1;
      if (!(x is Tile))
        throw new ArgumentNullException();
      Tile tile = (Tile) x;
      if ((int) this.m_Z > (int) tile.m_Z)
        return 1;
      if ((int) tile.m_Z > (int) this.m_Z)
        return -1;
      ItemData itemData1 = TileData.ItemTable[(int) this.m_ID & 16383];
      ItemData itemData2 = TileData.ItemTable[(int) tile.m_ID & 16383];
      if (itemData1.Height > itemData2.Height)
        return 1;
      if (itemData2.Height > itemData1.Height || itemData1.Background && !itemData2.Background)
        return -1;
      return itemData2.Background && !itemData1.Background ? 1 : 0;
    }
  }
}
