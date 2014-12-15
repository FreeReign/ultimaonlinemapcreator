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
			this.m_Hue = 0;
			this.m_TileID = iTileID;
			this.m_X = iX;
			this.m_Y = iY;
			this.m_Z = Convert.ToSByte(iZ);
		}
		public StaticCell(short iTileID, byte iX, byte iY, short iZ, short iHue)
		{
			this.m_Hue = 0;
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
			catch (Exception expr_45)
			{
				ProjectData.SetProjectError(expr_45);
				Interaction.MsgBox(string.Format("Error [{0}] X:{1} Y:{2} Z:{3} Hue:{4}", new object[]
				{
					this.m_TileID,
					this.m_X,
					this.m_Y,
					this.m_Z,
					this.m_Hue
				}), MsgBoxStyle.OkOnly, null);
				ProjectData.ClearProjectError();
			}
		}
	}
}
