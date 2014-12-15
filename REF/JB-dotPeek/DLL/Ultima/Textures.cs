// Decompiled with JetBrains decompiler
// Type: Ultima.Textures
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Ultima
{
  public class Textures
  {
    private static FileIndex m_FileIndex = new FileIndex("Texidx.mul", "Texmaps.mul", 4096, 10);

    public static FileIndex FileIndex
    {
      get
      {
        return Textures.m_FileIndex;
      }
    }

    public static unsafe Bitmap GetTexture(int index)
    {
      int length;
      int extra;
      bool patched;
      Stream input = Textures.m_FileIndex.Seek(index, out length, out extra, out patched);
      if (input == null)
        return (Bitmap) null;
      int num1 = extra == 0 ? 64 : 128;
      Bitmap bitmap = new Bitmap(num1, num1, PixelFormat.Format16bppArgb1555);
      BitmapData bitmapdata = bitmap.LockBits(new Rectangle(0, 0, num1, num1), ImageLockMode.WriteOnly, PixelFormat.Format16bppArgb1555);
      BinaryReader binaryReader = new BinaryReader(input);
      ushort* numPtr1 = (ushort*) (void*) bitmapdata.Scan0;
      int num2 = bitmapdata.Stride >> 1;
      int num3 = 0;
      while (num3 < num1)
      {
        ushort* numPtr2 = numPtr1;
        ushort* numPtr3 = numPtr2 + num1;
        while (numPtr2 < numPtr3)
          *numPtr2++ = (ushort) ((uint) binaryReader.ReadUInt16() ^ 32768U);
        ++num3;
        numPtr1 += num2;
      }
      bitmap.UnlockBits(bitmapdata);
      return bitmap;
    }
  }
}
