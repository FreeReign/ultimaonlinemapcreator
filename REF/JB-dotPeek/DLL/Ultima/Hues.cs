// Decompiled with JetBrains decompiler
// Type: Ultima.Hues
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System.IO;

namespace Ultima
{
  public class Hues
  {
    private static Hue[] m_List;

    public static Hue[] List
    {
      get
      {
        return Hues.m_List;
      }
    }

    static Hues()
    {
      string filePath = Client.GetFilePath("hues.mul");
      int index1 = 0;
      Hues.m_List = new Hue[3000];
      if (filePath != null)
      {
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
        {
          BinaryReader bin = new BinaryReader((Stream) fileStream);
          int num1 = (int) fileStream.Length / 708;
          if (num1 > 375)
            num1 = 375;
          for (int index2 = 0; index2 < num1; ++index2)
          {
            bin.ReadInt32();
            int num2 = 0;
            while (num2 < 8)
            {
              Hues.m_List[index1] = new Hue(index1, bin);
              ++num2;
              ++index1;
            }
          }
        }
      }
      for (; index1 < 3000; ++index1)
        Hues.m_List[index1] = new Hue(index1);
    }

    public static Hue GetHue(int index)
    {
      index &= 16383;
      if (index >= 0 && index < 3000)
        return Hues.m_List[index];
      else
        return Hues.m_List[0];
    }
  }
}
