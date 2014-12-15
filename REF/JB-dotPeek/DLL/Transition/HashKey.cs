// Decompiled with JetBrains decompiler
// Type: Transition.HashKey
// Assembly: Transition, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: D3B0804F-08F3-42BB-B2B3-B2AAA4B5AE51
// Assembly location: W:\JetBrains\UOLandscaper\Transition.dll

using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Transition
{
  public class HashKey
  {
    private byte m_Key;

    public byte Key
    {
      get
      {
        return this.m_Key;
      }
      set
      {
        this.m_Key = value;
      }
    }

    public HashKey()
    {
      this.m_Key = (byte) 0;
    }

    public HashKey(int Key)
    {
      this.m_Key = Convert.ToByte(Key);
    }

    public HashKey(byte Key)
    {
      this.m_Key = Key;
    }

    public HashKey(string Key)
    {
      this.m_Key = ByteType.FromString("&H" + Key);
    }

    public override string ToString()
    {
      return string.Format("{0:X2}", (object) this.m_Key);
    }
  }
}
