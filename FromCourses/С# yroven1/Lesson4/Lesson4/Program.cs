using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a;
            //a = new int[] { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < a.Length; i++) Console.Write("{0,4}", a[i]);
            //foreach (int el in a) Console.Write("{0,4}", el);



            int[] a = new int[10]; //Объявляем и указываем размерность массива
            for (int i = 0; i < 10; i++)
            {
                a[i] = i * i;//записываем в массив квадрат i
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", a[i]); // выводим массив
            }
        }   
    }
}
