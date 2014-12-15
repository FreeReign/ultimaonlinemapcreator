using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Ultima
{
	public class Frame
	{
		private const int DoubleXor = -2145386496;

		private Point m_Center;

		private System.Drawing.Bitmap m_Bitmap;

		public readonly static Frame Empty;

		public readonly static Frame[] EmptyFrames;

		public System.Drawing.Bitmap Bitmap
		{
			get
			{
				return this.m_Bitmap;
			}
		}

		public Point Center
		{
			get
			{
				return this.m_Center;
			}
		}

		static Frame()
		{
			Frame.Empty = new Frame();
			Frame.EmptyFrames = new Frame[] { Frame.Empty };
		}

		private Frame()
		{
			this.m_Bitmap = new System.Drawing.Bitmap(1, 1);
		}

		public unsafe Frame(ushort[] palette, BinaryReader bin, bool flip)
		{
			int num;
			int num1 = bin.ReadInt16();
			int num2 = bin.ReadInt16();
			int num3 = bin.ReadUInt16();
			int num4 = bin.ReadUInt16();
			System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(num3, num4, PixelFormat.Format16bppArgb1555);
			BitmapData bitmapDatum = bitmap.LockBits(new Rectangle(0, 0, num3, num4), ImageLockMode.WriteOnly, PixelFormat.Format16bppArgb1555);
			ushort* scan0 = (ushort*)((void*)bitmapDatum.Scan0);
			int stride = bitmapDatum.Stride >> 1;
			int num5 = num1 - 512;
			int num6 = num2 + num4 - 512;
			if (flip)
			{
				scan0 = scan0 - (num5 - num3 + 1) * 2;
				scan0 = scan0 + num6 * stride * 2;
			Label2:
				int num7 = bin.ReadInt32();
				num = num7;
				if (num7 != 2147450879)
				{
					goto Label0;
				}
				num1 = num3 - num1;
			}
			else
			{
				scan0 = scan0 + num5 * 2;
				scan0 = scan0 + num6 * stride * 2;
			Label3:
				int num8 = bin.ReadInt32();
				num = num8;
				if (num8 != 2147450879)
				{
					goto Label1;
				}
			}
			bitmap.UnlockBits(bitmapDatum);
			this.m_Center = new Point(num1, num2);
			this.m_Bitmap = bitmap;
			return;
		Label0:
			num = num ^ -2145386496;
			ushort* numPointer = scan0 + ((num >> 12 & 1023) * stride - (num >> 22 & 1023)) * 2;
			ushort* numPointer1 = numPointer - (num & 4095) * 2;
			while (numPointer > numPointer1)
			{
				ushort* numPointer2 = numPointer;
				numPointer = numPointer2 - 2;
				*numPointer2 = palette[bin.ReadByte()];
			}
			goto Label2;
		Label1:
			num = num ^ -2145386496;
			ushort* numPointer3 = scan0 + ((num >> 12 & 1023) * stride + (num >> 22 & 1023)) * 2;
			ushort* numPointer4 = numPointer3 + (num & 4095) * 2;
			while (numPointer3 < numPointer4)
			{
				ushort* numPointer5 = numPointer3;
				numPointer3 = numPointer5 + 2;
				*numPointer5 = palette[bin.ReadByte()];
			}
			goto Label3;
		}
	}
}