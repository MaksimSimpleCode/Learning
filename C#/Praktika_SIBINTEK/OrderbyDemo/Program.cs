using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderbyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 5, 1, -4, -12, 42, 4, 12, 22, -5, 0 };
            // Сформировать запрос на получение значений в отсортированном порядке.
            var posNums = from n in nums
                          orderby n //descending    //По умолчанию используется ascending(по возрастающей) но мы можем указать descending(по убывающей)
                          select n;
            Console.Write("Значения по наростающей: ");
            foreach (var i in posNums)
                Console.Write(i + " ");
        }
    }
}
