using System;
using System.Collections;
using System.IO;
using System.Text;

namespace Ultima
{
	public class StringList
	{
		private Hashtable m_Table;

		private StringEntry[] m_Entries;

		private string m_Language;

		private static byte[] m_Buffer;

		public StringEntry[] Entries
		{
			get
			{
				return this.m_Entries;
			}
		}

		public string Language
		{
			get
			{
				return this.m_Language;
			}
		}

		public Hashtable Table
		{
			get
			{
				return this.m_Table;
			}
		}

		static StringList()
		{
			StringList.m_Buffer = new byte[1024];
		}

		public StringList(string language)
		{
			this.m_Language = language;
			this.m_Table = new Hashtable();
			string filePath = Client.GetFilePath(string.Format("cliloc.{0}", language));
			if (filePath == null)
			{
				this.m_Entries = new StringEntry[0];
				return;
			}
			ArrayList arrayLists = new ArrayList();
			using (BinaryReader binaryReader = new BinaryReader(new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)))
			{
				binaryReader.ReadInt32();
				binaryReader.ReadInt16();
				while (binaryReader.PeekChar() != -1)
				{
					int num = binaryReader.ReadInt32();
					binaryReader.ReadByte();
					int num1 = binaryReader.ReadInt16();
					if (num1 > (int)StringList.m_Buffer.Length)
					{
						StringList.m_Buffer = new byte[num1 + 1023 & -1024];
					}
					binaryReader.Read(StringList.m_Buffer, 0, num1);
					string str = Encoding.UTF8.GetString(StringList.m_Buffer, 0, num1);
					arrayLists.Add(new StringEntry(num, str));
					this.m_Table[num] = str;
				}
			}
			this.m_Entries = (StringEntry[])arrayLists.ToArray(typeof(StringEntry));
		}
	}
}