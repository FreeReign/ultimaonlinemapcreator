// Decompiled with JetBrains decompiler
// Type: Ultima.BodyConverter
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System;
using System.Collections;
using System.IO;

namespace Ultima
{
  public class BodyConverter
  {
    private static int[] m_Table1;
    private static int[] m_Table2;

    static BodyConverter()
    {
      string filePath = Client.GetFilePath("bodyconv.def");
      if (filePath == null)
        return;
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      int num1 = 0;
      int num2 = 0;
      using (StreamReader streamReader = new StreamReader(filePath))
      {
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
                string[] strArray = str2.Split('\t');
                int num3 = Convert.ToInt32(strArray[0]);
                int num4 = Convert.ToInt32(strArray[1]);
                int num5;
                try
                {
                  num5 = Convert.ToInt32(strArray[2]);
                }
                catch
                {
                  num5 = -1;
                }
                if (num4 != -1)
                {
                  if (num4 == 68)
                    num4 = 122;
                  if (num3 > num1)
                    num1 = num3;
                  arrayList1.Add((object) num3);
                  arrayList1.Add((object) num4);
                }
                if (num5 != -1)
                {
                  if (num3 > num2)
                    num2 = num3;
                  arrayList2.Add((object) num3);
                  arrayList2.Add((object) num5);
                }
              }
              catch
              {
              }
            }
          }
        }
      }
      BodyConverter.m_Table1 = new int[num1 + 1];
      for (int index = 0; index < BodyConverter.m_Table1.Length; ++index)
        BodyConverter.m_Table1[index] = -1;
      int index1 = 0;
      while (index1 < arrayList1.Count)
      {
        BodyConverter.m_Table1[(int) arrayList1[index1]] = (int) arrayList1[index1 + 1];
        index1 += 2;
      }
      BodyConverter.m_Table2 = new int[num2 + 1];
      for (int index2 = 0; index2 < BodyConverter.m_Table2.Length; ++index2)
        BodyConverter.m_Table2[index2] = -1;
      int index3 = 0;
      while (index3 < arrayList2.Count)
      {
        BodyConverter.m_Table2[(int) arrayList2[index3]] = (int) arrayList2[index3 + 1];
        index3 += 2;
      }
    }

    private BodyConverter()
    {
    }

    public static bool Contains(int body)
    {
      return BodyConverter.m_Table1 != null && body >= 0 && (body < BodyConverter.m_Table1.Length && BodyConverter.m_Table1[body] != -1) || BodyConverter.m_Table2 != null && body >= 0 && (body < BodyConverter.m_Table2.Length && BodyConverter.m_Table2[body] != -1);
    }

    public static int Convert(ref int body)
    {
      if (BodyConverter.m_Table1 != null && body >= 0 && body < BodyConverter.m_Table1.Length)
      {
        int num = BodyConverter.m_Table1[body];
        if (num != -1)
        {
          body = num;
          return 2;
        }
      }
      if (BodyConverter.m_Table2 != null && body >= 0 && body < BodyConverter.m_Table2.Length)
      {
        int num = BodyConverter.m_Table2[body];
        if (num != -1)
        {
          body = num;
          return 3;
        }
      }
      return 1;
    }
  }
}
