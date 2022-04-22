using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void ChangeSign(ref int a, ref int b, ref int c)
        {
            //Модификатор параметров ref
            a = -a;
            b = -b;
            c = -c;
        }

        static void SetOut(out int a)
        {
            a = 10;
        }

        static void Main(string[] args)
        {
            //Модификатор параметров ref
            int a = 10, b = 20, c = 30;
            ChangeSign(ref a, ref b, ref c);
            Console.WriteLine("{0},{1},{2}", a, b, c);
            

        }
    }
}
