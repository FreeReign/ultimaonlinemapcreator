using System;
using System.Collections;
using System.IO;

namespace Ultima
{
	public class BodyConverter
	{
		private static int[] m_Table1;

		private static int[] m_Table2;

		static BodyConverter()
		{
			int num;
			string filePath = Client.GetFilePath("bodyconv.def");
			if (filePath == null)
			{
				return;
			}
			ArrayList arrayLists = new ArrayList();
			ArrayList arrayLists1 = new ArrayList();
			int num1 = 0;
			int num2 = 0;
			using (StreamReader streamReader = new StreamReader(filePath))
			{
				while (true)
				{
					string str = streamReader.ReadLine();
					string str1 = str;
					if (str == null)
					{
						break;
					}
					string str2 = str1.Trim();
					str1 = str2;
					if (str2.Length != 0 && !str1.StartsWith("#"))
					{
						try
						{
							string[] strArrays = str1.Split(new char[] { '\t' });
							int num3 = Convert.ToInt32(strArrays[0]);
							int num4 = Convert.ToInt32(strArrays[1]);
							try
							{
								num = Convert.ToInt32(strArrays[2]);
							}
							catch
							{
								num = -1;
							}
							if (num4 != -1)
							{
								if (num4 == 68)
								{
									num4 = 122;
								}
								if (num3 > num1)
								{
									num1 = num3;
								}
								arrayLists.Add(num3);
								arrayLists.Add(num4);
							}
							if (num != -1)
							{
								if (num3 > num2)
								{
									num2 = num3;
								}
								arrayLists1.Add(num3);
								arrayLists1.Add(num);
							}
						}
						catch
						{
						}
					}
				}
			}
			BodyConverter.m_Table1 = new int[num1 + 1];
			for (int i = 0; i < (int)BodyConverter.m_Table1.Length; i++)
			{
				BodyConverter.m_Table1[i] = -1;
			}
			for (int j = 0; j < arrayLists.Count; j = j + 2)
			{
				BodyConverter.m_Table1[(int)arrayLists[j]] = (int)arrayLists[j + 1];
			}
			BodyConverter.m_Table2 = new int[num2 + 1];
			for (int k = 0; k < (int)BodyConverter.m_Table2.Length; k++)
			{
				BodyConverter.m_Table2[k] = -1;
			}
			for (int l = 0; l < arrayLists1.Count; l = l + 2)
			{
				BodyConverter.m_Table2[(int)arrayLists1[l]] = (int)arrayLists1[l + 1];
			}
		}

		private BodyConverter()
		{
		}

		public static bool Contains(int body)
		{
			if (BodyConverter.m_Table1 != null && body >= 0 && body < (int)BodyConverter.m_Table1.Length && BodyConverter.m_Table1[body] != -1)
			{
				return true;
			}
			if (BodyConverter.m_Table2 != null && body >= 0 && body < (int)BodyConverter.m_Table2.Length && BodyConverter.m_Table2[body] != -1)
			{
				return true;
			}
			return false;
		}

		public static int Convert(ref int body)
		{
			if (BodyConverter.m_Table1 != null && body >= 0 && body < (int)BodyConverter.m_Table1.Length)
			{
				int mTable1 = BodyConverter.m_Table1[body];
				if (mTable1 != -1)
				{
					body = mTable1;
					return 2;
				}
			}
			if (BodyConverter.m_Table2 != null && body >= 0 && body < (int)BodyConverter.m_Table2.Length)
			{
				int mTable2 = BodyConverter.m_Table2[body];
				if (mTable2 != -1)
				{
					body = mTable2;
					return 3;
				}
			}
			return 1;
		}
	}
}