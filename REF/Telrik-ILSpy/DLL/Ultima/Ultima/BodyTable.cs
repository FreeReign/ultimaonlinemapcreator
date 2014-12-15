using System;
using System.Collections;
using System.IO;

namespace Ultima
{
	public class BodyTable
	{
		public static Hashtable m_Entries;

		static BodyTable()
		{
			BodyTable.m_Entries = new Hashtable();
			string filePath = Client.GetFilePath("body.def");
			if (filePath == null)
			{
				return;
			}
			StreamReader streamReader = new StreamReader(filePath);
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
						int num = str1.IndexOf(" {");
						int num1 = str1.IndexOf("} ");
						string str3 = str1.Substring(0, num);
						string str4 = str1.Substring(num + 2, num1 - num - 2);
						string str5 = str1.Substring(num1 + 2);
						int num2 = str4.IndexOf(',');
						if (num2 > -1)
						{
							str4 = str4.Substring(0, num2).Trim();
						}
						int bodyTableEntry = Convert.ToInt32(str3);
						int num3 = Convert.ToInt32(str4);
						int num4 = Convert.ToInt32(str5);
						BodyTable.m_Entries[bodyTableEntry] = new BodyTableEntry(num3, bodyTableEntry, num4);
					}
					catch
					{
					}
				}
			}
		}

		public BodyTable()
		{
		}
	}
}