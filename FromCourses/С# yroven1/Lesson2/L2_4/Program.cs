using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 10;
            int k = 0;
            int s = 0;
            for (int i = b; i >= a; i--) 
            {
                Console.Write(i + " ");
                k++;
                s = s + i;

            }
            Console.Write("\nk={0} s={1}", k, s);
            Console.ReadKey();
        }
    }
}
