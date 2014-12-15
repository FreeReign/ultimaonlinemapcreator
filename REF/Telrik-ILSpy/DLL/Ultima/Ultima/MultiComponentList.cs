using System;
using System.Drawing;
using System.IO;

namespace Ultima
{
	public sealed class MultiComponentList
	{
		private Point m_Min;

		private Point m_Max;

		private Point m_Center;

		private int m_Width;

		private int m_Height;

		private Tile[][][] m_Tiles;

		public readonly static MultiComponentList Empty;

		public Point Center
		{
			get
			{
				return this.m_Center;
			}
		}

		public int Height
		{
			get
			{
				return this.m_Height;
			}
		}

		public Point Max
		{
			get
			{
				return this.m_Max;
			}
		}

		public Point Min
		{
			get
			{
				return this.m_Min;
			}
		}

		public Tile[][][] Tiles
		{
			get
			{
				return this.m_Tiles;
			}
		}

		public int Width
		{
			get
			{
				return this.m_Width;
			}
		}

		static MultiComponentList()
		{
			MultiComponentList.Empty = new MultiComponentList();
		}

		public MultiComponentList(BinaryReader reader, int count)
		{
			Point empty = Point.Empty;
			Point point = empty;
			this.m_Max = empty;
			this.m_Min = point;
			MultiComponentList.MultiTileEntry[] multiTileEntryArray = new MultiComponentList.MultiTileEntry[count];
			for (int i = 0; i < count; i++)
			{
				multiTileEntryArray[i].m_ItemID = reader.ReadInt16();
				multiTileEntryArray[i].m_OffsetX = reader.ReadInt16();
				multiTileEntryArray[i].m_OffsetY = reader.ReadInt16();
				multiTileEntryArray[i].m_OffsetZ = reader.ReadInt16();
				multiTileEntryArray[i].m_Flags = reader.ReadInt32();
				MultiComponentList.MultiTileEntry multiTileEntry = multiTileEntryArray[i];
				if (multiTileEntry.m_OffsetX < this.m_Min.X)
				{
					this.m_Min.X = multiTileEntry.m_OffsetX;
				}
				if (multiTileEntry.m_OffsetY < this.m_Min.Y)
				{
					this.m_Min.Y = multiTileEntry.m_OffsetY;
				}
				if (multiTileEntry.m_OffsetX > this.m_Max.X)
				{
					this.m_Max.X = multiTileEntry.m_OffsetX;
				}
				if (multiTileEntry.m_OffsetY > this.m_Max.Y)
				{
					this.m_Max.Y = multiTileEntry.m_OffsetY;
				}
			}
			this.m_Center = new Point(-this.m_Min.X, -this.m_Min.Y);
			this.m_Width = this.m_Max.X - this.m_Min.X + 1;
			this.m_Height = this.m_Max.Y - this.m_Min.Y + 1;
			TileList[][] tileList = new TileList[this.m_Width][];
			this.m_Tiles = new Tile[this.m_Width][][];
			for (int j = 0; j < this.m_Width; j++)
			{
				tileList[j] = new TileList[this.m_Height];
				this.m_Tiles[j] = new Tile[this.m_Height][];
				for (int k = 0; k < this.m_Height; k++)
				{
					tileList[j][k] = new TileList();
				}
			}
			for (int l = 0; l < (int)multiTileEntryArray.Length; l++)
			{
				int mOffsetX = multiTileEntryArray[l].m_OffsetX + this.m_Center.X;
				int mOffsetY = multiTileEntryArray[l].m_OffsetY + this.m_Center.Y;
				tileList[mOffsetX][mOffsetY].Add((short)((multiTileEntryArray[l].m_ItemID & 16383) + 16384), (sbyte)multiTileEntryArray[l].m_OffsetZ);
			}
			for (int m = 0; m < this.m_Width; m++)
			{
				for (int n = 0; n < this.m_Height; n++)
				{
					this.m_Tiles[m][n] = tileList[m][n].ToArray();
					if ((int)this.m_Tiles[m][n].Length > 1)
					{
						Array.Sort(this.m_Tiles[m][n]);
					}
				}
			}
		}

		private MultiComponentList()
		{
			this.m_Tiles = new Tile[0][][];
		}

		public Bitmap GetImage()
		{
			if (this.m_Width == 0 || this.m_Height == 0)
			{
				return null;
			}
			int num = 1000;
			int num1 = 1000;
			int num2 = -1000;
			int num3 = -1000;
			for (int i = 0; i < this.m_Width; i++)
			{
				for (int j = 0; j < this.m_Height; j++)
				{
					Tile[] mTiles = this.m_Tiles[i][j];
					for (int k = 0; k < (int)mTiles.Length; k++)
					{
						Bitmap @static = Art.GetStatic(mTiles[k].ID - 16384);
						if (@static != null)
						{
							int width = (i - j) * 22;
							int z = (i + j) * 22;
							width = width - @static.Width / 2;
							z = z - mTiles[k].Z * 4;
							z = z - @static.Height;
							if (width < num)
							{
								num = width;
							}
							if (z < num1)
							{
								num1 = z;
							}
							width = width + @static.Width;
							z = z + @static.Height;
							if (width > num2)
							{
								num2 = width;
							}
							if (z > num3)
							{
								num3 = z;
							}
						}
					}
				}
			}
			Bitmap bitmap = new Bitmap(num2 - num, num3 - num1);
			Graphics graphic = Graphics.FromImage(bitmap);
			for (int l = 0; l < this.m_Width; l++)
			{
				for (int m = 0; m < this.m_Height; m++)
				{
					Tile[] tileArray = this.m_Tiles[l][m];
					for (int n = 0; n < (int)tileArray.Length; n++)
					{
						Bitmap static1 = Art.GetStatic(tileArray[n].ID - 16384);
						if (static1 != null)
						{
							int width1 = (l - m) * 22;
							int height = (l + m) * 22;
							width1 = width1 - static1.Width / 2;
							height = height - tileArray[n].Z * 4;
							height = height - static1.Height;
							width1 = width1 - num;
							height = height - num1;
							graphic.DrawImageUnscaled(static1, width1, height, static1.Width, static1.Height);
						}
					}
					int num4 = (l - m) * 22;
					int num5 = (l + m) * 22;
					num4 = num4 - num;
					num5 = num5 - num1;
				}
			}
			graphic.Dispose();
			return bitmap;
		}

		private struct MultiTileEntry
		{
			public short m_ItemID;

			public short m_OffsetX;

			public short m_OffsetY;

			public short m_OffsetZ;

			public int m_Flags;
		}
	}
}