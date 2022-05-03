using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = {"alpha", "beta", "gamma" };
            // Сформировать запрос на получение символов, возвращаемых из
             // строк в отсортированной последовательности. Обратите внимание
            // на применение вложенного оператора from.
            var chrs = from str in strs
                   let chrArray = str.ToCharArray()
                   from ch in chrArray
                   //orderby ch     //сортировка
                   select ch;
            Console.WriteLine("Отдельные символы, отсортированные по порядку:");
            // Выполнить запрос и вывести его результаты.
            foreach(char с in chrs) Console.Write(с + " ");
            Console.WriteLine();
        }
    }
}
