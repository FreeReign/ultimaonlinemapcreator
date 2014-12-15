using System;

namespace Ultima
{
	public struct LandData
	{
		private string m_Name;

		private TileFlag m_Flags;

		public TileFlag Flags
		{
			get
			{
				return this.m_Flags;
			}
		}

		public string Name
		{
			get
			{
				return this.m_Name;
			}
		}

		public LandData(string name, TileFlag flags)
		{
			this.m_Name = name;
			this.m_Flags = flags;
		}
	}
}