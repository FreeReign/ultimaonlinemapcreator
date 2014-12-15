// Decompiled with JetBrains decompiler
// Type: Ultima.MultiComponentList
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System;
using System.Drawing;
using System.IO;

namespace Ultima
{
  public sealed class MultiComponentList
  {
    public static readonly MultiComponentList Empty = new MultiComponentList();
    private Point m_Min;
    private Point m_Max;
    private Point m_Center;
    private int m_Width;
    private int m_Height;
    private Tile[][][] m_Tiles;

    public Point Min
    {
      get
      {
        return this.m_Min;
      }
    }

    public Point Max
    {
      get
      {
        return this.m_Max;
      }
    }

    public Point Center
    {
      get
      {
        return this.m_Center;
      }
    }

    public int Width
    {
      get
      {
        return this.m_Width;
      }
    }

    public int Height
    {
      get
      {
        return this.m_Height;
      }
    }

    public Tile[][][] Tiles
    {
      get
      {
        return this.m_Tiles;
      }
    }

    public MultiComponentList(BinaryReader reader, int count)
    {
      this.m_Min = this.m_Max = Point.Empty;
      MultiComponentList.MultiTileEntry[] multiTileEntryArray = new MultiComponentList.MultiTileEntry[count];
      for (int index = 0; index < count; ++index)
      {
        multiTileEntryArray[index].m_ItemID = reader.ReadInt16();
        multiTileEntryArray[index].m_OffsetX = reader.ReadInt16();
        multiTileEntryArray[index].m_OffsetY = reader.ReadInt16();
        multiTileEntryArray[index].m_OffsetZ = reader.ReadInt16();
        multiTileEntryArray[index].m_Flags = reader.ReadInt32();
        MultiComponentList.MultiTileEntry multiTileEntry = multiTileEntryArray[index];
        if ((int) multiTileEntry.m_OffsetX < this.m_Min.X)
          this.m_Min.X = (int) multiTileEntry.m_OffsetX;
        if ((int) multiTileEntry.m_OffsetY < this.m_Min.Y)
          this.m_Min.Y = (int) multiTileEntry.m_OffsetY;
        if ((int) multiTileEntry.m_OffsetX > this.m_Max.X)
          this.m_Max.X = (int) multiTileEntry.m_OffsetX;
        if ((int) multiTileEntry.m_OffsetY > this.m_Max.Y)
          this.m_Max.Y = (int) multiTileEntry.m_OffsetY;
      }
      this.m_Center = new Point(-this.m_Min.X, -this.m_Min.Y);
      this.m_Width = this.m_Max.X - this.m_Min.X + 1;
      this.m_Height = this.m_Max.Y - this.m_Min.Y + 1;
      TileList[][] tileListArray = new TileList[this.m_Width][];
      this.m_Tiles = new Tile[this.m_Width][][];
      for (int index1 = 0; index1 < this.m_Width; ++index1)
      {
        tileListArray[index1] = new TileList[this.m_Height];
        this.m_Tiles[index1] = new Tile[this.m_Height][];
        for (int index2 = 0; index2 < this.m_Height; ++index2)
          tileListArray[index1][index2] = new TileList();
      }
      for (int index1 = 0; index1 < multiTileEntryArray.Length; ++index1)
      {
        int index2 = (int) multiTileEntryArray[index1].m_OffsetX + this.m_Center.X;
        int index3 = (int) multiTileEntryArray[index1].m_OffsetY + this.m_Center.Y;
        tileListArray[index2][index3].Add((short) (((int) multiTileEntryArray[index1].m_ItemID & 16383) + 16384), (sbyte) multiTileEntryArray[index1].m_OffsetZ);
      }
      for (int index1 = 0; index1 < this.m_Width; ++index1)
      {
        for (int index2 = 0; index2 < this.m_Height; ++index2)
        {
          this.m_Tiles[index1][index2] = tileListArray[index1][index2].ToArray();
          if (this.m_Tiles[index1][index2].Length > 1)
            Array.Sort((Array) this.m_Tiles[index1][index2]);
        }
      }
    }

    private MultiComponentList()
    {
      this.m_Tiles = new Tile[0][][];
    }

    public Bitmap GetImage()
    {
      if (this.m_Width == 0 || this.m_Height == 0)
        return (Bitmap) null;
      int num1 = 1000;
      int num2 = 1000;
      int num3 = -1000;
      int num4 = -1000;
      for (int index1 = 0; index1 < this.m_Width; ++index1)
      {
        for (int index2 = 0; index2 < this.m_Height; ++index2)
        {
          Tile[] tileArray = this.m_Tiles[index1][index2];
          for (int index3 = 0; index3 < tileArray.Length; ++index3)
          {
            Bitmap @static = Art.GetStatic(tileArray[index3].ID - 16384);
            if (@static != null)
            {
              int num5 = (index1 - index2) * 22;
              int num6 = (index1 + index2) * 22;
              int num7 = num5 - @static.Width / 2;
              int num8 = num6 - tileArray[index3].Z * 4 - @static.Height;
              if (num7 < num1)
                num1 = num7;
              if (num8 < num2)
                num2 = num8;
              int num9 = num7 + @static.Width;
              int num10 = num8 + @static.Height;
              if (num9 > num3)
                num3 = num9;
              if (num10 > num4)
                num4 = num10;
            }
          }
        }
      }
      Bitmap bitmap = new Bitmap(num3 - num1, num4 - num2);
      Graphics graphics = Graphics.FromImage((Image) bitmap);
      for (int index1 = 0; index1 < this.m_Width; ++index1)
      {
        for (int index2 = 0; index2 < this.m_Height; ++index2)
        {
          Tile[] tileArray = this.m_Tiles[index1][index2];
          for (int index3 = 0; index3 < tileArray.Length; ++index3)
          {
            Bitmap @static = Art.GetStatic(tileArray[index3].ID - 16384);
            if (@static != null)
            {
              int num5 = (index1 - index2) * 22;
              int num6 = (index1 + index2) * 22;
              int num7 = num5 - @static.Width / 2;
              int num8 = num6 - tileArray[index3].Z * 4 - @static.Height;
              int x = num7 - num1;
              int y = num8 - num2;
              graphics.DrawImageUnscaled((Image) @static, x, y, @static.Width, @static.Height);
            }
          }
          int num9 = (index1 - index2) * 22;
          int num10 = (index1 + index2) * 22;
          int num11 = num9 - num1;
          int num12 = num10 - num2;
        }
      }
      graphics.Dispose();
      return bitmap;
    }

    private struct MultiTileEntry
    {
      public short m_ItemID;
      public short m_OffsetX;
      public short m_OffsetY;
      public short m_OffsetZ;
      public int m_Flags;
    }
  }
}
