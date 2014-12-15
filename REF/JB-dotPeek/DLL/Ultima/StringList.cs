// Decompiled with JetBrains decompiler
// Type: Ultima.StringList
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System.Collections;
using System.IO;
using System.Text;

namespace Ultima
{
  public class StringList
  {
    private static byte[] m_Buffer = new byte[1024];
    private Hashtable m_Table;
    private StringEntry[] m_Entries;
    private string m_Language;

    public StringEntry[] Entries
    {
      get
      {
        return this.m_Entries;
      }
    }

    public Hashtable Table
    {
      get
      {
        return this.m_Table;
      }
    }

    public string Language
    {
      get
      {
        return this.m_Language;
      }
    }

    public StringList(string language)
    {
      this.m_Language = language;
      this.m_Table = new Hashtable();
      string filePath = Client.GetFilePath(string.Format("cliloc.{0}", (object) language));
      if (filePath == null)
      {
        this.m_Entries = new StringEntry[0];
      }
      else
      {
        ArrayList arrayList = new ArrayList();
        using (BinaryReader binaryReader = new BinaryReader((Stream) new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)))
        {
          binaryReader.ReadInt32();
          int num1 = (int) binaryReader.ReadInt16();
          while (binaryReader.PeekChar() != -1)
          {
            int number = binaryReader.ReadInt32();
            int num2 = (int) binaryReader.ReadByte();
            int count = (int) binaryReader.ReadInt16();
            if (count > StringList.m_Buffer.Length)
              StringList.m_Buffer = new byte[count + 1023 & -1024];
            binaryReader.Read(StringList.m_Buffer, 0, count);
            string @string = Encoding.UTF8.GetString(StringList.m_Buffer, 0, count);
            arrayList.Add((object) new StringEntry(number, @string));
            this.m_Table[(object) number] = (object) @string;
          }
        }
        this.m_Entries = (StringEntry[]) arrayList.ToArray(typeof (StringEntry));
      }
    }
  }
}
