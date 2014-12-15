// Decompiled with JetBrains decompiler
// Type: Ultima.TileMatrix
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Ultima
{
  public class TileMatrix
  {
    private HuedTile[][][][][] m_StaticTiles;
    private Tile[][][] m_LandTiles;
    private Tile[] m_InvalidLandBlock;
    private HuedTile[][][] m_EmptyStaticBlock;
    private FileStream m_Map;
    private FileStream m_Index;
    private BinaryReader m_IndexReader;
    private FileStream m_Statics;
    private int m_BlockWidth;
    private int m_BlockHeight;
    private int m_Width;
    private int m_Height;
    private TileMatrixPatch m_Patch;
    private static HuedTileList[][] m_Lists;

    public TileMatrixPatch Patch
    {
      get
      {
        return this.m_Patch;
      }
    }

    public int BlockWidth
    {
      get
      {
        return this.m_BlockWidth;
      }
    }

    public int BlockHeight
    {
      get
      {
        return this.m_BlockHeight;
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

    public HuedTile[][][] EmptyStaticBlock
    {
      get
      {
        return this.m_EmptyStaticBlock;
      }
    }

    public TileMatrix(int fileIndex, int mapID, int width, int height)
    {
      this.m_Width = width;
      this.m_Height = height;
      this.m_BlockWidth = width >> 3;
      this.m_BlockHeight = height >> 3;
      if (fileIndex != (int) sbyte.MaxValue)
      {
        string filePath1 = Client.GetFilePath("map{0}.mul", (object) fileIndex);
        if (filePath1 != null)
          this.m_Map = new FileStream(filePath1, FileMode.Open, FileAccess.Read, FileShare.Read);
        string filePath2 = Client.GetFilePath("staidx{0}.mul", (object) fileIndex);
        if (filePath2 != null)
        {
          this.m_Index = new FileStream(filePath2, FileMode.Open, FileAccess.Read, FileShare.Read);
          this.m_IndexReader = new BinaryReader((Stream) this.m_Index);
        }
        string filePath3 = Client.GetFilePath("statics{0}.mul", (object) fileIndex);
        if (filePath3 != null)
          this.m_Statics = new FileStream(filePath3, FileMode.Open, FileAccess.Read, FileShare.Read);
      }
      this.m_EmptyStaticBlock = new HuedTile[8][][];
      for (int index1 = 0; index1 < 8; ++index1)
      {
        this.m_EmptyStaticBlock[index1] = new HuedTile[8][];
        for (int index2 = 0; index2 < 8; ++index2)
          this.m_EmptyStaticBlock[index1][index2] = new HuedTile[0];
      }
      this.m_InvalidLandBlock = new Tile[196];
      this.m_LandTiles = new Tile[this.m_BlockWidth][][];
      this.m_StaticTiles = new HuedTile[this.m_BlockWidth][][][][];
      this.m_Patch = new TileMatrixPatch(this, mapID);
    }

    [DllImport("Kernel32")]
    private static extern unsafe int _lread(IntPtr hFile, void* lpBuffer, int wBytes);

    public void SetStaticBlock(int x, int y, HuedTile[][][] value)
    {
      if (x < 0 || y < 0 || (x >= this.m_BlockWidth || y >= this.m_BlockHeight))
        return;
      if (this.m_StaticTiles[x] == null)
        this.m_StaticTiles[x] = new HuedTile[this.m_BlockHeight][][][];
      this.m_StaticTiles[x][y] = value;
    }

    public HuedTile[][][] GetStaticBlock(int x, int y)
    {
      if (x < 0 || y < 0 || (x >= this.m_BlockWidth || y >= this.m_BlockHeight) || (this.m_Statics == null || this.m_Index == null))
        return this.m_EmptyStaticBlock;
      if (this.m_StaticTiles[x] == null)
        this.m_StaticTiles[x] = new HuedTile[this.m_BlockHeight][][][];
      return this.m_StaticTiles[x][y] ?? (this.m_StaticTiles[x][y] = this.ReadStaticBlock(x, y));
    }

    public HuedTile[] GetStaticTiles(int x, int y)
    {
      return this.GetStaticBlock(x >> 3, y >> 3)[x & 7][y & 7];
    }

    public void SetLandBlock(int x, int y, Tile[] value)
    {
      if (x < 0 || y < 0 || (x >= this.m_BlockWidth || y >= this.m_BlockHeight))
        return;
      if (this.m_LandTiles[x] == null)
        this.m_LandTiles[x] = new Tile[this.m_BlockHeight][];
      this.m_LandTiles[x][y] = value;
    }

    public Tile[] GetLandBlock(int x, int y)
    {
      if (x < 0 || y < 0 || (x >= this.m_BlockWidth || y >= this.m_BlockHeight) || this.m_Map == null)
        return this.m_InvalidLandBlock;
      if (this.m_LandTiles[x] == null)
        this.m_LandTiles[x] = new Tile[this.m_BlockHeight][];
      return this.m_LandTiles[x][y] ?? (this.m_LandTiles[x][y] = this.ReadLandBlock(x, y));
    }

    public Tile GetLandTile(int x, int y)
    {
      return this.GetLandBlock(x >> 3, y >> 3)[((y & 7) << 3) + (x & 7)];
    }

    private unsafe HuedTile[][][] ReadStaticBlock(int x, int y)
    {
      this.m_IndexReader.BaseStream.Seek((long) ((x * this.m_BlockHeight + y) * 12), SeekOrigin.Begin);
      int num = this.m_IndexReader.ReadInt32();
      int wBytes = this.m_IndexReader.ReadInt32();
      if (num < 0 || wBytes <= 0)
        return this.m_EmptyStaticBlock;
      int length = wBytes / 7;
      this.m_Statics.Seek((long) num, SeekOrigin.Begin);
      fixed (StaticTile* staticTilePtr1 = &new StaticTile[length][0])
      {
        TileMatrix._lread(this.m_Statics.Handle, (void*) staticTilePtr1, wBytes);
        if (TileMatrix.m_Lists == null)
        {
          TileMatrix.m_Lists = new HuedTileList[8][];
          for (int index1 = 0; index1 < 8; ++index1)
          {
            TileMatrix.m_Lists[index1] = new HuedTileList[8];
            for (int index2 = 0; index2 < 8; ++index2)
              TileMatrix.m_Lists[index1][index2] = new HuedTileList();
          }
        }
        HuedTileList[][] huedTileListArray = TileMatrix.m_Lists;
        StaticTile* staticTilePtr2 = staticTilePtr1;
        for (StaticTile* staticTilePtr3 = staticTilePtr1 + length; staticTilePtr2 < staticTilePtr3; ++staticTilePtr2)
          huedTileListArray[(int) staticTilePtr2->m_X & 7][(int) staticTilePtr2->m_Y & 7].Add((short) (((int) staticTilePtr2->m_ID & 16383) + 16384), staticTilePtr2->m_Hue, staticTilePtr2->m_Z);
        HuedTile[][][] huedTileArray = new HuedTile[8][][];
        for (int index1 = 0; index1 < 8; ++index1)
        {
          huedTileArray[index1] = new HuedTile[8][];
          for (int index2 = 0; index2 < 8; ++index2)
            huedTileArray[index1][index2] = huedTileListArray[index1][index2].ToArray();
        }
        return huedTileArray;
      }
    }

    private unsafe Tile[] ReadLandBlock(int x, int y)
    {
      this.m_Map.Seek((long) ((x * this.m_BlockHeight + y) * 196 + 4), SeekOrigin.Begin);
      Tile[] tileArray = new Tile[64];
      fixed (Tile* tilePtr = &tileArray[0])
        TileMatrix._lread(this.m_Map.Handle, (void*) tilePtr, 192);
      return tileArray;
    }

    public void Dispose()
    {
      if (this.m_Map != null)
        this.m_Map.Close();
      if (this.m_Statics != null)
        this.m_Statics.Close();
      if (this.m_IndexReader == null)
        return;
      this.m_IndexReader.Close();
    }
  }
}
