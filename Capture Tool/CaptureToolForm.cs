using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace Capture_Tool
{
    public partial class CaptureTool : Form
    {
        private Queue<string> m_Files;
        private Queue<String> m_Captions;

        private string m_strIniFile;

        private Boolean m_bSettingsOpened;

        private DataStruct data;

        IniHandler ini;

        public CaptureTool()
        {
            InitializeComponent();
            ini = new IniHandler();
            string strDesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string strPath = System.IO.Path.Combine(strDesktopPath, IniConstants.CONST_SECTION);
            m_strIniFile = System.IO.Path.Combine(strPath, IniConstants.CONST_INIFILENAME);
            data.strOutputPath = strDesktopPath;
            m_bSettingsOpened = false;

            if(!Directory.Exists(strPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(strPath);
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                data.strScreenshotPath = System.IO.Path.Combine(strPath, IniConstants.CONST_SCREENS);
            }
            else
            {
                if(File.Exists(m_strIniFile))
                {
                    data = ini.readIni();
                }
                else
                {
                    data.bAddCaption = false;
                    data.bAddTitle = false;
                    data.bSaveWord = false;
                    data.bShowWord = false;
                    data.bSavePDF = false;
                    data.bSavePNG = false;
                    data.strScreenshotPath = System.IO.Path.Combine(strPath, IniConstants.CONST_SCREENS);
                }
            }
            m_Files = new Queue<string>();
            m_Captions = new Queue<string>();
        }

        private void Capture_Click(object sender, EventArgs e)
        {
            if(m_bSettingsOpened)
            {
                ini.readIni();
                m_bSettingsOpened = false;
            }
            btnSettings.Enabled = false;
            this.Hide();
            saveScreenshot(data.strScreenshotPath);
            this.Show();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            saveDocument();
        }

        private void saveDocument()
        {
            string strExt = "";
            if (m_Files.Count > 0)
            {
                this.Hide();
                object oMissing = System.Reflection.Missing.Value;
                object oEoD = "\\endofdoc";
                _Application oWord;
                _Document oDoc;

                oWord = new Microsoft.Office.Interop.Word.Application();
                if (!data.bSaveWord)
                {
                    oWord.Visible = data.bShowWord;
                }
                oDoc = oWord.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
                oWord.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                //oWord.Selection.TypeParagraph();
                if (data.bAddTitle)
                {
                    var ACForm = new AddCaption();
                    ACForm.Text = "Add Title";
                    ACForm.setLabel("Add title to the word document");
                    ACForm.ShowDialog();
                    string title = ACForm.getData();
                    if (title.Length > 0)
                    {
                        if (title.Length < 20)
                        {
                            oWord.Selection.Font.Size = 25;
                            oWord.Selection.Font.Bold = 300;
                        }
                        else
                        {
                            oWord.Selection.Font.Size = 12;
                            oWord.Selection.Font.Bold = 50;
                        }
                        oWord.Selection.TypeText(title);
                    }
                }
                foreach (string file in m_Files)
                {
                    string text = "";
                    string path = System.IO.Path.Combine(data.strScreenshotPath, file);
                    System.Windows.Forms.Clipboard.Clear();
                    Bitmap img = new Bitmap(path);
                    System.Windows.Forms.Clipboard.SetImage(img);
                    oWord.Selection.Paste();
                    img.Dispose();
                    System.Windows.Forms.Clipboard.Clear();
                    oWord.Selection.TypeParagraph();

                    if (data.bAddCaption)
                    {
                        text = m_Captions.Dequeue();
                    }
                    else
                    {
                        text = file.Replace("_", ":");
                        text = text.Replace("=", "::");
                        text = text.Replace(".png", "");
                        text = string.Concat("Screenshot ", text);
                    }
                    if (text.Length < 50 || text.Contains("Screenshot "))
                    {
                        oWord.Selection.Font.Size = 20;
                        oWord.Selection.Font.Bold = 300;
                    }
                    else
                    {
                        oWord.Selection.Font.Size = 12;
                    }
                    oWord.Selection.TypeText(text);
                    //System.Windows.Forms.Clipboard.Clear();
                }
                if (data.bSaveWord)
                    strExt = ".docx";
                if (data.bSavePDF)
                    strExt = ".pdf";
                if (!data.bSaveWord)
                {
                    if (!oWord.Visible)
                        oWord.Visible = true;
                }
                else if (data.bSaveWord)
                {
                    var ACForm = new AddCaption();
                    ACForm.Text = "Save As File Name";
                    ACForm.setLabel("Enter the file name to save the document");
                    ACForm.setSingleLine();
                    ACForm.ShowDialog();
                    string strFileName = ACForm.getData();
                    if (strFileName.Length == 0)
                    {
                        strFileName = string.Concat("TestResult", getTimeStamp(), strExt);
                    }
                    else
                    {
                        strFileName = string.Concat(strFileName, strExt);
                    }
                    if (!Directory.Exists(data.strOutputPath))
                    {
                        DirectoryInfo di = Directory.CreateDirectory(data.strOutputPath);
                        di.Attributes = FileAttributes.Directory;
                    }
                    oDoc.SaveAs2(System.IO.Path.Combine(data.strOutputPath, strFileName));
                    oWord.Quit();
                }
                deleteDir();
            }
            this.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if(m_Files.Count > 0)
            {
                var res = MessageBox.Show("Are you sure you dont want to save the document", "Form Closing", MessageBoxButtons.YesNo);
                if (res == DialogResult.No)
                {
                    saveDocument();
                }
                else
                {
                    deleteDir();
                }
            }
            this.Close();
        }

        private void Settings_Click(object sender, EventArgs e)
        {

        }

        private void About_Click(object sender, EventArgs e)
        {

        }

        private string getTimeStamp()
        {
            return DateTime.Now.ToString("yyyy-MM-dd=HH_mm_ss_ffff");
        }

        private void saveScreenshot(string strFilePath)
        {
            if(!Directory.Exists(strFilePath))
            {
                DirectoryInfo di = Directory.CreateDirectory(strFilePath);
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }
            Bitmap img;
            img = new Bitmap(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
            System.Drawing.Size s = new System.Drawing.Size(img.Width, img.Height);
            Graphics memGraphics = Graphics.FromImage(img);
            memGraphics.CopyFromScreen(0, 0, 0, 0, s);
            string strTS = string.Concat(getTimeStamp(), ".png");
            m_Files.Enqueue(strTS);
            img.Save(System.IO.Path.Combine(strFilePath, strTS));
            img.Dispose();
            memGraphics.Dispose();
            if(data.bAddCaption)
            {
                var ACForm = new AddCaption();
                ACForm.ShowDialog();
                string caption = ACForm.getData();
                m_Captions.Enqueue(caption);
            }
        }

        private void deleteDir()
        {
            if (Directory.Exists(data.strScreenshotPath))
                Directory.Delete(data.strScreenshotPath, true);
        }
    }   
}
