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

		public Transition.Transition Transition(string iKey)
		{
			get
			{
				return (Transition.Transition)this.i_Transitions[iKey];
			}
		}

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

		public void Add(Transition.Transition iValue)
		{
			try
			{
				this.i_Transitions.Add(iValue.HashKey, iValue);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Interaction.MsgBox(exception.Message, MsgBoxStyle.OKOnly, null);
				ProjectData.ClearProjectError();
			}
		}

		public void Clear()
		{
			this.i_Transitions.Clear();
		}

		public void Display(ListBox iList)
		{
			IEnumerator enumerator = null;
			iList.Items.Clear();
			try
			{
				enumerator = this.i_Transitions.Values.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Transition.Transition current = (Transition.Transition)enumerator.Current;
					iList.Items.Add(current);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		public void Load(string iFilename)
		{
			IEnumerator enumerator = null;
			XmlDocument xmlDocument = new XmlDocument();
			try
			{
				xmlDocument.Load(iFilename);
				try
				{
					enumerator = xmlDocument.SelectNodes("//Trans/TransInfo").GetEnumerator();
					while (enumerator.MoveNext())
					{
						Transition.Transition transition = new Transition.Transition((XmlElement)enumerator.Current);
						this.i_Transitions.Add(transition.HashKey, transition);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						((IDisposable)enumerator).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Interaction.MsgBox(string.Format("XMLFile:{0}", iFilename), MsgBoxStyle.OKOnly, null);
				ProjectData.ClearProjectError();
			}
		}

		public void MassLoad(string iPath)
		{
			this.ProcessDirectory(iPath);
		}

		public void ProcessDirectory(string targetDirectory)
		{
			string[] files = Directory.GetFiles(targetDirectory, "*.xml");
			for (int i = 0; i < (int)files.Length; i++)
			{
				this.Load(files[i]);
			}
			string[] directories = Directory.GetDirectories(targetDirectory);
			for (int j = 0; j < (int)directories.Length; j++)
			{
				this.ProcessDirectory(directories[j]);
			}
		}

		public void Remove(Transition.Transition iValue)
		{
			this.i_Transitions.Remove(iValue.HashKey);
		}

		public void Save(string iFilename)
		{
			IEnumerator enumerator = null;
			SaveFileDialog saveFileDialog = new SaveFileDialog()
			{
				FileName = iFilename,
				Filter = "xml files (*.xml)|*.xml"
			};
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				XmlTextWriter xmlTextWriter = new XmlTextWriter(saveFileDialog.FileName, Encoding.UTF8)
				{
					Indentation = 2,
					Formatting = Formatting.Indented
				};
				xmlTextWriter.WriteStartDocument();
				xmlTextWriter.WriteStartElement("Trans");
				try
				{
					enumerator = this.i_Transitions.Values.GetEnumerator();
					while (enumerator.MoveNext())
					{
						((Transition.Transition)enumerator.Current).Save(xmlTextWriter);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						((IDisposable)enumerator).Dispose();
					}
				}
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.WriteEndDocument();
				xmlTextWriter.Close();
			}
		}

		public void Save(string iPath, string iFilename)
		{
			IEnumerator enumerator = null;
			XmlTextWriter xmlTextWriter = new XmlTextWriter(string.Format("{0}/{1}.xml", iPath, iFilename), Encoding.UTF8)
			{
				Indentation = 2,
				Formatting = Formatting.Indented
			};
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("Trans");
			try
			{
				enumerator = this.i_Transitions.Values.GetEnumerator();
				while (enumerator.MoveNext())
				{
					((Transition.Transition)enumerator.Current).Save(xmlTextWriter);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteEndDocument();
			xmlTextWriter.Close();
		}
	}
}