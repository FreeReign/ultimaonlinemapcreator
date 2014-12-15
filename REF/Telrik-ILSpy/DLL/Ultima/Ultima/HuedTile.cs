using System;

namespace Ultima
{
	public struct HuedTile
	{
		internal short m_ID;

		internal short m_Hue;

		internal sbyte m_Z;

		public int Hue
		{
			get
			{
				return this.m_Hue;
			}
		}

		public int ID
		{
			get
			{
				return this.m_ID;
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

		public HuedTile(short id, short hue, sbyte z)
		{
			this.m_ID = id;
			this.m_Hue = hue;
			this.m_Z = z;
		}

		public void Set(short id, short hue, sbyte z)
		{
			this.m_ID = id;
			this.m_Hue = hue;
			this.m_Z = z;
		}
	}
}