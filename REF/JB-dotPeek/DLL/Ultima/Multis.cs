// Decompiled with JetBrains decompiler
// Type: Ultima.Multis
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System.IO;

namespace Ultima
{
  public class Multis
  {
    private static MultiComponentList[] m_Components = new MultiComponentList[16384];
    private static FileIndex m_FileIndex = new FileIndex("Multi.idx", "Multi.mul", 16384, 14);

    public static MultiComponentList[] Cache
    {
      get
      {
        return Multis.m_Components;
      }
    }

    public static FileIndex FileIndex
    {
      get
      {
        return Multis.m_FileIndex;
      }
    }

    public static MultiComponentList GetComponents(int index)
    {
      index &= 16383;
      MultiComponentList multiComponentList;
      if (index >= 0 && index < Multis.m_Components.Length)
      {
        multiComponentList = Multis.m_Components[index];
        if (multiComponentList == null)
          Multis.m_Components[index] = multiComponentList = Multis.Load(index);
      }
      else
        multiComponentList = MultiComponentList.Empty;
      return multiComponentList;
    }

    public static MultiComponentList Load(int index)
    {
      try
      {
        int length;
        int extra;
        bool patched;
        Stream input = Multis.m_FileIndex.Seek(index, out length, out extra, out patched);
        if (input == null)
          return MultiComponentList.Empty;
        else
          return new MultiComponentList(new BinaryReader(input), length / 12);
      }
      catch
      {
        return MultiComponentList.Empty;
      }
    }
  }
}
