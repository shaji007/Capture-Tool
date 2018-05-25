using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Capture_Tool
{
    public partial class SettingsForm : Form
    {
        private string m_strDesktopPath;
        private string m_strIniFile;

        private DataStruct data;

        IniHandler ini;

        public SettingsForm()
        {
            InitializeComponent();
            m_strDesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string strIniPath = System.IO.Path.Combine(m_strDesktopPath, IniConstants.CONST_SECTION);
            m_strIniFile = System.IO.Path.Combine(strIniPath, IniConstants.CONST_INIFILENAME);
            data.strScreenshotPath = System.IO.Path.Combine(strIniPath, IniConstants.CONST_SCREENS);
            ini = new IniHandler();

            if(!Directory.Exists(strIniPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(data.strScreenshotPath);
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                cbShowWord.Checked = false;
                cbSaveWord.Checked = false;
                cbSavePDF.Checked = false;
                cbSavePNG.Checked = false;
                cbAddCaption.Checked = false;
                cbAddTitle.Checked = false;
            }
            else
            {
                if(File.Exists(m_strIniFile))
                {
                    data = ini.readIni();
                }
                else
                {
                    if(tbOutputPath.Text.Length ==0)
                    {
                        tbOutputPath.Text = m_strDesktopPath;
                        data.strOutputPath = m_strDesktopPath;
                    }
                    if(tbScreenshotPath.Text.Length == 0)
                    {
                        tbScreenshotPath.Text = data.strScreenshotPath;
                    }
                    cbAddCaption.Checked = false;
                    cbAddTitle.Checked = false;
                    cbSavePDF.Checked = false;
                    cbSavePNG.Checked = false;
                    cbSaveWord.Checked = false;
                    cbShowWord.Checked = false;

                    data.bAddCaption = false;
                    data.bAddTitle = false;
                    data.bSavePDF = false;
                    data.bSavePNG = false;
                    data.bSaveWord = false;
                    data.bShowWord = false;

                    ini.writeIni(data);
                }
            }
        }

        private void SelectOutputPath_Click(object sender, EventArgs e)
        {
            SelectFolder(tbOutputPath);
        }

        private void SelectScreenshotPath_Click(object sender, EventArgs e)
        {
            SelectFolder(tbScreenshotPath);
        }

        private void SelectFolder(TextBox tbTextBox)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    tbTextBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            m_strDesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string strIniPath = System.IO.Path.Combine(m_strDesktopPath, IniConstants.CONST_SECTION);
            m_strIniFile = System.IO.Path.Combine(strIniPath, IniConstants.CONST_INIFILENAME);

            cbAddCaption.Checked = false;
            cbAddTitle.Checked = false;
            cbSavePDF.Checked = false;
            cbSavePNG.Checked = false;
            cbSaveWord.Checked = false;
            cbShowWord.Checked = false;

            tbOutputPath.Text = m_strDesktopPath;
            tbScreenshotPath.Text = data.strScreenshotPath;
        }

        private void ShowWord_Click(object sender, EventArgs e)
        {
            cbShowWord.Checked = !cbShowWord.Checked;
            if(cbShowWord.Checked)
            {
                cbAddCaption.Checked = false;
                cbAddCaption.Enabled = true;
                cbAddTitle.Checked = false;
                cbAddTitle.Enabled = true;
                cbSavePDF.Checked = false;
                cbSavePDF.Enabled = false;
                cbSavePNG.Checked = false;
                cbSavePNG.Enabled = false;
                cbSaveWord.Checked = false;
                cbSaveWord.Enabled = false;
            }
            else
            {
                cbAddCaption.Checked = false;
                cbAddCaption.Enabled = true;
                cbAddTitle.Checked = false;
                cbAddTitle.Enabled = true;
                cbSavePDF.Checked = false;
                cbSavePDF.Enabled = true;
                cbSavePNG.Checked = false;
                cbSavePNG.Enabled = true;
                cbSaveWord.Checked = false;
                cbSaveWord.Enabled = true;
            }
        }

        private void AddTitle_Click(object sender, EventArgs e)
        {
            cbAddTitle.Checked = !cbAddTitle.Checked;
            if (cbShowWord.Checked)
            {
                cbAddCaption.Checked = false;
                cbAddCaption.Enabled = true;
                cbShowWord.Checked = false;
                cbAddTitle.Enabled = true;
                cbSavePDF.Checked = false;
                cbSavePDF.Enabled = false;
                cbSavePNG.Checked = false;
                cbSavePNG.Enabled = false;
                cbSaveWord.Checked = false;
                cbSaveWord.Enabled = false;
            }
            else
            {
                cbAddCaption.Checked = false;
                cbAddCaption.Enabled = true;
                cbAddTitle.Checked = false;
                cbAddTitle.Enabled = true;
                cbSavePDF.Checked = false;
                cbSavePDF.Enabled = false;
                cbSavePNG.Checked = false;
                cbSavePNG.Enabled = false;
                cbSaveWord.Checked = false;
                cbSaveWord.Enabled = false;
            }
        }

        private void SaveWord_Click(object sender, EventArgs e)
        {
            cbAddCaption.Checked = false;
            cbAddTitle.Checked = false;
            cbSavePDF.Checked = false;
            cbSavePNG.Checked = false;
            cbSaveWord.Checked = false;
            cbShowWord.Checked = false;
        }

        private void AddCaption_Click(object sender, EventArgs e)
        {
            cbAddCaption.Checked = false;
            cbAddTitle.Checked = false;
            cbSavePDF.Checked = false;
            cbSavePNG.Checked = false;
            cbSaveWord.Checked = false;
            cbShowWord.Checked = false;
        }

        private void SavePDF_Click(object sender, EventArgs e)
        {
            cbAddCaption.Checked = false;
            cbAddTitle.Checked = false;
            cbSavePDF.Checked = false;
            cbSavePNG.Checked = false;
            cbSaveWord.Checked = false;
            cbShowWord.Checked = false;
        }

        private void SavePNG_Click(object sender, EventArgs e)
        {
            cbAddCaption.Checked = false;
            cbAddTitle.Checked = false;
            cbSavePDF.Checked = false;
            cbSavePNG.Checked = false;
            cbSaveWord.Checked = false;
            cbShowWord.Checked = false;
        }
    }
}
