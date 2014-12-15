// Decompiled with JetBrains decompiler
// Type: Ultima.TileMatrixPatch
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Ultima
{
  public class TileMatrixPatch
  {
    private int m_LandBlocks;
    private int m_StaticBlocks;

    public int LandBlocks
    {
      get
      {
        return this.m_LandBlocks;
      }
    }

    public int StaticBlocks
    {
      get
      {
        return this.m_StaticBlocks;
      }
    }

    public TileMatrixPatch(TileMatrix matrix, int index)
    {
      string filePath1 = Client.GetFilePath("mapdiff{0}.mul", (object) index);
      string filePath2 = Client.GetFilePath("mapdiffl{0}.mul", (object) index);
      if (filePath1 != null && filePath2 != null)
        this.m_LandBlocks = this.PatchLand(matrix, filePath1, filePath2);
      string filePath3 = Client.GetFilePath("stadiff{0}.mul", (object) index);
      string filePath4 = Client.GetFilePath("stadiffl{0}.mul", (object) index);
      string filePath5 = Client.GetFilePath("stadiffi{0}.mul", (object) index);
      if (filePath3 == null || filePath4 == null || filePath5 == null)
        return;
      this.m_StaticBlocks = this.PatchStatics(matrix, filePath3, filePath4, filePath5);
    }

    [DllImport("Kernel32")]
    private static extern unsafe int _lread(IntPtr hFile, void* lpBuffer, int wBytes);

    private unsafe int PatchLand(TileMatrix matrix, string dataPath, string indexPath)
    {
      using (FileStream fileStream1 = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.Read))
      {
        using (FileStream fileStream2 = new FileStream(indexPath, FileMode.Open, FileAccess.Read, FileShare.Read))
        {
          BinaryReader binaryReader = new BinaryReader((Stream) fileStream2);
          int num1 = (int) (binaryReader.BaseStream.Length / 4L);
          for (int index = 0; index < num1; ++index)
          {
            int num2 = binaryReader.ReadInt32();
            int x = num2 / matrix.BlockHeight;
            int y = num2 % matrix.BlockHeight;
            fileStream1.Seek(4L, SeekOrigin.Current);
            Tile[] tileArray = new Tile[64];
            fixed (Tile* tilePtr = &tileArray[0])
              TileMatrixPatch._lread(fileStream1.Handle, (void*) tilePtr, 192);
            matrix.SetLandBlock(x, y, tileArray);
          }
          return num1;
        }
      }
    }

    private unsafe int PatchStatics(TileMatrix matrix, string dataPath, string indexPath, string lookupPath)
    {
      using (FileStream fileStream1 = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.Read))
      {
        using (FileStream fileStream2 = new FileStream(indexPath, FileMode.Open, FileAccess.Read, FileShare.Read))
        {
          using (FileStream fileStream3 = new FileStream(lookupPath, FileMode.Open, FileAccess.Read, FileShare.Read))
          {
            BinaryReader binaryReader1 = new BinaryReader((Stream) fileStream2);
            BinaryReader binaryReader2 = new BinaryReader((Stream) fileStream3);
            int num1 = (int) (binaryReader1.BaseStream.Length / 4L);
            HuedTileList[][] huedTileListArray = new HuedTileList[8][];
            for (int index1 = 0; index1 < 8; ++index1)
            {
              huedTileListArray[index1] = new HuedTileList[8];
              for (int index2 = 0; index2 < 8; ++index2)
                huedTileListArray[index1][index2] = new HuedTileList();
            }
            for (int index1 = 0; index1 < num1; ++index1)
            {
              int num2 = binaryReader1.ReadInt32();
              int x = num2 / matrix.BlockHeight;
              int y = num2 % matrix.BlockHeight;
              int num3 = binaryReader2.ReadInt32();
              int wBytes = binaryReader2.ReadInt32();
              binaryReader2.ReadInt32();
              if (num3 < 0 || wBytes <= 0)
              {
                matrix.SetStaticBlock(x, y, matrix.EmptyStaticBlock);
              }
              else
              {
                fileStream1.Seek((long) num3, SeekOrigin.Begin);
                int length = wBytes / 7;
                StaticTile[] staticTileArray = new StaticTile[length];
                fixed (StaticTile* staticTilePtr1 = &staticTileArray[0])
                {
                  TileMatrixPatch._lread(fileStream1.Handle, (void*) staticTilePtr1, wBytes);
                  StaticTile* staticTilePtr2 = staticTilePtr1;
                  for (StaticTile* staticTilePtr3 = staticTilePtr1 + length; staticTilePtr2 < staticTilePtr3; ++staticTilePtr2)
                    huedTileListArray[(int) staticTilePtr2->m_X & 7][(int) staticTilePtr2->m_Y & 7].Add((short) (((int) staticTilePtr2->m_ID & 16383) + 16384), staticTilePtr2->m_Hue, staticTilePtr2->m_Z);
                  HuedTile[][][] huedTileArray = new HuedTile[8][][];
                  for (int index2 = 0; index2 < 8; ++index2)
                  {
                    huedTileArray[index2] = new HuedTile[8][];
                    for (int index3 = 0; index3 < 8; ++index3)
                      huedTileArray[index2][index3] = huedTileListArray[index2][index3].ToArray();
                  }
                  matrix.SetStaticBlock(x, y, huedTileArray);
                }
              }
            }
            return num1;
          }
        }
      }
    }
  }
}
