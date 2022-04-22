using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MhetodOverload    //Перегрузка методов и их описание
{
    class Program
    {
        //Так создается описание метода
        /// <summary>
        /// Возвоазает сумму 2 int переменных
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Возвращает сумму 3 int переменных 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int Sum (int a, int b, int c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            int a = 4;
            int b = 5;
            int c = 7;
            int result = 0;

            result = Sum(a, b, c);

           
            Console.WriteLine(result);
        }
    }
}
