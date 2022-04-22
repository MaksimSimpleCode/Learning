using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertRemoveReplase
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Это тест";
            Console.WriteLine("Исходная строка: " + str);
            // Вставить строку.
            str = str.Insert(4, "простой ");
            Console.WriteLine(str);
            // Заменить строку.
            str = str.Replace("простой", "непростой ");
            Console.WriteLine(str);
            // Заменить символы в строке
            str = str.Replace('т', 'X');
            Console.WriteLine(str);
            // Удалить строку.
            str = str.Remove(4, 5);
            Console.WriteLine(str);
        }
    }
}
