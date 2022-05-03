using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion     //РЕКУРСИЯ
{
    class Program
    {   static void Foo(int i)
        {
            Console.WriteLine("Foo"+i);
            if (i >= 3)     // Условие для выхода из рекурсии 
            {
                return;
            }

            i++;
            Foo(i);      // РЕКУРСИЯ это вызов метода внутри сюда.
            // По сути аналог цикла, можно сделать все то же самое что и циклом, нюанс в том что рекурсия ограницена стеком
        }
        static void Main(string[] args)
        {
            Foo(0);  //когда стек закончиться, выдаст ошибку.
        }
    }
}
