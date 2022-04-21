using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoWheres
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, -2, 3, -3, 0, -8, 12, 19, 6, 9, 10 };
            // Сформировать запрос на получение положительных значений меньше 10.
            var posNums = from n in nums
                          where n > 0
                          where n < 10
                          select n;
            Console.Write("Положительные числа меньше 10: ");
            foreach (var i in posNums)
                Console.Write(i + " ");

        }
    }
}
