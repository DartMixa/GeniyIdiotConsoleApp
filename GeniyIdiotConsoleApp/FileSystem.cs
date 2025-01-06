using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp
{
    static class FileSystem
    {
        static public string ReadFile(string fileName)
        {
            var sr = new StreamReader(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "/" + fileName + ".txt");
            var txt = sr.ReadToEnd();
            sr.Close();
            return txt;
        }
        static public void WriteFile(string fileName, string txt)
        {
            var sw = new StreamWriter(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "/" + fileName + ".txt");
            sw.Write(txt);
            sw.Close();
        }
    }
}
