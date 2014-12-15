using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Logger
{
	public class LoggerForm : Form
	{
		[AccessedThroughProperty("MenuItem3")]
		private MenuItem _MenuItem3;

		[AccessedThroughProperty("MenuItem2")]
		private MenuItem _MenuItem2;

		[AccessedThroughProperty("MenuItem1")]
		private MenuItem _MenuItem1;

		[AccessedThroughProperty("MainMenu1")]
		private MainMenu _MainMenu1;

		[AccessedThroughProperty("TextLog")]
		private TextBox _TextLog;

		private IContainer components;

		private string m_LogName;

		private DateTime m_Task_Start;

		private DateTime m_Task_End;

		internal virtual MainMenu MainMenu1
		{
			get
			{
				return this._MainMenu1;
			}
			set
			{
				this._MainMenu1 == null;
				this._MainMenu1 = value;
				this._MainMenu1 == null;
			}
		}

		internal virtual MenuItem MenuItem1
		{
			get
			{
				return this._MenuItem1;
			}
			set
			{
				this._MenuItem1 == null;
				this._MenuItem1 = value;
				this._MenuItem1 == null;
			}
		}

		internal virtual MenuItem MenuItem2
		{
			get
			{
				return this._MenuItem2;
			}
			set
			{
				if (this._MenuItem2 != null)
				{
					LoggerForm loggerForm = this;
					this._MenuItem2.Click -= new EventHandler(loggerForm.MenuItem2_Click);
				}
				this._MenuItem2 = value;
				if (this._MenuItem2 != null)
				{
					LoggerForm loggerForm1 = this;
					this._MenuItem2.Click += new EventHandler(loggerForm1.MenuItem2_Click);
				}
			}
		}

		internal virtual MenuItem MenuItem3
		{
			get
			{
				return this._MenuItem3;
			}
			set
			{
				if (this._MenuItem3 != null)
				{
					LoggerForm loggerForm = this;
					this._MenuItem3.Click -= new EventHandler(loggerForm.MenuItem3_Click);
				}
				this._MenuItem3 = value;
				if (this._MenuItem3 != null)
				{
					LoggerForm loggerForm1 = this;
					this._MenuItem3.Click += new EventHandler(loggerForm1.MenuItem3_Click);
				}
			}
		}

		internal virtual TextBox TextLog
		{
			get
			{
				return this._TextLog;
			}
			set
			{
				this._TextLog == null;
				this._TextLog = value;
				this._TextLog == null;
			}
		}

		public LoggerForm()
		{
			LoggerForm loggerForm = this;
			base.Load += new EventHandler(loggerForm.LoggerForm_Load);
			this.InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.components != null)
				{
					this.components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		public void EndTask()
		{
			this.m_Task_End = DateTime.Now;
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.TextLog = new TextBox();
			this.MainMenu1 = new MainMenu();
			this.MenuItem1 = new MenuItem();
			this.MenuItem2 = new MenuItem();
			this.MenuItem3 = new MenuItem();
			this.SuspendLayout();
			this.TextLog.Dock = DockStyle.Fill;
			this.TextLog.Location = new Point(0, 0);
			this.TextLog.Multiline = true;
			this.TextLog.Name = "TextLog";
			this.TextLog.ScrollBars = ScrollBars.Vertical;
			TextBox textLog = this.TextLog;
			System.Drawing.Size size = new System.Drawing.Size(440, 337);
			textLog.Size = size;
			this.TextLog.TabIndex = 0;
			this.TextLog.Text = "";
			System.Windows.Forms.Menu.MenuItemCollection menuItems = this.MainMenu1.MenuItems;
			MenuItem[] menuItem1 = new MenuItem[] { this.MenuItem1 };
			menuItems.AddRange(menuItem1);
			this.MenuItem1.Index = 0;
			System.Windows.Forms.Menu.MenuItemCollection menuItemCollections = this.MenuItem1.MenuItems;
			menuItem1 = new MenuItem[] { this.MenuItem2, this.MenuItem3 };
			menuItemCollections.AddRange(menuItem1);
			this.MenuItem1.Text = "File";
			this.MenuItem2.Index = 0;
			this.MenuItem2.Text = "Save";
			this.MenuItem3.Index = 1;
			this.MenuItem3.Text = "Print";
			size = new System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new System.Drawing.Size(440, 337);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.TextLog);
			this.Menu = this.MainMenu1;
			this.Name = "LoggerForm";
			this.Text = "Logger Utility";
			this.ResumeLayout(false);
		}

		private void LoggerForm_Load(object sender, EventArgs e)
		{
			TextBox textLog = this.TextLog;
			textLog.Text = string.Concat(textLog.Text, "Ultima Online Landscaper\r\n");
			textLog = this.TextLog;
			textLog.Text = string.Concat(textLog.Text, "=======================================\r\n");
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			for (int i = 0; i < (int)assemblies.Length; i++)
			{
				Assembly assembly = assemblies[i];
				if (assembly.EntryPoint != null)
				{
					this.m_LogName = assembly.EntryPoint.DeclaringType.Name;
					AssemblyName name = assembly.GetName();
					textLog = this.TextLog;
					textLog.Text = string.Concat(textLog.Text, string.Format("{0} version:{1}\r\n", name.Name, name.Version.ToString()));
					name = null;
					AssemblyName[] referencedAssemblies = assembly.GetReferencedAssemblies();
					for (int j = 0; j < (int)referencedAssemblies.Length; j++)
					{
						AssemblyName assemblyName = referencedAssemblies[j];
						textLog = this.TextLog;
						textLog.Text = string.Concat(textLog.Text, string.Format("{0} version:{1}\r\n", assemblyName.Name, assemblyName.Version.ToString()));
						assemblyName = null;
					}
				}
			}
			textLog = this.TextLog;
			textLog.Text = string.Concat(textLog.Text, "\r\n");
		}

		public void LogMessage(string Message)
		{
			TextBox textLog = this.TextLog;
			textLog.Text = string.Concat(textLog.Text, Message, "\r\n");
			this.Refresh();
		}

		public void LogTimeStamp()
		{
			TextBox textLog = this.TextLog;
			textLog.Text = string.Concat(textLog.Text, string.Format("  Task:{0:dd/MMM/yyyy hh:mm:ss}", this.m_Task_Start));
			textLog = this.TextLog;
			textLog.Text = string.Concat(textLog.Text, " === > ");
			textLog = this.TextLog;
			textLog.Text = string.Concat(textLog.Text, string.Format("{0:hh:mm:ss}", this.m_Task_End));
			textLog = this.TextLog;
			textLog.Text = string.Concat(textLog.Text, string.Format("  Total:{0} seconds\r\n", DateAndTime.DateDiff(DateInterval.Second, this.m_Task_Start, this.m_Task_End, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)));
			this.Refresh();
		}

		private void MenuItem2_Click(object sender, EventArgs e)
		{
			string str = string.Format("{0}/Data/Logger/{1}", Directory.GetCurrentDirectory(), this.m_LogName);
			if (!Directory.Exists(str))
			{
				Directory.CreateDirectory(str);
			}
			string str1 = DateTime.Now.ToString("yyyyMMMdd-hhmm");
			StreamWriter streamWriter = new StreamWriter(string.Format("{0}/{1}.txt", str, str1));
			streamWriter.Write(this.TextLog.Text);
			streamWriter.Close();
		}

		private void MenuItem3_Click(object sender, EventArgs e)
		{
			TextPrint textPrint = new TextPrint(this.TextLog.Text)
			{
				Font = new System.Drawing.Font("Arial", 10f)
			};
			textPrint.Print();
		}

		public void StartTask()
		{
			this.m_Task_Start = DateTime.Now;
		}
	}
}