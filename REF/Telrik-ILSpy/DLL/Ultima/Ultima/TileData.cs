using System;
using System.IO;
using System.Text;

namespace Ultima
{
	public class TileData
	{
		private static LandData[] m_LandData;

		private static ItemData[] m_ItemData;

		private static int[] m_HeightTable;

		private static byte[] m_StringBuffer;

		public static int[] HeightTable
		{
			get
			{
				return TileData.m_HeightTable;
			}
		}

		public static ItemData[] ItemTable
		{
			get
			{
				return TileData.m_ItemData;
			}
		}

		public static LandData[] LandTable
		{
			get
			{
				return TileData.m_LandData;
			}
		}

		static TileData()
		{
			TileData.m_StringBuffer = new byte[20];
			string filePath = Client.GetFilePath("tiledata.mul");
			if (filePath == null)
			{
				throw new FileNotFoundException();
			}
			using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				BinaryReader binaryReader = new BinaryReader(fileStream);
				TileData.m_LandData = new LandData[16384];
				for (int i = 0; i < 16384; i++)
				{
					if ((i & 31) == 0)
					{
						binaryReader.ReadInt32();
					}
					TileFlag tileFlag = (TileFlag)binaryReader.ReadInt32();
					binaryReader.ReadInt16();
					TileData.m_LandData[i] = new LandData(TileData.ReadNameString(binaryReader), tileFlag);
				}
				TileData.m_ItemData = new ItemData[16384];
				TileData.m_HeightTable = new int[16384];
				for (int j = 0; j < 16384; j++)
				{
					if ((j & 31) == 0)
					{
						binaryReader.ReadInt32();
					}
					TileFlag tileFlag1 = (TileFlag)binaryReader.ReadInt32();
					int num = binaryReader.ReadByte();
					int num1 = binaryReader.ReadByte();
					binaryReader.ReadInt16();
					binaryReader.ReadByte();
					int num2 = binaryReader.ReadByte();
					int num3 = binaryReader.ReadInt16();
					binaryReader.ReadInt16();
					binaryReader.ReadByte();
					int num4 = binaryReader.ReadByte();
					int num5 = binaryReader.ReadByte();
					TileData.m_ItemData[j] = new ItemData(TileData.ReadNameString(binaryReader), tileFlag1, num, num1, num2, num4, num5, num3);
					TileData.m_HeightTable[j] = num5;
				}
			}
		}

		private TileData()
		{
		}

		private static string ReadNameString(BinaryReader bin)
		{
			bin.Read(TileData.m_StringBuffer, 0, 20);
			int num = 0;
			while (num < 20 && TileData.m_StringBuffer[num] != 0)
			{
				num++;
			}
			return Encoding.ASCII.GetString(TileData.m_StringBuffer, 0, num);
		}
	}
}