// Decompiled with JetBrains decompiler
// Type: Ultima.LandData
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

namespace Ultima
{
  public struct LandData
  {
    private string m_Name;
    private TileFlag m_Flags;

    public string Name
    {
      get
      {
        return this.m_Name;
      }
    }

    public TileFlag Flags
    {
      get
      {
        return this.m_Flags;
      }
    }

    public LandData(string name, TileFlag flags)
    {
      this.m_Name = name;
      this.m_Flags = flags;
    }
  }
}
