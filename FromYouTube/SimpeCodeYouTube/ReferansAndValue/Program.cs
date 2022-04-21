using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferansAndValue      //Значимые и ссылочные типы 
{
    class Program
    {
        static void Foo (int a )
        {
           a = 5;
        }

        static void Ref (int[] arr)
        {
            arr[0] = 5;
        }
        static void Main(string[] args)
        {
            int a = 1;      // Значимый тип (struct, enum)
            Random rnd = new Random();      // Ссылочный тип (class)

            Foo(a);     // так как значимый тип, значение из метода не подтянеться и будет все та же 1

            int[] arr = new int[1];
            arr[0] = 1;
            Ref(arr);   // так как тип ссылочный, значение из метода подтянеться и будет равно 5

        }
    }
}

