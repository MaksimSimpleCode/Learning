using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuery2
{// Использовать методы запроса для формирования простого запроса.
 // Это переделанный вариант первого примера программы из настоящей главы
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, -2, 3, 0, -4, 5 };
            // Использовать методы Where() и Select() для
            // формирования простого запроса.
            var posNums = nums.Where(n => n > 0).Select(r => r*10);
            //var posNums = nums.Where(n => n > 0).OrderByDescending(j => j);
            Console.Write("Положительные значения из массива nums: ");
            // Выполнить запрос и вывести его результаты.
            foreach (int i in posNums) Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
