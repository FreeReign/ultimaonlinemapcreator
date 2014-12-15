// Decompiled with JetBrains decompiler
// Type: Logger.LoggerForm
// Assembly: Logger, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: BBBDC7A0-E2FF-4ED5-A568-6573EC28686F
// Assembly location: W:\JetBrains\UOLandscaper\Logger.dll

using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
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
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MainMenu1 == null)
          ;
        this._MainMenu1 = value;
        if (this._MainMenu1 != null)
          ;
      }
    }

    internal virtual MenuItem MenuItem1
    {
      get
      {
        return this._MenuItem1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem1 == null)
          ;
        this._MenuItem1 = value;
        if (this._MenuItem1 != null)
          ;
      }
    }

    internal virtual MenuItem MenuItem2
    {
      get
      {
        return this._MenuItem2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem2 != null)
          this._MenuItem2.Click -= new EventHandler(this.MenuItem2_Click);
        this._MenuItem2 = value;
        if (this._MenuItem2 == null)
          return;
        this._MenuItem2.Click += new EventHandler(this.MenuItem2_Click);
      }
    }

    internal virtual MenuItem MenuItem3
    {
      get
      {
        return this._MenuItem3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._MenuItem3 != null)
          this._MenuItem3.Click -= new EventHandler(this.MenuItem3_Click);
        this._MenuItem3 = value;
        if (this._MenuItem3 == null)
          return;
        this._MenuItem3.Click += new EventHandler(this.MenuItem3_Click);
      }
    }

    internal virtual TextBox TextLog
    {
      get
      {
        return this._TextLog;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._TextLog == null)
          ;
        this._TextLog = value;
        if (this._TextLog != null)
          ;
      }
    }

    public LoggerForm()
    {
      this.Load += new EventHandler(this.LoggerForm_Load);
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
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
      Size size1 = new Size(440, 337);
      Size size2 = size1;
      textLog.Size = size2;
      this.TextLog.TabIndex = 0;
      this.TextLog.Text = "";
      this.MainMenu1.MenuItems.AddRange(new MenuItem[1]
      {
        this.MenuItem1
      });
      this.MenuItem1.Index = 0;
      this.MenuItem1.MenuItems.AddRange(new MenuItem[2]
      {
        this.MenuItem2,
        this.MenuItem3
      });
      this.MenuItem1.Text = "File";
      this.MenuItem2.Index = 0;
      this.MenuItem2.Text = "Save";
      this.MenuItem3.Index = 1;
      this.MenuItem3.Text = "Print";
      size1 = new Size(5, 13);
      this.AutoScaleBaseSize = size1;
      size1 = new Size(440, 337);
      this.ClientSize = size1;
      this.ControlBox = false;
      this.Controls.Add((Control) this.TextLog);
      this.Menu = this.MainMenu1;
      this.Name = "LoggerForm";
      this.Text = "Logger Utility";
      this.ResumeLayout(false);
    }

    private void LoggerForm_Load(object sender, EventArgs e)
    {
      TextBox textLog1 = this.TextLog;
      textLog1.Text = textLog1.Text + "Ultima Online Landscaper\r\n";
      TextBox textLog2 = this.TextLog;
      textLog2.Text = textLog2.Text + "=======================================\r\n";
      Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
      int index1 = 0;
      while (index1 < assemblies.Length)
      {
        Assembly assembly = assemblies[index1];
        if (assembly.EntryPoint != null)
        {
          this.m_LogName = assembly.EntryPoint.DeclaringType.Name;
          AssemblyName name = assembly.GetName();
          TextBox textLog3 = this.TextLog;
          textLog3.Text = textLog3.Text + string.Format("{0} version:{1}\r\n", (object) name.Name, (object) name.Version.ToString());
          AssemblyName[] referencedAssemblies = assembly.GetReferencedAssemblies();
          int index2 = 0;
          while (index2 < referencedAssemblies.Length)
          {
            AssemblyName assemblyName = referencedAssemblies[index2];
            TextBox textLog4 = this.TextLog;
            textLog4.Text = textLog4.Text + string.Format("{0} version:{1}\r\n", (object) assemblyName.Name, (object) assemblyName.Version.ToString());
            checked { ++index2; }
          }
        }
        checked { ++index1; }
      }
      TextBox textLog5 = this.TextLog;
      textLog5.Text = textLog5.Text + "\r\n";
    }

    public void StartTask()
    {
      this.m_Task_Start = DateTime.Now;
    }

    public void EndTask()
    {
      this.m_Task_End = DateTime.Now;
    }

    public void LogTimeStamp()
    {
      TextBox textLog1 = this.TextLog;
      textLog1.Text = textLog1.Text + string.Format("  Task:{0:dd/MMM/yyyy hh:mm:ss}", (object) this.m_Task_Start);
      TextBox textLog2 = this.TextLog;
      textLog2.Text = textLog2.Text + " === > ";
      TextBox textLog3 = this.TextLog;
      textLog3.Text = textLog3.Text + string.Format("{0:hh:mm:ss}", (object) this.m_Task_End);
      TextBox textLog4 = this.TextLog;
      textLog4.Text = textLog4.Text + string.Format("  Total:{0} seconds\r\n", (object) DateAndTime.DateDiff(DateInterval.Second, this.m_Task_Start, this.m_Task_End, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
      this.Refresh();
    }

    public void LogMessage(string Message)
    {
      TextBox textLog = this.TextLog;
      textLog.Text = textLog.Text + Message + "\r\n";
      this.Refresh();
    }

    private void MenuItem3_Click(object sender, EventArgs e)
    {
      new TextPrint(this.TextLog.Text)
      {
        Font = new Font("Arial", 10f)
      }.Print();
    }

    private void MenuItem2_Click(object sender, EventArgs e)
    {
      string path = string.Format("{0}/Data/Logger/{1}", (object) Directory.GetCurrentDirectory(), (object) this.m_LogName);
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      string str = DateTime.Now.ToString("yyyyMMMdd-hhmm");
      StreamWriter streamWriter = new StreamWriter(string.Format("{0}/{1}.txt", (object) path, (object) str));
      streamWriter.Write(this.TextLog.Text);
      streamWriter.Close();
    }
  }
}
