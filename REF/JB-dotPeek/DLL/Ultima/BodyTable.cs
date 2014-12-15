// Decompiled with JetBrains decompiler
// Type: Ultima.BodyTable
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System;
using System.Collections;
using System.IO;

namespace Ultima
{
  public class BodyTable
  {
    public static Hashtable m_Entries = new Hashtable();

    static BodyTable()
    {
      string filePath = Client.GetFilePath("body.def");
      if (filePath == null)
        return;
      StreamReader streamReader = new StreamReader(filePath);
      string str1;
      while ((str1 = streamReader.ReadLine()) != null)
      {
        string str2;
        if ((str2 = str1.Trim()).Length != 0)
        {
          if (!str2.StartsWith("#"))
          {
            try
            {
              int length1 = str2.IndexOf(" {");
              int num = str2.IndexOf("} ");
              string str3 = str2.Substring(0, length1);
              string str4 = str2.Substring(length1 + 2, num - length1 - 2);
              string str5 = str2.Substring(num + 2);
              int length2 = str4.IndexOf(',');
              if (length2 > -1)
                str4 = str4.Substring(0, length2).Trim();
              int newID = Convert.ToInt32(str3);
              int oldID = Convert.ToInt32(str4);
              int newHue = Convert.ToInt32(str5);
              BodyTable.m_Entries[(object) newID] = (object) new BodyTableEntry(oldID, newID, newHue);
            }
            catch
            {
            }
          }
        }
      }
    }
  }
}
