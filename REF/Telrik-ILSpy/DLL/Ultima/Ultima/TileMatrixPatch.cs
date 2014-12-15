using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Ultima
{
	public class TileMatrixPatch
	{
		private int m_LandBlocks;

		private int m_StaticBlocks;

		public int LandBlocks
		{
			get
			{
				return this.m_LandBlocks;
			}
		}

		public int StaticBlocks
		{
			get
			{
				return this.m_StaticBlocks;
			}
		}

		public TileMatrixPatch(TileMatrix matrix, int index)
		{
			object[] objArray = new object[] { index };
			string filePath = Client.GetFilePath("mapdiff{0}.mul", objArray);
			objArray = new object[] { index };
			string str = Client.GetFilePath("mapdiffl{0}.mul", objArray);
			if (filePath != null && str != null)
			{
				this.m_LandBlocks = this.PatchLand(matrix, filePath, str);
			}
			objArray = new object[] { index };
			string filePath1 = Client.GetFilePath("stadiff{0}.mul", objArray);
			objArray = new object[] { index };
			string str1 = Client.GetFilePath("stadiffl{0}.mul", objArray);
			objArray = new object[] { index };
			string filePath2 = Client.GetFilePath("stadiffi{0}.mul", objArray);
			if (filePath1 != null && str1 != null && filePath2 != null)
			{
				this.m_StaticBlocks = this.PatchStatics(matrix, filePath1, str1, filePath2);
			}
		}

		[DllImport("Kernel32", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern unsafe int _lread(IntPtr hFile, void* lpBuffer, int wBytes);

		private int PatchLand(TileMatrix matrix, string dataPath, string indexPath)
		{
			unsafe
			{
				int num;
				using (FileStream fileStream = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					using (FileStream fileStream1 = new FileStream(indexPath, FileMode.Open, FileAccess.Read, FileShare.Read))
					{
						BinaryReader binaryReader = new BinaryReader(fileStream1);
						int length = (int)(binaryReader.BaseStream.Length / (long)4);
						for (int i = 0; i < length; i++)
						{
							int num1 = binaryReader.ReadInt32();
							int blockHeight = num1 / matrix.BlockHeight;
							int blockHeight1 = num1 % matrix.BlockHeight;
							fileStream.Seek((long)4, SeekOrigin.Current);
							Tile[] tileArray = new Tile[64];
							try
							{
								fixed (Tile* tilePointer = &tileArray[0])
								{
									TileMatrixPatch._lread(fileStream.Handle, tilePointer, 192);
								}
							}
							finally
							{
								tilePointer = null;
							}
							matrix.SetLandBlock(blockHeight, blockHeight1, tileArray);
						}
						num = length;
					}
				}
				return num;
			}
		}

		private unsafe int PatchStatics(TileMatrix matrix, string dataPath, string indexPath, string lookupPath)
		{
			int num;
			using (FileStream fileStream = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				using (FileStream fileStream1 = new FileStream(indexPath, FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					using (FileStream fileStream2 = new FileStream(lookupPath, FileMode.Open, FileAccess.Read, FileShare.Read))
					{
						BinaryReader binaryReader = new BinaryReader(fileStream1);
						BinaryReader binaryReader1 = new BinaryReader(fileStream2);
						int length = (int)(binaryReader.BaseStream.Length / (long)4);
						HuedTileList[][] huedTileList = new HuedTileList[8][];
						for (int i = 0; i < 8; i++)
						{
							huedTileList[i] = new HuedTileList[8];
							for (int j = 0; j < 8; j++)
							{
								huedTileList[i][j] = new HuedTileList();
							}
						}
						for (int k = 0; k < length; k++)
						{
							int num1 = binaryReader.ReadInt32();
							int blockHeight = num1 / matrix.BlockHeight;
							int blockHeight1 = num1 % matrix.BlockHeight;
							int num2 = binaryReader1.ReadInt32();
							int num3 = binaryReader1.ReadInt32();
							binaryReader1.ReadInt32();
							if (num2 < 0 || num3 <= 0)
							{
								matrix.SetStaticBlock(blockHeight, blockHeight1, matrix.EmptyStaticBlock);
							}
							else
							{
								fileStream.Seek((long)num2, SeekOrigin.Begin);
								int num4 = num3 / 7;
								StaticTile[] staticTileArray = new StaticTile[num4];
								try
								{
									fixed (StaticTile* staticTilePointer = &staticTileArray[0])
									{
										TileMatrixPatch._lread(fileStream.Handle, staticTilePointer, num3);
										StaticTile* staticTilePointer1 = staticTilePointer;
										StaticTile* staticTilePointer2 = staticTilePointer + num4 * sizeof(StaticTile);
										while (staticTilePointer1 < staticTilePointer2)
										{
											huedTileList[(*staticTilePointer1).m_X & 7][(*staticTilePointer1).m_Y & 7].Add((short)(((*staticTilePointer1).m_ID & 16383) + 16384), (*staticTilePointer1).m_Hue, (*staticTilePointer1).m_Z);
											staticTilePointer1 = staticTilePointer1 + sizeof(StaticTile);
										}
										HuedTile[][][] array = new HuedTile[8][][];
										for (int l = 0; l < 8; l++)
										{
											array[l] = new HuedTile[8][];
											for (int m = 0; m < 8; m++)
											{
												array[l][m] = huedTileList[l][m].ToArray();
											}
										}
										matrix.SetStaticBlock(blockHeight, blockHeight1, array);
									}
								}
								finally
								{
									staticTilePointer = null;
								}
							}
						}
						num = length;
					}
				}
			}
			return num;
		}
	}
}