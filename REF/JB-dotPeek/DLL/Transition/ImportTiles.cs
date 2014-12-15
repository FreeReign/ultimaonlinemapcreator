// Decompiled with JetBrains decompiler
// Type: Transition.ImportTiles
// Assembly: Transition, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: D3B0804F-08F3-42BB-B2B3-B2AAA4B5AE51
// Assembly location: W:\JetBrains\UOLandscaper\Transition.dll

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
      iPath = iPath + "\\Import Files\\";
      if (!Directory.Exists(iPath))
      {
        int num = (int) Interaction.MsgBox((object) "No Import Tiles directory was found.", MsgBoxStyle.OKOnly, (object) null);
      }
      else
        this.ProcessDirectory(StaticMap, iPath);
    }

    public void Load(Collection[,] StaticMap, string iFilename)
    {
      XmlDocument xmlDocument = new XmlDocument();
      try
      {
        xmlDocument.Load(iFilename);
        XmlElement xmlElement1 = (XmlElement) xmlDocument.SelectSingleNode("//Static_Tiles");
        try
        {
          foreach (XmlElement xmlElement2 in xmlElement1.SelectNodes("Tile"))
          {
            short iTileID = XmlConvert.ToInt16(xmlElement2.GetAttribute("TileID"));
            short num1 = XmlConvert.ToInt16(xmlElement2.GetAttribute("X"));
            short num2 = XmlConvert.ToInt16(xmlElement2.GetAttribute("Y"));
            short iZ = XmlConvert.ToInt16(xmlElement2.GetAttribute("Z"));
            short iHue = XmlConvert.ToInt16(xmlElement2.GetAttribute("Hue"));
            StaticCell staticCell = new StaticCell(iTileID, checked ((byte) unchecked ((int) num1 % 8)), checked ((byte) unchecked ((int) num2 % 8)), iZ, iHue);
            StaticMap[(int) (short) ((int) num1 >> 3), (int) (short) ((int) num2 >> 3)].Add((object) staticCell, (string) null, (object) null, (object) null);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            ((IDisposable) enumerator).Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ("Can not find:" + iFilename), MsgBoxStyle.OKOnly, (object) null);
        ProjectData.ClearProjectError();
      }
    }

    public void ProcessDirectory(Collection[,] StaticMap, string targetDirectory)
    {
      string[] files = Directory.GetFiles(targetDirectory, "*.xml");
      int index1 = 0;
      while (index1 < files.Length)
      {
        string iFilename = files[index1];
        this.Load(StaticMap, iFilename);
        checked { ++index1; }
      }
      string[] directories = Directory.GetDirectories(targetDirectory);
      int index2 = 0;
      while (index2 < directories.Length)
      {
        string targetDirectory1 = directories[index2];
        this.ProcessDirectory(StaticMap, targetDirectory1);
        checked { ++index2; }
      }
    }
  }
}
