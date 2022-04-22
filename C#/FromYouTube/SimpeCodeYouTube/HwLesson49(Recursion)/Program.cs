using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwLesson49_Recursion_     //ДЗ по Рекурсии
{
    /*
     * 1. Реализовать вывод массива с помощью рекурсии
     * 
     * 2. Найти сумму элементов массива с помощью рекурсии
     * 
     * 3. Найти сумму цифр числа с помощью рекурсии. 561 = 12
     */ 
    class Program
    {
        static void OutArray(int[]Array, int i=0)   //i - необязательный параметр.
        {
            if (i == Array.Length)
            {
                return;
            }
            else
            Console.WriteLine(Array[i]);
            i ++;
            OutArray(Array,i);
        }

        static void SumArray(int [] Array, int i=0)
        {
            int sum=0;
            if (i == Array.Length)
            {
                return;
            }
            else
                
            sum += Array[i];
            i++;
            SumArray(Array, i);
        }
        static void Main(string[] args)
        {
            int [] myArray = { 1,2,3,4,5};
            OutArray(myArray);

            SumArray(myArray);
        }
    }
}
