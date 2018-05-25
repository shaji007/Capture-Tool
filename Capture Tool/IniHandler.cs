using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Capture_Tool
{
    class IniHandler
    {
        private string m_strPath;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
             string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
                 string key, string def, StringBuilder retVal,
            int size, string filePath);

        public IniHandler()
        {
            string strDesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            m_strPath = System.IO.Path.Combine(strDesktopPath, IniConstants.CONST_SECTION, IniConstants.CONST_INIFILENAME);
        }

        public void write(string Key, string Value)
        {
            WritePrivateProfileString(IniConstants.CONST_SECTION, Key, Value, m_strPath);
        }

        public string read(string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(IniConstants.CONST_SECTION, Key, "", temp, 255, m_strPath);
            return temp.ToString();
        }

        public DataStruct readIni()
        {
            DataStruct data;
            string temp;
            temp = read(IniConstants.CONST_KEY_ADDCAPTION);
            data.bAddCaption = Convert.ToBoolean((temp.Length > 0) ? temp : "False");
            temp = read(IniConstants.CONST_KEY_ADDTITLE);
            data.bAddTitle = Convert.ToBoolean((temp.Length > 0) ? temp : "False");
            data.strOutputPath = read(IniConstants.CONST_KEY_OUTPUTPATH);
            temp = read(IniConstants.CONST_KEY_SAVEPDF);
            data.bSavePDF = Convert.ToBoolean((temp.Length > 0) ? temp : "False");
            temp = read(IniConstants.CONST_KEY_SAVEPNG);
            data.bSavePNG = Convert.ToBoolean((temp.Length > 0) ? temp : "False");
            temp = read(IniConstants.CONST_KEY_SAVEWORD);
            data.bSaveWord = Convert.ToBoolean((temp.Length > 0) ? temp : "False");
            temp = read(IniConstants.CONST_KEY_SHOWWORD);
            data.bShowWord = Convert.ToBoolean((temp.Length > 0) ? temp : "False");
            data.strScreenshotPath = read(IniConstants.CONST_KEY_TEMPPATH);
            return data;
        }

        public void writeIni(DataStruct data)
        {
            write(IniConstants.CONST_KEY_ADDCAPTION, data.bAddCaption.ToString());
            write(IniConstants.CONST_KEY_ADDTITLE, data.bAddTitle.ToString());
            write(IniConstants.CONST_KEY_OUTPUTPATH, data.strOutputPath);
            write(IniConstants.CONST_KEY_SAVEPDF, data.bSavePDF.ToString());
            write(IniConstants.CONST_KEY_SAVEPNG, data.bSavePNG.ToString());
            write(IniConstants.CONST_KEY_SAVEWORD, data.bSaveWord.ToString());
            write(IniConstants.CONST_KEY_SHOWWORD, data.bShowWord.ToString());
            write(IniConstants.CONST_KEY_TEMPPATH, data.strScreenshotPath);
        }
    }
}
