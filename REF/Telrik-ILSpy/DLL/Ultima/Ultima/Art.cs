using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Ultima
{
	public class Art
	{
		private static Ultima.FileIndex m_FileIndex;

		private static Bitmap[] m_Cache;

		public static Bitmap[] Cache
		{
			get
			{
				return Art.m_Cache;
			}
		}

		public static Ultima.FileIndex FileIndex
		{
			get
			{
				return Art.m_FileIndex;
			}
		}

		static Art()
		{
			Art.m_FileIndex = new Ultima.FileIndex("Artidx.mul", "Art.mul", 65536, 4);
			Art.m_Cache = new Bitmap[65536];
		}

		private Art()
		{
		}

		public static Bitmap GetLand(int index)
		{
			int num;
			int num1;
			bool flag;
			index = index & 16383;
			if (Art.m_Cache[index] != null)
			{
				return Art.m_Cache[index];
			}
			Stream stream = Art.m_FileIndex.Seek(index, out num, out num1, out flag);
			if (stream == null)
			{
				return null;
			}
			Bitmap[] mCache = Art.m_Cache;
			Bitmap bitmap = Art.LoadLand(stream);
			Bitmap bitmap1 = bitmap;
			mCache[index] = bitmap;
			return bitmap1;
		}

		public static Bitmap GetStatic(int index)
		{
			int num;
			int num1;
			bool flag;
			index = index + 16384;
			index = index & 65535;
			if (Art.m_Cache[index] != null)
			{
				return Art.m_Cache[index];
			}
			Stream stream = Art.m_FileIndex.Seek(index, out num, out num1, out flag);
			if (stream == null)
			{
				return null;
			}
			Bitmap[] mCache = Art.m_Cache;
			Bitmap bitmap = Art.LoadStatic(stream);
			Bitmap bitmap1 = bitmap;
			mCache[index] = bitmap;
			return bitmap1;
		}

		private static unsafe Bitmap LoadLand(Stream stream)
		{
			Bitmap bitmap = new Bitmap(44, 44, PixelFormat.Format16bppArgb1555);
			BitmapData bitmapDatum = bitmap.LockBits(new Rectangle(0, 0, 44, 44), ImageLockMode.WriteOnly, PixelFormat.Format16bppArgb1555);
			BinaryReader binaryReader = new BinaryReader(stream);
			int num = 21;
			int num1 = 2;
			ushort* scan0 = (ushort*)((void*)bitmapDatum.Scan0);
			int stride = bitmapDatum.Stride >> 1;
			int num2 = 0;
			while (num2 < 22)
			{
				ushort* numPointer = scan0 + num * 2;
				ushort* numPointer1 = numPointer + num1 * 2;
				while (numPointer < numPointer1)
				{
					ushort* numPointer2 = numPointer;
					numPointer = numPointer2 + 2;
					*numPointer2 = (ushort)(binaryReader.ReadUInt16() | 32768);
				}
				num2++;
				num--;
				num1 = num1 + 2;
				scan0 = scan0 + stride * 2;
			}
			num = 0;
			num1 = 44;
			int num3 = 0;
			while (num3 < 22)
			{
				ushort* numPointer3 = scan0 + num * 2;
				ushort* numPointer4 = numPointer3 + num1 * 2;
				while (numPointer3 < numPointer4)
				{
					ushort* numPointer5 = numPointer3;
					numPointer3 = numPointer5 + 2;
					*numPointer5 = (ushort)(binaryReader.ReadUInt16() | 32768);
				}
				num3++;
				num++;
				num1 = num1 - 2;
				scan0 = scan0 + stride * 2;
			}
			bitmap.UnlockBits(bitmapDatum);
			return bitmap;
		}

		private static unsafe Bitmap LoadStatic(Stream stream)
		{
			BinaryReader binaryReader = new BinaryReader(stream);
			binaryReader.ReadInt32();
			int num = binaryReader.ReadInt16();
			int num1 = binaryReader.ReadInt16();
			if (num <= 0 || num1 <= 0)
			{
				return null;
			}
			int[] numArray = new int[num1];
			int position = (int)binaryReader.BaseStream.Position + num1 * 2;
			for (int i = 0; i < num1; i++)
			{
				numArray[i] = position + binaryReader.ReadUInt16() * 2;
			}
			Bitmap bitmap = new Bitmap(num, num1, PixelFormat.Format16bppArgb1555);
			BitmapData bitmapDatum = bitmap.LockBits(new Rectangle(0, 0, num, num1), ImageLockMode.WriteOnly, PixelFormat.Format16bppArgb1555);
			ushort* scan0 = (ushort*)((void*)bitmapDatum.Scan0);
			int stride = bitmapDatum.Stride >> 1;
			int num2 = 0;
		Label1:
			if (num2 >= num1)
			{
				bitmap.UnlockBits(bitmapDatum);
				return bitmap;
			}
			binaryReader.BaseStream.Seek((long)numArray[num2], SeekOrigin.Begin);
			ushort* numPointer = scan0;
		Label2:
			ushort num3 = binaryReader.ReadUInt16();
			int num4 = (int)num3;
			ushort num5 = binaryReader.ReadUInt16();
			int num6 = (int)num5;
			if (num3 + num5 != 0)
			{
				goto Label0;
			}
			num2++;
			scan0 = scan0 + stride * 2;
			goto Label1;
		Label0:
			numPointer = numPointer + num4 * 2;
			ushort* numPointer1 = numPointer + num6 * 2;
			while (numPointer < numPointer1)
			{
				ushort* numPointer2 = numPointer;
				numPointer = numPointer2 + 2;
				*numPointer2 = (ushort)(binaryReader.ReadUInt16() ^ 32768);
			}
			goto Label2;
		}

		public static unsafe void Measure(Bitmap bmp, out int xMin, out int yMin, out int xMax, out int yMax)
		{
			int num = 0;
			int num1 = num;
			yMin = num;
			xMin = num1;
			int num2 = -1;
			num1 = num2;
			yMax = num2;
			xMax = num1;
			if (bmp == null || bmp.Width <= 0 || bmp.Height <= 0)
			{
				return;
			}
			BitmapData bitmapDatum = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format16bppArgb1555);
			int stride = (bitmapDatum.Stride >> 1) - bitmapDatum.Width;
			int stride1 = bitmapDatum.Stride >> 1;
			ushort* scan0 = (ushort*)((void*)bitmapDatum.Scan0);
			ushort* width = scan0 + bitmapDatum.Width * 2;
			ushort* height = scan0 + bitmapDatum.Height * stride1 * 2;
			bool flag = false;
			int num3 = 0;
			int num4 = 0;
			while (scan0 < height)
			{
				while (scan0 < width)
				{
					ushort* numPointer = scan0;
					scan0 = numPointer + 2;
					if ((*numPointer & 32768) != 0)
					{
						if (flag)
						{
							if (num3 < xMin)
							{
								xMin = num3;
							}
							if (num4 < yMin)
							{
								yMin = num4;
							}
							if (num3 > xMax)
							{
								xMax = num3;
							}
							if (num4 > yMax)
							{
								yMax = num4;
							}
						}
						else
						{
							flag = true;
							int num5 = num3;
							num1 = num5;
							xMax = num5;
							xMin = num1;
							int num6 = num4;
							num1 = num6;
							yMax = num6;
							yMin = num1;
						}
					}
					num3++;
				}
				scan0 = scan0 + stride * 2;
				width = width + stride1 * 2;
				num4++;
				num3 = 0;
			}
			bmp.UnlockBits(bitmapDatum);
		}
	}
}