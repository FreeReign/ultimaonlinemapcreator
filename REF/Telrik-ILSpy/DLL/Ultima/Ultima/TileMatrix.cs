using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Ultima
{
	public class TileMatrix
	{
		private HuedTile[][][][][] m_StaticTiles;

		private Tile[][][] m_LandTiles;

		private Tile[] m_InvalidLandBlock;

		private HuedTile[][][] m_EmptyStaticBlock;

		private FileStream m_Map;

		private FileStream m_Index;

		private BinaryReader m_IndexReader;

		private FileStream m_Statics;

		private int m_BlockWidth;

		private int m_BlockHeight;

		private int m_Width;

		private int m_Height;

		private TileMatrixPatch m_Patch;

		private static HuedTileList[][] m_Lists;

		public int BlockHeight
		{
			get
			{
				return this.m_BlockHeight;
			}
		}

		public int BlockWidth
		{
			get
			{
				return this.m_BlockWidth;
			}
		}

		public HuedTile[][][] EmptyStaticBlock
		{
			get
			{
				return this.m_EmptyStaticBlock;
			}
		}

		public int Height
		{
			get
			{
				return this.m_Height;
			}
		}

		public TileMatrixPatch Patch
		{
			get
			{
				return this.m_Patch;
			}
		}

		public int Width
		{
			get
			{
				return this.m_Width;
			}
		}

		public TileMatrix(int fileIndex, int mapID, int width, int height)
		{
			this.m_Width = width;
			this.m_Height = height;
			this.m_BlockWidth = width >> 3;
			this.m_BlockHeight = height >> 3;
			if (fileIndex != 127)
			{
				object[] objArray = new object[] { fileIndex };
				string filePath = Client.GetFilePath("map{0}.mul", objArray);
				if (filePath != null)
				{
					this.m_Map = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
				}
				objArray = new object[] { fileIndex };
				string str = Client.GetFilePath("staidx{0}.mul", objArray);
				if (str != null)
				{
					this.m_Index = new FileStream(str, FileMode.Open, FileAccess.Read, FileShare.Read);
					this.m_IndexReader = new BinaryReader(this.m_Index);
				}
				objArray = new object[] { fileIndex };
				string filePath1 = Client.GetFilePath("statics{0}.mul", objArray);
				if (filePath1 != null)
				{
					this.m_Statics = new FileStream(filePath1, FileMode.Open, FileAccess.Read, FileShare.Read);
				}
			}
			this.m_EmptyStaticBlock = new HuedTile[8][][];
			for (int i = 0; i < 8; i++)
			{
				this.m_EmptyStaticBlock[i] = new HuedTile[8][];
				for (int j = 0; j < 8; j++)
				{
					this.m_EmptyStaticBlock[i][j] = new HuedTile[0];
				}
			}
			this.m_InvalidLandBlock = new Tile[196];
			this.m_LandTiles = new Tile[this.m_BlockWidth][][];
			this.m_StaticTiles = new HuedTile[this.m_BlockWidth][][][][];
			this.m_Patch = new TileMatrixPatch(this, mapID);
		}

		[DllImport("Kernel32", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern unsafe int _lread(IntPtr hFile, void* lpBuffer, int wBytes);

		public void Dispose()
		{
			if (this.m_Map != null)
			{
				this.m_Map.Close();
			}
			if (this.m_Statics != null)
			{
				this.m_Statics.Close();
			}
			if (this.m_IndexReader != null)
			{
				this.m_IndexReader.Close();
			}
		}

		public Tile[] GetLandBlock(int x, int y)
		{
			if (x < 0 || y < 0 || x >= this.m_BlockWidth || y >= this.m_BlockHeight || this.m_Map == null)
			{
				return this.m_InvalidLandBlock;
			}
			if (this.m_LandTiles[x] == null)
			{
				this.m_LandTiles[x] = new Tile[this.m_BlockHeight][];
			}
			Tile[] mLandTiles = this.m_LandTiles[x][y];
			if (mLandTiles == null)
			{
				Tile[][] tileArray = this.m_LandTiles[x];
				Tile[] tileArray1 = this.ReadLandBlock(x, y);
				Tile[] tileArray2 = tileArray1;
				tileArray[y] = tileArray1;
				mLandTiles = tileArray2;
			}
			return mLandTiles;
		}

		public Tile GetLandTile(int x, int y)
		{
			Tile[] landBlock = this.GetLandBlock(x >> 3, y >> 3);
			return landBlock[((y & 7) << 3) + (x & 7)];
		}

		public HuedTile[][][] GetStaticBlock(int x, int y)
		{
			if (x < 0 || y < 0 || x >= this.m_BlockWidth || y >= this.m_BlockHeight || this.m_Statics == null || this.m_Index == null)
			{
				return this.m_EmptyStaticBlock;
			}
			if (this.m_StaticTiles[x] == null)
			{
				this.m_StaticTiles[x] = new HuedTile[this.m_BlockHeight][][][];
			}
			HuedTile[][][] mStaticTiles = this.m_StaticTiles[x][y];
			if (mStaticTiles == null)
			{
				HuedTile[][][][] huedTileArray = this.m_StaticTiles[x];
				HuedTile[][][] huedTileArray1 = this.ReadStaticBlock(x, y);
				HuedTile[][][] huedTileArray2 = huedTileArray1;
				huedTileArray[y] = huedTileArray1;
				mStaticTiles = huedTileArray2;
			}
			return mStaticTiles;
		}

		public HuedTile[] GetStaticTiles(int x, int y)
		{
			HuedTile[][][] staticBlock = this.GetStaticBlock(x >> 3, y >> 3);
			return staticBlock[x & 7][y & 7];
		}

		private Tile[] ReadLandBlock(int x, int y)
		{
			unsafe
			{
				this.m_Map.Seek((long)((x * this.m_BlockHeight + y) * 196 + 4), SeekOrigin.Begin);
				Tile[] tileArray = new Tile[64];
				fixed (Tile* tilePointer = &tileArray[0])
				{
					TileMatrix._lread(this.m_Map.Handle, tilePointer, 192);
				}
				return tileArray;
			}
		}

		private unsafe HuedTile[][][] ReadStaticBlock(int x, int y)
		{
			this.m_IndexReader.BaseStream.Seek((long)((x * this.m_BlockHeight + y) * 12), SeekOrigin.Begin);
			int num = this.m_IndexReader.ReadInt32();
			int num1 = this.m_IndexReader.ReadInt32();
			if (num < 0 || num1 <= 0)
			{
				return this.m_EmptyStaticBlock;
			}
			int num2 = num1 / 7;
			this.m_Statics.Seek((long)num, SeekOrigin.Begin);
			fixed (StaticTile* staticTilePointer = &(new StaticTile[num2])[0])
			{
				TileMatrix._lread(this.m_Statics.Handle, staticTilePointer, num1);
				if (TileMatrix.m_Lists == null)
				{
					TileMatrix.m_Lists = new HuedTileList[8][];
					for (int i = 0; i < 8; i++)
					{
						TileMatrix.m_Lists[i] = new HuedTileList[8];
						for (int j = 0; j < 8; j++)
						{
							TileMatrix.m_Lists[i][j] = new HuedTileList();
						}
					}
				}
				HuedTileList[][] mLists = TileMatrix.m_Lists;
				StaticTile* staticTilePointer1 = staticTilePointer;
				StaticTile* staticTilePointer2 = staticTilePointer + num2 * sizeof(StaticTile);
				while (staticTilePointer1 < staticTilePointer2)
				{
					mLists[(*staticTilePointer1).m_X & 7][(*staticTilePointer1).m_Y & 7].Add((short)(((*staticTilePointer1).m_ID & 16383) + 16384), (*staticTilePointer1).m_Hue, (*staticTilePointer1).m_Z);
					staticTilePointer1 = staticTilePointer1 + sizeof(StaticTile);
				}
				HuedTile[][][] array = new HuedTile[8][][];
				for (int k = 0; k < 8; k++)
				{
					array[k] = new HuedTile[8][];
					for (int l = 0; l < 8; l++)
					{
						array[k][l] = mLists[k][l].ToArray();
					}
				}
				return array;
			}
		}

		public void SetLandBlock(int x, int y, Tile[] value)
		{
			if (x < 0 || y < 0 || x >= this.m_BlockWidth || y >= this.m_BlockHeight)
			{
				return;
			}
			if (this.m_LandTiles[x] == null)
			{
				this.m_LandTiles[x] = new Tile[this.m_BlockHeight][];
			}
			this.m_LandTiles[x][y] = value;
		}

		public void SetStaticBlock(int x, int y, HuedTile[][][] value)
		{
			if (x < 0 || y < 0 || x >= this.m_BlockWidth || y >= this.m_BlockHeight)
			{
				return;
			}
			if (this.m_StaticTiles[x] == null)
			{
				this.m_StaticTiles[x] = new HuedTile[this.m_BlockHeight][][][];
			}
			this.m_StaticTiles[x][y] = value;
		}
	}
}