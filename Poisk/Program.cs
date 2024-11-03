using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileManager mgr = new FileManager(); // Экземпляр класса для подсчёта файлов
            int txtFileCount = mgr.CountTxtFiles();

            Console.WriteLine("Количество найденных txt файлов: {0}", txtFileCount);
            Console.ReadKey();
        }
    }
}
