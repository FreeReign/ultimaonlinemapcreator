using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace Transition
{
	public class MapTileCollection : CollectionBase
	{
		public MapTile this[int index]
		{
			get
			{
				return (MapTile)this.List[index];
			}
			set
			{
				this.List[index] = Value;
			}
		}

		public MapTile RandomTile
		{
			get
			{
				int num = checked((int)Math.Round((double)((float)(VBMath.Rnd() * (float)(checked(this.List.Count - 1))))));
				return (MapTile)this.List[num];
			}
		}

		public MapTileCollection()
		{
		}

		public void Add(MapTile Value)
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
					MapTile current = (MapTile)enumerator.Current;
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

		public void Load(XmlElement xmlInfo)
		{
			IEnumerator enumerator = null;
			IEnumerator enumerator1 = null;
			try
			{
				enumerator1 = xmlInfo.SelectNodes("MapTiles").GetEnumerator();
				while (enumerator1.MoveNext())
				{
					XmlElement current = (XmlElement)enumerator1.Current;
					try
					{
						enumerator = current.SelectNodes("MapTile").GetEnumerator();
						while (enumerator.MoveNext())
						{
							XmlElement xmlElement = (XmlElement)enumerator.Current;
							this.InnerList.Add(new MapTile(xmlElement));
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

		public void Remove(MapTile Value)
		{
			this.InnerList.Remove(Value);
		}

		public void Save(XmlTextWriter xmlInfo)
		{
			IEnumerator enumerator = null;
			xmlInfo.WriteStartElement("MapTiles");
			try
			{
				enumerator = this.InnerList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					((MapTile)enumerator.Current).Save(xmlInfo);
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
	}
}