// Decompiled with JetBrains decompiler
// Type: Transition.HashKeyCollection
// Assembly: Transition, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: D3B0804F-08F3-42BB-B2B3-B2AAA4B5AE51
// Assembly location: W:\JetBrains\UOLandscaper\Transition.dll

using Microsoft.VisualBasic;
using System.Collections;

namespace Transition
{
  public class HashKeyCollection : CollectionBase
  {
    public HashKey this[int index]
    {
      get
      {
        return (HashKey) this.List[index];
      }
      set
      {
        this.List[index] = (object) value;
      }
    }

    public void Add(HashKey Value)
    {
      if (this.InnerList.Count > 9)
        return;
      this.InnerList.Add((object) Value);
    }

    public void AddHashKey(string Value)
    {
      this.InnerList.Clear();
      byte num = (byte) 0;
      do
      {
        this.Add(new HashKey(Strings.Mid(Value, checked ((int) num * 2 + 1), 2)));
        ++num;
      }
      while ((int) num <= 8);
    }

    public void Remove(HashKey Value)
    {
      this.InnerList.Remove((object) Value);
    }

    public override string ToString()
    {
      return string.Format("{0:X2}{1:X2}{2:X2}{3:X2}{4:X2}{5:X2}{6:X2}{7:X2}{8:X2}", (object) this[0].Key, (object) this[1].Key, (object) this[2].Key, (object) this[3].Key, (object) this[4].Key, (object) this[5].Key, (object) this[6].Key, (object) this[7].Key, (object) this[8].Key);
    }
  }
}
