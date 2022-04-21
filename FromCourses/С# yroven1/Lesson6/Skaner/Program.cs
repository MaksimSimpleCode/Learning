using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skaner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Получаем список файлов в папке. AllDirectories - сканировать так же и подпапки
            string[]fs = Directory.GetFiles("C:\\123", ".", SearchOption.AllDirectories);
            //Просматриваем каждый файл в массиве
            foreach (var filename in fs)
            {
                //Создаем регулярное выражения для поиска почтовых адресов
                Regex regex = new Regex(@"(\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,6})");
                //Считываем файл
                string s = File.ReadAllText(filename);
                Console.WriteLine(filename);
                //Выводим найденые адреса на экран
                foreach (var c in regex.Matches(s))
                    Console.WriteLine("{0}", c);
            }
            Console.ReadKey();
        }
    }
}
