// Decompiled with JetBrains decompiler
// Type: UOMapMake.RoughEdge
// Assembly: UOMapMake, Version=1.0.1819.29268, Culture=neutral, PublicKeyToken=null
// MVID: 6505317C-3933-4E34-800A-F915B4881A03
// Assembly location: W:\JetBrains\UOLandscaper\UOMapMake.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Xml;

namespace UOMapMake
{
  public class RoughEdge
  {
    private Hashtable m_CornerEdge;
    private Hashtable m_LeftEdge;
    private Hashtable m_TopEdge;

    public RoughEdge()
    {
      this.m_CornerEdge = new Hashtable();
      this.m_LeftEdge = new Hashtable();
      this.m_TopEdge = new Hashtable();
      XmlDocument xmlDocument = new XmlDocument();
      try
      {
        string filename = string.Format("{0}Data\\System\\RoughEdge\\Corner.xml", (object) AppDomain.CurrentDomain.BaseDirectory);
        xmlDocument.Load(filename);
        try
        {
          foreach (XmlElement xmlElement in xmlDocument.SelectNodes("//Terrains/Corner"))
          {
            short num = XmlConvert.ToInt16(xmlElement.GetAttribute("TileID"));
            this.m_CornerEdge.Add((object) num, (object) num);
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
        int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.OKOnly, (object) null);
        ProjectData.ClearProjectError();
      }
      try
      {
        string filename = string.Format("{0}Data\\System\\RoughEdge\\Left.xml", (object) AppDomain.CurrentDomain.BaseDirectory);
        xmlDocument.Load(filename);
        try
        {
          foreach (XmlElement xmlElement in xmlDocument.SelectNodes("//Terrains/Left"))
          {
            short num = XmlConvert.ToInt16(xmlElement.GetAttribute("TileID"));
            this.m_LeftEdge.Add((object) num, (object) num);
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
        int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.OKOnly, (object) null);
        ProjectData.ClearProjectError();
      }
      try
      {
        string filename = string.Format("{0}Data\\System\\RoughEdge\\Top.xml", (object) AppDomain.CurrentDomain.BaseDirectory);
        xmlDocument.Load(filename);
        try
        {
          foreach (XmlElement xmlElement in xmlDocument.SelectNodes("//Terrains/Top"))
          {
            short num = XmlConvert.ToInt16(xmlElement.GetAttribute("TileID"));
            this.m_TopEdge.Add((object) num, (object) num);
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
        int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.OKOnly, (object) null);
        ProjectData.ClearProjectError();
      }
    }

    public short CheckCorner(short TileID)
    {
      return this.m_CornerEdge[(object) TileID] == null ? (short) 0 : (short) -5;
    }

    public short CheckLeft(short TileID)
    {
      short num1;
      if (this.m_LeftEdge[(object) TileID] == null)
      {
        num1 = (short) 0;
      }
      else
      {
        VBMath.Randomize();
        float num2 = VBMath.Rnd() * 15f;
        if ((double) num2 == 0.0)
          num1 = (short) -4;
        else if ((double) num2 >= 1.0 && (double) num2 <= 3.0)
          num1 = (short) -3;
        else if ((double) num2 >= 4.0 && (double) num2 <= 8.0)
          num1 = (short) -2;
        else if ((double) num2 == 9.0)
          num1 = (short) -1;
        else if ((double) num2 == 10.0)
          num1 = (short) 0;
        else if ((double) num2 >= 11.0 && (double) num2 <= 13.0)
          num1 = (short) 1;
        else if ((double) num2 == 14.0)
          num1 = (short) 2;
        else if ((double) num2 == 15.0)
          num1 = (short) 3;
      }
      return num1;
    }

    public short CheckTop(short TileID)
    {
      short num1;
      if (this.m_TopEdge[(object) TileID] == null)
      {
        num1 = (short) 0;
      }
      else
      {
        VBMath.Randomize();
        float num2 = VBMath.Rnd() * 15f;
        if ((double) num2 == 0.0)
          num1 = (short) -4;
        else if ((double) num2 >= 1.0 && (double) num2 <= 3.0)
          num1 = (short) -3;
        else if ((double) num2 >= 4.0 && (double) num2 <= 8.0)
          num1 = (short) -2;
        else if ((double) num2 == 9.0)
          num1 = (short) -1;
        else if ((double) num2 == 10.0)
          num1 = (short) 0;
        else if ((double) num2 >= 11.0 && (double) num2 <= 13.0)
          num1 = (short) 1;
        else if ((double) num2 == 14.0)
          num1 = (short) 2;
        else if ((double) num2 == 15.0)
          num1 = (short) 3;
      }
      return num1;
    }
  }
}
