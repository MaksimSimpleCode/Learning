using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @in   //Модификатор in
{
    class Program
    {
        static void Foo(in int value)   //Не позволяет менять данные, только для чтения.
        {
           //  value = 5;
        }
        static void Main(string[] args)
        {
            int a = 10;
            Foo( a);
        }
    }
}
