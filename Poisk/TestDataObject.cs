using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poisk
{
    public class TestDataObject
    {
        public List<string> GetFiles()
        {
            return new List<string> { "file1.txt", "file2.txt", "file3.txt", "image.png" };
        }
    }
}
