using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Xml;

namespace DataList
{
	internal class Core
	{
		public Core()
		{
		}

		[STAThread]
		private static void Main(string[] args)
		{
			FileStream fileStream = null;
			StreamWriter streamWriter = null;
			try
			{
				if (!File.Exists(string.Format("{0}Data.xml", AppDomain.CurrentDomain.BaseDirectory)))
				{
					Console.WriteLine("Writing Data into a Data.xml file");
					XmlTextWriter xmlTextWriter = new XmlTextWriter(string.Format("{0}Data.xml", AppDomain.CurrentDomain.BaseDirectory), Encoding.ASCII)
					{
						Formatting = Formatting.Indented,
						IndentChar = '\t',
						Indentation = 2
					};
					xmlTextWriter.WriteStartElement("Config");
					xmlTextWriter.WriteComment("Configuration File for DataList");
					xmlTextWriter.WriteStartElement("DataName");
					xmlTextWriter.WriteAttributeString("Name", "Blank Data");
					xmlTextWriter.WriteEndElement();
					xmlTextWriter.WriteStartElement("Directories");
					xmlTextWriter.WriteStartElement("Directory");
					xmlTextWriter.WriteAttributeString("Name", "Main");
					xmlTextWriter.WriteEndElement();
					xmlTextWriter.WriteStartElement("Directory");
					xmlTextWriter.WriteAttributeString("Name", "Main\\SubFolder");
					xmlTextWriter.WriteEndElement();
					xmlTextWriter.WriteStartElement("Directory");
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
			string value = null;
			ArrayList arrayLists = new ArrayList();
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(string.Format("{0}Data.xml", AppDomain.CurrentDomain.BaseDirectory));
				XmlNode itemOf = xmlDocument.GetElementsByTagName("Config")[0];
				value = itemOf["DataName"].Attributes["Name"].Value;
				foreach (XmlNode elementsByTagName in xmlDocument.GetElementsByTagName("Directory"))
				{
					XmlAttribute xmlAttribute = elementsByTagName.Attributes["Name"];
					arrayLists.Add(xmlAttribute.Value);
				}
			}
			catch
			{
				Console.WriteLine("Error reading Data.cfg");
			}
			Console.Write("Searching {0} Data...", value);
			fileStream = null;
			streamWriter = null;
			try
			{
				try
				{
					if (!Directory.Exists(string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, arrayLists[0])))
					{
						Console.WriteLine("Failed... Present Directory not found...");
					}
					else
					{
						fileStream = new FileStream(string.Format("{0}{1}_Data.log", AppDomain.CurrentDomain.BaseDirectory, value), FileMode.Create);
						streamWriter = new StreamWriter(fileStream);
						Console.WriteLine("Found...");
						streamWriter.WriteLine("***FullName***");
						Console.WriteLine("***FullName***");
						int num = 1;
						foreach (string arrayList in arrayLists)
						{
							string[] directories = Directory.GetDirectories(string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, arrayList));
							for (int i = 0; i < (int)directories.Length; i++)
							{
								string[] files = Directory.GetFiles(directories[i]);
								for (int j = 0; j < (int)files.Length; j++)
								{
									string str = files[j];
									streamWriter.WriteLine(str);
									Console.WriteLine("Writing to File: {0}", str);
									num++;
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
						foreach (string arrayList1 in arrayLists)
						{
							string[] strArrays = Directory.GetFiles(string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, arrayList1));
							for (int k = 0; k < (int)strArrays.Length; k++)
							{
								string str1 = strArrays[k];
								int length = AppDomain.CurrentDomain.BaseDirectory.Length + 5;
								streamWriter.WriteLine(Path.GetFullPath(str1).Substring(length));
								Console.WriteLine("Writing to File: {0}", Path.GetFullPath(str1).Substring(length));
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
						foreach (string arrayList2 in arrayLists)
						{
							string[] directories1 = Directory.GetDirectories(string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, arrayList2));
							for (int l = 0; l < (int)directories1.Length; l++)
							{
								FileInfo[] fileInfoArray = (new DirectoryInfo(directories1[l])).GetFiles();
								for (int m = 0; m < (int)fileInfoArray.Length; m++)
								{
									FileInfo fileInfo = fileInfoArray[m];
									streamWriter.WriteLine(fileInfo.Name);
									Console.WriteLine("Writing to File: {0}", fileInfo.Name);
								}
							}
						}
						Console.WriteLine();
						Console.WriteLine("Completed, Process generated {0} Files", num);
					}
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					Console.WriteLine("Failed...");
					Console.WriteLine();
					Console.WriteLine(exception.ToString());
				}
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