using System;

namespace Ultima
{
	public class LocationPointer
	{
		private int m_PointerX;

		private int m_SizeX;

		private int m_PointerY;

		private int m_SizeY;

		private int m_PointerZ;

		private int m_SizeZ;

		private int m_PointerF;

		private int m_SizeF;

		public int PointerF
		{
			get
			{
				return this.m_PointerF;
			}
			set
			{
				this.m_PointerF = value;
			}
		}

		public int PointerX
		{
			get
			{
				return this.m_PointerX;
			}
			set
			{
				this.m_PointerX = value;
			}
		}

		public int PointerY
		{
			get
			{
				return this.m_PointerY;
			}
			set
			{
				this.m_PointerY = value;
			}
		}

		public int PointerZ
		{
			get
			{
				return this.m_PointerZ;
			}
			set
			{
				this.m_PointerZ = value;
			}
		}

		public int SizeF
		{
			get
			{
				return this.m_SizeF;
			}
			set
			{
				this.m_SizeF = value;
			}
		}

		public int SizeX
		{
			get
			{
				return this.m_SizeX;
			}
			set
			{
				this.m_SizeX = value;
			}
		}

		public int SizeY
		{
			get
			{
				return this.m_SizeY;
			}
			set
			{
				this.m_SizeY = value;
			}
		}

		public int SizeZ
		{
			get
			{
				return this.m_SizeZ;
			}
			set
			{
				this.m_SizeZ = value;
			}
		}

		public LocationPointer(int ptrX, int ptrY, int ptrZ, int ptrF, int sizeX, int sizeY, int sizeZ, int sizeF)
		{
			this.m_PointerX = ptrX;
			this.m_PointerY = ptrY;
			this.m_PointerZ = ptrZ;
			this.m_PointerF = ptrF;
			this.m_SizeX = sizeX;
			this.m_SizeY = sizeY;
			this.m_SizeZ = sizeZ;
			this.m_SizeF = sizeF;
		}
	}
}