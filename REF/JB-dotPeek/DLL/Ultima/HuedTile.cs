// Decompiled with JetBrains decompiler
// Type: Ultima.HuedTile
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System.Runtime.InteropServices;

namespace Ultima
{
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  public struct HuedTile
  {
    internal short m_ID;
    internal short m_Hue;
    internal sbyte m_Z;

    public int ID
    {
      get
      {
        return (int) this.m_ID;
      }
    }

    public int Hue
    {
      get
      {
        return (int) this.m_Hue;
      }
    }

    public int Z
    {
      get
      {
        return (int) this.m_Z;
      }
      set
      {
        this.m_Z = (sbyte) value;
      }
    }

    public HuedTile(short id, short hue, sbyte z)
    {
      this.m_ID = id;
      this.m_Hue = hue;
      this.m_Z = z;
    }

    public void Set(short id, short hue, sbyte z)
    {
      this.m_ID = id;
      this.m_Hue = hue;
      this.m_Z = z;
    }
  }
}
