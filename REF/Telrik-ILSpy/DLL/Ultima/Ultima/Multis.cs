using System;
using System.IO;

namespace Ultima
{
	public class Multis
	{
		private static MultiComponentList[] m_Components;

		private static Ultima.FileIndex m_FileIndex;

		public static MultiComponentList[] Cache
		{
			get
			{
				return Multis.m_Components;
			}
		}

		public static Ultima.FileIndex FileIndex
		{
			get
			{
				return Multis.m_FileIndex;
			}
		}

		static Multis()
		{
			Multis.m_Components = new MultiComponentList[16384];
			Multis.m_FileIndex = new Ultima.FileIndex("Multi.idx", "Multi.mul", 16384, 14);
		}

		public Multis()
		{
		}

		public static MultiComponentList GetComponents(int index)
		{
			MultiComponentList empty;
			index = index & 16383;
			if (index < 0 || index >= (int)Multis.m_Components.Length)
			{
				empty = MultiComponentList.Empty;
			}
			else
			{
				empty = Multis.m_Components[index];
				if (empty == null)
				{
					MultiComponentList[] mComponents = Multis.m_Components;
					MultiComponentList multiComponentList = Multis.Load(index);
					empty = multiComponentList;
					mComponents[index] = multiComponentList;
				}
			}
			return empty;
		}

		public static MultiComponentList Load(int index)
		{
			int num;
			int num1;
			bool flag;
			MultiComponentList empty;
			try
			{
				Stream stream = Multis.m_FileIndex.Seek(index, out num, out num1, out flag);
				empty = (stream != null ? new MultiComponentList(new BinaryReader(stream), num / 12) : MultiComponentList.Empty);
			}
			catch
			{
				empty = MultiComponentList.Empty;
			}
			return empty;
		}
	}
}