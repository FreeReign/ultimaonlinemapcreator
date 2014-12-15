using System;
using System.Collections;
using System.IO;

namespace Ultima
{
	public class Animations
	{
		private static Ultima.FileIndex m_FileIndex;

		private static Ultima.FileIndex m_FileIndex2;

		private static Ultima.FileIndex m_FileIndex3;

		private static int[] m_Table;

		public static Ultima.FileIndex FileIndex
		{
			get
			{
				return Animations.m_FileIndex;
			}
		}

		public static Ultima.FileIndex FileIndex2
		{
			get
			{
				return Animations.m_FileIndex;
			}
		}

		public static Ultima.FileIndex FileIndex3
		{
			get
			{
				return Animations.m_FileIndex;
			}
		}

		static Animations()
		{
			Animations.m_FileIndex = new Ultima.FileIndex("Anim.idx", "Anim.mul", 262144, 6);
			Animations.m_FileIndex2 = new Ultima.FileIndex("Anim2.idx", "Anim2.mul", 65536, -1);
			Animations.m_FileIndex3 = new Ultima.FileIndex("Anim3.idx", "Anim3.mul", 131072, -1);
		}

		private Animations()
		{
		}

		public static Frame[] GetAnimation(int body, int action, int direction, int hue, bool preserveHue)
		{
			Ultima.FileIndex mFileIndex2;
			int num;
			int num1;
			int num2;
			bool flag;
			if (!preserveHue)
			{
				Animations.Translate(ref body, ref hue);
			}
			else
			{
				Animations.Translate(ref body);
			}
			switch (BodyConverter.Convert(ref body))
			{
				case 2:
				{
					mFileIndex2 = Animations.m_FileIndex2;
					if (body >= 200)
					{
						num = 22000 + (body - 200) * 65;
						break;
					}
					else
					{
						num = body * 110;
						break;
					}
				}
				case 3:
				{
					mFileIndex2 = Animations.m_FileIndex3;
					if (body < 300)
					{
						num = body * 65;
						break;
					}
					else if (body >= 400)
					{
						num = 35000 + (body - 400) * 175;
						break;
					}
					else
					{
						num = 33000 + (body - 300) * 110;
						break;
					}
				}
				default:
				{
					mFileIndex2 = Animations.m_FileIndex;
					if (body < 200)
					{
						num = body * 110;
						break;
					}
					else if (body >= 400)
					{
						num = 35000 + (body - 400) * 175;
						break;
					}
					else
					{
						num = 22000 + (body - 200) * 65;
						break;
					}
				}
			}
			num = num + action * 5;
			num = (direction > 4 ? num + (direction - (direction - 4) * 2) : num + direction);
			Stream stream = mFileIndex2.Seek(num, out num1, out num2, out flag);
			if (stream == null)
			{
				return null;
			}
			bool flag1 = direction > 4;
			BinaryReader binaryReader = new BinaryReader(stream);
			ushort[] numArray = new ushort[256];
			for (int i = 0; i < 256; i++)
			{
				numArray[i] = (ushort)(binaryReader.ReadUInt16() ^ 32768);
			}
			int position = (int)binaryReader.BaseStream.Position;
			int num3 = binaryReader.ReadInt32();
			int[] numArray1 = new int[num3];
			for (int j = 0; j < num3; j++)
			{
				numArray1[j] = position + binaryReader.ReadInt32();
			}
			bool flag2 = (hue & 32768) == 0;
			hue = (hue & 16383) - 1;
			Hue list = null;
			if (hue >= 0 && hue < (int)Hues.List.Length)
			{
				list = Hues.List[hue];
			}
			Frame[] frame = new Frame[num3];
			for (int k = 0; k < num3; k++)
			{
				binaryReader.BaseStream.Seek((long)numArray1[k], SeekOrigin.Begin);
				frame[k] = new Frame(numArray, binaryReader, flag1);
				if (list != null)
				{
					list.ApplyTo(frame[k].Bitmap, flag2);
				}
			}
			return frame;
		}

		private static void LoadTable()
		{
			int length = 400 + ((int)Animations.m_FileIndex.Index.Length - 35000) / 175;
			Animations.m_Table = new int[length];
			for (int i = 0; i < length; i++)
			{
				object item = BodyTable.m_Entries[i];
				if (item == null || BodyConverter.Contains(i))
				{
					Animations.m_Table[i] = i;
				}
				else
				{
					BodyTableEntry bodyTableEntry = (BodyTableEntry)item;
					Animations.m_Table[i] = bodyTableEntry.m_OldID | -2147483648 | ((bodyTableEntry.m_NewHue ^ 32768) & 65535) << 15;
				}
			}
		}

		public static void Translate(ref int body)
		{
			if (Animations.m_Table == null)
			{
				Animations.LoadTable();
			}
			if (body <= 0 || body >= (int)Animations.m_Table.Length)
			{
				body = 0;
				return;
			}
			body = Animations.m_Table[body] & 32767;
		}

		public static void Translate(ref int body, ref int hue)
		{
			if (Animations.m_Table == null)
			{
				Animations.LoadTable();
			}
			if (body <= 0 || body >= (int)Animations.m_Table.Length)
			{
				body = 0;
				return;
			}
			int mTable = Animations.m_Table[body];
			if ((mTable & -2147483648) != 0)
			{
				body = mTable & 32767;
				int num = (hue & 16383) - 1;
				if (num < 0 || num >= (int)Hues.List.Length)
				{
					hue = mTable >> 15 & 65535;
				}
			}
		}
	}
}