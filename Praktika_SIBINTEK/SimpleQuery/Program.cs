using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, -2, 3, 0, -4, 5 };
            // Сформировать простой запрос на получение только положительных значений.
            var posNums = from n in nums
                          where n > 0
                          select n;
            Console.Write("Положительные значения из массива nums: ");
            // Выполнить запрос и отобразить его результаты.
            foreach (int i in posNums) Console.Write(i + " ");
            Console.WriteLine();

            nums[1] = 15;
            Console.Write("Положительные значения из массива nums после его изменения: ");
            foreach (int i in posNums) Console.Write(i + " ");  //Как видно, сделав один раз запрос, результаты его могут изменяться при изменении источника данных
            Console.WriteLine();


        }
    }
}
