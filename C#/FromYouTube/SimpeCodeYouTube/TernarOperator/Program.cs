using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernarOperator
{
    class Program
    {
        /*
         *  Тернарный оператор
         * 
         * [Первый операнд - условие]? [второй операнд if_true]: [третий операнд if_else]
         */
          
        static void Main(string[] args)
        {
            int a = 0; // унарный оператор
            int b = 1;// унарный оператор


            int c = a + b;   // Бинарный оператор

            string d = a > b ? "a>b" : "a<b";

            Console.WriteLine(d);



        }
    }
}
