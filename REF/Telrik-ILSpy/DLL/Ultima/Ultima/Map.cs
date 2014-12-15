using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace Ultima
{
	public class Map
	{
		private TileMatrix m_Tiles;

		private int m_FileIndex;

		private int m_MapID;

		private int m_Width;

		private int m_Height;

		private static short[] m_Colors;

		public readonly static Map Felucca;

		public readonly static Map Trammel;

		public readonly static Map Ilshenar;

		public readonly static Map Malas;

		private short[][][] m_Cache;

		private short[][][] m_Cache_NoStatics;

		private short[] m_Black;

		public static short[] Colors
		{
			get
			{
				return Map.m_Colors;
			}
			set
			{
				Map.m_Colors = value;
			}
		}

		public bool LoadedMatrix
		{
			get
			{
				return this.m_Tiles != null;
			}
		}

		public TileMatrix Tiles
		{
			get
			{
				if (this.m_Tiles == null)
				{
					this.m_Tiles = new TileMatrix(this.m_FileIndex, this.m_MapID, this.m_Width, this.m_Height);
				}
				return this.m_Tiles;
			}
		}

		static Map()
		{
			Map.Felucca = new Map(0, 0, 6144, 4096);
			Map.Trammel = new Map(0, 1, 6144, 4096);
			Map.Ilshenar = new Map(2, 2, 2304, 1600);
			Map.Malas = new Map(3, 3, 2560, 2048);
		}

		private Map(int fileIndex, int mapID, int width, int height)
		{
			this.m_FileIndex = fileIndex;
			this.m_MapID = mapID;
			this.m_Width = width;
			this.m_Height = height;
		}

		[DllImport("Kernel32", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern unsafe int _lread(IntPtr hFile, void* lpBuffer, int wBytes);

		public Bitmap GetImage(int x, int y, int width, int height)
		{
			return this.GetImage(x, y, width, height, true);
		}

		public Bitmap GetImage(int x, int y, int width, int height, bool statics)
		{
			Bitmap bitmap = new Bitmap(width << 3, height << 3, PixelFormat.Format16bppRgb555);
			this.GetImage(x, y, width, height, bitmap, statics);
			return bitmap;
		}

		public void GetImage(int x, int y, int width, int height, Bitmap bmp)
		{
			this.GetImage(x, y, width, height, bmp, true);
		}

		public unsafe void GetImage(int x, int y, int width, int height, Bitmap bmp, bool statics)
		{
			if (Map.m_Colors == null)
			{
				Map.LoadColors();
			}
			BitmapData bitmapDatum = bmp.LockBits(new Rectangle(0, 0, width << 3, height << 3), ImageLockMode.WriteOnly, PixelFormat.Format16bppRgb555);
			int stride = bitmapDatum.Stride;
			int num = stride << 3;
			byte* scan0 = (byte*)((void*)bitmapDatum.Scan0);
			int num1 = 0;
			int num2 = y;
			while (num1 < height)
			{
				int* numPointer = (int*)scan0;
				int* numPointer1 = (int*)(scan0 + stride);
				int* numPointer2 = (int*)(scan0 + 2 * stride);
				int* numPointer3 = (int*)(scan0 + 3 * stride);
				int* numPointer4 = (int*)(scan0 + 4 * stride);
				int* numPointer5 = (int*)(scan0 + 5 * stride);
				int* numPointer6 = (int*)(scan0 + 6 * stride);
				int* numPointer7 = (int*)(scan0 + 7 * stride);
				int num3 = 0;
				int num4 = x;
				while (num3 < width)
				{
					short[] renderedBlock = this.GetRenderedBlock(num4, num2, statics);
					fixed (short* numPointer8 = &renderedBlock[0])
					{
						int* numPointer9 = (int*)numPointer8;
						int* numPointer10 = numPointer;
						numPointer = numPointer10 + 4;
						int* numPointer11 = numPointer9;
						numPointer9 = numPointer11 + 4;
						*numPointer10 = *numPointer11;
						int* numPointer12 = numPointer;
						numPointer = numPointer12 + 4;
						int* numPointer13 = numPointer9;
						numPointer9 = numPointer13 + 4;
						*numPointer12 = *numPointer13;
						int* numPointer14 = numPointer;
						numPointer = numPointer14 + 4;
						int* numPointer15 = numPointer9;
						numPointer9 = numPointer15 + 4;
						*numPointer14 = *numPointer15;
						int* numPointer16 = numPointer;
						numPointer = numPointer16 + 4;
						int* numPointer17 = numPointer9;
						numPointer9 = numPointer17 + 4;
						*numPointer16 = *numPointer17;
						int* numPointer18 = numPointer1;
						numPointer1 = numPointer18 + 4;
						int* numPointer19 = numPointer9;
						numPointer9 = numPointer19 + 4;
						*numPointer18 = *numPointer19;
						int* numPointer20 = numPointer1;
						numPointer1 = numPointer20 + 4;
						int* numPointer21 = numPointer9;
						numPointer9 = numPointer21 + 4;
						*numPointer20 = *numPointer21;
						int* numPointer22 = numPointer1;
						numPointer1 = numPointer22 + 4;
						int* numPointer23 = numPointer9;
						numPointer9 = numPointer23 + 4;
						*numPointer22 = *numPointer23;
						int* numPointer24 = numPointer1;
						numPointer1 = numPointer24 + 4;
						int* numPointer25 = numPointer9;
						numPointer9 = numPointer25 + 4;
						*numPointer24 = *numPointer25;
						int* numPointer26 = numPointer2;
						numPointer2 = numPointer26 + 4;
						int* numPointer27 = numPointer9;
						numPointer9 = numPointer27 + 4;
						*numPointer26 = *numPointer27;
						int* numPointer28 = numPointer2;
						numPointer2 = numPointer28 + 4;
						int* numPointer29 = numPointer9;
						numPointer9 = numPointer29 + 4;
						*numPointer28 = *numPointer29;
						int* numPointer30 = numPointer2;
						numPointer2 = numPointer30 + 4;
						int* numPointer31 = numPointer9;
						numPointer9 = numPointer31 + 4;
						*numPointer30 = *numPointer31;
						int* numPointer32 = numPointer2;
						numPointer2 = numPointer32 + 4;
						int* numPointer33 = numPointer9;
						numPointer9 = numPointer33 + 4;
						*numPointer32 = *numPointer33;
						int* numPointer34 = numPointer3;
						numPointer3 = numPointer34 + 4;
						int* numPointer35 = numPointer9;
						numPointer9 = numPointer35 + 4;
						*numPointer34 = *numPointer35;
						int* numPointer36 = numPointer3;
						numPointer3 = numPointer36 + 4;
						int* numPointer37 = numPointer9;
						numPointer9 = numPointer37 + 4;
						*numPointer36 = *numPointer37;
						int* numPointer38 = numPointer3;
						numPointer3 = numPointer38 + 4;
						int* numPointer39 = numPointer9;
						numPointer9 = numPointer39 + 4;
						*numPointer38 = *numPointer39;
						int* numPointer40 = numPointer3;
						numPointer3 = numPointer40 + 4;
						int* numPointer41 = numPointer9;
						numPointer9 = numPointer41 + 4;
						*numPointer40 = *numPointer41;
						int* numPointer42 = numPointer4;
						numPointer4 = numPointer42 + 4;
						int* numPointer43 = numPointer9;
						numPointer9 = numPointer43 + 4;
						*numPointer42 = *numPointer43;
						int* numPointer44 = numPointer4;
						numPointer4 = numPointer44 + 4;
						int* numPointer45 = numPointer9;
						numPointer9 = numPointer45 + 4;
						*numPointer44 = *numPointer45;
						int* numPointer46 = numPointer4;
						numPointer4 = numPointer46 + 4;
						int* numPointer47 = numPointer9;
						numPointer9 = numPointer47 + 4;
						*numPointer46 = *numPointer47;
						int* numPointer48 = numPointer4;
						numPointer4 = numPointer48 + 4;
						int* numPointer49 = numPointer9;
						numPointer9 = numPointer49 + 4;
						*numPointer48 = *numPointer49;
						int* numPointer50 = numPointer5;
						numPointer5 = numPointer50 + 4;
						int* numPointer51 = numPointer9;
						numPointer9 = numPointer51 + 4;
						*numPointer50 = *numPointer51;
						int* numPointer52 = numPointer5;
						numPointer5 = numPointer52 + 4;
						int* numPointer53 = numPointer9;
						numPointer9 = numPointer53 + 4;
						*numPointer52 = *numPointer53;
						int* numPointer54 = numPointer5;
						numPointer5 = numPointer54 + 4;
						int* numPointer55 = numPointer9;
						numPointer9 = numPointer55 + 4;
						*numPointer54 = *numPointer55;
						int* numPointer56 = numPointer5;
						numPointer5 = numPointer56 + 4;
						int* numPointer57 = numPointer9;
						numPointer9 = numPointer57 + 4;
						*numPointer56 = *numPointer57;
						int* numPointer58 = numPointer6;
						numPointer6 = numPointer58 + 4;
						int* numPointer59 = numPointer9;
						numPointer9 = numPointer59 + 4;
						*numPointer58 = *numPointer59;
						int* numPointer60 = numPointer6;
						numPointer6 = numPointer60 + 4;
						int* numPointer61 = numPointer9;
						numPointer9 = numPointer61 + 4;
						*numPointer60 = *numPointer61;
						int* numPointer62 = numPointer6;
						numPointer6 = numPointer62 + 4;
						int* numPointer63 = numPointer9;
						numPointer9 = numPointer63 + 4;
						*numPointer62 = *numPointer63;
						int* numPointer64 = numPointer6;
						numPointer6 = numPointer64 + 4;
						int* numPointer65 = numPointer9;
						numPointer9 = numPointer65 + 4;
						*numPointer64 = *numPointer65;
						int* numPointer66 = numPointer7;
						numPointer7 = numPointer66 + 4;
						int* numPointer67 = numPointer9;
						numPointer9 = numPointer67 + 4;
						*numPointer66 = *numPointer67;
						int* numPointer68 = numPointer7;
						numPointer7 = numPointer68 + 4;
						int* numPointer69 = numPointer9;
						numPointer9 = numPointer69 + 4;
						*numPointer68 = *numPointer69;
						int* numPointer70 = numPointer7;
						numPointer7 = numPointer70 + 4;
						int* numPointer71 = numPointer9;
						numPointer9 = numPointer71 + 4;
						*numPointer70 = *numPointer71;
						int* numPointer72 = numPointer7;
						numPointer7 = numPointer72 + 4;
						int* numPointer73 = numPointer9;
						numPointer9 = numPointer73 + 4;
						*numPointer72 = *numPointer73;
					}
					num3++;
					num4++;
				}
				num1++;
				num2++;
				scan0 = scan0 + num;
			}
			bmp.UnlockBits(bitmapDatum);
		}

		private short[] GetRenderedBlock(int x, int y, bool statics)
		{
			TileMatrix tiles = this.Tiles;
			int blockWidth = tiles.BlockWidth;
			int blockHeight = tiles.BlockHeight;
			if (x < 0 || y < 0 || x >= blockWidth || y >= blockHeight)
			{
				if (this.m_Black == null)
				{
					this.m_Black = new short[64];
				}
				return this.m_Black;
			}
			short[][][] numArray = (statics ? this.m_Cache : this.m_Cache_NoStatics);
			if (numArray == null)
			{
				if (!statics)
				{
					this.m_Cache_NoStatics = new short[this.m_Tiles.BlockHeight][][];
				}
				else
				{
					short[][][] numArray1 = new short[this.m_Tiles.BlockHeight][][];
					numArray = numArray1;
					this.m_Cache = numArray1;
				}
			}
			if (numArray[y] == null)
			{
				numArray[y] = new short[this.m_Tiles.BlockWidth][];
			}
			short[] numArray2 = numArray[y][x];
			if (numArray2 == null)
			{
				short[][] numArray3 = numArray[y];
				short[] numArray4 = this.RenderBlock(x, y, statics);
				numArray2 = numArray4;
				numArray3[x] = numArray4;
			}
			return numArray2;
		}

		private static void LoadColors()
		{
			unsafe
			{
				Map.m_Colors = new short[32768];
				string filePath = Client.GetFilePath("radarcol.mul");
				if (filePath == null)
				{
					return;
				}
				fixed (short* mColors = &Map.m_Colors[0])
				{
					using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
					{
						Map._lread(fileStream.Handle, mColors, 65536);
					}
				}
			}
		}

		private unsafe short[] RenderBlock(int x, int y, bool drawStatics)
		{
			int mID;
			HuedTile[][][] staticBlock;
			short[] numArray = new short[64];
			Tile[] landBlock = this.m_Tiles.GetLandBlock(x, y);
			fixed (short* mColors = &Map.m_Colors[0])
			{
				fixed (int* heightTable = &TileData.HeightTable[0])
				{
					fixed (Tile* tilePointer = &landBlock[0])
					{
						Tile* tilePointer1 = tilePointer;
						fixed (short* numPointer = &numArray[0])
						{
							short* numPointer1 = numPointer;
							if (!drawStatics)
							{
								Tile* tilePointer2 = tilePointer1 + 64 * sizeof(Tile);
								while (tilePointer1 < tilePointer2)
								{
									short* mID1 = numPointer1;
									numPointer1 = mID1 + 2;
									Tile* tilePointer3 = tilePointer1;
									tilePointer1 = tilePointer3 + sizeof(Tile);
									*mID1 = (short)(*(mColors + (void*)(*tilePointer3).m_ID * 2));
								}
							}
							else
							{
								if (drawStatics)
								{
									staticBlock = this.m_Tiles.GetStaticBlock(x, y);
								}
								else
								{
									staticBlock = null;
								}
								HuedTile[][][] huedTileArray = staticBlock;
								int num = 0;
								int num1 = 0;
								while (num < 8)
								{
									for (int i = 0; i < 8; i++)
									{
										int num2 = -255;
										int num3 = -255;
										int mID2 = 0;
										int mHue = 0;
										HuedTile[] huedTileArray1 = huedTileArray[i][num];
										if ((int)huedTileArray1.Length > 0)
										{
											fixed (HuedTile* huedTilePointer = &huedTileArray1[0])
											{
												HuedTile* huedTilePointer1 = huedTilePointer;
												HuedTile* length = huedTilePointer1 + (int)huedTileArray1.Length * sizeof(HuedTile);
												while (huedTilePointer1 < length)
												{
													int mZ = (*huedTilePointer1).m_Z;
													mID = mZ + *(heightTable + ((*huedTilePointer1).m_ID & 16383) * 4);
													if (mID > num2 || mZ > num3 && mID >= num2)
													{
														num2 = mID;
														num3 = mZ;
														mID2 = (*huedTilePointer1).m_ID;
														mHue = (*huedTilePointer1).m_Hue;
													}
													huedTilePointer1 = huedTilePointer1 + sizeof(HuedTile);
												}
											}
										}
										mID = (*tilePointer1).m_Z;
										if (mID > num2)
										{
											mID2 = (*tilePointer1).m_ID;
											mHue = 0;
										}
										if (mHue != 0)
										{
											short* colors = numPointer1;
											numPointer1 = colors + 2;
											*colors = Hues.GetHue(mHue - 1).Colors[*(mColors + mID2 * 2) >> 10 & 31];
										}
										else
										{
											short* numPointer2 = numPointer1;
											numPointer1 = numPointer2 + 2;
											*numPointer2 = *(mColors + mID2 * 2);
										}
										tilePointer1 = tilePointer1 + sizeof(Tile);
									}
									num++;
									num1 = num1 + 8;
								}
							}
						}
					}
				}
			}
			return numArray;
		}
	}
}