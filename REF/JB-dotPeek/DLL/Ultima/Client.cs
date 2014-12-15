// Decompiled with JetBrains decompiler
// Type: Ultima.Client
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

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
    private static LocationPointer m_LocationPointer;

    public static ProcessStream ProcessStream
    {
      get
      {
        if (Client.m_ProcStream == null || Client.m_ProcStream.Window != Client.Handle)
          Client.m_ProcStream = !Client.Running ? (WindowProcessStream) null : new WindowProcessStream(Client.Handle);
        return (ProcessStream) Client.m_ProcStream;
      }
    }

    public static LocationPointer LocationPointer
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

    public static IntPtr Handle
    {
      get
      {
        if (Client.IsWindow(Client.m_Handle) == 0)
          Client.m_Handle = Client.FindHandle();
        return Client.m_Handle;
      }
    }

    public static bool Running
    {
      get
      {
        return Client.Handle != IntPtr.Zero;
      }
    }

    public static ArrayList Directories
    {
      get
      {
        if (Client.m_Directories == null)
          Client.m_Directories = Client.LoadDirectories();
        return Client.m_Directories;
      }
    }

    private Client()
    {
    }

    [DllImport("User32")]
    private static extern int IsWindow(IntPtr hWnd);

    [DllImport("User32")]
    private static extern int SetForegroundWindow(IntPtr hWnd);

    [DllImport("User32")]
    private static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

    [DllImport("User32")]
    private static extern int OemKeyScan(int wOemChar);

    public static bool FindLocation(ref int x, ref int y, ref int z, ref int facet)
    {
      LocationPointer locationPointer = Client.LocationPointer;
      ProcessStream processStream = Client.ProcessStream;
      if (processStream == null || locationPointer == null)
        return false;
      processStream.BeginAccess();
      if (locationPointer.PointerX > 0)
      {
        processStream.Seek((long) locationPointer.PointerX, SeekOrigin.Begin);
        x = Client.Read(processStream, locationPointer.SizeX);
      }
      if (locationPointer.PointerY > 0)
      {
        processStream.Seek((long) locationPointer.PointerY, SeekOrigin.Begin);
        y = Client.Read(processStream, locationPointer.SizeY);
      }
      if (locationPointer.PointerZ > 0)
      {
        processStream.Seek((long) locationPointer.PointerZ, SeekOrigin.Begin);
        z = Client.Read(processStream, locationPointer.SizeZ);
      }
      if (locationPointer.PointerF > 0)
      {
        processStream.Seek((long) locationPointer.PointerF, SeekOrigin.Begin);
        facet = Client.Read(processStream, locationPointer.SizeF);
      }
      processStream.EndAccess();
      return true;
    }

    public static int Read(ProcessStream pc, int bytes)
    {
      byte[] buffer = new byte[bytes];
      pc.Read(buffer, 0, bytes);
      switch (bytes)
      {
        case 1:
          return (int) (sbyte) buffer[0];
        case 2:
          return (int) (short) ((int) buffer[0] | (int) buffer[1] << 8);
        case 4:
          return (int) buffer[0] | (int) buffer[1] << 8 | (int) buffer[2] << 16 | (int) buffer[3] << 24;
        default:
          int num1 = 0;
          int num2 = 0;
          for (int index = 0; index < buffer.Length; ++index)
          {
            num1 |= (int) buffer[index] << num2;
            num2 += 8;
          }
          return num1;
      }
    }

    public static int Search(ProcessStream pc, byte[] mask, byte[] vals)
    {
      if (mask.Length != vals.Length)
        throw new Exception();
      int count = 4096 + mask.Length;
      pc.BeginAccess();
      byte[] buffer = new byte[count];
      int num = 0;
      while (true)
      {
        pc.Seek((long) (4194304 + num * 4096), SeekOrigin.Begin);
        if (pc.Read(buffer, 0, count) == count)
        {
          for (int index1 = 0; index1 < 4096; ++index1)
          {
            bool flag = true;
            for (int index2 = 0; flag && index2 < mask.Length; ++index2)
              flag = ((int) buffer[index1 + index2] & (int) mask[index2]) == (int) vals[index2];
            if (flag)
            {
              pc.EndAccess();
              return 4194304 + num * 4096 + index1;
            }
          }
          ++num;
        }
        else
          break;
      }
      pc.EndAccess();
      return 0;
    }

    public static int Search(ProcessStream pc, byte[] buffer)
    {
      int count = 4096 + buffer.Length;
      pc.BeginAccess();
      byte[] buffer1 = new byte[count];
      int num = 0;
      while (true)
      {
        pc.Seek((long) (4194304 + num * 4096), SeekOrigin.Begin);
        if (pc.Read(buffer1, 0, count) == count)
        {
          for (int index1 = 0; index1 < 4096; ++index1)
          {
            bool flag = true;
            for (int index2 = 0; flag && index2 < buffer.Length; ++index2)
              flag = (int) buffer[index2] == (int) buffer1[index1 + index2];
            if (flag)
            {
              pc.EndAccess();
              return 4194304 + num * 4096 + index1;
            }
          }
          ++num;
        }
        else
          break;
      }
      pc.EndAccess();
      return 0;
    }

    public static void Calibrate(int x, int y, int z)
    {
      Client.m_LocationPointer = (LocationPointer) null;
      ProcessStream processStream = Client.ProcessStream;
      if (processStream == null)
        return;
      byte[] buffer = new byte[12]
      {
        (byte) z,
        (byte) (z >> 8),
        (byte) (z >> 16),
        (byte) (z >> 24),
        (byte) y,
        (byte) (y >> 8),
        (byte) (y >> 16),
        (byte) (y >> 24),
        (byte) x,
        (byte) (x >> 8),
        (byte) (x >> 16),
        (byte) (x >> 24)
      };
      int ptrZ = Client.Search(processStream, buffer);
      if (ptrZ == 0)
        return;
      Client.m_LocationPointer = new LocationPointer(ptrZ + 8, ptrZ + 4, ptrZ, 0, 4, 4, 4, 0);
    }

    public static void Calibrate()
    {
      Client.Calibrate(CalibrationInfo.GetList());
    }

    public static void Calibrate(CalibrationInfo[] info)
    {
      Client.m_LocationPointer = (LocationPointer) null;
      ProcessStream processStream = Client.ProcessStream;
      if (processStream == null)
        return;
      int coordPointer1 = 0;
      int coordSize1 = 0;
      int coordPointer2 = 0;
      int coordSize2 = 0;
      int coordPointer3 = 0;
      int coordSize3 = 0;
      int coordPointer4 = 0;
      int coordSize4 = 0;
      for (int index = 0; index < info.Length; ++index)
      {
        CalibrationInfo calibrationInfo = info[index];
        int ptr = Client.Search(processStream, calibrationInfo.Mask, calibrationInfo.Vals);
        if (ptr != 0)
        {
          if (coordPointer1 == 0 && calibrationInfo.DetX.Length > 0)
            Client.GetCoordDetails(processStream, ptr, calibrationInfo.DetX, out coordPointer1, out coordSize1);
          if (coordPointer2 == 0 && calibrationInfo.DetY.Length > 0)
            Client.GetCoordDetails(processStream, ptr, calibrationInfo.DetY, out coordPointer2, out coordSize2);
          if (coordPointer3 == 0 && calibrationInfo.DetZ.Length > 0)
            Client.GetCoordDetails(processStream, ptr, calibrationInfo.DetZ, out coordPointer3, out coordSize3);
          if (coordPointer4 == 0 && calibrationInfo.DetF.Length > 0)
            Client.GetCoordDetails(processStream, ptr, calibrationInfo.DetF, out coordPointer4, out coordSize4);
          if (coordPointer1 != 0 && coordPointer2 != 0 && (coordPointer3 != 0 && coordPointer4 != 0))
            break;
        }
      }
      if (coordPointer1 == 0 && coordPointer2 == 0 && (coordPointer3 == 0 && coordPointer4 == 0))
        return;
      Client.m_LocationPointer = new LocationPointer(coordPointer1, coordPointer2, coordPointer3, coordPointer4, coordSize1, coordSize2, coordSize3, coordSize4);
    }

    private static void GetCoordDetails(ProcessStream pc, int ptr, byte[] dets, out int coordPointer, out int coordSize)
    {
      pc.Seek((long) (ptr + (int) dets[0]), SeekOrigin.Begin);
      coordPointer = Client.Read(pc, (int) dets[1]);
      if ((int) dets[2] < (int) byte.MaxValue)
      {
        pc.Seek((long) coordPointer, SeekOrigin.Begin);
        coordPointer = Client.Read(pc, (int) dets[2]);
      }
      if ((int) dets[3] < (int) byte.MaxValue)
      {
        pc.Seek((long) (ptr + (int) dets[3]), SeekOrigin.Begin);
        coordPointer += Client.Read(pc, (int) dets[4]);
      }
      coordSize = (int) dets[5];
    }

    private static void SendChar(IntPtr hWnd, char c)
    {
      int num = (int) c;
      int lParam = 1 | (Client.OemKeyScan(num) & (int) byte.MaxValue) << 16 | -1073741824;
      Client.SendMessage(hWnd, 258, num, lParam);
    }

    public static bool BringToTop()
    {
      IntPtr handle = Client.Handle;
      if (!(handle != IntPtr.Zero))
        return false;
      Client.SetForegroundWindow(handle);
      return true;
    }

    public static bool SendText(string text)
    {
      IntPtr handle = Client.Handle;
      if (!(handle != IntPtr.Zero))
        return false;
      for (int index = 0; index < text.Length; ++index)
        Client.SendChar(handle, text[index]);
      Client.SendChar(handle, '\r');
      Client.SendChar(handle, '\n');
      return true;
    }

    public static bool SendText(string format, params object[] args)
    {
      return Client.SendText(string.Format(format, args));
    }

    [DllImport("user32")]
    private static extern IntPtr FindWindowA(string lpClassName, string lpWindowName);

    private static IntPtr FindHandle()
    {
      IntPtr windowA1;
      if (Client.IsWindow(windowA1 = Client.FindWindowA("Ultima Online", (string) null)) != 0)
        return windowA1;
      IntPtr windowA2;
      if (Client.IsWindow(windowA2 = Client.FindWindowA("Ultima Online Third Dawn", (string) null)) != 0)
        return windowA2;
      else
        return IntPtr.Zero;
    }

    public static string GetFilePath(string file)
    {
      ArrayList directories = Client.Directories;
      if (directories.Count == 0)
        throw new DirectoryNotFoundException();
      for (int index = 0; index < directories.Count; ++index)
      {
        string path = Path.Combine((string) directories[index], file);
        if (File.Exists(path))
          return path;
      }
      return (string) null;
    }

    internal static string GetFilePath(string format, params object[] args)
    {
      return Client.GetFilePath(string.Format(format, args));
    }

    private static ArrayList LoadDirectories()
    {
      ArrayList arrayList = new ArrayList();
      string exePath1 = Client.GetExePath("Ultima Online");
      string exePath2 = Client.GetExePath("Ultima Online Third Dawn");
      if (exePath1 != null)
        arrayList.Add((object) exePath1);
      if (exePath2 != null)
        arrayList.Add((object) exePath2);
      return arrayList;
    }

    private static string GetExePath(string subName)
    {
      try
      {
        using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Format("SOFTWARE\\Origin Worlds Online\\{0}\\1.0", (object) subName)))
        {
          if (registryKey == null)
            return (string) null;
          string path = registryKey.GetValue("ExePath") as string;
          if (path == null || path.Length <= 0 || !File.Exists(path))
            return (string) null;
          else
            return Path.GetDirectoryName(path) ?? (string) null;
        }
      }
      catch
      {
        return (string) null;
      }
    }
  }
}
