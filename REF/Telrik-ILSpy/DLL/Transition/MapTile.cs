using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace Transition
{
	public class MapTile
	{
		private short m_TileID;

		private short m_AltID;

		public short AltIDMod
		{
			get
			{
				return this.m_AltID;
			}
			set
			{
				this.m_AltID = value;
			}
		}

		public short TileID
		{
			get
			{
				return this.m_TileID;
			}
			set
			{
				this.m_TileID = value;
			}
		}

		public MapTile(short TileID, short AltID)
		{
			this.m_TileID = TileID;
			this.m_AltID = AltID;
		}

		public MapTile()
		{
		}

		public MapTile(XmlElement xmlInfo)
		{
			try
			{
				this.m_TileID = XmlConvert.ToInt16(xmlInfo.GetAttribute("TileID"));
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				this.m_TileID = ShortType.FromString(string.Concat("&H", xmlInfo.GetAttribute("TileID")));
				ProjectData.ClearProjectError();
			}
			this.m_AltID = XmlConvert.ToInt16(xmlInfo.GetAttribute("AltIDMod"));
		}

		public void Save(XmlTextWriter xmlInfo)
		{
			xmlInfo.WriteStartElement("MapTile");
			xmlInfo.WriteAttributeString("TileID", StringType.FromInteger(this.m_TileID));
			xmlInfo.WriteAttributeString("AltIDMod", StringType.FromInteger(this.m_AltID));
			xmlInfo.WriteEndElement();
		}

		public override string ToString()
		{
			string str = string.Format("{0:X4} [{1}]", this.m_TileID, this.m_AltID);
			return str;
		}
	}
}