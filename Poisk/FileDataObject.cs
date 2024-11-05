using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poisk
{
    public class FileDataObject
    {
        public List<string> GetFiles()
        {
            string path = "C:\\Users\\mvino\\source\\repos\\Testirovanie4prakt_3kurs"; // Путь для поиска файлов

            List<string> list = new List<string>();
            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] files = d.GetFiles();

            foreach (var file in files)
            {
                list.Add(file.Name);
            }

            return list;
        }
    }
}