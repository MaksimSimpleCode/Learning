using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson1_4
{
    class Lesson1_4
    {
        static void Main(string[] args)
        {
            //Обмен значениями переменных a и b с помощью 3 (буфферной) переменной
            int a = 1;
            int b = 2;
            int c;
            c = a;
            a = b;
            b = c;

            
            Console.WriteLine(a+" "+b);
            Console.ReadKey();
        }
    }
}
