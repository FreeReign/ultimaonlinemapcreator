using System;

namespace Ultima
{
	public class TileList
	{
		private Tile[] m_Tiles;

		private int m_Count;

		public int Count
		{
			get
			{
				return this.m_Count;
			}
		}

		public TileList()
		{
			this.m_Tiles = new Tile[8];
			this.m_Count = 0;
		}

		public void Add(short id, sbyte z)
		{
			if (this.m_Count + 1 > (int)this.m_Tiles.Length)
			{
				Tile[] mTiles = this.m_Tiles;
				this.m_Tiles = new Tile[(int)mTiles.Length * 2];
				for (int i = 0; i < (int)mTiles.Length; i++)
				{
					this.m_Tiles[i] = mTiles[i];
				}
			}
			Tile[] tileArray = this.m_Tiles;
			TileList tileList = this;
			int mCount = tileList.m_Count;
			int num = mCount;
			tileList.m_Count = mCount + 1;
			tileArray[num].Set(id, z);
		}

		public Tile[] ToArray()
		{
			Tile[] mTiles = new Tile[this.m_Count];
			for (int i = 0; i < this.m_Count; i++)
			{
				mTiles[i] = this.m_Tiles[i];
			}
			this.m_Count = 0;
			return mTiles;
		}
	}
}