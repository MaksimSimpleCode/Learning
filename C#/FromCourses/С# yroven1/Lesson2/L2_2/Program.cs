using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = 2;
            string s;
            switch (month)
            {
                case 1: s = "Январь";
                    break;
                case 2: s = "Февраль";
                    break;
                default:
                    s = "Нет";
                    break;
               
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    } 
}
