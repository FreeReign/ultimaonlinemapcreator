using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace DragonConv
{
	public class ClsDragon
	{
		private int m_GroupID;

		private byte m_TerrainID;

		private byte m_AltitudeID;

		public byte AltitudeID
		{
			get
			{
				return this.m_AltitudeID;
			}
			set
			{
				this.m_AltitudeID = value;
			}
		}

		public int GroupID
		{
			get
			{
				return this.m_GroupID;
			}
			set
			{
				this.m_GroupID = value;
			}
		}

		public byte TerrainID
		{
			get
			{
				return this.m_TerrainID;
			}
			set
			{
				this.m_TerrainID = value;
			}
		}

		public ClsDragon(XmlElement xmlInfo)
		{
			this.m_GroupID = IntegerType.FromString(string.Concat("&H", xmlInfo.GetAttribute("GroupID")));
			this.m_TerrainID = ByteType.FromString(string.Concat("&H", xmlInfo.GetAttribute("Terrain")));
			this.m_AltitudeID = ByteType.FromString(string.Concat("&H", xmlInfo.GetAttribute("Alt")));
		}

		public void Save(XmlTextWriter xmlInfo)
		{
			xmlInfo.WriteStartElement("HoxCode");
			xmlInfo.WriteAttributeString("GroupID", StringType.FromInteger(this.m_GroupID));
			xmlInfo.WriteAttributeString("Alt", StringType.FromByte(this.m_AltitudeID));
			xmlInfo.WriteAttributeString("Terrain", StringType.FromByte(this.m_TerrainID));
			xmlInfo.WriteEndElement();
		}
	}
}