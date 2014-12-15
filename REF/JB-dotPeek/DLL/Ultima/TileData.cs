// Decompiled with JetBrains decompiler
// Type: Ultima.TileData
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System.IO;
using System.Text;

namespace Ultima
{
  public class TileData
  {
    private static byte[] m_StringBuffer = new byte[20];
    private static LandData[] m_LandData;
    private static ItemData[] m_ItemData;
    private static int[] m_HeightTable;

    public static LandData[] LandTable
    {
      get
      {
        return TileData.m_LandData;
      }
    }

    public static ItemData[] ItemTable
    {
      get
      {
        return TileData.m_ItemData;
      }
    }

    public static int[] HeightTable
    {
      get
      {
        return TileData.m_HeightTable;
      }
    }

    static TileData()
    {
      string filePath = Client.GetFilePath("tiledata.mul");
      if (filePath == null)
        throw new FileNotFoundException();
      using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
      {
        BinaryReader bin = new BinaryReader((Stream) fileStream);
        TileData.m_LandData = new LandData[16384];
        for (int index = 0; index < 16384; ++index)
        {
          if ((index & 31) == 0)
            bin.ReadInt32();
          TileFlag flags = (TileFlag) bin.ReadInt32();
          int num = (int) bin.ReadInt16();
          TileData.m_LandData[index] = new LandData(TileData.ReadNameString(bin), flags);
        }
        TileData.m_ItemData = new ItemData[16384];
        TileData.m_HeightTable = new int[16384];
        for (int index = 0; index < 16384; ++index)
        {
          if ((index & 31) == 0)
            bin.ReadInt32();
          TileFlag flags = (TileFlag) bin.ReadInt32();
          int weight = (int) bin.ReadByte();
          int quality = (int) bin.ReadByte();
          int num1 = (int) bin.ReadInt16();
          int num2 = (int) bin.ReadByte();
          int quantity = (int) bin.ReadByte();
          int anim = (int) bin.ReadInt16();
          int num3 = (int) bin.ReadInt16();
          int num4 = (int) bin.ReadByte();
          int num5 = (int) bin.ReadByte();
          int height = (int) bin.ReadByte();
          TileData.m_ItemData[index] = new ItemData(TileData.ReadNameString(bin), flags, weight, quality, quantity, num5, height, anim);
          TileData.m_HeightTable[index] = height;
        }
      }
    }

    private TileData()
    {
    }

    private static string ReadNameString(BinaryReader bin)
    {
      bin.Read(TileData.m_StringBuffer, 0, 20);
      int count = 0;
      while (count < 20 && (int) TileData.m_StringBuffer[count] != 0)
        ++count;
      return Encoding.ASCII.GetString(TileData.m_StringBuffer, 0, count);
    }
  }
}
