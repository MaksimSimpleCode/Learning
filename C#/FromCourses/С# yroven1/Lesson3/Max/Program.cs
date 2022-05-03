using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа, 0 является выходом из программы.");
            int a = int.Parse(Console.ReadLine());
            int max = a;
            while (a != 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a > max)
                {
                    max = a;
                }
                
            }
            Console.WriteLine("Максимальное число : "+max);
            Console.ReadKey();
        }
    }
}
