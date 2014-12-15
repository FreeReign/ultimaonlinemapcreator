using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.IO;
using System.Xml;

namespace Transition
{
	public class ImportTiles
	{
		public ImportTiles(Collection[,] StaticMap, string iPath)
		{
			iPath = string.Concat(iPath, "\\Import Files\\");
			if (Directory.Exists(iPath))
			{
				this.ProcessDirectory(StaticMap, iPath);
			}
			else
			{
				Interaction.MsgBox("No Import Tiles directory was found.", MsgBoxStyle.OKOnly, null);
			}
		}

		public void Load(Collection[,] StaticMap, string iFilename)
		{
			IEnumerator enumerator = null;
			XmlDocument xmlDocument = new XmlDocument();
			try
			{
				xmlDocument.Load(iFilename);
				XmlElement xmlElement = (XmlElement)xmlDocument.SelectSingleNode("//Static_Tiles");
				try
				{
					enumerator = xmlElement.SelectNodes("Tile").GetEnumerator();
					while (enumerator.MoveNext())
					{
						XmlElement current = (XmlElement)enumerator.Current;
						short num = XmlConvert.ToInt16(current.GetAttribute("TileID"));
						short num1 = XmlConvert.ToInt16(current.GetAttribute("X"));
						short num2 = XmlConvert.ToInt16(current.GetAttribute("Y"));
						short num3 = XmlConvert.ToInt16(current.GetAttribute("Z"));
						short num4 = XmlConvert.ToInt16(current.GetAttribute("Hue"));
						StaticCell staticCell = new StaticCell(num, checked((byte)(num1 % 8)), checked((byte)(num2 % 8)), num3, num4);
						StaticMap[(short)(num1 >> 3), (short)(num2 >> 3)].Add(staticCell, null, null, null);
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
				Interaction.MsgBox(string.Concat("Can not find:", iFilename), MsgBoxStyle.OKOnly, null);
				ProjectData.ClearProjectError();
			}
		}

		public void ProcessDirectory(Collection[,] StaticMap, string targetDirectory)
		{
			string[] files = Directory.GetFiles(targetDirectory, "*.xml");
			for (int i = 0; i < (int)files.Length; i++)
			{
				this.Load(StaticMap, files[i]);
			}
			string[] directories = Directory.GetDirectories(targetDirectory);
			for (int j = 0; j < (int)directories.Length; j++)
			{
				this.ProcessDirectory(StaticMap, directories[j]);
			}
		}
	}
}