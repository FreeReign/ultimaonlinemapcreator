using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Altitude
{
	public class ClsAltitudeTable
	{
		private Hashtable i_AltitudeTable;

		public Hashtable AltitudeHash
		{
			get
			{
				return this.i_AltitudeTable;
			}
		}

		public ClsAltitude GetAltitude(int Index)
		{
			get
			{
				return (ClsAltitude)this.i_AltitudeTable[Index];
			}
			set
			{
				this.i_AltitudeTable[Index] = Value;
			}
		}

		public ClsAltitudeTable()
		{
			this.i_AltitudeTable = new Hashtable();
		}

		public void Display(ListBox iList)
		{
			IEnumerator enumerator = null;
			iList.Items.Clear();
			try
			{
				enumerator = this.i_AltitudeTable.Values.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ClsAltitude current = (ClsAltitude)enumerator.Current;
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

		public ColorPalette GetAltPalette()
		{
			IEnumerator enumerator = null;
			ColorPalette palette = (new Bitmap(2, 2, PixelFormat.Format8bppIndexed)).Palette;
			try
			{
				enumerator = this.i_AltitudeTable.Values.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ClsAltitude current = (ClsAltitude)enumerator.Current;
					palette.Entries[current.Key] = current.AltitudeColor;
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			return palette;
		}

		public void Load()
		{
			IEnumerator enumerator = null;
			IEnumerator enumerator1 = null;
			string str = string.Format("{0}Data/System/Altitude.xml", AppDomain.CurrentDomain.BaseDirectory);
			XmlDocument xmlDocument = new XmlDocument();
			try
			{
				xmlDocument.Load(str);
				this.i_AltitudeTable.Clear();
				try
				{
					enumerator1 = xmlDocument.SelectNodes("Altitudes").GetEnumerator();
					while (enumerator1.MoveNext())
					{
						XmlElement current = (XmlElement)enumerator1.Current;
						try
						{
							enumerator = current.SelectNodes("Altitude").GetEnumerator();
							while (enumerator.MoveNext())
							{
								ClsAltitude clsAltitude = new ClsAltitude((XmlElement)enumerator.Current);
								this.i_AltitudeTable.Add(clsAltitude.Key, clsAltitude);
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
				Interaction.MsgBox(string.Format("XMLFile:{0}", str), MsgBoxStyle.OKOnly, null);
				ProjectData.ClearProjectError();
			}
		}

		public void Save()
		{
			IEnumerator enumerator = null;
			string str = string.Format("{0}Data\\System\\Altitude.xml", AppDomain.CurrentDomain.BaseDirectory);
			XmlTextWriter xmlTextWriter = new XmlTextWriter(str, Encoding.UTF8)
			{
				Indentation = 2,
				Formatting = Formatting.Indented
			};
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("Altitudes");
			try
			{
				enumerator = this.i_AltitudeTable.Values.GetEnumerator();
				while (enumerator.MoveNext())
				{
					((ClsAltitude)enumerator.Current).Save(xmlTextWriter);
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

		public void SaveACO()
		{
			byte num = Convert.ToByte(this.i_AltitudeTable.Count);
			string str = string.Format("{0}/Data/Photoshop/Altitude.ACO", Directory.GetCurrentDirectory());
			FileStream fileStream = new FileStream(str, FileMode.Create);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			binaryWriter.Write((byte)0);
			binaryWriter.Write((byte)1);
			binaryWriter.Write((byte)0);
			binaryWriter.Write(num);
			int num1 = 0;
			do
			{
				if (this.i_AltitudeTable[num1] != null)
				{
					binaryWriter.Write((byte)0);
					binaryWriter.Write((byte)0);
					((ClsAltitude)this.i_AltitudeTable[num1]).SaveACO(binaryWriter);
				}
				num1++;
			}
			while (num1 <= 255);
			binaryWriter.Write((byte)0);
			binaryWriter.Write((byte)2);
			binaryWriter.Write((byte)0);
			binaryWriter.Write(num);
			int num2 = 0;
			do
			{
				if (this.i_AltitudeTable[num2] != null)
				{
					binaryWriter.Write((byte)0);
					binaryWriter.Write((byte)0);
					((ClsAltitude)this.i_AltitudeTable[num2]).SaveACOText(binaryWriter);
				}
				num2++;
			}
			while (num2 <= 255);
			binaryWriter.Close();
			fileStream.Close();
			Interaction.MsgBox("Altitude.ACO Saved", MsgBoxStyle.OKOnly, null);
		}

		public void SaveACT()
		{
			string str = string.Format("{0}/Data/Photoshop/Altitude.ACT", Directory.GetCurrentDirectory());
			FileStream fileStream = new FileStream(str, FileMode.Create);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			byte num = 0;
			int num1 = 0;
			do
			{
				if (this.i_AltitudeTable[num1] != null)
				{
					((ClsAltitude)this.i_AltitudeTable[num1]).SaveACT(binaryWriter);
				}
				else
				{
					binaryWriter.Write(num);
					binaryWriter.Write(num);
					binaryWriter.Write(num);
				}
				num1++;
			}
			while (num1 <= 255);
			binaryWriter.Close();
			fileStream.Close();
			Interaction.MsgBox("Altitude.ACT Saved", MsgBoxStyle.OKOnly, null);
		}
	}
}