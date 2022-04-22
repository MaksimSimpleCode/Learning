using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 4, 8, 6, 9, 10, 3, 6, 7 };
            var ltAvg = from n in nums
                        let x = nums.Average()
                        where n < x
                        select n;
            Console.WriteLine("Среднее значение равно " + nums.Average());
            Console.Write("Значения меньше среднего: ");
            // Выполнить запрос и вывести его результаты.
            foreach (int i in ltAvg) Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
