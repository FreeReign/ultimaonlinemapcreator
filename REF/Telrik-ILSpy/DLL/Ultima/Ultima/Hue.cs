using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace Ultima
{
	public class Hue
	{
		private int m_Index;

		private short[] m_Colors;

		private string m_Name;

		public short[] Colors
		{
			get
			{
				return this.m_Colors;
			}
		}

		public int Index
		{
			get
			{
				return this.m_Index;
			}
		}

		public string Name
		{
			get
			{
				return this.m_Name;
			}
		}

		public Hue(int index)
		{
			this.m_Name = "Null";
			this.m_Index = index;
			this.m_Colors = new short[34];
		}

		public Hue(int index, BinaryReader bin)
		{
			this.m_Index = index;
			this.m_Colors = new short[34];
			for (int i = 0; i < 34; i++)
			{
				this.m_Colors[i] = (short)(bin.ReadUInt16() | 32768);
			}
			bool flag = false;
			StringBuilder stringBuilder = new StringBuilder(20, 20);
			for (int j = 0; j < 20; j++)
			{
				char chr = (char)bin.ReadByte();
				if (chr == 0)
				{
					flag = true;
				}
				else if (!flag)
				{
					stringBuilder.Append(chr);
				}
			}
			this.m_Name = stringBuilder.ToString();
		}

		public unsafe void ApplyTo(Bitmap bmp, bool onlyHueGrayPixels)
		{
			BitmapData bitmapDatum = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format16bppArgb1555);
			int stride = bitmapDatum.Stride >> 1;
			int width = bitmapDatum.Width;
			int height = bitmapDatum.Height;
			int num = stride - width;
			ushort* scan0 = (ushort*)((void*)bitmapDatum.Scan0);
			ushort* numPointer = scan0 + width * 2;
			ushort* numPointer1 = scan0 + stride * height * 2;
			ushort* numPointer2 = stackalloc ushort[2 * 64];
			fixed (short* mColors = &this.m_Colors[0])
			{
				ushort* numPointer3 = (ushort*)mColors;
				ushort* numPointer4 = numPointer2;
				ushort* numPointer5 = numPointer4 + 64;
				while (numPointer4 < numPointer5)
				{
					ushort* numPointer6 = numPointer4;
					numPointer4 = numPointer6 + 2;
					*numPointer6 = 0;
				}
				numPointer5 = numPointer5 + 64;
				while (numPointer4 < numPointer5)
				{
					ushort* numPointer7 = numPointer4;
					numPointer4 = numPointer7 + 2;
					ushort* numPointer8 = numPointer3;
					numPointer3 = numPointer8 + 2;
					*numPointer7 = *numPointer8;
				}
			}
			if (!onlyHueGrayPixels)
			{
				while (scan0 < numPointer1)
				{
					while (scan0 < numPointer)
					{
						*scan0 = *(numPointer2 + (*scan0 >> 10) * 2);
						scan0 = scan0 + 2;
					}
					scan0 = scan0 + num * 2;
					numPointer = numPointer + stride * 2;
				}
			}
			else
			{
				while (scan0 < numPointer1)
				{
					while (scan0 < numPointer)
					{
						int num1 = *scan0;
						int num2 = num1 >> 10 & 31;
						int num3 = num1 >> 5 & 31;
						if (num2 != num3 || num2 != (num1 & 31))
						{
							scan0 = scan0 + 2;
						}
						else
						{
							ushort* numPointer9 = scan0;
							scan0 = numPointer9 + 2;
							*numPointer9 = *(numPointer2 + (num1 >> 10) * 2);
						}
					}
					scan0 = scan0 + num * 2;
					numPointer = numPointer + stride * 2;
				}
			}
			bmp.UnlockBits(bitmapDatum);
		}

		public Color GetColor(int index)
		{
			int mColors = this.m_Colors[index];
			return Color.FromArgb((mColors & 31744) >> 7, (mColors & 992) >> 2, (mColors & 31) << 3);
		}
	}
}