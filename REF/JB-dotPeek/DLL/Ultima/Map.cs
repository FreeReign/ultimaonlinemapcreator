// Decompiled with JetBrains decompiler
// Type: Ultima.Map
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace Ultima
{
  public class Map
  {
    public static readonly Map Felucca = new Map(0, 0, 6144, 4096);
    public static readonly Map Trammel = new Map(0, 1, 6144, 4096);
    public static readonly Map Ilshenar = new Map(2, 2, 2304, 1600);
    public static readonly Map Malas = new Map(3, 3, 2560, 2048);
    private TileMatrix m_Tiles;
    private int m_FileIndex;
    private int m_MapID;
    private int m_Width;
    private int m_Height;
    private static short[] m_Colors;
    private short[][][] m_Cache;
    private short[][][] m_Cache_NoStatics;
    private short[] m_Black;

    public static short[] Colors
    {
      get
      {
        return Map.m_Colors;
      }
      set
      {
        Map.m_Colors = value;
      }
    }

    public bool LoadedMatrix
    {
      get
      {
        return this.m_Tiles != null;
      }
    }

    public TileMatrix Tiles
    {
      get
      {
        if (this.m_Tiles == null)
          this.m_Tiles = new TileMatrix(this.m_FileIndex, this.m_MapID, this.m_Width, this.m_Height);
        return this.m_Tiles;
      }
    }

    private Map(int fileIndex, int mapID, int width, int height)
    {
      this.m_FileIndex = fileIndex;
      this.m_MapID = mapID;
      this.m_Width = width;
      this.m_Height = height;
    }

    public Bitmap GetImage(int x, int y, int width, int height)
    {
      return this.GetImage(x, y, width, height, true);
    }

    public Bitmap GetImage(int x, int y, int width, int height, bool statics)
    {
      Bitmap bmp = new Bitmap(width << 3, height << 3, PixelFormat.Format16bppRgb555);
      this.GetImage(x, y, width, height, bmp, statics);
      return bmp;
    }

    private short[] GetRenderedBlock(int x, int y, bool statics)
    {
      TileMatrix tiles = this.Tiles;
      int blockWidth = tiles.BlockWidth;
      int blockHeight = tiles.BlockHeight;
      if (x < 0 || y < 0 || (x >= blockWidth || y >= blockHeight))
      {
        if (this.m_Black == null)
          this.m_Black = new short[64];
        return this.m_Black;
      }
      else
      {
        short[][][] numArray1 = statics ? this.m_Cache : this.m_Cache_NoStatics;
        if (numArray1 == null)
        {
          if (statics)
            this.m_Cache = numArray1 = new short[this.m_Tiles.BlockHeight][][];
          else
            this.m_Cache_NoStatics = new short[this.m_Tiles.BlockHeight][][];
        }
        if (numArray1[y] == null)
          numArray1[y] = new short[this.m_Tiles.BlockWidth][];
        short[] numArray2 = numArray1[y][x];
        if (numArray2 == null)
          numArray1[y][x] = numArray2 = this.RenderBlock(x, y, statics);
        return numArray2;
      }
    }

    private unsafe short[] RenderBlock(int x, int y, bool drawStatics)
    {
      short[] numArray = new short[64];
      Tile[] landBlock = this.m_Tiles.GetLandBlock(x, y);
      fixed (short* numPtr1 = &Map.m_Colors[0])
        fixed (int* numPtr2 = &TileData.HeightTable[0])
          fixed (Tile* tilePtr1 = &landBlock[0])
          {
            Tile* tilePtr2 = tilePtr1;
            fixed (short* numPtr3 = &numArray[0])
            {
              short* numPtr4 = numPtr3;
              if (drawStatics)
              {
                HuedTile[][][] huedTileArray1 = drawStatics ? this.m_Tiles.GetStaticBlock(x, y) : (HuedTile[][][]) null;
                int index1 = 0;
                int num1 = 0;
                while (index1 < 8)
                {
                  for (int index2 = 0; index2 < 8; ++index2)
                  {
                    int num2 = -255;
                    int num3 = -255;
                    int index3 = 0;
                    int num4 = 0;
                    HuedTile[] huedTileArray2 = huedTileArray1[index2][index1];
                    if (huedTileArray2.Length > 0)
                    {
                      fixed (HuedTile* huedTilePtr1 = &huedTileArray2[0])
                      {
                        HuedTile* huedTilePtr2 = huedTilePtr1;
                        for (HuedTile* huedTilePtr3 = huedTilePtr2 + huedTileArray2.Length; huedTilePtr2 < huedTilePtr3; ++huedTilePtr2)
                        {
                          int num5 = (int) huedTilePtr2->m_Z;
                          int num6 = num5 + numPtr2[(int) huedTilePtr2->m_ID & 16383];
                          if (num6 > num2 || num5 > num3 && num6 >= num2)
                          {
                            num2 = num6;
                            num3 = num5;
                            index3 = (int) huedTilePtr2->m_ID;
                            num4 = (int) huedTilePtr2->m_Hue;
                          }
                        }
                      }
                    }
                    if ((int) tilePtr2->m_Z > num2)
                    {
                      index3 = (int) tilePtr2->m_ID;
                      num4 = 0;
                    }
                    *numPtr4++ = num4 != 0 ? Hues.GetHue(num4 - 1).Colors[(int) numPtr1[index3] >> 10 & 31] : numPtr1[index3];
                    ++tilePtr2;
                  }
                  ++index1;
                  num1 += 8;
                }
              }
              else
              {
                Tile* tilePtr3 = tilePtr2 + 64;
                while (tilePtr2 < tilePtr3)
                  *numPtr4++ = numPtr1[tilePtr2++->m_ID];
              }
            }
          }
      return numArray;
    }

    public void GetImage(int x, int y, int width, int height, Bitmap bmp)
    {
      this.GetImage(x, y, width, height, bmp, true);
    }

    public unsafe void GetImage(int x, int y, int width, int height, Bitmap bmp, bool statics)
    {
      if (Map.m_Colors == null)
        Map.LoadColors();
      BitmapData bitmapdata = bmp.LockBits(new Rectangle(0, 0, width << 3, height << 3), ImageLockMode.WriteOnly, PixelFormat.Format16bppRgb555);
      int stride = bitmapdata.Stride;
      int num1 = stride << 3;
      byte* numPtr1 = (byte*) (void*) bitmapdata.Scan0;
      int num2 = 0;
      int y1 = y;
      while (num2 < height)
      {
        int* numPtr2 = (int*) numPtr1;
        int* numPtr3 = (int*) (numPtr1 + stride);
        int* numPtr4 = (int*) (numPtr1 + (new IntPtr(2) * stride).ToInt64());
        int* numPtr5 = (int*) (numPtr1 + (new IntPtr(3) * stride).ToInt64());
        int* numPtr6 = (int*) (numPtr1 + (new IntPtr(4) * stride).ToInt64());
        int* numPtr7 = (int*) (numPtr1 + (new IntPtr(5) * stride).ToInt64());
        int* numPtr8 = (int*) (numPtr1 + (new IntPtr(6) * stride).ToInt64());
        int* numPtr9 = (int*) (numPtr1 + (new IntPtr(7) * stride).ToInt64());
        int num3 = 0;
        int x1 = x;
        while (num3 < width)
        {
          fixed (short* numPtr10 = &this.GetRenderedBlock(x1, y1, statics)[0])
          {
            int* numPtr11 = numPtr2;
            int num4 = 4;
            int* numPtr12 = (int*) ((IntPtr) numPtr11 + num4);
            int* numPtr13 = (int*) numPtr10;
            int num5 = 4;
            int* numPtr14 = (int*) ((IntPtr) numPtr13 + num5);
            int num6 = *numPtr13;
            *numPtr11 = num6;
            int* numPtr15 = numPtr12;
            int num7 = 4;
            int* numPtr16 = (int*) ((IntPtr) numPtr15 + num7);
            int* numPtr17 = numPtr14;
            int num8 = 4;
            int* numPtr18 = (int*) ((IntPtr) numPtr17 + num8);
            int num9 = *numPtr17;
            *numPtr15 = num9;
            int* numPtr19 = numPtr16;
            int num10 = 4;
            int* numPtr20 = (int*) ((IntPtr) numPtr19 + num10);
            int* numPtr21 = numPtr18;
            int num11 = 4;
            int* numPtr22 = (int*) ((IntPtr) numPtr21 + num11);
            int num12 = *numPtr21;
            *numPtr19 = num12;
            int* numPtr23 = numPtr20;
            int num13 = 4;
            numPtr2 = (int*) ((IntPtr) numPtr23 + num13);
            int* numPtr24 = numPtr22;
            int num14 = 4;
            int* numPtr25 = (int*) ((IntPtr) numPtr24 + num14);
            int num15 = *numPtr24;
            *numPtr23 = num15;
            int* numPtr26 = numPtr3;
            int num16 = 4;
            int* numPtr27 = (int*) ((IntPtr) numPtr26 + num16);
            int* numPtr28 = numPtr25;
            int num17 = 4;
            int* numPtr29 = (int*) ((IntPtr) numPtr28 + num17);
            int num18 = *numPtr28;
            *numPtr26 = num18;
            int* numPtr30 = numPtr27;
            int num19 = 4;
            int* numPtr31 = (int*) ((IntPtr) numPtr30 + num19);
            int* numPtr32 = numPtr29;
            int num20 = 4;
            int* numPtr33 = (int*) ((IntPtr) numPtr32 + num20);
            int num21 = *numPtr32;
            *numPtr30 = num21;
            int* numPtr34 = numPtr31;
            int num22 = 4;
            int* numPtr35 = (int*) ((IntPtr) numPtr34 + num22);
            int* numPtr36 = numPtr33;
            int num23 = 4;
            int* numPtr37 = (int*) ((IntPtr) numPtr36 + num23);
            int num24 = *numPtr36;
            *numPtr34 = num24;
            int* numPtr38 = numPtr35;
            int num25 = 4;
            numPtr3 = (int*) ((IntPtr) numPtr38 + num25);
            int* numPtr39 = numPtr37;
            int num26 = 4;
            int* numPtr40 = (int*) ((IntPtr) numPtr39 + num26);
            int num27 = *numPtr39;
            *numPtr38 = num27;
            int* numPtr41 = numPtr4;
            int num28 = 4;
            int* numPtr42 = (int*) ((IntPtr) numPtr41 + num28);
            int* numPtr43 = numPtr40;
            int num29 = 4;
            int* numPtr44 = (int*) ((IntPtr) numPtr43 + num29);
            int num30 = *numPtr43;
            *numPtr41 = num30;
            int* numPtr45 = numPtr42;
            int num31 = 4;
            int* numPtr46 = (int*) ((IntPtr) numPtr45 + num31);
            int* numPtr47 = numPtr44;
            int num32 = 4;
            int* numPtr48 = (int*) ((IntPtr) numPtr47 + num32);
            int num33 = *numPtr47;
            *numPtr45 = num33;
            int* numPtr49 = numPtr46;
            int num34 = 4;
            int* numPtr50 = (int*) ((IntPtr) numPtr49 + num34);
            int* numPtr51 = numPtr48;
            int num35 = 4;
            int* numPtr52 = (int*) ((IntPtr) numPtr51 + num35);
            int num36 = *numPtr51;
            *numPtr49 = num36;
            int* numPtr53 = numPtr50;
            int num37 = 4;
            numPtr4 = (int*) ((IntPtr) numPtr53 + num37);
            int* numPtr54 = numPtr52;
            int num38 = 4;
            int* numPtr55 = (int*) ((IntPtr) numPtr54 + num38);
            int num39 = *numPtr54;
            *numPtr53 = num39;
            int* numPtr56 = numPtr5;
            int num40 = 4;
            int* numPtr57 = (int*) ((IntPtr) numPtr56 + num40);
            int* numPtr58 = numPtr55;
            int num41 = 4;
            int* numPtr59 = (int*) ((IntPtr) numPtr58 + num41);
            int num42 = *numPtr58;
            *numPtr56 = num42;
            int* numPtr60 = numPtr57;
            int num43 = 4;
            int* numPtr61 = (int*) ((IntPtr) numPtr60 + num43);
            int* numPtr62 = numPtr59;
            int num44 = 4;
            int* numPtr63 = (int*) ((IntPtr) numPtr62 + num44);
            int num45 = *numPtr62;
            *numPtr60 = num45;
            int* numPtr64 = numPtr61;
            int num46 = 4;
            int* numPtr65 = (int*) ((IntPtr) numPtr64 + num46);
            int* numPtr66 = numPtr63;
            int num47 = 4;
            int* numPtr67 = (int*) ((IntPtr) numPtr66 + num47);
            int num48 = *numPtr66;
            *numPtr64 = num48;
            int* numPtr68 = numPtr65;
            int num49 = 4;
            numPtr5 = (int*) ((IntPtr) numPtr68 + num49);
            int* numPtr69 = numPtr67;
            int num50 = 4;
            int* numPtr70 = (int*) ((IntPtr) numPtr69 + num50);
            int num51 = *numPtr69;
            *numPtr68 = num51;
            int* numPtr71 = numPtr6;
            int num52 = 4;
            int* numPtr72 = (int*) ((IntPtr) numPtr71 + num52);
            int* numPtr73 = numPtr70;
            int num53 = 4;
            int* numPtr74 = (int*) ((IntPtr) numPtr73 + num53);
            int num54 = *numPtr73;
            *numPtr71 = num54;
            int* numPtr75 = numPtr72;
            int num55 = 4;
            int* numPtr76 = (int*) ((IntPtr) numPtr75 + num55);
            int* numPtr77 = numPtr74;
            int num56 = 4;
            int* numPtr78 = (int*) ((IntPtr) numPtr77 + num56);
            int num57 = *numPtr77;
            *numPtr75 = num57;
            int* numPtr79 = numPtr76;
            int num58 = 4;
            int* numPtr80 = (int*) ((IntPtr) numPtr79 + num58);
            int* numPtr81 = numPtr78;
            int num59 = 4;
            int* numPtr82 = (int*) ((IntPtr) numPtr81 + num59);
            int num60 = *numPtr81;
            *numPtr79 = num60;
            int* numPtr83 = numPtr80;
            int num61 = 4;
            numPtr6 = (int*) ((IntPtr) numPtr83 + num61);
            int* numPtr84 = numPtr82;
            int num62 = 4;
            int* numPtr85 = (int*) ((IntPtr) numPtr84 + num62);
            int num63 = *numPtr84;
            *numPtr83 = num63;
            int* numPtr86 = numPtr7;
            int num64 = 4;
            int* numPtr87 = (int*) ((IntPtr) numPtr86 + num64);
            int* numPtr88 = numPtr85;
            int num65 = 4;
            int* numPtr89 = (int*) ((IntPtr) numPtr88 + num65);
            int num66 = *numPtr88;
            *numPtr86 = num66;
            int* numPtr90 = numPtr87;
            int num67 = 4;
            int* numPtr91 = (int*) ((IntPtr) numPtr90 + num67);
            int* numPtr92 = numPtr89;
            int num68 = 4;
            int* numPtr93 = (int*) ((IntPtr) numPtr92 + num68);
            int num69 = *numPtr92;
            *numPtr90 = num69;
            int* numPtr94 = numPtr91;
            int num70 = 4;
            int* numPtr95 = (int*) ((IntPtr) numPtr94 + num70);
            int* numPtr96 = numPtr93;
            int num71 = 4;
            int* numPtr97 = (int*) ((IntPtr) numPtr96 + num71);
            int num72 = *numPtr96;
            *numPtr94 = num72;
            int* numPtr98 = numPtr95;
            int num73 = 4;
            numPtr7 = (int*) ((IntPtr) numPtr98 + num73);
            int* numPtr99 = numPtr97;
            int num74 = 4;
            int* numPtr100 = (int*) ((IntPtr) numPtr99 + num74);
            int num75 = *numPtr99;
            *numPtr98 = num75;
            int* numPtr101 = numPtr8;
            int num76 = 4;
            int* numPtr102 = (int*) ((IntPtr) numPtr101 + num76);
            int* numPtr103 = numPtr100;
            int num77 = 4;
            int* numPtr104 = (int*) ((IntPtr) numPtr103 + num77);
            int num78 = *numPtr103;
            *numPtr101 = num78;
            int* numPtr105 = numPtr102;
            int num79 = 4;
            int* numPtr106 = (int*) ((IntPtr) numPtr105 + num79);
            int* numPtr107 = numPtr104;
            int num80 = 4;
            int* numPtr108 = (int*) ((IntPtr) numPtr107 + num80);
            int num81 = *numPtr107;
            *numPtr105 = num81;
            int* numPtr109 = numPtr106;
            int num82 = 4;
            int* numPtr110 = (int*) ((IntPtr) numPtr109 + num82);
            int* numPtr111 = numPtr108;
            int num83 = 4;
            int* numPtr112 = (int*) ((IntPtr) numPtr111 + num83);
            int num84 = *numPtr111;
            *numPtr109 = num84;
            int* numPtr113 = numPtr110;
            int num85 = 4;
            numPtr8 = (int*) ((IntPtr) numPtr113 + num85);
            int* numPtr114 = numPtr112;
            int num86 = 4;
            int* numPtr115 = (int*) ((IntPtr) numPtr114 + num86);
            int num87 = *numPtr114;
            *numPtr113 = num87;
            int* numPtr116 = numPtr9;
            int num88 = 4;
            int* numPtr117 = (int*) ((IntPtr) numPtr116 + num88);
            int* numPtr118 = numPtr115;
            int num89 = 4;
            int* numPtr119 = (int*) ((IntPtr) numPtr118 + num89);
            int num90 = *numPtr118;
            *numPtr116 = num90;
            int* numPtr120 = numPtr117;
            int num91 = 4;
            int* numPtr121 = (int*) ((IntPtr) numPtr120 + num91);
            int* numPtr122 = numPtr119;
            int num92 = 4;
            int* numPtr123 = (int*) ((IntPtr) numPtr122 + num92);
            int num93 = *numPtr122;
            *numPtr120 = num93;
            int* numPtr124 = numPtr121;
            int num94 = 4;
            int* numPtr125 = (int*) ((IntPtr) numPtr124 + num94);
            int* numPtr126 = numPtr123;
            int num95 = 4;
            int* numPtr127 = (int*) ((IntPtr) numPtr126 + num95);
            int num96 = *numPtr126;
            *numPtr124 = num96;
            int* numPtr128 = numPtr125;
            int num97 = 4;
            numPtr9 = (int*) ((IntPtr) numPtr128 + num97);
            int* numPtr129 = numPtr127;
            int num98 = 4;
            int* numPtr130 = (int*) ((IntPtr) numPtr129 + num98);
            int num99 = *numPtr129;
            *numPtr128 = num99;
          }
          ++num3;
          ++x1;
        }
        ++num2;
        ++y1;
        numPtr1 += num1;
      }
      bmp.UnlockBits(bitmapdata);
    }

    [DllImport("Kernel32")]
    private static extern unsafe int _lread(IntPtr hFile, void* lpBuffer, int wBytes);

    private static unsafe void LoadColors()
    {
      Map.m_Colors = new short[32768];
      string filePath = Client.GetFilePath("radarcol.mul");
      if (filePath == null)
        return;
      fixed (short* numPtr = &Map.m_Colors[0])
      {
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
          Map._lread(fileStream.Handle, (void*) numPtr, 65536);
      }
    }
  }
}
