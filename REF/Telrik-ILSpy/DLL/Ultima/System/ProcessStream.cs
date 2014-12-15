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

		public override bool CanRead
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

		public override bool CanWrite
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
				return (long)this.m_Position;
			}
			set
			{
				this.m_Position = (int)value;
			}
		}

		public abstract IntPtr ProcessID
		{
			get;
		}

		public ProcessStream()
		{
		}

		public virtual bool BeginAccess()
		{
			if (this.m_Open)
			{
				return false;
			}
			this.m_Process = ProcessStream.OpenProcess(2035711, 0, this.ProcessID);
			this.m_Open = true;
			return true;
		}

		[DllImport("Kernel32", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int CloseHandle(IntPtr handle);

		public virtual void EndAccess()
		{
			if (!this.m_Open)
			{
				return;
			}
			ProcessStream.CloseHandle(this.m_Process);
			this.m_Open = false;
		}

		public override void Flush()
		{
		}

		[DllImport("Kernel32", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern IntPtr OpenProcess(int desiredAccess, int inheritHandle, IntPtr processID);

		public override int Read(byte[] buffer, int offset, int count)
		{
			unsafe
			{
				bool flag = !this.BeginAccess();
				int num = 0;
				fixed (byte* numPointer = &buffer[0])
				{
					ProcessStream.ReadProcessMemory(this.m_Process, this.m_Position, numPointer + offset, count, ref num);
				}
				ProcessStream mPosition = this;
				mPosition.m_Position = mPosition.m_Position + count;
				if (flag)
				{
					this.EndAccess();
				}
				return num;
			}
		}

		[DllImport("Kernel32", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern unsafe int ReadProcessMemory(IntPtr process, int baseAddress, void* buffer, int size, ref int op);

		public override long Seek(long offset, SeekOrigin origin)
		{
			switch (origin)
			{
				case SeekOrigin.Begin:
				{
					this.m_Position = (int)offset;
					break;
				}
				case SeekOrigin.Current:
				{
					ProcessStream mPosition = this;
					mPosition.m_Position = mPosition.m_Position + (int)offset;
					break;
				}
				case SeekOrigin.End:
				{
					throw new NotSupportedException();
				}
			}
			return (long)this.m_Position;
		}

		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			unsafe
			{
				bool flag = !this.BeginAccess();
				fixed (byte* numPointer = &buffer[0])
				{
					ProcessStream.WriteProcessMemory(this.m_Process, this.m_Position, numPointer + offset, count, 0);
				}
				ProcessStream mPosition = this;
				mPosition.m_Position = mPosition.m_Position + count;
				if (flag)
				{
					this.EndAccess();
				}
			}
		}

		[DllImport("Kernel32", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern unsafe int WriteProcessMemory(IntPtr process, int baseAddress, void* buffer, int size, int nullMe);
	}
}