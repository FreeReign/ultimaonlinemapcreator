using Microsoft.Win32;
using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;

namespace Ultima
{
	public sealed class Client
	{
		private const int WM_CHAR = 258;

		private static ArrayList m_Directories;

		private static IntPtr m_Handle;

		private static WindowProcessStream m_ProcStream;

		private static Ultima.LocationPointer m_LocationPointer;

		public static ArrayList Directories
		{
			get
			{
				if (Client.m_Directories == null)
				{
					Client.m_Directories = Client.LoadDirectories();
				}
				return Client.m_Directories;
			}
		}

		public static IntPtr Handle
		{
			get
			{
				if (Client.IsWindow(Client.m_Handle) == 0)
				{
					Client.m_Handle = Client.FindHandle();
				}
				return Client.m_Handle;
			}
		}

		public static Ultima.LocationPointer LocationPointer
		{
			get
			{
				return Client.m_LocationPointer;
			}
			set
			{
				Client.m_LocationPointer = value;
			}
		}

		public static System.ProcessStream ProcessStream
		{
			get
			{
				if (Client.m_ProcStream == null || Client.m_ProcStream.Window != Client.Handle)
				{
					if (!Client.Running)
					{
						Client.m_ProcStream = null;
					}
					else
					{
						Client.m_ProcStream = new WindowProcessStream(Client.Handle);
					}
				}
				return Client.m_ProcStream;
			}
		}

		public static bool Running
		{
			get
			{
				return Client.Handle != IntPtr.Zero;
			}
		}

		private Client()
		{
		}

		public static bool BringToTop()
		{
			IntPtr handle = Client.Handle;
			if (handle == IntPtr.Zero)
			{
				return false;
			}
			Client.SetForegroundWindow(handle);
			return true;
		}

		public static void Calibrate(int x, int y, int z)
		{
			Client.m_LocationPointer = null;
			System.ProcessStream processStream = Client.ProcessStream;
			if (processStream == null)
			{
				return;
			}
			byte[] numArray = new byte[] { (byte)z, (byte)(z >> 8), (byte)(z >> 16), (byte)(z >> 24), (byte)y, (byte)(y >> 8), (byte)(y >> 16), (byte)(y >> 24), (byte)x, (byte)(x >> 8), (byte)(x >> 16), (byte)(x >> 24) };
			int num = Client.Search(processStream, numArray);
			if (num == 0)
			{
				return;
			}
			Client.m_LocationPointer = new Ultima.LocationPointer(num + 8, num + 4, num, 0, 4, 4, 4, 0);
		}

		public static void Calibrate()
		{
			Client.Calibrate(CalibrationInfo.GetList());
		}

		public static void Calibrate(CalibrationInfo[] info)
		{
			Client.m_LocationPointer = null;
			System.ProcessStream processStream = Client.ProcessStream;
			if (processStream == null)
			{
				return;
			}
			int num = 0;
			int num1 = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			for (int i = 0; i < (int)info.Length; i++)
			{
				CalibrationInfo calibrationInfo = info[i];
				int num8 = Client.Search(processStream, calibrationInfo.Mask, calibrationInfo.Vals);
				if (num8 != 0)
				{
					if (num == 0 && (int)calibrationInfo.DetX.Length > 0)
					{
						Client.GetCoordDetails(processStream, num8, calibrationInfo.DetX, out num, out num1);
					}
					if (num2 == 0 && (int)calibrationInfo.DetY.Length > 0)
					{
						Client.GetCoordDetails(processStream, num8, calibrationInfo.DetY, out num2, out num3);
					}
					if (num4 == 0 && (int)calibrationInfo.DetZ.Length > 0)
					{
						Client.GetCoordDetails(processStream, num8, calibrationInfo.DetZ, out num4, out num5);
					}
					if (num6 == 0 && (int)calibrationInfo.DetF.Length > 0)
					{
						Client.GetCoordDetails(processStream, num8, calibrationInfo.DetF, out num6, out num7);
					}
					if (num != 0 && num2 != 0 && num4 != 0 && num6 != 0)
					{
						break;
					}
				}
			}
			if (num != 0 || num2 != 0 || num4 != 0 || num6 != 0)
			{
				Client.m_LocationPointer = new Ultima.LocationPointer(num, num2, num4, num6, num1, num3, num5, num7);
			}
		}

		private static IntPtr FindHandle()
		{
			IntPtr intPtr = Client.FindWindowA("Ultima Online", null);
			IntPtr intPtr1 = intPtr;
			if (Client.IsWindow(intPtr) != 0)
			{
				return intPtr1;
			}
			IntPtr intPtr2 = Client.FindWindowA("Ultima Online Third Dawn", null);
			intPtr1 = intPtr2;
			if (Client.IsWindow(intPtr2) != 0)
			{
				return intPtr1;
			}
			return IntPtr.Zero;
		}

		public static bool FindLocation(ref int x, ref int y, ref int z, ref int facet)
		{
			Ultima.LocationPointer locationPointer = Client.LocationPointer;
			System.ProcessStream processStream = Client.ProcessStream;
			if (processStream == null || locationPointer == null)
			{
				return false;
			}
			processStream.BeginAccess();
			if (locationPointer.PointerX > 0)
			{
				processStream.Seek((long)locationPointer.PointerX, SeekOrigin.Begin);
				x = Client.Read(processStream, locationPointer.SizeX);
			}
			if (locationPointer.PointerY > 0)
			{
				processStream.Seek((long)locationPointer.PointerY, SeekOrigin.Begin);
				y = Client.Read(processStream, locationPointer.SizeY);
			}
			if (locationPointer.PointerZ > 0)
			{
				processStream.Seek((long)locationPointer.PointerZ, SeekOrigin.Begin);
				z = Client.Read(processStream, locationPointer.SizeZ);
			}
			if (locationPointer.PointerF > 0)
			{
				processStream.Seek((long)locationPointer.PointerF, SeekOrigin.Begin);
				facet = Client.Read(processStream, locationPointer.SizeF);
			}
			processStream.EndAccess();
			return true;
		}

		[DllImport("user32", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern IntPtr FindWindowA(string lpClassName, string lpWindowName);

		private static void GetCoordDetails(System.ProcessStream pc, int ptr, byte[] dets, out int coordPointer, out int coordSize)
		{
			pc.Seek((long)(ptr + dets[0]), SeekOrigin.Begin);
			coordPointer = Client.Read(pc, (int)dets[1]);
			if (dets[2] < 255)
			{
				pc.Seek((long)coordPointer, SeekOrigin.Begin);
				coordPointer = Client.Read(pc, (int)dets[2]);
			}
			if (dets[3] < 255)
			{
				pc.Seek((long)(ptr + dets[3]), SeekOrigin.Begin);
				coordPointer = coordPointer + Client.Read(pc, (int)dets[4]);
			}
			coordSize = dets[5];
		}

		private static string GetExePath(string subName)
		{
			string str;
			try
			{
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Format("SOFTWARE\\Origin Worlds Online\\{0}\\1.0", subName)))
				{
					if (registryKey != null)
					{
						string value = registryKey.GetValue("ExePath") as string;
						if (value == null || value.Length <= 0 || !File.Exists(value))
						{
							str = null;
						}
						else
						{
							value = Path.GetDirectoryName(value);
							if (value != null)
							{
								str = value;
							}
							else
							{
								str = null;
							}
						}
					}
					else
					{
						str = null;
					}
				}
			}
			catch
			{
				str = null;
			}
			return str;
		}

		public static string GetFilePath(string file)
		{
			ArrayList directories = Client.Directories;
			if (directories.Count == 0)
			{
				throw new DirectoryNotFoundException();
			}
			for (int i = 0; i < directories.Count; i++)
			{
				string str = Path.Combine((string)directories[i], file);
				if (File.Exists(str))
				{
					return str;
				}
			}
			return null;
		}

		internal static string GetFilePath(string format, params object[] args)
		{
			return Client.GetFilePath(string.Format(format, args));
		}

		[DllImport("User32", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int IsWindow(IntPtr hWnd);

		private static ArrayList LoadDirectories()
		{
			ArrayList arrayLists = new ArrayList();
			string exePath = Client.GetExePath("Ultima Online");
			string str = Client.GetExePath("Ultima Online Third Dawn");
			if (exePath != null)
			{
				arrayLists.Add(exePath);
			}
			if (str != null)
			{
				arrayLists.Add(str);
			}
			return arrayLists;
		}

		[DllImport("User32", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int OemKeyScan(int wOemChar);

		public static int Read(System.ProcessStream pc, int bytes)
		{
			int num;
			int num1;
			int i;
			byte[] numArray = new byte[bytes];
			pc.Read(numArray, 0, bytes);
			switch (bytes)
			{
				case 1:
				{
					return (sbyte)numArray[0];
				}
				case 2:
				{
					return (short)(numArray[0] | numArray[1] << 8);
				}
				case 3:
				{
					num = 0;
					num1 = 0;
					for (i = 0; i < (int)numArray.Length; i++)
					{
						num = num | numArray[i] << (num1 & 31);
						num1 = num1 + 8;
					}
					return num;
				}
				case 4:
				{
					return numArray[0] | numArray[1] << 8 | numArray[2] << 16 | numArray[3] << 24;
				}
				default:
				{
					num = 0;
					num1 = 0;
					for (i = 0; i < (int)numArray.Length; i++)
					{
						num = num | numArray[i] << (num1 & 31);
						num1 = num1 + 8;
					}
					return num;
				}
			}
		}

		public static int Search(System.ProcessStream pc, byte[] mask, byte[] vals)
		{
			if ((int)mask.Length != (int)vals.Length)
			{
				throw new Exception();
			}
			int length = 4096 + (int)mask.Length;
			pc.BeginAccess();
			byte[] numArray = new byte[length];
			int num = 0;
			while (true)
			{
				pc.Seek((long)(4194304 + num * 4096), SeekOrigin.Begin);
				if (pc.Read(numArray, 0, length) != length)
				{
					break;
				}
				for (int i = 0; i < 4096; i++)
				{
					bool flag = true;
					for (int j = 0; flag && j < (int)mask.Length; j++)
					{
						flag = (numArray[i + j] & mask[j]) == vals[j];
					}
					if (flag)
					{
						pc.EndAccess();
						return 4194304 + num * 4096 + i;
					}
				}
				num++;
			}
			pc.EndAccess();
			return 0;
		}

		public static int Search(System.ProcessStream pc, byte[] buffer)
		{
			int length = 4096 + (int)buffer.Length;
			pc.BeginAccess();
			byte[] numArray = new byte[length];
			int num = 0;
			while (true)
			{
				pc.Seek((long)(4194304 + num * 4096), SeekOrigin.Begin);
				if (pc.Read(numArray, 0, length) != length)
				{
					break;
				}
				for (int i = 0; i < 4096; i++)
				{
					bool flag = true;
					for (int j = 0; flag && j < (int)buffer.Length; j++)
					{
						flag = buffer[j] == numArray[i + j];
					}
					if (flag)
					{
						pc.EndAccess();
						return 4194304 + num * 4096 + i;
					}
				}
				num++;
			}
			pc.EndAccess();
			return 0;
		}

		private static void SendChar(IntPtr hWnd, char c)
		{
			int num = c;
			int num1 = 1 | (Client.OemKeyScan(num) & 255) << 16 | -1073741824;
			Client.SendMessage(hWnd, 258, num, num1);
		}

		[DllImport("User32", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

		public static bool SendText(string text)
		{
			IntPtr handle = Client.Handle;
			if (handle == IntPtr.Zero)
			{
				return false;
			}
			for (int i = 0; i < text.Length; i++)
			{
				Client.SendChar(handle, text[i]);
			}
			Client.SendChar(handle, '\r');
			Client.SendChar(handle, '\n');
			return true;
		}

		public static bool SendText(string format, params object[] args)
		{
			return Client.SendText(string.Format(format, args));
		}

		[DllImport("User32", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int SetForegroundWindow(IntPtr hWnd);
	}
}