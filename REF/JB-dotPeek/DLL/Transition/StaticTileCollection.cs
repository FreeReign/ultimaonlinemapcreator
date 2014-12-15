// Decompiled with JetBrains decompiler
// Type: Transition.StaticTileCollection
// Assembly: Transition, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: D3B0804F-08F3-42BB-B2B3-B2AAA4B5AE51
// Assembly location: W:\JetBrains\UOLandscaper\Transition.dll

using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Windows.Forms;
using System.Xml;

namespace Transition
{
  public class StaticTileCollection : CollectionBase
  {
    public StaticTile this[int index]
    {
      get
      {
        return (StaticTile) this.List[index];
      }
      set
      {
        this.List[index] = (object) value;
      }
    }

    public StaticTile RandomTile
    {
      get
      {
        return (StaticTile) this.List[checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * (float) checked (this.List.Count - 1))))];
      }
    }

    public void Add(StaticTile Value)
    {
      this.InnerList.Add((object) Value);
    }

    public void Remove(StaticTile Value)
    {
      this.InnerList.Remove((object) Value);
    }

    public void Save(XmlTextWriter xmlInfo)
    {
      ((XmlWriter) xmlInfo).WriteStartElement("StaticTiles");
      try
      {
        foreach (StaticTile staticTile in this.InnerList)
          staticTile.Save(xmlInfo);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
      xmlInfo.WriteEndElement();
    }

    public void Load(XmlElement xmlInfo)
    {
      try
      {
        foreach (XmlElement xmlElement in xmlInfo.SelectNodes("StaticTiles"))
        {
          try
          {
            foreach (XmlElement xmlInfo1 in xmlElement.SelectNodes("StaticTile"))
              this.InnerList.Add((object) new StaticTile(xmlInfo1));
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              ((IDisposable) enumerator).Dispose();
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
    }

    public void Display(ListBox iList)
    {
      iList.Items.Clear();
      try
      {
        foreach (StaticTile staticTile in this.InnerList)
          iList.Items.Add((object) staticTile);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
    }
  }
}
