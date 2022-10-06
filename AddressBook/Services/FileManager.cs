using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Services
{
    internal class FileManager
    {
        public void Save(string filepath, string content)
        {
            using var sw = new StreamWriter(filepath);
            sw.WriteLine(content);
        }

        public string Read(string filepath)
        {
            try
            {
                using var sr = new StreamReader(filepath);
                return sr.ReadToEnd();

            }
            catch { }

            return null;
        }
    }
}
