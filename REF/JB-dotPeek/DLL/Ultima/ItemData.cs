// Decompiled with JetBrains decompiler
// Type: Ultima.ItemData
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

namespace Ultima
{
  public struct ItemData
  {
    internal string m_Name;
    internal TileFlag m_Flags;
    internal byte m_Weight;
    internal byte m_Quality;
    internal byte m_Quantity;
    internal byte m_Value;
    internal byte m_Height;
    internal short m_Animation;

    public string Name
    {
      get
      {
        return this.m_Name;
      }
    }

    public int Animation
    {
      get
      {
        return (int) this.m_Animation;
      }
    }

    public TileFlag Flags
    {
      get
      {
        return this.m_Flags;
      }
    }

    public bool Background
    {
      get
      {
        return (this.m_Flags & TileFlag.Background) != TileFlag.None;
      }
    }

    public bool Bridge
    {
      get
      {
        return (this.m_Flags & TileFlag.Bridge) != TileFlag.None;
      }
    }

    public bool Impassable
    {
      get
      {
        return (this.m_Flags & TileFlag.Impassable) != TileFlag.None;
      }
    }

    public bool Surface
    {
      get
      {
        return (this.m_Flags & TileFlag.Surface) != TileFlag.None;
      }
    }

    public int Weight
    {
      get
      {
        return (int) this.m_Weight;
      }
    }

    public int Quality
    {
      get
      {
        return (int) this.m_Quality;
      }
    }

    public int Quantity
    {
      get
      {
        return (int) this.m_Quantity;
      }
    }

    public int Value
    {
      get
      {
        return (int) this.m_Value;
      }
    }

    public int Height
    {
      get
      {
        return (int) this.m_Height;
      }
    }

    public int CalcHeight
    {
      get
      {
        if ((this.m_Flags & TileFlag.Bridge) != TileFlag.None)
          return (int) this.m_Height / 2;
        else
          return (int) this.m_Height;
      }
    }

    public ItemData(string name, TileFlag flags, int weight, int quality, int quantity, int value, int height, int anim)
    {
      this.m_Name = name;
      this.m_Flags = flags;
      this.m_Weight = (byte) weight;
      this.m_Quality = (byte) quality;
      this.m_Quantity = (byte) quantity;
      this.m_Value = (byte) value;
      this.m_Height = (byte) height;
      this.m_Animation = (short) anim;
    }
  }
}
