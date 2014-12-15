using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Ultima
{
	public class Gumps
	{
		private static Ultima.FileIndex m_FileIndex;

		private static byte[] m_PixelBuffer;

		private static byte[] m_StreamBuffer;

		private static byte[] m_ColorTable;

		public static Ultima.FileIndex FileIndex
		{
			get
			{
				return Gumps.m_FileIndex;
			}
		}

		static Gumps()
		{
			Gumps.m_FileIndex = new Ultima.FileIndex("Gumpidx.mul", "Gumpart.mul", 65536, 12);
		}

		public Gumps()
		{
		}

		public static unsafe Bitmap GetGump(int index, Hue hue, bool onlyHueGrayPixels)
		{
			int num;
			int num1;
			bool flag;
			int* numPointer;
			ushort num2;
			ushort num3;
			Stream stream = Gumps.m_FileIndex.Seek(index, out num, out num1, out flag);
			if (stream == null)
			{
				return null;
			}
			int num4 = num1 >> 16 & 65535;
			int num5 = num1 & 65535;
			if (num4 <= 0 || num5 <= 0)
			{
				return null;
			}
			int num6 = (num4 << 1) + 3 & -4;
			int num7 = num5 * num6;
			int num8 = num4 + 1 & -2;
			int num9 = num8 - num4;
			byte[] mPixelBuffer = Gumps.m_PixelBuffer;
			if (mPixelBuffer == null || (int)mPixelBuffer.Length < num7)
			{
				byte[] numArray = new byte[num7 + 2047 & -2048];
				mPixelBuffer = numArray;
				Gumps.m_PixelBuffer = numArray;
			}
			byte[] mStreamBuffer = Gumps.m_StreamBuffer;
			if (mStreamBuffer == null || (int)mStreamBuffer.Length < num)
			{
				byte[] numArray1 = new byte[num + 2047 & -2048];
				mStreamBuffer = numArray1;
				Gumps.m_StreamBuffer = numArray1;
			}
			byte[] mColorTable = Gumps.m_ColorTable;
			if (mColorTable == null)
			{
				byte[] numArray2 = new byte[128];
				mColorTable = numArray2;
				Gumps.m_ColorTable = numArray2;
			}
			stream.Read(mStreamBuffer, 0, num);
			fixed (short* colors = &hue.Colors[0])
			{
				fixed (byte* numPointer1 = &mStreamBuffer[0])
				{
					fixed (byte* numPointer2 = &mPixelBuffer[0])
					{
						fixed (byte* numPointer3 = &mColorTable[0])
						{
							ushort* numPointer4 = (ushort*)colors;
							ushort* numPointer5 = numPointer4 + 64;
							ushort* numPointer6 = (ushort*)numPointer3;
							ushort* numPointer7 = numPointer6;
							while (numPointer4 < numPointer5)
							{
								ushort* numPointer8 = numPointer7;
								numPointer7 = numPointer8 + 2;
								ushort* numPointer9 = numPointer4;
								numPointer4 = numPointer9 + 2;
								*numPointer8 = *numPointer9;
							}
							ushort* numPointer10 = (ushort*)numPointer2;
							int* numPointer11 = (int*)numPointer1;
							int* numPointer12 = numPointer11 + num5 * 4;
							int* numPointer13 = numPointer11;
							ushort* numPointer14 = numPointer10;
							ushort* numPointer15 = numPointer14;
							ushort* numPointer16 = numPointer14 + num4 * 2;
							if (!onlyHueGrayPixels)
							{
								while (numPointer11 < numPointer12)
								{
									int* numPointer17 = numPointer11;
									numPointer11 = numPointer17 + 4;
									numPointer = numPointer13 + *numPointer17 * 4;
									numPointer15 = numPointer14;
									while (numPointer14 < numPointer16)
									{
										num2 = (ushort)(*numPointer);
										num3 = (ushort)(*(2 + numPointer));
										numPointer = numPointer + 4;
										numPointer15 = (ushort*)(numPointer15 + (void*)num3 * 2);
										if (num2 != 0)
										{
											num2 = *(numPointer6 + (num2 >> 10) * 2);
										}
										while (numPointer14 < numPointer15)
										{
											ushort* numPointer18 = numPointer14;
											numPointer14 = numPointer18 + 2;
											*numPointer18 = num2;
										}
									}
									numPointer14 = numPointer14 + num9 * 2;
									numPointer16 = numPointer16 + num8 * 2;
								}
							}
							else
							{
								while (numPointer11 < numPointer12)
								{
									int* numPointer19 = numPointer11;
									numPointer11 = numPointer19 + 4;
									numPointer = numPointer13 + *numPointer19 * 4;
									numPointer15 = numPointer14;
									while (numPointer14 < numPointer16)
									{
										num2 = (ushort)(*numPointer);
										num3 = (ushort)(*(2 + numPointer));
										numPointer = numPointer + 4;
										numPointer15 = (ushort*)(numPointer15 + (void*)num3 * 2);
										if (num2 != 0 && (num2 & 31) == (num2 >> 5 & 31) && (num2 & 31) == (num2 >> 10 & 31))
										{
											num2 = *(numPointer6 + (num2 >> 10) * 2);
										}
										else if (num2 != 0)
										{
											num2 = (ushort)(num2 ^ 32768);
										}
										while (numPointer14 < numPointer15)
										{
											ushort* numPointer20 = numPointer14;
											numPointer14 = numPointer20 + 2;
											*numPointer20 = num2;
										}
									}
									numPointer14 = numPointer14 + num9 * 2;
									numPointer16 = numPointer16 + num8 * 2;
								}
							}
							return new Bitmap(num4, num5, num6, PixelFormat.Format16bppArgb1555, (IntPtr)numPointer10);
						}
					}
				}
			}
		}

		public static unsafe Bitmap GetGump(int index)
		{
			int num;
			int num1;
			bool flag;
			Stream stream = Gumps.m_FileIndex.Seek(index, out num, out num1, out flag);
			if (stream == null)
			{
				return null;
			}
			int num2 = num1 >> 16 & 65535;
			int num3 = num1 & 65535;
			Bitmap bitmap = new Bitmap(num2, num3, PixelFormat.Format16bppArgb1555);
			BitmapData bitmapDatum = bitmap.LockBits(new Rectangle(0, 0, num2, num3), ImageLockMode.WriteOnly, PixelFormat.Format16bppArgb1555);
			BinaryReader binaryReader = new BinaryReader(stream);
			int[] numArray = new int[num3];
			int position = (int)binaryReader.BaseStream.Position;
			for (int i = 0; i < num3; i++)
			{
				numArray[i] = position + binaryReader.ReadInt32() * 4;
			}
			ushort* scan0 = (ushort*)((void*)bitmapDatum.Scan0);
			int stride = bitmapDatum.Stride >> 1;
			int num4 = 0;
			while (num4 < num3)
			{
				binaryReader.BaseStream.Seek((long)numArray[num4], SeekOrigin.Begin);
				ushort* numPointer = scan0;
				ushort* width = scan0 + bitmapDatum.Width * 2;
				while (numPointer < width)
				{
					ushort num5 = binaryReader.ReadUInt16();
					ushort* numPointer1 = (ushort*)(numPointer + (void*)binaryReader.ReadUInt16() * 2);
					if (num5 != 0)
					{
						num5 = (ushort)(num5 ^ 32768);
						while (numPointer < numPointer1)
						{
							ushort* numPointer2 = numPointer;
							numPointer = numPointer2 + 2;
							*numPointer2 = num5;
						}
					}
					else
					{
						numPointer = numPointer1;
					}
				}
				num4++;
				scan0 = scan0 + stride * 2;
			}
			bitmap.UnlockBits(bitmapDatum);
			return bitmap;
		}
	}
}