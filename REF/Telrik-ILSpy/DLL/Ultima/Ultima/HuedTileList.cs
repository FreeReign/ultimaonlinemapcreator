using System;

namespace Ultima
{
	public class HuedTileList
	{
		private HuedTile[] m_Tiles;

		private int m_Count;

		public int Count
		{
			get
			{
				return this.m_Count;
			}
		}

		public HuedTileList()
		{
			this.m_Tiles = new HuedTile[8];
			this.m_Count = 0;
		}

		public void Add(short id, short hue, sbyte z)
		{
			if (this.m_Count + 1 > (int)this.m_Tiles.Length)
			{
				HuedTile[] mTiles = this.m_Tiles;
				this.m_Tiles = new HuedTile[(int)mTiles.Length * 2];
				for (int i = 0; i < (int)mTiles.Length; i++)
				{
					this.m_Tiles[i] = mTiles[i];
				}
			}
			HuedTile[] huedTileArray = this.m_Tiles;
			HuedTileList huedTileList = this;
			int mCount = huedTileList.m_Count;
			int num = mCount;
			huedTileList.m_Count = mCount + 1;
			huedTileArray[num].Set(id, hue, z);
		}

		public HuedTile[] ToArray()
		{
			HuedTile[] mTiles = new HuedTile[this.m_Count];
			for (int i = 0; i < this.m_Count; i++)
			{
				mTiles[i] = this.m_Tiles[i];
			}
			this.m_Count = 0;
			return mTiles;
		}
	}
}