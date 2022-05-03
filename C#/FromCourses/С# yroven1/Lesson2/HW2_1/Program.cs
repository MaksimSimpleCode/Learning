using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_1
{
    class Program
    {   //Вывести в диапазоне от 10 до 100 все числа, сумма двух последних цифр которых равна 10:
        static bool Check(int a)
        {
            if ((a % 10 + a / 10 % 10 == 10))
                return true;
            else return false;
}
        static void Main(string[] args)
        {
            for (int i = 10; i <= 100; i++)
                if (Check(i)) Console.WriteLine(i);
            Console.ReadKey();
        }

        
    }
}
