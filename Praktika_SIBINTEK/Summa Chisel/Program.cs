using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summa_Chisel
{
    // Expr10. Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5.
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            for (int i =0; i<=1000;i++)
            {
                
                x += i;
                Console.WriteLine(x);
            }
            Console.WriteLine(x);
        }
    }
}
