// Decompiled with JetBrains decompiler
// Type: Ultima.StringEntry
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

namespace Ultima
{
  public class StringEntry
  {
    private int m_Number;
    private string m_Text;

    public int Number
    {
      get
      {
        return this.m_Number;
      }
    }

    public string Text
    {
      get
      {
        return this.m_Text;
      }
    }

    public StringEntry(int number, string text)
    {
      this.m_Number = number;
      this.m_Text = text;
    }
  }
}
