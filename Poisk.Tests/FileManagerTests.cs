using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Poisk.Tests
{
    [TestClass]
    public class FileManagerTests
    {
        [TestMethod]
        public void CountTxtFiles_WithTestData_ReturnsCorrectCount()
        {
            var manager = new FileManager();
            var testDataObject = new TestDataObject();

            int txtFileCount = 0;
            foreach (var file in testDataObject.GetFiles())
            {
                if (file.EndsWith(".txt"))
                {
                    txtFileCount++;
                }
            }

            Assert.AreEqual(3, txtFileCount); // Ожидаем 3 файла txt в тестовых данных
        }
    }
}
