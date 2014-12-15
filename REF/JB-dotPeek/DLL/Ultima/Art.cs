// Decompiled with JetBrains decompiler
// Type: Ultima.Art
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Ultima
{
  public class Art
  {
    private static FileIndex m_FileIndex = new FileIndex("Artidx.mul", "Art.mul", 65536, 4);
    private static Bitmap[] m_Cache = new Bitmap[65536];

    public static FileIndex FileIndex
    {
      get
      {
        return Art.m_FileIndex;
      }
    }

    public static Bitmap[] Cache
    {
      get
      {
        return Art.m_Cache;
      }
    }

    private Art()
    {
    }

    public static Bitmap GetLand(int index)
    {
      index &= 16383;
      if (Art.m_Cache[index] != null)
        return Art.m_Cache[index];
      int length;
      int extra;
      bool patched;
      Stream stream = Art.m_FileIndex.Seek(index, out length, out extra, out patched);
      if (stream == null)
        return (Bitmap) null;
      else
        return Art.m_Cache[index] = Art.LoadLand(stream);
    }

    public static Bitmap GetStatic(int index)
    {
      index += 16384;
      index &= (int) ushort.MaxValue;
      if (Art.m_Cache[index] != null)
        return Art.m_Cache[index];
      int length;
      int extra;
      bool patched;
      Stream stream = Art.m_FileIndex.Seek(index, out length, out extra, out patched);
      if (stream == null)
        return (Bitmap) null;
      else
        return Art.m_Cache[index] = Art.LoadStatic(stream);
    }

    public static unsafe void Measure(Bitmap bmp, out int xMin, out int yMin, out int xMax, out int yMax)
    {
      xMin = yMin = 0;
      xMax = yMax = -1;
      if (bmp == null || bmp.Width <= 0 || bmp.Height <= 0)
        return;
      BitmapData bitmapdata = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format16bppArgb1555);
      int num1 = (bitmapdata.Stride >> 1) - bitmapdata.Width;
      int num2 = bitmapdata.Stride >> 1;
      ushort* numPtr1 = (ushort*) (void*) bitmapdata.Scan0;
      ushort* numPtr2 = numPtr1 + bitmapdata.Width;
      ushort* numPtr3 = numPtr1 + bitmapdata.Height * num2;
      bool flag = false;
      int num3 = 0;
      int num4 = 0;
      while (numPtr1 < numPtr3)
      {
        while (numPtr1 < numPtr2)
        {
          if (((int) *numPtr1++ & 32768) != 0)
          {
            if (!flag)
            {
              flag = true;
              xMin = xMax = num3;
              yMin = yMax = num4;
            }
            else
            {
              if (num3 < xMin)
                xMin = num3;
              if (num4 < yMin)
                yMin = num4;
              if (num3 > xMax)
                xMax = num3;
              if (num4 > yMax)
                yMax = num4;
            }
          }
          ++num3;
        }
        numPtr1 += num1;
        numPtr2 += num2;
        ++num4;
        num3 = 0;
      }
      bmp.UnlockBits(bitmapdata);
    }

    private static unsafe Bitmap LoadStatic(Stream stream)
    {
      BinaryReader binaryReader = new BinaryReader(stream);
      binaryReader.ReadInt32();
      int width = (int) binaryReader.ReadInt16();
      int height = (int) binaryReader.ReadInt16();
      if (width <= 0 || height <= 0)
        return (Bitmap) null;
      int[] numArray = new int[height];
      int num1 = (int) binaryReader.BaseStream.Position + height * 2;
      for (int index = 0; index < height; ++index)
        numArray[index] = num1 + (int) binaryReader.ReadUInt16() * 2;
      Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format16bppArgb1555);
      BitmapData bitmapdata = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format16bppArgb1555);
      ushort* numPtr1 = (ushort*) (void*) bitmapdata.Scan0;
      int num2 = bitmapdata.Stride >> 1;
      int index1 = 0;
      while (index1 < height)
      {
        binaryReader.BaseStream.Seek((long) numArray[index1], SeekOrigin.Begin);
        ushort* numPtr2 = numPtr1;
        int num3;
        int num4;
        while ((num3 = (int) binaryReader.ReadUInt16()) + (num4 = (int) binaryReader.ReadUInt16()) != 0)
        {
          numPtr2 += num3;
          ushort* numPtr3 = numPtr2 + num4;
          while (numPtr2 < numPtr3)
            *numPtr2++ = (ushort) ((uint) binaryReader.ReadUInt16() ^ 32768U);
        }
        ++index1;
        numPtr1 += num2;
      }
      bitmap.UnlockBits(bitmapdata);
      return bitmap;
    }

    private static unsafe Bitmap LoadLand(Stream stream)
    {
      Bitmap bitmap = new Bitmap(44, 44, PixelFormat.Format16bppArgb1555);
      BitmapData bitmapdata = bitmap.LockBits(new Rectangle(0, 0, 44, 44), ImageLockMode.WriteOnly, PixelFormat.Format16bppArgb1555);
      BinaryReader binaryReader = new BinaryReader(stream);
      int num1 = 21;
      int num2 = 2;
      ushort* numPtr1 = (ushort*) (void*) bitmapdata.Scan0;
      int num3 = bitmapdata.Stride >> 1;
      int num4 = 0;
      while (num4 < 22)
      {
        ushort* numPtr2 = numPtr1 + num1;
        ushort* numPtr3 = numPtr2 + num2;
        while (numPtr2 < numPtr3)
          *numPtr2++ = (ushort) ((uint) binaryReader.ReadUInt16() | 32768U);
        ++num4;
        --num1;
        num2 += 2;
        numPtr1 += num3;
      }
      int num5 = 0;
      int num6 = 44;
      int num7 = 0;
      while (num7 < 22)
      {
        ushort* numPtr2 = numPtr1 + num5;
        ushort* numPtr3 = numPtr2 + num6;
        while (numPtr2 < numPtr3)
          *numPtr2++ = (ushort) ((uint) binaryReader.ReadUInt16() | 32768U);
        ++num7;
        ++num5;
        num6 -= 2;
        numPtr1 += num3;
      }
      bitmap.UnlockBits(bitmapdata);
      return bitmap;
    }
  }
}
