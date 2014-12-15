using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace Transition
{
	public class RandomStaticCollection : CollectionBase
	{
		private string m_Description;

		private int m_Freq;

		public string Description
		{
			get
			{
				return this.m_Description;
			}
			set
			{
				this.m_Description = value;
			}
		}

		public int Freq
		{
			get
			{
				return this.m_Freq;
			}
			set
			{
				this.m_Freq = value;
			}
		}

		public Collection iCollection
		{
			get
			{
				return (Collection)this.List;
			}
		}

		public RandomStatic this[int index]
		{
			get
			{
				return (RandomStatic)this.List[index];
			}
			set
			{
				this.List[index] = Value;
			}
		}

		public RandomStaticCollection()
		{
		}

		public RandomStaticCollection(string iDescription, int iFreq)
		{
			this.m_Description = iDescription;
			this.m_Freq = iFreq;
		}

		public RandomStaticCollection(XmlElement xmlInfo)
		{
			IEnumerator enumerator = null;
			this.m_Description = xmlInfo.GetAttribute("Description");
			this.m_Freq = XmlConvert.ToInt16(xmlInfo.GetAttribute("Freq"));
			try
			{
				enumerator = xmlInfo.SelectNodes("Static").GetEnumerator();
				while (enumerator.MoveNext())
				{
					XmlElement current = (XmlElement)enumerator.Current;
					this.InnerList.Add(new RandomStatic(current));
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

		public void Add(RandomStatic Value)
		{
			this.InnerList.Add(Value);
		}

		public void Display(ListBox iList)
		{
			IEnumerator enumerator = null;
			iList.Items.Clear();
			try
			{
				enumerator = this.InnerList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					RandomStatic current = (RandomStatic)enumerator.Current;
					iList.Items.Add(current);
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

		public void RandomStatic(short X, short Y, short Z, Collection[,] StaticMap)
		{
			IEnumerator enumerator = null;
			try
			{
				enumerator = this.InnerList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					RandomStatic current = (RandomStatic)enumerator.Current;
					StaticCell staticCell = new StaticCell(current.TileID, checked((byte)(checked((short)(X + current.X)) % 8)), checked((byte)(checked((short)(Y + current.Y)) % 8)), checked((short)(Z + current.Z)));
					StaticMap[(short)(checked((short)(X + current.X)) >> 3), (short)(checked((short)(Y + current.Y)) >> 3)].Add(staticCell, null, null, null);
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

		public void Remove(RandomStatic Value)
		{
			this.InnerList.Remove(Value);
		}

		public void Save(XmlTextWriter xmlInfo)
		{
			IEnumerator enumerator = null;
			xmlInfo.WriteStartElement("Statics");
			xmlInfo.WriteAttributeString("Description", this.m_Description);
			xmlInfo.WriteAttributeString("Freq", StringType.FromInteger(this.m_Freq));
			try
			{
				enumerator = this.InnerList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					((RandomStatic)enumerator.Current).Save(xmlInfo);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			xmlInfo.WriteEndElement();
		}

		public override string ToString()
		{
			string str = string.Format("{0} Freq:{1}", this.m_Description, this.m_Freq);
			return str;
		}
	}
}