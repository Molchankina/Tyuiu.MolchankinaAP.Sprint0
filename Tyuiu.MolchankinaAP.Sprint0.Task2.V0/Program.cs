using Tyuiu.MolchankinaAP.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MolchankinaAP.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataServise и метода GetMessage
            //из библиотеки Tyuiu.MolchankinaAP.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataServise.GetMessage("Ангелина"));
            Console.ReadKey();
        }
    }
}
