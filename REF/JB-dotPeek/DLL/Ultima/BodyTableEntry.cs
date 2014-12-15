// Decompiled with JetBrains decompiler
// Type: Ultima.BodyTableEntry
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

namespace Ultima
{
  public class BodyTableEntry
  {
    public int m_OldID;
    public int m_NewID;
    public int m_NewHue;

    public BodyTableEntry(int oldID, int newID, int newHue)
    {
      this.m_OldID = oldID;
      this.m_NewID = newID;
      this.m_NewHue = newHue;
    }
  }
}
