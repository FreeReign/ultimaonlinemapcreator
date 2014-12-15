// Decompiled with JetBrains decompiler
// Type: Transition.RandomStatics
// Assembly: Transition, Version=1.0.1819.29267, Culture=neutral, PublicKeyToken=null
// MVID: D3B0804F-08F3-42BB-B2B3-B2AAA4B5AE51
// Assembly location: W:\JetBrains\UOLandscaper\Transition.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Transition
{
  public class RandomStatics : CollectionBase
  {
    private int m_Freq;
    private Collection m_Random;

    public int Freq
    {
      get
      {
        return this.m_Freq;
      }
      set
      {
        this.m_Freq = value;
      }
    }

    public RandomStaticCollection this[int index]
    {
      get
      {
        return (RandomStaticCollection) this.List[index];
      }
      set
      {
        this.List[index] = (object) value;
      }
    }

    public RandomStatics()
    {
      this.m_Random = new Collection();
    }

    public RandomStatics(string iFileName)
    {
      this.m_Random = new Collection();
      XmlDocument xmlDocument = new XmlDocument();
      try
      {
        string filename = string.Format("{0}Data\\Statics\\{1}", (object) AppDomain.CurrentDomain.BaseDirectory, (object) iFileName);
        xmlDocument.Load(filename);
        XmlElement xmlElement = (XmlElement) xmlDocument.SelectSingleNode("//RandomStatics");
        this.m_Freq = (int) XmlConvert.ToInt16(xmlElement.GetAttribute("Chance"));
        try
        {
          foreach (XmlElement xmlInfo in xmlElement.SelectNodes("Statics"))
          {
            RandomStaticCollection staticCollection = new RandomStaticCollection(xmlInfo);
            this.InnerList.Add((object) staticCollection);
            if (staticCollection.Freq > 0)
            {
              int num1 = 1;
              byte num2 = checked ((byte) staticCollection.Freq);
              for (byte index = (byte) num1; (int) index <= (int) num2; ++index)
                this.m_Random.Add((object) staticCollection, (string) null, (object) null, (object) null);
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
        int num = (int) Interaction.MsgBox((object) ("Can not find:" + iFileName), MsgBoxStyle.OKOnly, (object) null);
        ProjectData.ClearProjectError();
      }
    }

    public void Add(RandomStaticCollection Value)
    {
      this.InnerList.Add((object) Value);
      int num1 = 0;
      byte num2 = checked ((byte) Value.Count);
      for (byte index = (byte) num1; (int) index <= (int) num2; ++index)
        this.m_Random.Add((object) Value, (string) null, (object) null, (object) null);
    }

    public void Remove(RandomStaticCollection Value)
    {
      this.InnerList.Remove((object) Value);
    }

    public void Save(string iFileName)
    {
      XmlTextWriter xmlInfo = new XmlTextWriter(iFileName, Encoding.UTF8);
      xmlInfo.Indentation = 2;
      xmlInfo.Formatting = Formatting.Indented;
      xmlInfo.WriteStartDocument();
      ((XmlWriter) xmlInfo).WriteStartElement("RandomStatics");
      xmlInfo.WriteAttributeString("Chance", StringType.FromInteger(this.m_Freq));
      try
      {
        foreach (RandomStaticCollection staticCollection in this.InnerList)
          staticCollection.Save(xmlInfo);
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

    public void Display(ListBox iList)
    {
      iList.Items.Clear();
      try
      {
        foreach (RandomStaticCollection staticCollection in this.InnerList)
          iList.Items.Add((object) staticCollection);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          ((IDisposable) enumerator).Dispose();
      }
    }

    public void GetRandomStatic(short X, short Y, short Z, Collection[,] StaticMap)
    {
      if (this.m_Random.Count == 0)
        return;
      VBMath.Randomize();
      if (checked ((int) Math.Round((double) Conversion.Int(unchecked (100f * VBMath.Rnd())))) <= this.m_Freq)
        ((RandomStaticCollection) this.m_Random[checked ((int) Math.Round((double) unchecked ((float) Conversion.Int(checked (this.m_Random.Count - 1)) * VBMath.Rnd())) + 1)]).RandomStatic(X, Y, Z, StaticMap);
    }
  }
}
