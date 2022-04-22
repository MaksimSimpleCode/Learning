using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            do
            {
                
                 s = Console.ReadLine();
                foreach (char letter in s)
                {
                    Console.WriteLine(letter);
                    Thread.Sleep(1000);
                }
            }
            while (s != "stop");
            {
                Console.WriteLine("Вы ввели стоп слово");
            
            }

            Console.ReadLine();

        }
    }
}
