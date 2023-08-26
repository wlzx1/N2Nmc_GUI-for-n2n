using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace N2Nmc.csl
{
    internal class Class2
    {
        public class IniFile
        {
            private string filePath;

            // 导入 Windows API 函数
            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

            [DllImport("kernel32")]
            private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder value, int size, string filePath);

            public IniFile(string filePath)
            {
                this.filePath = filePath;
            }

            public void WriteValue(string section, string key, string value)
            {
                WritePrivateProfileString(section, key, value, filePath);
            }

            public string ReadValue(string section, string key, string defaultValue = "")
            {
                StringBuilder sb = new StringBuilder(255);
                GetPrivateProfileString(section, key, defaultValue, sb, 255, filePath);
                return sb.ToString();
            }
        }
    }
}
