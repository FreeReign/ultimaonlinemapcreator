// Decompiled with JetBrains decompiler
// Type: Transition.StaticCell
// Assembly: Transition, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: D3B0804F-08F3-42BB-B2B3-B2AAA4B5AE51
// Assembly location: W:\JetBrains\UOLandscaper\Transition.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;

namespace Transition
{
  public class StaticCell
  {
    private short m_TileID;
    private byte m_X;
    private byte m_Y;
    private sbyte m_Z;
    private short m_Hue;

    public StaticCell(short iTileID, byte iX, byte iY, short iZ)
    {
      this.m_Hue = (short) 0;
      this.m_TileID = iTileID;
      this.m_X = iX;
      this.m_Y = iY;
      this.m_Z = Convert.ToSByte(iZ);
    }

    public StaticCell(short iTileID, byte iX, byte iY, short iZ, short iHue)
    {
      this.m_Hue = (short) 0;
      this.m_TileID = iTileID;
      this.m_X = iX;
      this.m_Y = iY;
      this.m_Z = Convert.ToSByte(iZ);
      this.m_Hue = iHue;
    }

    public void Write(BinaryWriter i_StaticFile)
    {
      try
      {
        i_StaticFile.Write(this.m_TileID);
        i_StaticFile.Write(this.m_X);
        i_StaticFile.Write(this.m_Y);
        i_StaticFile.Write(this.m_Z);
        i_StaticFile.Write(this.m_Hue);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) string.Format("Error [{0}] X:{1} Y:{2} Z:{3} Hue:{4}", (object) this.m_TileID, (object) this.m_X, (object) this.m_Y, (object) this.m_Z, (object) this.m_Hue), MsgBoxStyle.OKOnly, (object) null);
        ProjectData.ClearProjectError();
      }
    }
  }
}
