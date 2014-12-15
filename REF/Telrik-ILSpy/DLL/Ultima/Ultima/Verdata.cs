using System;
using System.IO;

namespace Ultima
{
	public class Verdata
	{
		private static Entry5D[] m_Patches;

		private static System.IO.Stream m_Stream;

		public static Entry5D[] Patches
		{
			get
			{
				return Verdata.m_Patches;
			}
		}

		public static System.IO.Stream Stream
		{
			get
			{
				return Verdata.m_Stream;
			}
		}

		static Verdata()
		{
			string filePath = Client.GetFilePath("verdata.mul");
			if (filePath == null)
			{
				Verdata.m_Patches = new Entry5D[0];
				Verdata.m_Stream = System.IO.Stream.Null;
				return;
			}
			Verdata.m_Stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
			BinaryReader binaryReader = new BinaryReader(Verdata.m_Stream);
			Verdata.m_Patches = new Entry5D[binaryReader.ReadInt32()];
			for (int i = 0; i < (int)Verdata.m_Patches.Length; i++)
			{
				Verdata.m_Patches[i].file = binaryReader.ReadInt32();
				Verdata.m_Patches[i].index = binaryReader.ReadInt32();
				Verdata.m_Patches[i].lookup = binaryReader.ReadInt32();
				Verdata.m_Patches[i].length = binaryReader.ReadInt32();
				Verdata.m_Patches[i].extra = binaryReader.ReadInt32();
			}
		}

		public Verdata()
		{
		}
	}
}