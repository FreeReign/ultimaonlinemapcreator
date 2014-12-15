using System.Runtime.InteropServices;

namespace System
{
	public class WindowProcessStream : ProcessStream
	{
		private IntPtr m_Window;

		private IntPtr m_ProcessID;

		public override IntPtr ProcessID
		{
			get
			{
				if (WindowProcessStream.IsWindow(this.m_Window) != 0 && this.m_ProcessID != IntPtr.Zero)
				{
					return this.m_ProcessID;
				}
				WindowProcessStream.GetWindowThreadProcessId(this.m_Window, ref this.m_ProcessID);
				return this.m_ProcessID;
			}
		}

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

		public WindowProcessStream(IntPtr window)
		{
			this.m_Window = window;
		}

		[DllImport("User32", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int GetWindowThreadProcessId(IntPtr window, ref IntPtr processID);

		[DllImport("User32", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int IsWindow(IntPtr window);
	}
}