// Decompiled with JetBrains decompiler
// Type: Ultima.Frame
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Ultima
{
  public class Frame
  {
    public static readonly Frame Empty = new Frame();
    public static readonly Frame[] EmptyFrames = new Frame[1]
    {
      Frame.Empty
    };
    private const int DoubleXor = -2145386496;
    private Point m_Center;
    private Bitmap m_Bitmap;

    public Point Center
    {
      get
      {
        return this.m_Center;
      }
    }

    public Bitmap Bitmap
    {
      get
      {
        return this.m_Bitmap;
      }
    }

    private Frame()
    {
      this.m_Bitmap = new Bitmap(1, 1);
    }

    public unsafe Frame(ushort[] palette, BinaryReader bin, bool flip)
    {
      int x = (int) bin.ReadInt16();
      int y = (int) bin.ReadInt16();
      int width = (int) bin.ReadUInt16();
      int height = (int) bin.ReadUInt16();
      Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format16bppArgb1555);
      BitmapData bitmapdata = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format16bppArgb1555);
      ushort* numPtr1 = (ushort*) (void*) bitmapdata.Scan0;
      int num1 = bitmapdata.Stride >> 1;
      int num2 = x - 512;
      int num3 = y + height - 512;
      if (!flip)
      {
        ushort* numPtr2 = numPtr1 + num2 + num3 * num1;
        int num4;
        while ((num4 = bin.ReadInt32()) != 2147450879)
        {
          int num5 = num4 ^ -2145386496;
          ushort* numPtr3 = numPtr2 + ((num5 >> 12 & 1023) * num1 + (num5 >> 22 & 1023));
          ushort* numPtr4 = numPtr3 + (num5 & 4095);
          while (numPtr3 < numPtr4)
            *numPtr3++ = palette[(int) bin.ReadByte()];
        }
      }
      else
      {
        ushort* numPtr2 = numPtr1 - (num2 - width + 1) + num3 * num1;
        int num4;
        while ((num4 = bin.ReadInt32()) != 2147450879)
        {
          int num5 = num4 ^ -2145386496;
          ushort* numPtr3 = numPtr2 + ((num5 >> 12 & 1023) * num1 - (num5 >> 22 & 1023));
          ushort* numPtr4 = numPtr3 - (num5 & 4095);
          while (numPtr3 > numPtr4)
            *numPtr3-- = palette[(int) bin.ReadByte()];
        }
        x = width - x;
      }
      bitmap.UnlockBits(bitmapdata);
      this.m_Center = new Point(x, y);
      this.m_Bitmap = bitmap;
    }
  }
}
