// Decompiled with JetBrains decompiler
// Type: Ultima.CalibrationInfo
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System;
using System.Collections;
using System.IO;

namespace Ultima
{
  public class CalibrationInfo
  {
    private static CalibrationInfo[] m_DefaultList = new CalibrationInfo[3]
    {
      new CalibrationInfo(new byte[15]
      {
        byte.MaxValue,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        (byte) 0,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
      }, new byte[15]
      {
        (byte) 160,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 132,
        (byte) 192,
        (byte) 15,
        (byte) 133,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 139,
        (byte) 13
      }, new byte[0], new byte[0], new byte[0], new byte[6]
      {
        (byte) 1,
        (byte) 4,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        (byte) 1
      }),
      new CalibrationInfo(new byte[32]
      {
        byte.MaxValue,
        byte.MaxValue,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        (byte) 0,
        byte.MaxValue,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        (byte) 0,
        byte.MaxValue,
        byte.MaxValue,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        (byte) 0
      }, new byte[32]
      {
        (byte) 139,
        (byte) 21,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 131,
        (byte) 196,
        (byte) 16,
        (byte) 102,
        (byte) 137,
        (byte) 90,
        (byte) 0,
        (byte) 161,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 102,
        (byte) 137,
        (byte) 120,
        (byte) 0,
        (byte) 139,
        (byte) 13,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 102,
        (byte) 137,
        (byte) 113,
        (byte) 0
      }, new byte[6]
      {
        (byte) 2,
        (byte) 4,
        (byte) 4,
        (byte) 12,
        (byte) 1,
        (byte) 2
      }, new byte[6]
      {
        (byte) 14,
        (byte) 4,
        (byte) 4,
        (byte) 21,
        (byte) 1,
        (byte) 2
      }, new byte[6]
      {
        (byte) 24,
        (byte) 4,
        (byte) 4,
        (byte) 31,
        (byte) 1,
        (byte) 2
      }, new byte[0]),
      new CalibrationInfo(new byte[48]
      {
        byte.MaxValue,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        (byte) 0,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        (byte) 0,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        (byte) 0,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0
      }, new byte[48]
      {
        (byte) 161,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 104,
        (byte) 64,
        (byte) 46,
        (byte) 4,
        (byte) 1,
        (byte) 15,
        (byte) 191,
        (byte) 80,
        (byte) 0,
        (byte) 15,
        (byte) 191,
        (byte) 72,
        (byte) 0,
        (byte) 82,
        (byte) 81,
        (byte) 15,
        (byte) 191,
        (byte) 80,
        (byte) 0,
        (byte) 82,
        (byte) 141,
        (byte) 133,
        (byte) 228,
        (byte) 253,
        byte.MaxValue,
        byte.MaxValue,
        (byte) 104,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 80,
        (byte) 232,
        (byte) 7,
        (byte) 68,
        (byte) 16,
        (byte) 0,
        (byte) 138,
        (byte) 13,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0
      }, new byte[6]
      {
        (byte) 1,
        (byte) 4,
        (byte) 4,
        (byte) 23,
        (byte) 1,
        (byte) 2
      }, new byte[6]
      {
        (byte) 1,
        (byte) 4,
        (byte) 4,
        (byte) 17,
        (byte) 1,
        (byte) 2
      }, new byte[6]
      {
        (byte) 1,
        (byte) 4,
        (byte) 4,
        (byte) 13,
        (byte) 1,
        (byte) 2
      }, new byte[6]
      {
        (byte) 44,
        (byte) 4,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        (byte) 1
      })
    };
    private byte[] m_Mask;
    private byte[] m_Vals;
    private byte[] m_DetX;
    private byte[] m_DetY;
    private byte[] m_DetZ;
    private byte[] m_DetF;

    public byte[] Mask
    {
      get
      {
        return this.m_Mask;
      }
    }

    public byte[] Vals
    {
      get
      {
        return this.m_Vals;
      }
    }

    public byte[] DetX
    {
      get
      {
        return this.m_DetX;
      }
    }

    public byte[] DetY
    {
      get
      {
        return this.m_DetY;
      }
    }

    public byte[] DetZ
    {
      get
      {
        return this.m_DetZ;
      }
    }

    public byte[] DetF
    {
      get
      {
        return this.m_DetF;
      }
    }

    public static CalibrationInfo[] DefaultList
    {
      get
      {
        return CalibrationInfo.m_DefaultList;
      }
      set
      {
        CalibrationInfo.m_DefaultList = value;
      }
    }

    public CalibrationInfo(byte[] mask, byte[] vals, byte[] detx, byte[] dety, byte[] detz, byte[] detf)
    {
      this.m_Mask = mask;
      this.m_Vals = vals;
      this.m_DetX = detx;
      this.m_DetY = dety;
      this.m_DetZ = detz;
      this.m_DetF = detf;
    }

    private static byte[] ReadBytes(StreamReader ip)
    {
      string str = ip.ReadLine();
      if (str == null)
        return (byte[]) null;
      byte[] numArray = new byte[(str.Length + 2) / 3];
      int num = 0;
      int index = 0;
      while (index + 1 < str.Length)
      {
        char ch1 = str[index];
        char ch2 = str[index + 1];
        char ch3;
        if ((int) ch1 >= 48 && (int) ch1 <= 57)
          ch3 = (char) ((uint) ch1 - 48U);
        else if ((int) ch1 >= 97 && (int) ch1 <= 102)
        {
          ch3 = (char) ((uint) ch1 - 87U);
        }
        else
        {
          if ((int) ch1 < 65 || (int) ch1 > 70)
            return (byte[]) null;
          ch3 = (char) ((uint) ch1 - 55U);
        }
        char ch4;
        if ((int) ch2 >= 48 && (int) ch2 <= 57)
          ch4 = (char) ((uint) ch2 - 48U);
        else if ((int) ch2 >= 97 && (int) ch2 <= 102)
        {
          ch4 = (char) ((uint) ch2 - 87U);
        }
        else
        {
          if ((int) ch2 < 65 || (int) ch2 > 70)
            return (byte[]) null;
          ch4 = (char) ((uint) ch2 - 55U);
        }
        numArray[num++] = (byte) ((uint) ch3 << 4 | (uint) ch4);
        index += 3;
      }
      return numArray;
    }

    public static CalibrationInfo[] GetList()
    {
      ArrayList arrayList = new ArrayList();
      string path = Path.Combine(Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]), "calibration.cfg");
      if (File.Exists(path))
      {
        using (StreamReader ip = new StreamReader(path))
        {
          string str;
          while ((str = ip.ReadLine()) != null)
          {
            byte[] mask;
            byte[] vals;
            byte[] detx;
            byte[] dety;
            byte[] detz;
            byte[] detf;
            if (str.Trim().ToLower() == "Begin" && (mask = CalibrationInfo.ReadBytes(ip)) != null && ((vals = CalibrationInfo.ReadBytes(ip)) != null && (detx = CalibrationInfo.ReadBytes(ip)) != null) && ((dety = CalibrationInfo.ReadBytes(ip)) != null && (detz = CalibrationInfo.ReadBytes(ip)) != null && (detf = CalibrationInfo.ReadBytes(ip)) != null))
              arrayList.Add((object) new CalibrationInfo(mask, vals, detx, dety, detz, detf));
          }
        }
      }
      arrayList.AddRange((ICollection) CalibrationInfo.DefaultList);
      return (CalibrationInfo[]) arrayList.ToArray(typeof (CalibrationInfo));
    }
  }
}
