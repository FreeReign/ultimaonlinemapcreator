// Decompiled with JetBrains decompiler
// Type: DataList.Core
// Assembly: DataList, Version=1.0.2119.36767, Culture=neutral, PublicKeyToken=null
// MVID: 24BF0BAF-9370-4E5F-9697-F61B66680C81
// Assembly location: W:\JetBrains\UOLandscaper\DataList.exe

using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Xml;

namespace DataList
{
  internal class Core
  {
    [STAThread]
    private static void Main(string[] args)
    {
      try
      {
        if (!File.Exists(string.Format("{0}Data.xml", (object) AppDomain.CurrentDomain.BaseDirectory)))
        {
          Console.WriteLine("Writing Data into a Data.xml file");
          XmlTextWriter xmlTextWriter = new XmlTextWriter(string.Format("{0}Data.xml", (object) AppDomain.CurrentDomain.BaseDirectory), Encoding.ASCII);
          xmlTextWriter.Formatting = Formatting.Indented;
          xmlTextWriter.IndentChar = '\t';
          xmlTextWriter.Indentation = 2;
          ((XmlWriter) xmlTextWriter).WriteStartElement("Config");
          xmlTextWriter.WriteComment("Configuration File for DataList");
          ((XmlWriter) xmlTextWriter).WriteStartElement("DataName");
          xmlTextWriter.WriteAttributeString("Name", "Blank Data");
          xmlTextWriter.WriteEndElement();
          ((XmlWriter) xmlTextWriter).WriteStartElement("Directories");
          ((XmlWriter) xmlTextWriter).WriteStartElement("Directory");
          xmlTextWriter.WriteAttributeString("Name", "Main");
          xmlTextWriter.WriteEndElement();
          ((XmlWriter) xmlTextWriter).WriteStartElement("Directory");
          xmlTextWriter.WriteAttributeString("Name", "Main\\SubFolder");
          xmlTextWriter.WriteEndElement();
          ((XmlWriter) xmlTextWriter).WriteStartElement("Directory");
          xmlTextWriter.WriteAttributeString("Name", "Main\\SubFolder\\SubFolder");
          xmlTextWriter.WriteEndElement();
          xmlTextWriter.WriteEndElement();
          xmlTextWriter.WriteEndElement();
          xmlTextWriter.Close();
        }
      }
      catch
      {
        Console.WriteLine("Error writing into Data.xml");
        return;
      }
      string str1 = (string) null;
      ArrayList arrayList = new ArrayList();
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(string.Format("{0}Data.xml", (object) AppDomain.CurrentDomain.BaseDirectory));
        str1 = xmlDocument.GetElementsByTagName("Config")[0]["DataName"].Attributes["Name"].Value;
        foreach (XmlNode xmlNode in xmlDocument.GetElementsByTagName("Directory"))
        {
          XmlAttribute xmlAttribute = xmlNode.Attributes["Name"];
          arrayList.Add((object) xmlAttribute.Value);
        }
      }
      catch
      {
        Console.WriteLine("Error reading Data.cfg");
      }
      Console.Write("Searching {0} Data...", (object) str1);
      FileStream fileStream = (FileStream) null;
      StreamWriter streamWriter = (StreamWriter) null;
      try
      {
        if (Directory.Exists(string.Format("{0}{1}", (object) AppDomain.CurrentDomain.BaseDirectory, arrayList[0])))
        {
          fileStream = new FileStream(string.Format("{0}{1}_Data.log", (object) AppDomain.CurrentDomain.BaseDirectory, (object) str1), FileMode.Create);
          streamWriter = new StreamWriter((Stream) fileStream);
          Console.WriteLine("Found...");
          streamWriter.WriteLine("***FullName***");
          Console.WriteLine("***FullName***");
          int num = 1;
          foreach (string str2 in arrayList)
          {
            foreach (string path in Directory.GetDirectories(string.Format("{0}{1}", (object) AppDomain.CurrentDomain.BaseDirectory, (object) str2)))
            {
              foreach (string str3 in Directory.GetFiles(path))
              {
                streamWriter.WriteLine(str3);
                Console.WriteLine("Writing to File: {0}", (object) str3);
                ++num;
              }
            }
          }
          Console.WriteLine();
          streamWriter.WriteLine();
          Console.WriteLine();
          streamWriter.WriteLine();
          Console.WriteLine();
          streamWriter.WriteLine();
          Console.WriteLine("***Name of Files without the path of \"Data\"***");
          streamWriter.WriteLine("***Name of Files without the path of \"Data\"***");
          Console.WriteLine();
          streamWriter.WriteLine();
          foreach (string str2 in arrayList)
          {
            foreach (string path in Directory.GetFiles(string.Format("{0}{1}", (object) AppDomain.CurrentDomain.BaseDirectory, (object) str2)))
            {
              int startIndex = AppDomain.CurrentDomain.BaseDirectory.Length + 5;
              streamWriter.WriteLine(Path.GetFullPath(path).Substring(startIndex));
              Console.WriteLine("Writing to File: {0}", (object) Path.GetFullPath(path).Substring(startIndex));
            }
          }
          Console.WriteLine();
          streamWriter.WriteLine();
          Console.WriteLine();
          streamWriter.WriteLine();
          Console.WriteLine();
          streamWriter.WriteLine();
          Console.WriteLine("***Name of Files***");
          streamWriter.WriteLine("***Name of Files***");
          Console.WriteLine();
          streamWriter.WriteLine();
          foreach (string str2 in arrayList)
          {
            foreach (string path in Directory.GetDirectories(string.Format("{0}{1}", (object) AppDomain.CurrentDomain.BaseDirectory, (object) str2)))
            {
              foreach (FileInfo fileInfo in new DirectoryInfo(path).GetFiles())
              {
                streamWriter.WriteLine(fileInfo.Name);
                Console.WriteLine("Writing to File: {0}", (object) fileInfo.Name);
              }
            }
          }
          Console.WriteLine();
          Console.WriteLine("Completed, Process generated {0} Files", (object) num);
        }
        else
          Console.WriteLine("Failed... Present Directory not found...");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Failed...");
        Console.WriteLine();
        Console.WriteLine(ex.ToString());
      }
      finally
      {
        if (streamWriter != null && fileStream != null)
        {
          streamWriter.Close();
          fileStream.Close();
        }
      }
      Console.ReadLine();
    }
  }
}
