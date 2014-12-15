using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Text;
using System.Xml;

namespace DragonConv
{
	public class ClsDragonTable
	{
		private Hashtable m_Dragon;

		public Hashtable DragonHash
		{
			get
			{
				return this.m_Dragon;
			}
		}

		public ClsDragon GetDragon(int Index)
		{
			get
			{
				return (ClsDragon)this.m_Dragon[Index];
			}
			set
			{
				this.m_Dragon[Index] = Value;
			}
		}

		public ClsDragonTable()
		{
			this.m_Dragon = new Hashtable(256);
		}

		public void Load(string iFileName)
		{
			IEnumerator enumerator = null;
			IEnumerator enumerator1 = null;
			XmlDocument xmlDocument = new XmlDocument();
			try
			{
				xmlDocument.Load(iFileName);
				this.m_Dragon.Clear();
				try
				{
					enumerator1 = xmlDocument.SelectNodes("Dragon").GetEnumerator();
					while (enumerator1.MoveNext())
					{
						XmlElement current = (XmlElement)enumerator1.Current;
						try
						{
							enumerator = current.SelectNodes("HexCode").GetEnumerator();
							while (enumerator.MoveNext())
							{
								ClsDragon clsDragon = new ClsDragon((XmlElement)enumerator.Current);
								this.m_Dragon.Add(clsDragon.GroupID, clsDragon);
							}
						}
						finally
						{
							if (enumerator is IDisposable)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
					}
				}
				finally
				{
					if (enumerator1 is IDisposable)
					{
						((IDisposable)enumerator1).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Interaction.MsgBox(exception.Message, MsgBoxStyle.OKOnly, null);
				ProjectData.ClearProjectError();
			}
		}

		public void Save(string iFilename)
		{
			IEnumerator enumerator = null;
			XmlTextWriter xmlTextWriter = new XmlTextWriter(iFilename, Encoding.UTF8)
			{
				Indentation = 2,
				Formatting = Formatting.Indented
			};
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("Dragon");
			try
			{
				enumerator = this.m_Dragon.Values.GetEnumerator();
				while (enumerator.MoveNext())
				{
					((ClsDragon)enumerator.Current).Save(xmlTextWriter);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteEndDocument();
			xmlTextWriter.Close();
		}
	}
}