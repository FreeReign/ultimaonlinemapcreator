// Decompiled with JetBrains decompiler
// Type: Ultima.Animations
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System.IO;

namespace Ultima
{
  public class Animations
  {
    private static FileIndex m_FileIndex = new FileIndex("Anim.idx", "Anim.mul", 262144, 6);
    private static FileIndex m_FileIndex2 = new FileIndex("Anim2.idx", "Anim2.mul", 65536, -1);
    private static FileIndex m_FileIndex3 = new FileIndex("Anim3.idx", "Anim3.mul", 131072, -1);
    private static int[] m_Table;

    public static FileIndex FileIndex
    {
      get
      {
        return Animations.m_FileIndex;
      }
    }

    public static FileIndex FileIndex2
    {
      get
      {
        return Animations.m_FileIndex;
      }
    }

    public static FileIndex FileIndex3
    {
      get
      {
        return Animations.m_FileIndex;
      }
    }

    private Animations()
    {
    }

    public static Frame[] GetAnimation(int body, int action, int direction, int hue, bool preserveHue)
    {
      if (preserveHue)
        Animations.Translate(ref body);
      else
        Animations.Translate(ref body, ref hue);
      FileIndex fileIndex;
      int num1;
      switch (BodyConverter.Convert(ref body))
      {
        case 2:
          fileIndex = Animations.m_FileIndex2;
          num1 = body >= 200 ? 22000 + (body - 200) * 65 : body * 110;
          break;
        case 3:
          fileIndex = Animations.m_FileIndex3;
          num1 = body >= 300 ? (body >= 400 ? 35000 + (body - 400) * 175 : 33000 + (body - 300) * 110) : body * 65;
          break;
        default:
          fileIndex = Animations.m_FileIndex;
          num1 = body >= 200 ? (body >= 400 ? 35000 + (body - 400) * 175 : 22000 + (body - 200) * 65) : body * 110;
          break;
      }
      int num2 = num1 + action * 5;
      int index1 = direction > 4 ? num2 + (direction - (direction - 4) * 2) : num2 + direction;
      int length1;
      int extra;
      bool patched;
      Stream input = fileIndex.Seek(index1, out length1, out extra, out patched);
      if (input == null)
        return (Frame[]) null;
      bool flip = direction > 4;
      BinaryReader bin = new BinaryReader(input);
      ushort[] palette = new ushort[256];
      for (int index2 = 0; index2 < 256; ++index2)
        palette[index2] = (ushort) ((uint) bin.ReadUInt16() ^ 32768U);
      int num3 = (int) bin.BaseStream.Position;
      int length2 = bin.ReadInt32();
      int[] numArray = new int[length2];
      for (int index2 = 0; index2 < length2; ++index2)
        numArray[index2] = num3 + bin.ReadInt32();
      bool onlyHueGrayPixels = (hue & 32768) == 0;
      hue = (hue & 16383) - 1;
      Hue hue1 = (Hue) null;
      if (hue >= 0 && hue < Hues.List.Length)
        hue1 = Hues.List[hue];
      Frame[] frameArray = new Frame[length2];
      for (int index2 = 0; index2 < length2; ++index2)
      {
        bin.BaseStream.Seek((long) numArray[index2], SeekOrigin.Begin);
        frameArray[index2] = new Frame(palette, bin, flip);
        if (hue1 != null)
          hue1.ApplyTo(frameArray[index2].Bitmap, onlyHueGrayPixels);
      }
      return frameArray;
    }

    public static void Translate(ref int body)
    {
      if (Animations.m_Table == null)
        Animations.LoadTable();
      if (body <= 0 || body >= Animations.m_Table.Length)
        body = 0;
      else
        body = Animations.m_Table[body] & (int) short.MaxValue;
    }

    public static void Translate(ref int body, ref int hue)
    {
      if (Animations.m_Table == null)
        Animations.LoadTable();
      if (body <= 0 || body >= Animations.m_Table.Length)
      {
        body = 0;
      }
      else
      {
        int num1 = Animations.m_Table[body];
        if ((num1 & int.MinValue) == 0)
          return;
        body = num1 & (int) short.MaxValue;
        int num2 = (hue & 16383) - 1;
        if (num2 >= 0 && num2 < Hues.List.Length)
          return;
        hue = num1 >> 15 & (int) ushort.MaxValue;
      }
    }

    private static void LoadTable()
    {
      int length = 400 + (Animations.m_FileIndex.Index.Length - 35000) / 175;
      Animations.m_Table = new int[length];
      for (int body = 0; body < length; ++body)
      {
        object obj = BodyTable.m_Entries[(object) body];
        if (obj == null || BodyConverter.Contains(body))
        {
          Animations.m_Table[body] = body;
        }
        else
        {
          BodyTableEntry bodyTableEntry = (BodyTableEntry) obj;
          Animations.m_Table[body] = bodyTableEntry.m_OldID | int.MinValue | ((bodyTableEntry.m_NewHue ^ 32768) & (int) ushort.MaxValue) << 15;
        }
      }
    }
  }
}
