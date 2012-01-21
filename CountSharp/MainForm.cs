using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace BrrrBayBay.CountSharp
{
	public partial class MainForm : Form
	{
		char[] whiteSpaces = new char[] { '\r', '\n', '\t' };

		public MainForm()
		{
			InitializeComponent();
		}


		private enum LineType
		{
			None,
			Empty,
			Code,
			StandardComments,
			XmlComments
		}


		private void selectDirectoryButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog diag = new FolderBrowserDialog();
			DialogResult res = diag.ShowDialog();
			if (res == System.Windows.Forms.DialogResult.OK)
			{
				
				selectDirectoryButton.Visible = false;
				ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(Object state)
				{
					processProjectFolder(diag.SelectedPath);
				}));
			}
			diag.Dispose();
		}



		private void processProjectFolder(String rootFolder)
		{
			LineCount count = new LineCount();
			List<String> sharpFiles;
			int done = 0;
			int total = 0;

			this.Invoke(new MethodInvoker(delegate()
			{
				scanningLabel.Visible = true;
			}));

			sharpFiles = findCSharpFiles(rootFolder);
			total = sharpFiles.Count;

			this.Invoke(new MethodInvoker(delegate()
			{
				fileCountLabel.Text = total.ToString("###.###.###") + " files.";
				scanningLabel.Visible = false;
				progressBar.Visible = true;
			}));


			foreach (String file in sharpFiles)
			{
				examineFile(file, count);
				done++;

				this.Invoke(new MethodInvoker(delegate()
				{
					updateProgress(done, total);
				}));
			}

			this.Invoke(new MethodInvoker(delegate()
			{
				progressBar.Visible = false;
				selectDirectoryButton.Visible = true;
				showLineCount(count);
			}));

		}



		private void updateProgress(int done, int total)
		{
			double percentage = (((double)done) / ((double)total)) * 100.0;
			progressBar.Value = (int)Math.Round(percentage);
		}


		private void showLineCount(LineCount count)
		{
			String linesFormat = "###,###,###";
			String pFormat = "F2";

			resultsGroup.Enabled = true;

			codeCountBox.Text = count.Code.ToString(linesFormat);
			sCommentsCountBox.Text = count.StandardComments.ToString(linesFormat);
			xCommentsCountBox.Text = count.XmlComments.ToString(linesFormat);
			totalCommentsCountBox.Text = count.TotalComments.ToString(linesFormat);
			emptyCountBox.Text = count.Empty.ToString(linesFormat);
			totalCountBox.Text = count.Total.ToString(linesFormat);

			codePercentBox.Text = count.getPercentOfTotal(count.Code).ToString(pFormat);
			sCommentsPercentBox.Text = count.getPercentOfTotal(count.StandardComments).ToString(pFormat);
			xCommentsPercentBox.Text = count.getPercentOfTotal(count.XmlComments).ToString(pFormat);
			totalCommentsPercentBox.Text = count.getPercentOfTotal(count.TotalComments).ToString(pFormat);
			emptyPercentBox.Text = count.getPercentOfTotal(count.Empty).ToString(pFormat);
		}




		private List<String> findCSharpFiles(String rootDir)
		{
			List<String> sharpFiles = new List<string>();
			string[] allFiles;

			allFiles = Directory.GetFiles(rootDir, "*.cs", SearchOption.AllDirectories);

			sharpFiles = new List<string>(allFiles);

			return sharpFiles;
		}




		private void examineFile(String path, LineCount count)
		{
			string line;
			using (StreamReader file = new StreamReader(path, Encoding.Default))
			{
				while ((line = file.ReadLine()) != null)
				{
					examineLine(line, count);
				}
				file.Close();
			}
		}



		private void examineLine(String line, LineCount count)
		{
			LineType lineType = LineType.None;


			foreach (char ch in whiteSpaces)
			{
				line = line.Replace(ch, ' ');
			}

			if (line.Length == 0)
			{
				lineType = LineType.Empty;
			}
			else
			{
				for (int i = 0; i < line.Length; i++)
				{

					// Whitespace line
					if (line[i] == ' ')
					{
						if (i == line.Length - 1)
						{
							lineType = LineType.Empty;
							break;
						}
						continue;
					}


					// Comments and XML comments
					if (line[i] == '/')
					{
						if (i + 1 < line.Length)
						{
							if (line[i + 1] == '/')
							{
								if (i + 2 < line.Length)
								{
									if (line[i + 2] == '/')
									{
										lineType = LineType.XmlComments;
										break;
									}
									else
									{
										lineType = LineType.StandardComments;
										break;
									}
								}
								else
								{
									lineType = LineType.StandardComments;
									break;
								}
							}
							else
							{
								lineType = LineType.StandardComments;
								break;
							}
						}
						else
						{
							lineType = LineType.Code;
							break;
						}
					}

					// Normal code
					lineType = LineType.Code;
					break;
				}
			}



			if (lineType != LineType.None)
			{
				switch (lineType)
				{
					case LineType.Code:
						count.addCodeLine();
						break;
					case LineType.Empty:
						count.addEmptyLine();
						break;
					case LineType.StandardComments:
						count.addStandardComments();
						break;
					case LineType.XmlComments:
						count.addXmlComment();
						break;
					default:
						throw new Exception("Unknown line type");
				}
			}
			else
			{
				throw new Exception("error while determining line type");
			}

			

		}


	}
}
