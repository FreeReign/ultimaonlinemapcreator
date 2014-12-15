// Decompiled with JetBrains decompiler
// Type: Ultima.FileIndex
// Assembly: Ultima, Version=1.0.1472.37576, Culture=neutral, PublicKeyToken=null
// MVID: 46638872-DE1F-4F9F-8E8D-1BE44A131A9D
// Assembly location: W:\JetBrains\UOLandscaper\Ultima.dll

using System.IO;

namespace Ultima
{
  public class FileIndex
  {
    private Entry3D[] m_Index;
    private Stream m_Stream;

    public Entry3D[] Index
    {
      get
      {
        return this.m_Index;
      }
    }

    public Stream Stream
    {
      get
      {
        return this.m_Stream;
      }
    }

    public FileIndex(string idxFile, string mulFile, int length, int file)
    {
      this.m_Index = new Entry3D[length];
      string filePath1 = Client.GetFilePath(idxFile);
      string filePath2 = Client.GetFilePath(mulFile);
      if (filePath1 != null && filePath2 != null)
      {
        using (FileStream fileStream = new FileStream(filePath1, FileMode.Open, FileAccess.Read, FileShare.Read))
        {
          BinaryReader binaryReader = new BinaryReader((Stream) fileStream);
          this.m_Stream = (Stream) new FileStream(filePath2, FileMode.Open, FileAccess.Read, FileShare.Read);
          int num = (int) (fileStream.Length / 12L);
          for (int index = 0; index < num && index < length; ++index)
          {
            this.m_Index[index].lookup = binaryReader.ReadInt32();
            this.m_Index[index].length = binaryReader.ReadInt32();
            this.m_Index[index].extra = binaryReader.ReadInt32();
          }
          for (int index = num; index < length; ++index)
          {
            this.m_Index[index].lookup = -1;
            this.m_Index[index].length = -1;
            this.m_Index[index].extra = -1;
          }
        }
      }
      foreach (Entry5D entry5D in Verdata.Patches)
      {
        if (entry5D.file == file && entry5D.index >= 0 && entry5D.index < length)
        {
          this.m_Index[entry5D.index].lookup = entry5D.lookup;
          this.m_Index[entry5D.index].length = entry5D.length | int.MinValue;
          this.m_Index[entry5D.index].extra = entry5D.extra;
        }
      }
    }

    public Stream Seek(int index, out int length, out int extra, out bool patched)
    {
      if (index < 0 || index >= this.m_Index.Length)
      {
        length = extra = 0;
        patched = false;
        return (Stream) null;
      }
      else
      {
        Entry3D entry3D = this.m_Index[index];
        if (entry3D.lookup < 0)
        {
          length = extra = 0;
          patched = false;
          return (Stream) null;
        }
        else
        {
          length = entry3D.length & int.MaxValue;
          extra = entry3D.extra;
          if ((entry3D.length & int.MinValue) != 0)
          {
            patched = true;
            Verdata.Stream.Seek((long) entry3D.lookup, SeekOrigin.Begin);
            return Verdata.Stream;
          }
          else if (this.m_Stream == null)
          {
            length = extra = 0;
            patched = false;
            return (Stream) null;
          }
          else
          {
            patched = false;
            this.m_Stream.Seek((long) entry3D.lookup, SeekOrigin.Begin);
            return this.m_Stream;
          }
        }
      }
    }
  }
}
