// Decompiled with JetBrains decompiler
// Type: Ultima.Verdata
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System.IO;

namespace Ultima
{
  public class Verdata
  {
    private static Entry5D[] m_Patches;
    private static Stream m_Stream;

    public static Stream Stream
    {
      get
      {
        return Verdata.m_Stream;
      }
    }

    public static Entry5D[] Patches
    {
      get
      {
        return Verdata.m_Patches;
      }
    }

    static Verdata()
    {
      string filePath = Client.GetFilePath("verdata.mul");
      if (filePath == null)
      {
        Verdata.m_Patches = new Entry5D[0];
        Verdata.m_Stream = Stream.Null;
      }
      else
      {
        Verdata.m_Stream = (Stream) new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        BinaryReader binaryReader = new BinaryReader(Verdata.m_Stream);
        Verdata.m_Patches = new Entry5D[binaryReader.ReadInt32()];
        for (int index = 0; index < Verdata.m_Patches.Length; ++index)
        {
          Verdata.m_Patches[index].file = binaryReader.ReadInt32();
          Verdata.m_Patches[index].index = binaryReader.ReadInt32();
          Verdata.m_Patches[index].lookup = binaryReader.ReadInt32();
          Verdata.m_Patches[index].length = binaryReader.ReadInt32();
          Verdata.m_Patches[index].extra = binaryReader.ReadInt32();
        }
      }
    }
  }
}
