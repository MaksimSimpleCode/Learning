using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_7
{
    class Program
    {
        static void Loop(int a, int b)
        {
            //рекурсия, метот который внутри вызывает сам себя
            Console.Write("{0,4}", a);
            if (a < b) Loop(a + 1, b);

        }

        static void Main(string[] args)
        {
            Loop(0, 10);
            Console.ReadKey();
        }
    }
}
