using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_4
{
    class Program
    {
        static int Min3(int a, int b, int c)
        {
            int min= a;
            if (b < c) min = b;
            if (c < b) min = c;
            Console.WriteLine("Минимальное число: " + min);
            Console.ReadKey();
            return min;

        }

            

        static void Main(string[] args)
        {
            Min3(30, 20, 50);
            
        }
    }
}
