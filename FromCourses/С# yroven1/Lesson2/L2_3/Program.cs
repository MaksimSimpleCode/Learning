using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, count = 0;
            do
            {
                Console.WriteLine("Введите возраст");
                a = int.Parse(Console.ReadLine());
                count++;
            }

            while (a < 1 || a > 99);// Повторять пока условие true
            Console.WriteLine("Вы сделали " + count + "  попыток ввода");
            Console.ReadKey();

            
        }
    }
}
