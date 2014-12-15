// Decompiled with JetBrains decompiler
// Type: Transition.RandomStaticCollection
// Assembly: Transition, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: D3B0804F-08F3-42BB-B2B3-B2AAA4B5AE51
// Assembly location: W:\JetBrains\UOLandscaper\Transition.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Windows.Forms;
using System.Xml;

namespace Transition
{
  public class RandomStaticCollection : CollectionBase
  {
    private string m_Description;
    private int m_Freq;

    public Collection iCollection
    {
      get
      {
        return (Collection) this.List;
      }
    }

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

    public RandomStatic this[int index]
    {
      get
      {
        return (RandomStatic) this.List[index];
      }
      set
      {
        this.List[index] = (object) value;
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
      this.m_Description = xmlInfo.GetAttribute("Description");
      this.m_Freq = (int) XmlConvert.ToInt16(xmlInfo.GetAttribute("Freq"));
      try
      {
        foreach (XmlElement xmlInfo1 in xmlInfo.SelectNodes("Static"))
          this.InnerList.Add((object) new RandomStatic(xmlInfo1));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
    }

    public void Add(RandomStatic Value)
    {
      this.InnerList.Add((object) Value);
    }

    public void Remove(RandomStatic Value)
    {
      this.InnerList.Remove((object) Value);
    }

    public void Save(XmlTextWriter xmlInfo)
    {
      ((XmlWriter) xmlInfo).WriteStartElement("Statics");
      xmlInfo.WriteAttributeString("Description", this.m_Description);
      xmlInfo.WriteAttributeString("Freq", StringType.FromInteger(this.m_Freq));
      try
      {
        foreach (RandomStatic randomStatic in this.InnerList)
          randomStatic.Save(xmlInfo);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
      xmlInfo.WriteEndElement();
    }

    public void Display(ListBox iList)
    {
      iList.Items.Clear();
      try
      {
        foreach (RandomStatic randomStatic in this.InnerList)
          iList.Items.Add((object) randomStatic);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
    }

    public void RandomStatic(short X, short Y, short Z, Collection[,] StaticMap)
    {
      try
      {
        foreach (RandomStatic randomStatic in this.InnerList)
        {
          StaticCell staticCell = new StaticCell(randomStatic.TileID, checked ((byte) unchecked ((int) checked ((short) unchecked ((int) X + (int) randomStatic.X)) % 8)), checked ((byte) unchecked ((int) checked ((short) unchecked ((int) Y + (int) randomStatic.Y)) % 8)), checked ((short) unchecked ((int) Z + (int) randomStatic.Z)));
          StaticMap[(int) (short) ((int) checked ((short) unchecked ((int) X + (int) randomStatic.X)) >> 3), (int) (short) ((int) checked ((short) unchecked ((int) Y + (int) randomStatic.Y)) >> 3)].Add((object) staticCell, (string) null, (object) null, (object) null);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
    }

    public override string ToString()
    {
      return string.Format("{0} Freq:{1}", (object) this.m_Description, (object) this.m_Freq);
    }
  }
}
