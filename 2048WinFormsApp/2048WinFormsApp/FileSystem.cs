using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2048WinFormsApp
{
    static class FileSystem
    {
        static public string ReadFile(string fileName)
        {
            var sr = new StreamReader(fileName);
            var txt = sr.ReadToEnd();
            sr.Close();
            return txt;
        }
        static public void WriteFile(string fileName, string txt)
        {
            var sw = new StreamWriter(fileName);
            sw.Write(txt);
            sw.Close();
        }
    }
}
