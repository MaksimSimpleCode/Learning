using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("Строка str: " + str);
            Console.Write("Подстрока str.Substring(15): ");
            string substr = str.Substring(15);
            Console.WriteLine(substr);
            Console.Write("Подстрока str.Substring(0, 15): ");
            substr = str.Substring(0, 15);
            Console.WriteLine(substr);
        }
    }
}
