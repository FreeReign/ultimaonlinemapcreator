using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Ultima
{
	public class Textures
	{
		private static Ultima.FileIndex m_FileIndex;

		public static Ultima.FileIndex FileIndex
		{
			get
			{
				return Textures.m_FileIndex;
			}
		}

		static Textures()
		{
			Textures.m_FileIndex = new Ultima.FileIndex("Texidx.mul", "Texmaps.mul", 4096, 10);
		}

		public Textures()
		{
		}

		public static unsafe Bitmap GetTexture(int index)
		{
			int num;
			int num1;
			bool flag;
			Stream stream = Textures.m_FileIndex.Seek(index, out num, out num1, out flag);
			if (stream == null)
			{
				return null;
			}
			int num2 = (num1 == 0 ? 64 : 128);
			Bitmap bitmap = new Bitmap(num2, num2, PixelFormat.Format16bppArgb1555);
			BitmapData bitmapDatum = bitmap.LockBits(new Rectangle(0, 0, num2, num2), ImageLockMode.WriteOnly, PixelFormat.Format16bppArgb1555);
			BinaryReader binaryReader = new BinaryReader(stream);
			ushort* scan0 = (ushort*)((void*)bitmapDatum.Scan0);
			int stride = bitmapDatum.Stride >> 1;
			int num3 = 0;
			while (num3 < num2)
			{
				ushort* numPointer = scan0;
				ushort* numPointer1 = numPointer + num2 * 2;
				while (numPointer < numPointer1)
				{
					ushort* numPointer2 = numPointer;
					numPointer = numPointer2 + 2;
					*numPointer2 = (ushort)(binaryReader.ReadUInt16() ^ 32768);
				}
				num3++;
				scan0 = scan0 + stride * 2;
			}
			bitmap.UnlockBits(bitmapDatum);
			return bitmap;
		}
	}
}