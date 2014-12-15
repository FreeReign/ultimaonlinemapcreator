// Decompiled with JetBrains decompiler
// Type: System.ProcessStream
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System.IO;
using System.Runtime.InteropServices;

namespace System
{
  public abstract class ProcessStream : Stream
  {
    private const int ProcessAllAccess = 2035711;
    protected bool m_Open;
    protected IntPtr m_Process;
    protected int m_Position;

    public abstract IntPtr ProcessID { get; }

    public override bool CanRead
    {
      get
      {
        return true;
      }
    }

    public override bool CanWrite
    {
      get
      {
        return true;
      }
    }

    public override bool CanSeek
    {
      get
      {
        return true;
      }
    }

    public override long Length
    {
      get
      {
        throw new NotSupportedException();
      }
    }

    public override long Position
    {
      get
      {
        return (long) this.m_Position;
      }
      set
      {
        this.m_Position = (int) value;
      }
    }

    [DllImport("Kernel32")]
    private static extern IntPtr OpenProcess(int desiredAccess, int inheritHandle, IntPtr processID);

    [DllImport("Kernel32")]
    private static extern int CloseHandle(IntPtr handle);

    [DllImport("Kernel32")]
    private static extern unsafe int ReadProcessMemory(IntPtr process, int baseAddress, void* buffer, int size, ref int op);

    [DllImport("Kernel32")]
    private static extern unsafe int WriteProcessMemory(IntPtr process, int baseAddress, void* buffer, int size, int nullMe);

    public virtual bool BeginAccess()
    {
      if (this.m_Open)
        return false;
      this.m_Process = ProcessStream.OpenProcess(2035711, 0, this.ProcessID);
      this.m_Open = true;
      return true;
    }

    public virtual void EndAccess()
    {
      if (!this.m_Open)
        return;
      ProcessStream.CloseHandle(this.m_Process);
      this.m_Open = false;
    }

    public override void Flush()
    {
    }

    public override unsafe int Read(byte[] buffer, int offset, int count)
    {
      bool flag = !this.BeginAccess();
      int op = 0;
      fixed (byte* numPtr = &buffer[0])
        ProcessStream.ReadProcessMemory(this.m_Process, this.m_Position, (void*) (numPtr + offset), count, ref op);
      this.m_Position += count;
      if (flag)
        this.EndAccess();
      return op;
    }

    public override unsafe void Write(byte[] buffer, int offset, int count)
    {
      bool flag = !this.BeginAccess();
      fixed (byte* numPtr = &buffer[0])
        ProcessStream.WriteProcessMemory(this.m_Process, this.m_Position, (void*) (numPtr + offset), count, 0);
      this.m_Position += count;
      if (!flag)
        return;
      this.EndAccess();
    }

    public override void SetLength(long value)
    {
      throw new NotSupportedException();
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
      switch (origin)
      {
        case SeekOrigin.Begin:
          this.m_Position = (int) offset;
          break;
        case SeekOrigin.Current:
          this.m_Position += (int) offset;
          break;
        case SeekOrigin.End:
          throw new NotSupportedException();
      }
      return (long) this.m_Position;
    }
  }
}
