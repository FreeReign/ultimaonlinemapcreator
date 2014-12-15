// Decompiled with JetBrains decompiler
// Type: DragonConv.ClsDragonTable
// Assembly: DragonConv, Version=1.0.1819.29268, Culture=neutral, PublicKeyToken=null
// MVID: BA7AE34F-ABD8-4700-AE28-2ED5A239CB08
// Assembly location: W:\JetBrains\UOLandscaper\DragonConv.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Text;
using System.Xml;

namespace DragonConv
{
  public class ClsDragonTable
  {
    private Hashtable m_Dragon;

    public Hashtable DragonHash
    {
      get
      {
        return this.m_Dragon;
      }
    }

    public ClsDragonTable()
    {
      this.m_Dragon = new Hashtable(256);
    }

    public ClsDragon get_GetDragon(int Index)
    {
      return (ClsDragon) this.m_Dragon[(object) Index];
    }

    public void set_GetDragon(int Index, ClsDragon Value)
    {
      this.m_Dragon[(object) Index] = (object) Value;
    }

    public void Load(string iFileName)
    {
      XmlDocument xmlDocument = new XmlDocument();
      try
      {
        xmlDocument.Load(iFileName);
        this.m_Dragon.Clear();
        try
        {
          foreach (XmlElement xmlElement in xmlDocument.SelectNodes("Dragon"))
          {
            try
            {
              foreach (XmlElement xmlInfo in xmlElement.SelectNodes("HexCode"))
              {
                ClsDragon clsDragon = new ClsDragon(xmlInfo);
                this.m_Dragon.Add((object) clsDragon.GroupID, (object) clsDragon);
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                ((IDisposable) enumerator).Dispose();
            }
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
        int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.OKOnly, (object) null);
        ProjectData.ClearProjectError();
      }
    }

    public void Save(string iFilename)
    {
      XmlTextWriter xmlInfo = new XmlTextWriter(iFilename, Encoding.UTF8);
      xmlInfo.Indentation = 2;
      xmlInfo.Formatting = Formatting.Indented;
      xmlInfo.WriteStartDocument();
      ((XmlWriter) xmlInfo).WriteStartElement("Dragon");
      try
      {
        foreach (ClsDragon clsDragon in (IEnumerable) this.m_Dragon.Values)
          clsDragon.Save(xmlInfo);
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
  }
}
