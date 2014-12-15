// Decompiled with JetBrains decompiler
// Type: Transition.TransitionTable
// Assembly: Transition, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: D3B0804F-08F3-42BB-B2B3-B2AAA4B5AE51
// Assembly location: W:\JetBrains\UOLandscaper\Transition.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Transition
{
  public class TransitionTable
  {
    private Hashtable i_Transitions;

    public Hashtable TransitionTable
    {
      get
      {
        return this.i_Transitions;
      }
    }

    public TransitionTable()
    {
      this.i_Transitions = new Hashtable();
    }

    public Transition get_Transition(string iKey)
    {
      return (Transition) this.i_Transitions[(object) iKey];
    }

    public void Clear()
    {
      this.i_Transitions.Clear();
    }

    public void Add(Transition iValue)
    {
      try
      {
        this.i_Transitions.Add((object) iValue.HashKey, (object) iValue);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.OKOnly, (object) null);
        ProjectData.ClearProjectError();
      }
    }

    public void Remove(Transition iValue)
    {
      this.i_Transitions.Remove((object) iValue.HashKey);
    }

    public void Display(ListBox iList)
    {
      iList.Items.Clear();
      try
      {
        foreach (Transition transition in (IEnumerable) this.i_Transitions.Values)
          iList.Items.Add((object) transition);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
    }

    public void Load(string iFilename)
    {
      XmlDocument xmlDocument = new XmlDocument();
      try
      {
        xmlDocument.Load(iFilename);
        try
        {
          foreach (XmlElement xmlInfo in xmlDocument.SelectNodes("//Trans/TransInfo"))
          {
            Transition transition = new Transition(xmlInfo);
            this.i_Transitions.Add((object) transition.HashKey, (object) transition);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            ((IDisposable) enumerator).Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) string.Format("XMLFile:{0}", (object) iFilename), MsgBoxStyle.OKOnly, (object) null);
        ProjectData.ClearProjectError();
      }
    }

    public void Save(string iFilename)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.FileName = iFilename;
      saveFileDialog.Filter = "xml files (*.xml)|*.xml";
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      XmlTextWriter xmlInfo = new XmlTextWriter(saveFileDialog.FileName, Encoding.UTF8);
      xmlInfo.Indentation = 2;
      xmlInfo.Formatting = Formatting.Indented;
      xmlInfo.WriteStartDocument();
      ((XmlWriter) xmlInfo).WriteStartElement("Trans");
      try
      {
        foreach (Transition transition in (IEnumerable) this.i_Transitions.Values)
          transition.Save(xmlInfo);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
      xmlInfo.WriteEndElement();
      xmlInfo.WriteEndDocument();
      xmlInfo.Close();
    }

    public void Save(string iPath, string iFilename)
    {
      XmlTextWriter xmlInfo = new XmlTextWriter(string.Format("{0}/{1}.xml", (object) iPath, (object) iFilename), Encoding.UTF8);
      xmlInfo.Indentation = 2;
      xmlInfo.Formatting = Formatting.Indented;
      xmlInfo.WriteStartDocument();
      ((XmlWriter) xmlInfo).WriteStartElement("Trans");
      try
      {
        foreach (Transition transition in (IEnumerable) this.i_Transitions.Values)
          transition.Save(xmlInfo);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
      xmlInfo.WriteEndElement();
      xmlInfo.WriteEndDocument();
      xmlInfo.Close();
    }

    public void MassLoad(string iPath)
    {
      this.ProcessDirectory(iPath);
    }

    public void ProcessDirectory(string targetDirectory)
    {
      string[] files = Directory.GetFiles(targetDirectory, "*.xml");
      int index1 = 0;
      while (index1 < files.Length)
      {
        this.Load(files[index1]);
        checked { ++index1; }
      }
      string[] directories = Directory.GetDirectories(targetDirectory);
      int index2 = 0;
      while (index2 < directories.Length)
      {
        this.ProcessDirectory(directories[index2]);
        checked { ++index2; }
      }
    }
  }
}
