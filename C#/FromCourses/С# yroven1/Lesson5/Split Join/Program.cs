using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            string poems = "белеет парус одинокий в тумане моря голубом";
            char[] div = {' '};//Создаем массив разделителей
            //разбираем строку на части
            string[] parts = poems.Split(div);
            Console.WriteLine("Результат разбиения строки на части: ");
            for (int i = 0; i < parts.Length; i++)
                Console.WriteLine(parts[i]);
            //Собираем эти части в одну строку, в качестве разделителя используем символ |
            string str = String.Join("|", parts);
            Console.WriteLine(str);

            string str1 = "Hello!";
            string str2 = "Hello!";
            //Сравнение с использованием статического метода
            Console.WriteLine(String.Compare(str1, str2));
            //сравнивание с использованием нестатического метода 
            Console.WriteLine(str1.CompareTo(str2));
        }
    }
}
