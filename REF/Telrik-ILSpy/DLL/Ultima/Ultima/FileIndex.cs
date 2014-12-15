using System;
using System.IO;

namespace Ultima
{
	public class FileIndex
	{
		private Entry3D[] m_Index;

		private System.IO.Stream m_Stream;

		public Entry3D[] Index
		{
			get
			{
				return this.m_Index;
			}
		}

		public System.IO.Stream Stream
		{
			get
			{
				return this.m_Stream;
			}
		}

		public FileIndex(string idxFile, string mulFile, int length, int file)
		{
			this.m_Index = new Entry3D[length];
			string filePath = Client.GetFilePath(idxFile);
			string str = Client.GetFilePath(mulFile);
			if (filePath != null && str != null)
			{
				using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					BinaryReader binaryReader = new BinaryReader(fileStream);
					this.m_Stream = new FileStream(str, FileMode.Open, FileAccess.Read, FileShare.Read);
					int num = (int)(fileStream.Length / (long)12);
					for (int i = 0; i < num && i < length; i++)
					{
						this.m_Index[i].lookup = binaryReader.ReadInt32();
						this.m_Index[i].length = binaryReader.ReadInt32();
						this.m_Index[i].extra = binaryReader.ReadInt32();
					}
					for (int j = num; j < length; j++)
					{
						this.m_Index[j].lookup = -1;
						this.m_Index[j].length = -1;
						this.m_Index[j].extra = -1;
					}
				}
			}
			Entry5D[] patches = Verdata.Patches;
			for (int k = 0; k < (int)patches.Length; k++)
			{
				Entry5D entry5D = patches[k];
				if (entry5D.file == file && entry5D.index >= 0 && entry5D.index < length)
				{
					this.m_Index[entry5D.index].lookup = entry5D.lookup;
					this.m_Index[entry5D.index].length = entry5D.length | -2147483648;
					this.m_Index[entry5D.index].extra = entry5D.extra;
				}
			}
		}

		public System.IO.Stream Seek(int index, out int length, out int extra, out bool patched)
		{
			int num;
			if (index < 0 || index >= (int)this.m_Index.Length)
			{
				int num1 = 0;
				num = num1;
				extra = num1;
				length = num;
				patched = false;
				return null;
			}
			Entry3D mIndex = this.m_Index[index];
			if (mIndex.lookup < 0)
			{
				int num2 = 0;
				num = num2;
				extra = num2;
				length = num;
				patched = false;
				return null;
			}
			length = mIndex.length & 2147483647;
			extra = mIndex.extra;
			if ((mIndex.length & -2147483648) != 0)
			{
				patched = true;
				Verdata.Stream.Seek((long)mIndex.lookup, SeekOrigin.Begin);
				return Verdata.Stream;
			}
			if (this.m_Stream == null)
			{
				int num3 = 0;
				num = num3;
				extra = num3;
				length = num;
				patched = false;
				return null;
			}
			patched = false;
			this.m_Stream.Seek((long)mIndex.lookup, SeekOrigin.Begin);
			return this.m_Stream;
		}
	}
}