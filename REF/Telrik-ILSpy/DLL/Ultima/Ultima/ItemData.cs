using System;

namespace Ultima
{
	public struct ItemData
	{
		internal string m_Name;

		internal TileFlag m_Flags;

		internal byte m_Weight;

		internal byte m_Quality;

		internal byte m_Quantity;

		internal byte m_Value;

		internal byte m_Height;

		internal short m_Animation;

		public int Animation
		{
			get
			{
				return this.m_Animation;
			}
		}

		public bool Background
		{
			get
			{
				return (this.m_Flags & TileFlag.Background) != TileFlag.None;
			}
		}

		public bool Bridge
		{
			get
			{
				return (this.m_Flags & TileFlag.Bridge) != TileFlag.None;
			}
		}

		public int CalcHeight
		{
			get
			{
				if ((this.m_Flags & TileFlag.Bridge) == TileFlag.None)
				{
					return this.m_Height;
				}
				return this.m_Height / 2;
			}
		}

		public TileFlag Flags
		{
			get
			{
				return this.m_Flags;
			}
		}

		public int Height
		{
			get
			{
				return this.m_Height;
			}
		}

		public bool Impassable
		{
			get
			{
				return (this.m_Flags & TileFlag.Impassable) != TileFlag.None;
			}
		}

		public string Name
		{
			get
			{
				return this.m_Name;
			}
		}

		public int Quality
		{
			get
			{
				return this.m_Quality;
			}
		}

		public int Quantity
		{
			get
			{
				return this.m_Quantity;
			}
		}

		public bool Surface
		{
			get
			{
				return (this.m_Flags & TileFlag.Surface) != TileFlag.None;
			}
		}

		public int Value
		{
			get
			{
				return this.m_Value;
			}
		}

		public int Weight
		{
			get
			{
				return this.m_Weight;
			}
		}

		public ItemData(string name, TileFlag flags, int weight, int quality, int quantity, int value, int height, int anim)
		{
			this.m_Name = name;
			this.m_Flags = flags;
			this.m_Weight = (byte)weight;
			this.m_Quality = (byte)quality;
			this.m_Quantity = (byte)quantity;
			this.m_Value = (byte)value;
			this.m_Height = (byte)height;
			this.m_Animation = (short)anim;
		}
	}
}