using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            int y = int.Parse(Console.ReadLine());

            var client = new Summ.SummatorClient("BasicHttpBinding_ISummator");

            Console.WriteLine("Ответ с WCF сервиса: "+client.GetSum(x, y).ToString());
            Console.ReadLine();
            client.Close();
        }
    }
}
