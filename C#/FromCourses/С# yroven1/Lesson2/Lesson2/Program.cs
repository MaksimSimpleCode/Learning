using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 5;
            int max;
            // тернорная операция(альтернатива if в некоторых случаях)
            max = a > b ? a : b;
            //Еще пример с возрастом Console.WriteLine(aga <= 18 ? "Ты" : "Вы");
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
