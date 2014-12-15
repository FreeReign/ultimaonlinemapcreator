using System;
using System.Xml;

namespace DragonConv
{
	public class TransInfo
	{
		private string m_Description;

		private string m_Location;

		public string Location
		{
			get
			{
				return this.m_Location;
			}
			set
			{
				this.m_Location = value;
			}
		}

		public TransInfo(XmlElement iElement)
		{
			this.m_Description = iElement.GetAttribute("Description");
			this.m_Location = iElement.GetAttribute("Location");
		}

		public override string ToString()
		{
			return string.Format("{0}", this.m_Description);
		}
	}
}