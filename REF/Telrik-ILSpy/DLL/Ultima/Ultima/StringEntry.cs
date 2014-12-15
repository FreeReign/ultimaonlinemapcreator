using System;

namespace Ultima
{
	public class StringEntry
	{
		private int m_Number;

		private string m_Text;

		public int Number
		{
			get
			{
				return this.m_Number;
			}
		}

		public string Text
		{
			get
			{
				return this.m_Text;
			}
		}

		public StringEntry(int number, string text)
		{
			this.m_Number = number;
			this.m_Text = text;
		}
	}
}