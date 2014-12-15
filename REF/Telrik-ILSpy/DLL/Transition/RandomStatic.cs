using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Xml;

namespace Transition
{
	public class RandomStatic
	{
		private short m_TileID;

		private short m_XMod;

		private short m_YMod;

		private short m_ZMod;

		private short m_HueMod;

		public short Hue
		{
			get
			{
				return this.m_HueMod;
			}
			set
			{
				this.m_HueMod = value;
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

		public short X
		{
			get
			{
				return this.m_XMod;
			}
			set
			{
				this.m_XMod = value;
			}
		}

		public short Y
		{
			get
			{
				return this.m_YMod;
			}
			set
			{
				this.m_YMod = value;
			}
		}

		public short Z
		{
			get
			{
				return this.m_ZMod;
			}
			set
			{
				this.m_ZMod = value;
			}
		}

		public RandomStatic()
		{
		}

		public RandomStatic(short iTileID, short iXMod, short iYMod, short iZMod, short iHueMod)
		{
			this.m_TileID = iTileID;
			this.m_XMod = iXMod;
			this.m_YMod = iYMod;
			this.m_ZMod = iZMod;
			this.m_HueMod = iHueMod;
		}

		public RandomStatic(XmlElement xmlInfo)
		{
			try
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
				this.m_XMod = XmlConvert.ToInt16(xmlInfo.GetAttribute("X"));
				this.m_YMod = XmlConvert.ToInt16(xmlInfo.GetAttribute("Y"));
				this.m_ZMod = XmlConvert.ToInt16(xmlInfo.GetAttribute("Z"));
				this.m_HueMod = XmlConvert.ToInt16(xmlInfo.GetAttribute("Hue"));
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Interaction.MsgBox(string.Format("Error\r\n{0}", xmlInfo.OuterXml), MsgBoxStyle.OKOnly, null);
				ProjectData.ClearProjectError();
			}
		}

		public void Save(XmlTextWriter xmlInfo)
		{
			xmlInfo.WriteStartElement("Static");
			xmlInfo.WriteAttributeString("TileID", StringType.FromInteger(this.m_TileID));
			xmlInfo.WriteAttributeString("X", StringType.FromInteger(this.m_XMod));
			xmlInfo.WriteAttributeString("Y", StringType.FromInteger(this.m_YMod));
			xmlInfo.WriteAttributeString("Z", StringType.FromInteger(this.m_ZMod));
			xmlInfo.WriteAttributeString("Hue", StringType.FromInteger(this.m_HueMod));
			xmlInfo.WriteEndElement();
		}

		public override string ToString()
		{
			object[] mTileID = new object[] { this.m_TileID, this.m_XMod, this.m_YMod, this.m_ZMod, this.m_HueMod };
			return string.Format("Tile:{0:X4} X:{1} Y:{2} Z:{3} Hue:{4}", mTileID);
		}
	}
}