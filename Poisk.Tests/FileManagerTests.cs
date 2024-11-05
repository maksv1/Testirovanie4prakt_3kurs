using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poisk.Tests
{
    [TestClass]
    public class FileManagerTests
    {
        [TestMethod]
        public void CountTxtFiles_WithTestData_ReturnsCorrectCount()
        {
            // Передаем TestDataObject, чтобы использовать тестовые данные
            var fileManager = new FileManager();

            int txtFileCount = fileManager.CountTxtFiles();

            Assert.AreEqual(3, txtFileCount); // Ожидаем 3 файла с расширением .txt
        }
    }
}
