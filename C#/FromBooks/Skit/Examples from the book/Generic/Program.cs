using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 5;
            string str = "Строка";
            Console.WriteLine("Числаи строка до метода: " + a + ", " + b+", "+ str);
            Swap<int>(ref a, ref b, out str);

            Console.WriteLine("Числаи строка после метода: " + a + ", " + b + ", " + str);
        }

        static void Swap<T>(ref T first, ref T second, out string output)
        {
            T temp = second;
            second = first;
            first = temp;

            output = "Переменная внутри метода";
            Console.WriteLine("Числаи строка до метода: " + first + ", " + second + ", " + output);
        }
        // out внтури метода мы можем что-то присвоить, но получать значения можем только из других  агрументов.
        //Мы не получим "Строка" внутри метода Swap если попробуем передать ее через str
    }
}
