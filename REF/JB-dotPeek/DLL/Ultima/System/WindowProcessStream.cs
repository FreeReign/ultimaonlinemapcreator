// Decompiled with JetBrains decompiler
// Type: System.WindowProcessStream
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System.Runtime.InteropServices;

namespace System
{
  public class WindowProcessStream : ProcessStream
  {
    private IntPtr m_Window;
    private IntPtr m_ProcessID;

    public IntPtr Window
    {
      get
      {
        return this.m_Window;
      }
      set
      {
        this.m_Window = value;
        this.m_ProcessID = IntPtr.Zero;
      }
    }

    public override IntPtr ProcessID
    {
      get
      {
        if (WindowProcessStream.IsWindow(this.m_Window) != 0 && this.m_ProcessID != IntPtr.Zero)
          return this.m_ProcessID;
        WindowProcessStream.GetWindowThreadProcessId(this.m_Window, ref this.m_ProcessID);
        return this.m_ProcessID;
      }
    }

    public WindowProcessStream(IntPtr window)
    {
      this.m_Window = window;
    }

    [DllImport("User32")]
    private static extern int IsWindow(IntPtr window);

    [DllImport("User32")]
    private static extern int GetWindowThreadProcessId(IntPtr window, ref IntPtr processID);
  }
}
