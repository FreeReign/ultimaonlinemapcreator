// Decompiled with JetBrains decompiler
// Type: Transition.MapCell
// Assembly: Transition, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: D3B0804F-08F3-42BB-B2B3-B2AAA4B5AE51
// Assembly location: W:\JetBrains\UOLandscaper\Transition.dll

using System;
using System.IO;

namespace Transition
{
  public class MapCell
  {
    private byte m_GroupID;
    private short m_TileID;
    private short m_Alt;

    public byte GroupID
    {
      get
      {
        return this.m_GroupID;
      }
    }

    public short TileID
    {
      get
      {
        return this.m_TileID;
      }
      set
      {
        this.m_TileID = value;
      }
    }

    public short AltID
    {
      get
      {
        return this.m_Alt;
      }
      set
      {
        this.m_Alt = value;
      }
    }

    public MapCell(byte i_Terrian, short i_Alt)
    {
      this.m_GroupID = i_Terrian;
      this.m_TileID = (short) 0;
      this.m_Alt = i_Alt;
    }

    public void ChangeAltID(short AltMOD)
    {
      this.m_Alt = checked ((short) unchecked ((int) this.m_Alt + (int) AltMOD));
    }

    public void WriteMapMul(BinaryWriter i_MapFile)
    {
      i_MapFile.Write(this.m_TileID);
      if ((int) this.m_Alt <= -127)
        this.m_Alt = (short) -127;
      if ((int) this.m_Alt >= (int) sbyte.MaxValue)
        this.m_Alt = (short) sbyte.MaxValue;
      sbyte num = Convert.ToSByte(this.m_Alt);
      i_MapFile.Write(num);
    }
  }
}
