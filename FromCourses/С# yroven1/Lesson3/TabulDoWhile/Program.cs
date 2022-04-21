using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabulDoWhile
{
    class Program
    {
        static double F(double x)
        {
            return 1 / x;
        }

        static void Main(string[] args)
        {
            double a = -5;
            double b = 5;
            double h = 0.5;
            Console.WriteLine("{0,10}{1,10}", "x", "F(x)");
            double x = a;
            do
            {
                Console.WriteLine("{0,10}{1,10:f3}", x, F(x));
                x = x + h;
            }
            while (x <= b);
           
        }
    }
}
