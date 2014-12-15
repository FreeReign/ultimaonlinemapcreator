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

		public HashKeyCollection GetHaskKeyTable
		{
			get
			{
				return this.m_HashKey;
			}
		}

		public byte GetKey(int Index)
		{
			get
			{
				return this.m_HashKey[Index].Key;
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

		public string HashKey
		{
			get
			{
				return this.m_HashKey.ToString();
			}
			set
			{
				byte num = 0;
				do
				{
					this.m_HashKey.Add(new Transition.HashKey(Strings.Mid(value, checked(checked(num * 2) + 1), 2)));
					num = checked((byte)(num + 1));
				}
				while (num <= 8);
			}
		}

		public Transition(XmlElement xmlInfo)
		{
			this.m_HashKey = new HashKeyCollection();
			this.m_StaticTiles = new StaticTileCollection();
			this.m_MapTiles = new MapTileCollection();
			this.m_RandomTiles = null;
			this.m_File = null;
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
			this.m_RandomTiles = null;
			this.m_File = null;
			this.m_Description = "<New Transition>";
			this.m_HashKey.Clear();
			byte num = 0;
			do
			{
				this.m_HashKey.Add(new Transition.HashKey());
				num = checked((byte)(num + 1));
			}
			while (num <= 8);
		}

		public Transition(string iDescription, string iHashKey, MapTileCollection iMapTiles, StaticTileCollection iStaticTiles)
		{
			IEnumerator enumerator = null;
			IEnumerator enumerator1 = null;
			this.m_HashKey = new HashKeyCollection();
			this.m_StaticTiles = new StaticTileCollection();
			this.m_MapTiles = new MapTileCollection();
			this.m_RandomTiles = null;
			this.m_File = null;
			this.m_Description = iDescription;
			this.m_HashKey.AddHashKey(iHashKey);
			try
			{
				enumerator1 = iMapTiles.GetEnumerator();
				while (enumerator1.MoveNext())
				{
					MapTile current = (MapTile)enumerator1.Current;
					this.m_MapTiles.Add(current);
				}
			}
			finally
			{
				if (enumerator1 is IDisposable)
				{
					((IDisposable)enumerator1).Dispose();
				}
			}
			try
			{
				enumerator = iStaticTiles.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Transition.StaticTile staticTile = (Transition.StaticTile)enumerator.Current;
					this.m_StaticTiles.Add(staticTile);
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

		public Transition(string iDescription, ClsTerrain iGroupA, ClsTerrain iGroupB, string iHashKey)
		{
			this.m_HashKey = new HashKeyCollection();
			this.m_StaticTiles = new StaticTileCollection();
			this.m_MapTiles = new MapTileCollection();
			this.m_RandomTiles = null;
			this.m_File = null;
			this.m_Description = iDescription;
			byte num = 0;
			do
			{
				string str = Strings.Mid(iHashKey, checked(num + 1), 1);
				if (StringType.StrCmp(str, "A", false) == 0)
				{
					this.m_HashKey.Add(new Transition.HashKey(iGroupA.GroupID));
				}
				else if (StringType.StrCmp(str, "B", false) == 0)
				{
					this.m_HashKey.Add(new Transition.HashKey(iGroupB.GroupID));
				}
				num = checked((byte)(num + 1));
			}
			while (num <= 8);
		}

		public Transition(string iDescription, string iHashKey, ClsTerrain iGroupA, ClsTerrain iGroupB, MapTileCollection iMapTiles, StaticTileCollection iStaticTiles)
		{
			IEnumerator enumerator = null;
			IEnumerator enumerator1 = null;
			this.m_HashKey = new HashKeyCollection();
			this.m_StaticTiles = new StaticTileCollection();
			this.m_MapTiles = new MapTileCollection();
			this.m_RandomTiles = null;
			this.m_File = null;
			this.m_Description = iDescription;
			byte num = 0;
			do
			{
				string str = Strings.Mid(iHashKey, checked(num + 1), 1);
				if (StringType.StrCmp(str, "A", false) == 0)
				{
					this.m_HashKey.Add(new Transition.HashKey(iGroupA.GroupID));
				}
				else if (StringType.StrCmp(str, "B", false) == 0)
				{
					this.m_HashKey.Add(new Transition.HashKey(iGroupB.GroupID));
				}
				num = checked((byte)(num + 1));
			}
			while (num <= 8);
			if (iMapTiles != null)
			{
				try
				{
					enumerator1 = iMapTiles.GetEnumerator();
					while (enumerator1.MoveNext())
					{
						MapTile current = (MapTile)enumerator1.Current;
						this.m_MapTiles.Add(current);
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
			if (iStaticTiles != null)
			{
				try
				{
					enumerator = iStaticTiles.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Transition.StaticTile staticTile = (Transition.StaticTile)enumerator.Current;
						this.m_StaticTiles.Add(staticTile);
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

		public Transition(string iDescription, ClsTerrain iGroupA, ClsTerrain iGroupB, ClsTerrain iGroupC, string iHashKey)
		{
			this.m_HashKey = new HashKeyCollection();
			this.m_StaticTiles = new StaticTileCollection();
			this.m_MapTiles = new MapTileCollection();
			this.m_RandomTiles = null;
			this.m_File = null;
			this.m_Description = iDescription;
			byte num = 0;
			do
			{
				string str = Strings.Mid(iHashKey, checked(num + 1), 1);
				if (StringType.StrCmp(str, "A", false) == 0)
				{
					this.m_HashKey.Add(new Transition.HashKey(iGroupA.GroupID));
				}
				else if (StringType.StrCmp(str, "B", false) == 0)
				{
					this.m_HashKey.Add(new Transition.HashKey(iGroupB.GroupID));
				}
				else if (StringType.StrCmp(str, "C", false) == 0)
				{
					this.m_HashKey.Add(new Transition.HashKey(iGroupC.GroupID));
				}
				num = checked((byte)(num + 1));
			}
			while (num <= 8);
		}

		public Transition(string iDescription, string iHashKey)
		{
			this.m_HashKey = new HashKeyCollection();
			this.m_StaticTiles = new StaticTileCollection();
			this.m_MapTiles = new MapTileCollection();
			this.m_RandomTiles = null;
			this.m_File = null;
			this.m_Description = iDescription;
			byte num = 0;
			do
			{
				this.m_HashKey.Add(new Transition.HashKey(Strings.Mid(iHashKey, checked(checked(num * 2) + 1), 2)));
				num = checked((byte)(num + 1));
			}
			while (num <= 8);
		}

		public Transition(string iDescription, ClsTerrain iGroupA, ClsTerrain iGroupB, string iHashKey, MapTile iMapTile)
		{
			this.m_HashKey = new HashKeyCollection();
			this.m_StaticTiles = new StaticTileCollection();
			this.m_MapTiles = new MapTileCollection();
			this.m_RandomTiles = null;
			this.m_File = null;
			this.m_Description = iDescription;
			byte num = 0;
			do
			{
				string str = Strings.Mid(iHashKey, checked(num + 1), 1);
				if (StringType.StrCmp(str, "A", false) == 0)
				{
					this.m_HashKey.Add(new Transition.HashKey(iGroupA.GroupID));
				}
				else if (StringType.StrCmp(str, "B", false) == 0)
				{
					this.m_HashKey.Add(new Transition.HashKey(iGroupB.GroupID));
				}
				num = checked((byte)(num + 1));
			}
			while (num <= 8);
			this.m_MapTiles.Add(iMapTile);
		}

		public void AddMapTile(short TileID, short AltIDMod)
		{
			this.m_MapTiles.Add(new MapTile(TileID, AltIDMod));
		}

		public void AddStaticTile(short TileID, short AltIDMod)
		{
			this.m_StaticTiles.Add(new Transition.StaticTile(TileID, AltIDMod));
		}

		public void Clone(ClsTerrain iGroupA, ClsTerrain iGroupB)
		{
			this.m_Description = this.m_Description.Replace(iGroupA.Name, iGroupB.Name);
			int groupID = 0;
			do
			{
				if (this.m_HashKey[groupID].Key == iGroupA.GroupID)
				{
					this.m_HashKey[groupID].Key = checked((byte)iGroupB.GroupID);
				}
				groupID++;
			}
			while (groupID <= 8);
		}

		public virtual MapTile GetRandomMapTile()
		{
			MapTile randomTile = null;
			if (this.GetMapTiles.Count > 0)
			{
				randomTile = this.m_MapTiles.RandomTile;
			}
			return randomTile;
		}

		public virtual void GetRandomStaticTiles(short X, short Y, short Z, Collection[,] StaticMap, bool iRandom)
		{
			if (this.m_StaticTiles.Count > 0)
			{
				Transition.StaticTile randomTile = this.m_StaticTiles.RandomTile;
				StaticMap[(short)(X >> 3), (short)(Y >> 3)].Add(new StaticCell(randomTile.TileID, checked((byte)(X % 8)), checked((byte)(Y % 8)), checked((short)(Z + randomTile.AltIDMod))), null, null, null);
				randomTile = null;
			}
			if (iRandom)
			{
				if (this.m_RandomTiles != null)
				{
					this.m_RandomTiles.GetRandomStatic(X, Y, Z, StaticMap);
				}
			}
		}

		public void RemoveMapTile(MapTile iMapTile)
		{
			this.m_MapTiles.Remove(iMapTile);
		}

		public void RemoveStaticTile(Transition.StaticTile iStaticTile)
		{
			this.m_StaticTiles.Remove(iStaticTile);
		}

		public void Save(XmlTextWriter xmlInfo)
		{
			xmlInfo.WriteStartElement("TransInfo");
			xmlInfo.WriteAttributeString("Description", this.m_Description);
			xmlInfo.WriteAttributeString("HashKey", this.m_HashKey.ToString());
			if (this.m_File != null)
			{
				xmlInfo.WriteAttributeString("File", this.m_File);
			}
			this.m_MapTiles.Save(xmlInfo);
			this.m_StaticTiles.Save(xmlInfo);
			xmlInfo.WriteEndElement();
		}

		public void SetHashKey(int iKey, byte iKeyHash)
		{
			this.m_HashKey[iKey].Key = iKeyHash;
		}

		public override string ToString()
		{
			string str = string.Format("[{0}] {1}", this.m_HashKey.ToString(), this.m_Description);
			return str;
		}

		public Bitmap TransitionImage(ClsTerrainTable iTerrain)
		{
			Bitmap bitmap = new Bitmap(400, 168, PixelFormat.Format16bppRgb555);
			Graphics graphic = Graphics.FromImage(bitmap);
			Font font = new Font("Arial", 10f);
			Graphics graphic1 = graphic;
			graphic1.Clear(Color.White);
			Bitmap land = Art.GetLand(iTerrain[0].TileID);
			Point point = new Point(61, 15);
			graphic1.DrawImage(land, point);
			Bitmap land1 = Art.GetLand(iTerrain[1].TileID);
			point = new Point(84, 38);
			graphic1.DrawImage(land1, point);
			Bitmap bitmap1 = Art.GetLand(iTerrain[2].TileID);
			point = new Point(107, 61);
			graphic1.DrawImage(bitmap1, point);
			Bitmap land2 = Art.GetLand(iTerrain[3].TileID);
			point = new Point(38, 38);
			graphic1.DrawImage(land2, point);
			Bitmap bitmap2 = Art.GetLand(iTerrain[4].TileID);
			point = new Point(61, 61);
			graphic1.DrawImage(bitmap2, point);
			Bitmap land3 = Art.GetLand(iTerrain[5].TileID);
			point = new Point(84, 84);
			graphic1.DrawImage(land3, point);
			Bitmap bitmap3 = Art.GetLand(iTerrain[6].TileID);
			point = new Point(15, 61);
			graphic1.DrawImage(bitmap3, point);
			Bitmap land4 = Art.GetLand(iTerrain[7].TileID);
			point = new Point(38, 84);
			graphic1.DrawImage(land4, point);
			Bitmap bitmap4 = Art.GetLand(iTerrain[8].TileID);
			point = new Point(61, 107);
			graphic1.DrawImage(bitmap4, point);
			graphic1.DrawString(this.ToString(), font, Brushes.Black, 151f, 2f);
			graphic1 = null;
			graphic.Dispose();
			return bitmap;
		}
	}
}