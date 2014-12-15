using System;
using System.Collections;
using System.IO;

namespace Ultima
{
	public class CalibrationInfo
	{
		private byte[] m_Mask;

		private byte[] m_Vals;

		private byte[] m_DetX;

		private byte[] m_DetY;

		private byte[] m_DetZ;

		private byte[] m_DetF;

		private static CalibrationInfo[] m_DefaultList;

		public static CalibrationInfo[] DefaultList
		{
			get
			{
				return CalibrationInfo.m_DefaultList;
			}
			set
			{
				CalibrationInfo.m_DefaultList = value;
			}
		}

		public byte[] DetF
		{
			get
			{
				return this.m_DetF;
			}
		}

		public byte[] DetX
		{
			get
			{
				return this.m_DetX;
			}
		}

		public byte[] DetY
		{
			get
			{
				return this.m_DetY;
			}
		}

		public byte[] DetZ
		{
			get
			{
				return this.m_DetZ;
			}
		}

		public byte[] Mask
		{
			get
			{
				return this.m_Mask;
			}
		}

		public byte[] Vals
		{
			get
			{
				return this.m_Vals;
			}
		}

		static CalibrationInfo()
		{
			CalibrationInfo[] calibrationInfo = new CalibrationInfo[] { new CalibrationInfo(new byte[] { 255, 0, 0, 0, 0, 255, 255, 255, 255, 0, 255, 255, 255, 255, 255 }, new byte[] { 160, 0, 0, 0, 0, 132, 192, 15, 133, 0, 0, 0, 0, 139, 13 }, new byte[0], new byte[0], new byte[0], new byte[] { 1, 4, 255, 255, 255, 1 }), new CalibrationInfo(new byte[] { 255, 255, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 0, 255, 0, 0, 0, 0, 255, 255, 255, 0, 255, 255, 0, 0, 0, 0, 255, 255, 255, 0 }, new byte[] { 139, 21, 0, 0, 0, 0, 131, 196, 16, 102, 137, 90, 0, 161, 0, 0, 0, 0, 102, 137, 120, 0, 139, 13, 0, 0, 0, 0, 102, 137, 113, 0 }, new byte[] { 2, 4, 4, 12, 1, 2 }, new byte[] { 14, 4, 4, 21, 1, 2 }, new byte[] { 24, 4, 4, 31, 1, 2 }, new byte[0]), new CalibrationInfo(new byte[] { 255, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 255, 255, 255, 0, 255, 255, 255, 255, 255, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0 }, new byte[] { 161, 0, 0, 0, 0, 104, 64, 46, 4, 1, 15, 191, 80, 0, 15, 191, 72, 0, 82, 81, 15, 191, 80, 0, 82, 141, 133, 228, 253, 255, 255, 104, 0, 0, 0, 0, 80, 232, 7, 68, 16, 0, 138, 13, 0, 0, 0, 0 }, new byte[] { 1, 4, 4, 23, 1, 2 }, new byte[] { 1, 4, 4, 17, 1, 2 }, new byte[] { 1, 4, 4, 13, 1, 2 }, new byte[] { 44, 4, 255, 255, 255, 1 }) };
			CalibrationInfo.m_DefaultList = calibrationInfo;
		}

		public CalibrationInfo(byte[] mask, byte[] vals, byte[] detx, byte[] dety, byte[] detz, byte[] detf)
		{
			this.m_Mask = mask;
			this.m_Vals = vals;
			this.m_DetX = detx;
			this.m_DetY = dety;
			this.m_DetZ = detz;
			this.m_DetF = detf;
		}

		public static CalibrationInfo[] GetList()
		{
			ArrayList arrayLists = new ArrayList();
			string directoryName = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
			directoryName = Path.Combine(directoryName, "calibration.cfg");
			if (File.Exists(directoryName))
			{
				using (StreamReader streamReader = new StreamReader(directoryName))
				{
					while (true)
					{
						string str = streamReader.ReadLine();
						string str1 = str;
						if (str == null)
						{
							break;
						}
						str1 = str1.Trim();
						if (str1.ToLower() == "Begin")
						{
							byte[] numArray = CalibrationInfo.ReadBytes(streamReader);
							byte[] numArray1 = numArray;
							if (numArray != null)
							{
								byte[] numArray2 = CalibrationInfo.ReadBytes(streamReader);
								byte[] numArray3 = numArray2;
								if (numArray2 != null)
								{
									byte[] numArray4 = CalibrationInfo.ReadBytes(streamReader);
									byte[] numArray5 = numArray4;
									if (numArray4 != null)
									{
										byte[] numArray6 = CalibrationInfo.ReadBytes(streamReader);
										byte[] numArray7 = numArray6;
										if (numArray6 != null)
										{
											byte[] numArray8 = CalibrationInfo.ReadBytes(streamReader);
											byte[] numArray9 = numArray8;
											if (numArray8 != null)
											{
												byte[] numArray10 = CalibrationInfo.ReadBytes(streamReader);
												byte[] numArray11 = numArray10;
												if (numArray10 != null)
												{
													arrayLists.Add(new CalibrationInfo(numArray1, numArray3, numArray5, numArray7, numArray9, numArray11));
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			arrayLists.AddRange(CalibrationInfo.DefaultList);
			return (CalibrationInfo[])arrayLists.ToArray(typeof(CalibrationInfo));
		}

		private static byte[] ReadBytes(StreamReader ip)
		{
			string str = ip.ReadLine();
			if (str == null)
			{
				return null;
			}
			byte[] numArray = new byte[(str.Length + 2) / 3];
			int num = 0;
			for (int i = 0; i + 1 < str.Length; i = i + 3)
			{
				char chr = str[i];
				char chr1 = str[i + 1];
				if (chr >= '0' && chr <= '9')
				{
					chr = (char)(chr - 48);
				}
				else if (chr < 'a' || chr > 'f')
				{
					if (chr < 'A' || chr > 'F')
					{
						return null;
					}
					chr = (char)(chr - 55);
				}
				else
				{
					chr = (char)(chr - 87);
				}
				if (chr1 >= '0' && chr1 <= '9')
				{
					chr1 = (char)(chr1 - 48);
				}
				else if (chr1 < 'a' || chr1 > 'f')
				{
					if (chr1 < 'A' || chr1 > 'F')
					{
						return null;
					}
					chr1 = (char)(chr1 - 55);
				}
				else
				{
					chr1 = (char)(chr1 - 87);
				}
				int num1 = num;
				num = num1 + 1;
				numArray[num1] = (byte)(chr << '\u0004' | chr1);
			}
			return numArray;
		}
	}
}