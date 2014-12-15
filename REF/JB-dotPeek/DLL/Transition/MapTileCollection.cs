// Decompiled with JetBrains decompiler
// Type: Transition.MapTileCollection
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
  public class MapTileCollection : CollectionBase
  {
    public MapTile this[int index]
    {
      get
      {
        return (MapTile) this.List[index];
      }
      set
      {
        this.List[index] = (object) value;
      }
    }

    public MapTile RandomTile
    {
      get
      {
        return (MapTile) this.List[checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * (float) checked (this.List.Count - 1))))];
      }
    }

    public void Add(MapTile Value)
    {
      this.InnerList.Add((object) Value);
    }

    public void Remove(MapTile Value)
    {
      this.InnerList.Remove((object) Value);
    }

    public void Save(XmlTextWriter xmlInfo)
    {
      ((XmlWriter) xmlInfo).WriteStartElement("MapTiles");
      try
      {
        foreach (MapTile mapTile in this.InnerList)
          mapTile.Save(xmlInfo);
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
        foreach (XmlElement xmlElement in xmlInfo.SelectNodes("MapTiles"))
        {
          try
          {
            foreach (XmlElement xmlInfo1 in xmlElement.SelectNodes("MapTile"))
              this.InnerList.Add((object) new MapTile(xmlInfo1));
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
        foreach (MapTile mapTile in this.InnerList)
          iList.Items.Add((object) mapTile);
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
