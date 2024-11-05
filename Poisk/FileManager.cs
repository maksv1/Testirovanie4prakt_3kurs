using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poisk
{
    public class FileManager
    {
        public int CountTxtFiles()
        {
            //FileDataObject obj = new FileDataObject(); // Класс для работы с файловой системой
            TestDataObject obj = new TestDataObject(); // Заглушка для тестирования

            List<string> files = obj.GetFiles();
            int txtFileCount = 0;

            foreach (var file in files)
            {
                if (file.EndsWith(".txt"))
                {
                    txtFileCount++;
                }
            }

            return txtFileCount;
        }
    }
}
