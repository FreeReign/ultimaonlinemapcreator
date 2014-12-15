// Decompiled with JetBrains decompiler
// Type: Ultima.Hue
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace Ultima
{
  public class Hue
  {
    private int m_Index;
    private short[] m_Colors;
    private string m_Name;

    public int Index
    {
      get
      {
        return this.m_Index;
      }
    }

    public short[] Colors
    {
      get
      {
        return this.m_Colors;
      }
    }

    public string Name
    {
      get
      {
        return this.m_Name;
      }
    }

    public Hue(int index)
    {
      this.m_Name = "Null";
      this.m_Index = index;
      this.m_Colors = new short[34];
    }

    public Hue(int index, BinaryReader bin)
    {
      this.m_Index = index;
      this.m_Colors = new short[34];
      for (int index1 = 0; index1 < 34; ++index1)
        this.m_Colors[index1] = (short) ((int) bin.ReadUInt16() | 32768);
      bool flag = false;
      StringBuilder stringBuilder = new StringBuilder(20, 20);
      for (int index1 = 0; index1 < 20; ++index1)
      {
        char ch = (char) bin.ReadByte();
        if ((int) ch == 0)
          flag = true;
        else if (!flag)
          stringBuilder.Append(ch);
      }
      this.m_Name = stringBuilder.ToString();
    }

    public Color GetColor(int index)
    {
      int num = (int) this.m_Colors[index];
      return Color.FromArgb((num & 31744) >> 7, (num & 992) >> 2, (num & 31) << 3);
    }

    public unsafe void ApplyTo(Bitmap bmp, bool onlyHueGrayPixels)
    {
      BitmapData bitmapdata = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format16bppArgb1555);
      int num1 = bitmapdata.Stride >> 1;
      int width = bitmapdata.Width;
      int height = bitmapdata.Height;
      int num2 = num1 - width;
      ushort* numPtr1 = (ushort*) (void*) bitmapdata.Scan0;
      ushort* numPtr2 = numPtr1 + width;
      ushort* numPtr3 = numPtr1 + num1 * height;
      // ISSUE: untyped stack allocation
      ushort* numPtr4 = (ushort*) __untypedstackalloc(2 * 64);
      fixed (short* numPtr5 = &this.m_Colors[0])
      {
        ushort* numPtr6 = (ushort*) numPtr5;
        ushort* numPtr7 = numPtr4;
        ushort* numPtr8 = numPtr7 + 32;
        while (numPtr7 < numPtr8)
          *numPtr7++ = (ushort) 0;
        ushort* numPtr9 = numPtr8 + 32;
        while (numPtr7 < numPtr9)
          *numPtr7++ = *numPtr6++;
      }
      if (onlyHueGrayPixels)
      {
        while (numPtr1 < numPtr3)
        {
          while (numPtr1 < numPtr2)
          {
            int num3 = (int) *numPtr1;
            int num4 = num3 >> 10 & 31;
            int num5 = num3 >> 5 & 31;
            int num6 = num3 & 31;
            if (num4 == num5 && num4 == num6)
              *numPtr1++ = numPtr4[num3 >> 10];
            else
              numPtr1 += 2;
          }
          numPtr1 += num2;
          numPtr2 += num1;
        }
      }
      else
      {
        while (numPtr1 < numPtr3)
        {
          while (numPtr1 < numPtr2)
          {
            *numPtr1 = numPtr4[(int) *numPtr1 >> 10];
            numPtr1 += 2;
          }
          numPtr1 += num2;
          numPtr2 += num1;
        }
      }
      bmp.UnlockBits(bitmapdata);
    }
  }
}
