using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Transition
{
	public class RandomStatics : CollectionBase
	{
		private int m_Freq;

		private Collection m_Random;

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

		public RandomStaticCollection this[int index]
		{
			get
			{
				return (RandomStaticCollection)this.List[index];
			}
			set
			{
				this.List[index] = Value;
			}
		}

		public RandomStatics()
		{
			this.m_Random = new Collection();
		}

		public RandomStatics(string iFileName)
		{
			IEnumerator enumerator = null;
			this.m_Random = new Collection();
			XmlDocument xmlDocument = new XmlDocument();
			try
			{
				string str = string.Format("{0}Data\\Statics\\{1}", AppDomain.CurrentDomain.BaseDirectory, iFileName);
				xmlDocument.Load(str);
				XmlElement xmlElement = (XmlElement)xmlDocument.SelectSingleNode("//RandomStatics");
				this.m_Freq = XmlConvert.ToInt16(xmlElement.GetAttribute("Chance"));
				try
				{
					enumerator = xmlElement.SelectNodes("Statics").GetEnumerator();
					while (enumerator.MoveNext())
					{
						RandomStaticCollection randomStaticCollection = new RandomStaticCollection((XmlElement)enumerator.Current);
						this.InnerList.Add(randomStaticCollection);
						if (randomStaticCollection.Freq > 0)
						{
							byte freq = checked((byte)randomStaticCollection.Freq);
							for (byte i = 1; i <= freq; i = checked((byte)(i + 1)))
							{
								this.m_Random.Add(randomStaticCollection, null, null, null);
							}
						}
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
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Interaction.MsgBox(string.Concat("Can not find:", iFileName), MsgBoxStyle.OKOnly, null);
				ProjectData.ClearProjectError();
			}
		}

		public void Add(RandomStaticCollection Value)
		{
			this.InnerList.Add(Value);
			byte count = checked((byte)Value.Count);
			for (byte i = 0; i <= count; i = checked((byte)(i + 1)))
			{
				this.m_Random.Add(Value, null, null, null);
			}
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
					RandomStaticCollection current = (RandomStaticCollection)enumerator.Current;
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

		public void GetRandomStatic(short X, short Y, short Z, Collection[,] StaticMap)
		{
			if (this.m_Random.Count != 0)
			{
				VBMath.Randomize();
				if (checked((int)Math.Round((double)Conversion.Int(100f * VBMath.Rnd()))) <= this.m_Freq)
				{
					int num = checked(checked((int)Math.Round((double)((float)((float)Conversion.Int(checked(this.m_Random.Count - 1)) * VBMath.Rnd())))) + 1);
					((RandomStaticCollection)this.m_Random[num]).RandomStatic(X, Y, Z, StaticMap);
				}
			}
		}

		public void Remove(RandomStaticCollection Value)
		{
			this.InnerList.Remove(Value);
		}

		public void Save(string iFileName)
		{
			IEnumerator enumerator = null;
			XmlTextWriter xmlTextWriter = new XmlTextWriter(iFileName, Encoding.UTF8)
			{
				Indentation = 2,
				Formatting = Formatting.Indented
			};
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("RandomStatics");
			xmlTextWriter.WriteAttributeString("Chance", StringType.FromInteger(this.m_Freq));
			try
			{
				enumerator = this.InnerList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					((RandomStaticCollection)enumerator.Current).Save(xmlTextWriter);
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