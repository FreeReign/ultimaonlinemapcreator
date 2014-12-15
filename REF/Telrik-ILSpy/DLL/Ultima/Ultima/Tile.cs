using System;

namespace Ultima
{
	public struct Tile : IComparable
	{
		internal short m_ID;

		internal sbyte m_Z;

		public int ID
		{
			get
			{
				return this.m_ID;
			}
		}

		public bool Ignored
		{
			get
			{
				if (this.m_ID == 2 || this.m_ID == 475)
				{
					return true;
				}
				if (this.m_ID < 430)
				{
					return false;
				}
				return this.m_ID <= 437;
			}
		}

		public int Z
		{
			get
			{
				return this.m_Z;
			}
			set
			{
				this.m_Z = (sbyte)value;
			}
		}

		public Tile(short id, sbyte z)
		{
			this.m_ID = id;
			this.m_Z = z;
		}

		public int CompareTo(object x)
		{
			if (x == null)
			{
				return 1;
			}
			if (!(x is Tile))
			{
				throw new ArgumentNullException();
			}
			Tile tile = (Tile)x;
			if (this.m_Z > tile.m_Z)
			{
				return 1;
			}
			if (tile.m_Z > this.m_Z)
			{
				return -1;
			}
			ItemData itemTable = TileData.ItemTable[this.m_ID & 16383];
			ItemData itemDatum = TileData.ItemTable[tile.m_ID & 16383];
			if (itemTable.Height > itemDatum.Height)
			{
				return 1;
			}
			if (itemDatum.Height > itemTable.Height)
			{
				return -1;
			}
			if (itemTable.Background && !itemDatum.Background)
			{
				return -1;
			}
			if (itemDatum.Background && !itemTable.Background)
			{
				return 1;
			}
			return 0;
		}

		public void Set(short id, sbyte z)
		{
			this.m_ID = id;
			this.m_Z = z;
		}
	}
}