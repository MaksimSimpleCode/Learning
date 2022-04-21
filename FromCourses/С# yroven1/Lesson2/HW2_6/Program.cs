using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0, s = 0;
            Console.WriteLine("Введите числа(только четные и положительные, остальные не будут учитываться), в конце программа выдаст сумму этих чисел, выходом из программы является 0");
            int a = int.Parse(Console.ReadLine());
            while (a!= 0)
            {
                if (a > 0 && a%2==0) { k++; s = s + a; }
                 a = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Сумма выших чисел :"+s);
            Console.ReadKey();
        }
    }
}
