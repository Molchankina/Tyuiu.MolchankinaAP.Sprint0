using System.Security.Cryptography.X509Certificates;
using Tyuiu.MolchankinaAP.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MolchankinaAP.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassegeValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Ангелина";
            var res = DataServise.GetMessage(name);
            Assert.AreEqual("Привет, Ангелина", res);
        }
    }
}