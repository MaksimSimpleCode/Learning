using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Регулярные_выражения
{
    class Program
    {
        static void Main(string[] args)
        {
            string data1 = "Петр,Андрей,Николай";
            string data2 = "Петр,Андрей,Aлександр";
            Regex regex = new Regex("Николай"); //Создание регулярного выражения
            Console.WriteLine(regex.IsMatch(data1)); //True
            Console.WriteLine(regex.IsMatch(data2)); //False
            Console.ReadKey();
        }
    }
}
