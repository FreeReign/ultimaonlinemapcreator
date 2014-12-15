// Decompiled with JetBrains decompiler
// Type: Ultima.Gumps
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Ultima
{
  public class Gumps
  {
    private static FileIndex m_FileIndex = new FileIndex("Gumpidx.mul", "Gumpart.mul", 65536, 12);
    private static byte[] m_PixelBuffer;
    private static byte[] m_StreamBuffer;
    private static byte[] m_ColorTable;

    public static FileIndex FileIndex
    {
      get
      {
        return Gumps.m_FileIndex;
      }
    }

    public static unsafe Bitmap GetGump(int index, Hue hue, bool onlyHueGrayPixels)
    {
      int length;
      int extra;
      bool patched;
      Stream stream = Gumps.m_FileIndex.Seek(index, out length, out extra, out patched);
      if (stream == null)
        return (Bitmap) null;
      int width = extra >> 16 & (int) ushort.MaxValue;
      int height = extra & (int) ushort.MaxValue;
      if (width <= 0 || height <= 0)
        return (Bitmap) null;
      int stride = (width << 1) + 3 & -4;
      int num1 = height * stride;
      int num2 = width + 1 & -2;
      int num3 = num2 - width;
      byte[] numArray1 = Gumps.m_PixelBuffer;
      if (numArray1 == null || numArray1.Length < num1)
        Gumps.m_PixelBuffer = numArray1 = new byte[num1 + 2047 & -2048];
      byte[] buffer = Gumps.m_StreamBuffer;
      if (buffer == null || buffer.Length < length)
        Gumps.m_StreamBuffer = buffer = new byte[length + 2047 & -2048];
      byte[] numArray2 = Gumps.m_ColorTable;
      if (numArray2 == null)
        Gumps.m_ColorTable = numArray2 = new byte[128];
      stream.Read(buffer, 0, length);
      fixed (short* numPtr1 = &hue.Colors[0])
        fixed (byte* numPtr2 = &buffer[0])
          fixed (byte* numPtr3 = &numArray1[0])
            fixed (byte* numPtr4 = &numArray2[0])
            {
              ushort* numPtr5 = (ushort*) numPtr1;
              ushort* numPtr6 = numPtr5 + 32;
              ushort* numPtr7 = (ushort*) numPtr4;
              ushort* numPtr8 = numPtr7;
              while (numPtr5 < numPtr6)
                *numPtr8++ = *numPtr5++;
              ushort* numPtr9 = (ushort*) numPtr3;
              int* numPtr10 = (int*) numPtr2;
              int* numPtr11 = numPtr10 + height;
              int* numPtr12 = numPtr10;
              ushort* numPtr13 = numPtr9;
              ushort* numPtr14 = numPtr13 + width;
              if (onlyHueGrayPixels)
              {
                while (numPtr10 < numPtr11)
                {
                  int* numPtr15 = numPtr12 + *numPtr10++;
                  ushort* numPtr16 = numPtr13;
                  while (numPtr13 < numPtr14)
                  {
                    ushort num4 = *(ushort*) numPtr15;
                    ushort num5 = *(ushort*) (new IntPtr(2) + (IntPtr) numPtr15);
                    numPtr15 += 4;
                    numPtr16 += num5;
                    if ((int) num4 != 0 && ((int) num4 & 31) == ((int) num4 >> 5 & 31) && ((int) num4 & 31) == ((int) num4 >> 10 & 31))
                      num4 = numPtr7[(int) num4 >> 10];
                    else if ((int) num4 != 0)
                      num4 ^= (ushort) short.MinValue;
                    while (numPtr13 < numPtr16)
                      *numPtr13++ = num4;
                  }
                  numPtr13 += num3;
                  numPtr14 += num2;
                }
              }
              else
              {
                while (numPtr10 < numPtr11)
                {
                  int* numPtr15 = numPtr12 + *numPtr10++;
                  ushort* numPtr16 = numPtr13;
                  while (numPtr13 < numPtr14)
                  {
                    ushort num4 = *(ushort*) numPtr15;
                    ushort num5 = *(ushort*) (new IntPtr(2) + (IntPtr) numPtr15);
                    numPtr15 += 4;
                    numPtr16 += num5;
                    if ((int) num4 != 0)
                      num4 = numPtr7[(int) num4 >> 10];
                    while (numPtr13 < numPtr16)
                      *numPtr13++ = num4;
                  }
                  numPtr13 += num3;
                  numPtr14 += num2;
                }
              }
              return new Bitmap(width, height, stride, PixelFormat.Format16bppArgb1555, (IntPtr) ((void*) numPtr9));
            }
    }

    public static unsafe Bitmap GetGump(int index)
    {
      int length;
      int extra;
      bool patched;
      Stream input = Gumps.m_FileIndex.Seek(index, out length, out extra, out patched);
      if (input == null)
        return (Bitmap) null;
      int width = extra >> 16 & (int) ushort.MaxValue;
      int height = extra & (int) ushort.MaxValue;
      Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format16bppArgb1555);
      BitmapData bitmapdata = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format16bppArgb1555);
      BinaryReader binaryReader = new BinaryReader(input);
      int[] numArray = new int[height];
      int num1 = (int) binaryReader.BaseStream.Position;
      for (int index1 = 0; index1 < height; ++index1)
        numArray[index1] = num1 + binaryReader.ReadInt32() * 4;
      ushort* numPtr1 = (ushort*) (void*) bitmapdata.Scan0;
      int num2 = bitmapdata.Stride >> 1;
      int index2 = 0;
      while (index2 < height)
      {
        binaryReader.BaseStream.Seek((long) numArray[index2], SeekOrigin.Begin);
        ushort* numPtr2 = numPtr1;
        ushort* numPtr3 = numPtr1 + bitmapdata.Width;
        while (numPtr2 < numPtr3)
        {
          ushort num3 = binaryReader.ReadUInt16();
          ushort* numPtr4 = numPtr2 + binaryReader.ReadUInt16();
          if ((int) num3 == 0)
          {
            numPtr2 = numPtr4;
          }
          else
          {
            ushort num4 = (ushort) ((uint) num3 ^ 32768U);
            while (numPtr2 < numPtr4)
              *numPtr2++ = num4;
          }
        }
        ++index2;
        numPtr1 += num2;
      }
      bitmap.UnlockBits(bitmapdata);
      return bitmap;
    }
  }
}
