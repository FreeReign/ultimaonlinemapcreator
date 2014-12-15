using System;

namespace Ultima
{
	public class BodyTableEntry
	{
		public int m_OldID;

		public int m_NewID;

		public int m_NewHue;

		public BodyTableEntry(int oldID, int newID, int newHue)
		{
			this.m_OldID = oldID;
			this.m_NewID = newID;
			this.m_NewHue = newHue;
		}
	}
}