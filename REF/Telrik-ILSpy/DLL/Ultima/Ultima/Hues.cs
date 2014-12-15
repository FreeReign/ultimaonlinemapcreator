using System;
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
			int num = 0;
			Hues.m_List = new Hue[3000];
			if (filePath != null)
			{
				using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					BinaryReader binaryReader = new BinaryReader(fileStream);
					int length = (int)fileStream.Length / 708;
					if (length > 375)
					{
						length = 375;
					}
					for (int i = 0; i < length; i++)
					{
						binaryReader.ReadInt32();
						int num1 = 0;
						while (num1 < 8)
						{
							Hues.m_List[num] = new Hue(num, binaryReader);
							num1++;
							num++;
						}
					}
				}
			}
			while (num < 3000)
			{
				Hues.m_List[num] = new Hue(num);
				num++;
			}
		}

		public Hues()
		{
		}

		public static Hue GetHue(int index)
		{
			index = index & 16383;
			if (index >= 0 && index < 3000)
			{
				return Hues.m_List[index];
			}
			return Hues.m_List[0];
		}
	}
}