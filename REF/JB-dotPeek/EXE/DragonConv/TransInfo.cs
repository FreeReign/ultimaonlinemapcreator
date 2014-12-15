// Decompiled with JetBrains decompiler
// Type: DragonConv.TransInfo
// Assembly: DragonConv, Version=1.0.1819.29268, Culture=neutral, PublicKeyToken=null
// MVID: BA7AE34F-ABD8-4700-AE28-2ED5A239CB08
// Assembly location: W:\JetBrains\UOLandscaper\DragonConv.exe

using System.Xml;

namespace DragonConv
{
  public class TransInfo
  {
    private string m_Description;
    private string m_Location;

    public string Location
    {
      get
      {
        return this.m_Location;
      }
      set
      {
        this.m_Location = value;
      }
    }

    public TransInfo(XmlElement iElement)
    {
      this.m_Description = iElement.GetAttribute("Description");
      this.m_Location = iElement.GetAttribute("Location");
    }

    public override string ToString()
    {
      return string.Format("{0}", (object) this.m_Description);
    }
  }
}
