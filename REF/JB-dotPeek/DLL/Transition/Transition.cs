// Decompiled with JetBrains decompiler
// Type: Transition.Transition
// Assembly: Transition, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: D3B0804F-08F3-42BB-B2B3-B2AAA4B5AE51
// Assembly location: W:\JetBrains\UOLandscaper\Transition.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.Xml;
using Terrain;
using Ultima;

namespace Transition
{
  public class Transition
  {
    private string m_Description;
    private HashKeyCollection m_HashKey;
    private StaticTileCollection m_StaticTiles;
    private MapTileCollection m_MapTiles;
    private RandomStatics m_RandomTiles;
    private string m_File;

    public string File
    {
      get
      {
        return this.m_File;
      }
      set
      {
        this.m_File = value;
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

    public string HashKey
    {
      get
      {
        return this.m_HashKey.ToString();
      }
      set
      {
        byte num = (byte) 0;
        do
        {
          this.m_HashKey.Add(new HashKey(Strings.Mid(value, checked ((int) num * 2 + 1), 2)));
          ++num;
        }
        while ((int) num <= 8);
      }
    }

    public MapTileCollection GetMapTiles
    {
      get
      {
        return this.m_MapTiles;
      }
      set
      {
        this.m_MapTiles = value;
      }
    }

    public StaticTileCollection GetStaticTiles
    {
      get
      {
        return this.m_StaticTiles;
      }
      set
      {
        this.m_StaticTiles = value;
      }
    }

    public HashKeyCollection GetHaskKeyTable
    {
      get
      {
        return this.m_HashKey;
      }
    }

    public Transition(XmlElement xmlInfo)
    {
      this.m_HashKey = new HashKeyCollection();
      this.m_StaticTiles = new StaticTileCollection();
      this.m_MapTiles = new MapTileCollection();
      this.m_RandomTiles = (RandomStatics) null;
      this.m_File = (string) null;
      this.m_Description = xmlInfo.GetAttribute("Description");
      this.m_HashKey.AddHashKey(xmlInfo.GetAttribute("HashKey"));
      if (StringType.StrCmp(xmlInfo.GetAttribute("File"), string.Empty, false) != 0)
      {
        this.m_RandomTiles = new RandomStatics(xmlInfo.GetAttribute("File"));
        this.m_File = xmlInfo.GetAttribute("File");
      }
      this.m_MapTiles.Load(xmlInfo);
      this.m_StaticTiles.Load(xmlInfo);
    }

    public Transition()
    {
      this.m_HashKey = new HashKeyCollection();
      this.m_StaticTiles = new StaticTileCollection();
      this.m_MapTiles = new MapTileCollection();
      this.m_RandomTiles = (RandomStatics) null;
      this.m_File = (string) null;
      this.m_Description = "<New Transition>";
      this.m_HashKey.Clear();
      byte num = (byte) 0;
      do
      {
        this.m_HashKey.Add(new HashKey());
        ++num;
      }
      while ((int) num <= 8);
    }

    public Transition(string iDescription, string iHashKey, MapTileCollection iMapTiles, StaticTileCollection iStaticTiles)
    {
      this.m_HashKey = new HashKeyCollection();
      this.m_StaticTiles = new StaticTileCollection();
      this.m_MapTiles = new MapTileCollection();
      this.m_RandomTiles = (RandomStatics) null;
      this.m_File = (string) null;
      this.m_Description = iDescription;
      this.m_HashKey.AddHashKey(iHashKey);
      try
      {
        foreach (MapTile mapTile in (CollectionBase) iMapTiles)
          this.m_MapTiles.Add(mapTile);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
      try
      {
        foreach (StaticTile staticTile in (CollectionBase) iStaticTiles)
          this.m_StaticTiles.Add(staticTile);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
    }

    public Transition(string iDescription, ClsTerrain iGroupA, ClsTerrain iGroupB, string iHashKey)
    {
      this.m_HashKey = new HashKeyCollection();
      this.m_StaticTiles = new StaticTileCollection();
      this.m_MapTiles = new MapTileCollection();
      this.m_RandomTiles = (RandomStatics) null;
      this.m_File = (string) null;
      this.m_Description = iDescription;
      byte num = (byte) 0;
      do
      {
        string sLeft = Strings.Mid(iHashKey, checked ((int) num + 1), 1);
        if (StringType.StrCmp(sLeft, "A", false) == 0)
          this.m_HashKey.Add(new HashKey(iGroupA.GroupID));
        else if (StringType.StrCmp(sLeft, "B", false) == 0)
          this.m_HashKey.Add(new HashKey(iGroupB.GroupID));
        ++num;
      }
      while ((int) num <= 8);
    }

    public Transition(string iDescription, string iHashKey, ClsTerrain iGroupA, ClsTerrain iGroupB, MapTileCollection iMapTiles, StaticTileCollection iStaticTiles)
    {
      this.m_HashKey = new HashKeyCollection();
      this.m_StaticTiles = new StaticTileCollection();
      this.m_MapTiles = new MapTileCollection();
      this.m_RandomTiles = (RandomStatics) null;
      this.m_File = (string) null;
      this.m_Description = iDescription;
      byte num = (byte) 0;
      do
      {
        string sLeft = Strings.Mid(iHashKey, checked ((int) num + 1), 1);
        if (StringType.StrCmp(sLeft, "A", false) == 0)
          this.m_HashKey.Add(new HashKey(iGroupA.GroupID));
        else if (StringType.StrCmp(sLeft, "B", false) == 0)
          this.m_HashKey.Add(new HashKey(iGroupB.GroupID));
        ++num;
      }
      while ((int) num <= 8);
      if (iMapTiles != null)
      {
        try
        {
          foreach (MapTile mapTile in (CollectionBase) iMapTiles)
            this.m_MapTiles.Add(mapTile);
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            ((IDisposable) enumerator).Dispose();
        }
      }
      if (iStaticTiles == null)
        return;
      try
      {
        foreach (StaticTile staticTile in (CollectionBase) iStaticTiles)
          this.m_StaticTiles.Add(staticTile);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
    }

    public Transition(string iDescription, ClsTerrain iGroupA, ClsTerrain iGroupB, ClsTerrain iGroupC, string iHashKey)
    {
      this.m_HashKey = new HashKeyCollection();
      this.m_StaticTiles = new StaticTileCollection();
      this.m_MapTiles = new MapTileCollection();
      this.m_RandomTiles = (RandomStatics) null;
      this.m_File = (string) null;
      this.m_Description = iDescription;
      byte num = (byte) 0;
      do
      {
        string sLeft = Strings.Mid(iHashKey, checked ((int) num + 1), 1);
        if (StringType.StrCmp(sLeft, "A", false) == 0)
          this.m_HashKey.Add(new HashKey(iGroupA.GroupID));
        else if (StringType.StrCmp(sLeft, "B", false) == 0)
          this.m_HashKey.Add(new HashKey(iGroupB.GroupID));
        else if (StringType.StrCmp(sLeft, "C", false) == 0)
          this.m_HashKey.Add(new HashKey(iGroupC.GroupID));
        ++num;
      }
      while ((int) num <= 8);
    }

    public Transition(string iDescription, string iHashKey)
    {
      this.m_HashKey = new HashKeyCollection();
      this.m_StaticTiles = new StaticTileCollection();
      this.m_MapTiles = new MapTileCollection();
      this.m_RandomTiles = (RandomStatics) null;
      this.m_File = (string) null;
      this.m_Description = iDescription;
      byte num = (byte) 0;
      do
      {
        this.m_HashKey.Add(new HashKey(Strings.Mid(iHashKey, checked ((int) num * 2 + 1), 2)));
        ++num;
      }
      while ((int) num <= 8);
    }

    public Transition(string iDescription, ClsTerrain iGroupA, ClsTerrain iGroupB, string iHashKey, MapTile iMapTile)
    {
      this.m_HashKey = new HashKeyCollection();
      this.m_StaticTiles = new StaticTileCollection();
      this.m_MapTiles = new MapTileCollection();
      this.m_RandomTiles = (RandomStatics) null;
      this.m_File = (string) null;
      this.m_Description = iDescription;
      byte num = (byte) 0;
      do
      {
        string sLeft = Strings.Mid(iHashKey, checked ((int) num + 1), 1);
        if (StringType.StrCmp(sLeft, "A", false) == 0)
          this.m_HashKey.Add(new HashKey(iGroupA.GroupID));
        else if (StringType.StrCmp(sLeft, "B", false) == 0)
          this.m_HashKey.Add(new HashKey(iGroupB.GroupID));
        ++num;
      }
      while ((int) num <= 8);
      this.m_MapTiles.Add(iMapTile);
    }

    public virtual MapTile GetRandomMapTile()
    {
      MapTile randomTile;
      if (this.GetMapTiles.Count > 0)
        randomTile = this.m_MapTiles.RandomTile;
      return randomTile;
    }

    public virtual void GetRandomStaticTiles(short X, short Y, short Z, Collection[,] StaticMap, bool iRandom)
    {
      if (this.m_StaticTiles.Count > 0)
      {
        StaticTile randomTile = this.m_StaticTiles.RandomTile;
        StaticMap[(int) (short) ((int) X >> 3), (int) (short) ((int) Y >> 3)].Add((object) new StaticCell(randomTile.TileID, checked ((byte) unchecked ((int) X % 8)), checked ((byte) unchecked ((int) Y % 8)), checked ((short) unchecked ((int) Z + (int) randomTile.AltIDMod))), (string) null, (object) null, (object) null);
      }
      if (!iRandom || this.m_RandomTiles == null)
        return;
      this.m_RandomTiles.GetRandomStatic(X, Y, Z, StaticMap);
    }

    public byte get_GetKey(int Index)
    {
      return this.m_HashKey[Index].Key;
    }

    public void Clone(ClsTerrain iGroupA, ClsTerrain iGroupB)
    {
      this.m_Description = this.m_Description.Replace(iGroupA.Name, iGroupB.Name);
      int index = 0;
      do
      {
        if ((int) this.m_HashKey[index].Key == iGroupA.GroupID)
          this.m_HashKey[index].Key = checked ((byte) iGroupB.GroupID);
        checked { ++index; }
      }
      while (index <= 8);
    }

    public void SetHashKey(int iKey, byte iKeyHash)
    {
      this.m_HashKey[iKey].Key = iKeyHash;
    }

    public void AddMapTile(short TileID, short AltIDMod)
    {
      this.m_MapTiles.Add(new MapTile(TileID, AltIDMod));
    }

    public void RemoveMapTile(MapTile iMapTile)
    {
      this.m_MapTiles.Remove(iMapTile);
    }

    public void AddStaticTile(short TileID, short AltIDMod)
    {
      this.m_StaticTiles.Add(new StaticTile(TileID, AltIDMod));
    }

    public void RemoveStaticTile(StaticTile iStaticTile)
    {
      this.m_StaticTiles.Remove(iStaticTile);
    }

    public override string ToString()
    {
      return string.Format("[{0}] {1}", (object) this.m_HashKey.ToString(), (object) this.m_Description);
    }

    public Bitmap TransitionImage(ClsTerrainTable iTerrain)
    {
      Bitmap bitmap = new Bitmap(400, 168, PixelFormat.Format16bppRgb555);
      Graphics graphics1 = Graphics.FromImage((Image) bitmap);
      Font font = new Font("Arial", 10f);
      Graphics graphics2 = graphics1;
      graphics2.Clear(Color.White);
      Graphics graphics3 = graphics2;
      Bitmap land1 = Art.GetLand((int) iTerrain.get_TerrianGroup(0).TileID);
      Point point1 = new Point(61, 15);
      Point point2 = point1;
      graphics3.DrawImage((Image) land1, point2);
      Graphics graphics4 = graphics2;
      Bitmap land2 = Art.GetLand((int) iTerrain.get_TerrianGroup(1).TileID);
      point1 = new Point(84, 38);
      Point point3 = point1;
      graphics4.DrawImage((Image) land2, point3);
      Graphics graphics5 = graphics2;
      Bitmap land3 = Art.GetLand((int) iTerrain.get_TerrianGroup(2).TileID);
      point1 = new Point(107, 61);
      Point point4 = point1;
      graphics5.DrawImage((Image) land3, point4);
      Graphics graphics6 = graphics2;
      Bitmap land4 = Art.GetLand((int) iTerrain.get_TerrianGroup(3).TileID);
      point1 = new Point(38, 38);
      Point point5 = point1;
      graphics6.DrawImage((Image) land4, point5);
      Graphics graphics7 = graphics2;
      Bitmap land5 = Art.GetLand((int) iTerrain.get_TerrianGroup(4).TileID);
      point1 = new Point(61, 61);
      Point point6 = point1;
      graphics7.DrawImage((Image) land5, point6);
      Graphics graphics8 = graphics2;
      Bitmap land6 = Art.GetLand((int) iTerrain.get_TerrianGroup(5).TileID);
      point1 = new Point(84, 84);
      Point point7 = point1;
      graphics8.DrawImage((Image) land6, point7);
      Graphics graphics9 = graphics2;
      Bitmap land7 = Art.GetLand((int) iTerrain.get_TerrianGroup(6).TileID);
      point1 = new Point(15, 61);
      Point point8 = point1;
      graphics9.DrawImage((Image) land7, point8);
      Graphics graphics10 = graphics2;
      Bitmap land8 = Art.GetLand((int) iTerrain.get_TerrianGroup(7).TileID);
      point1 = new Point(38, 84);
      Point point9 = point1;
      graphics10.DrawImage((Image) land8, point9);
      Graphics graphics11 = graphics2;
      Bitmap land9 = Art.GetLand((int) iTerrain.get_TerrianGroup(8).TileID);
      point1 = new Point(61, 107);
      Point point10 = point1;
      graphics11.DrawImage((Image) land9, point10);
      graphics2.DrawString(this.ToString(), font, Brushes.Black, 151f, 2f);
      graphics1.Dispose();
      return bitmap;
    }

    public void Save(XmlTextWriter xmlInfo)
    {
      ((XmlWriter) xmlInfo).WriteStartElement("TransInfo");
      xmlInfo.WriteAttributeString("Description", this.m_Description);
      xmlInfo.WriteAttributeString("HashKey", this.m_HashKey.ToString());
      if (this.m_File != null)
        xmlInfo.WriteAttributeString("File", this.m_File);
      this.m_MapTiles.Save(xmlInfo);
      this.m_StaticTiles.Save(xmlInfo);
      xmlInfo.WriteEndElement();
    }
  }
}
