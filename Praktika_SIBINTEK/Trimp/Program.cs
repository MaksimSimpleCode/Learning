using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trimp //Обрезка/добавление пробелов, символов
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "тест";
            Console.WriteLine("Исходная строка: " + str);
            // Заполнить строку пробелами слева.
            str = str.PadLeft(10);
            Console.WriteLine(" | " + str + "|");
            // Заполнить строку пробелами справа,
            str = str.PadRight(20);
            Console.WriteLine("|" + str + "|");
            // Обрезать пробелы.
            str = str.Trim();
            Console.WriteLine("|" + str + "|");
            // Заполнить строку символами # слева.
            str = str.PadLeft(10, '#');
            Console.WriteLine("|" + str + "|");
            // Заполнить строку символами # справа.
            str = str.PadRight(20, '#');
            Console.WriteLine("|" + str + "|");
            // Обрезать символы #.
            str = str.Trim('#');
            Console.WriteLine("|" + str + "|");
        }
    }
}
