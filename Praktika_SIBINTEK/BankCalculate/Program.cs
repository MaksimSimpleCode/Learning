using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCalculate
{
    class Program
    {
        static double Calculate(string userInput)
        {
            //double sum;
            //return sum = money * Math.Pow((1 + (procent / 100) / 12),mounth);
            double sum = double.Parse(userInput.Split(' ')[0]);
            double rate = double.Parse(userInput.Split(' ')[1]);
            int t = int.Parse(userInput.Split(' ')[2]);
            double temp = sum * (1 + (rate / 100 )/ 12);
            double result = Math.Pow((1 + (rate / 100 )/ 12), t);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму, процент, и кол-во месяцев, через пробел");

            string userInput = Console.ReadLine();
            Console.WriteLine(Calculate(userInput));


           // double a = Convert.ToInt32(Console.ReadLine());
           // double b = Convert.ToDouble(Console.ReadLine());
           // double c = Convert.ToInt32(Console.ReadLine());
           //Console.WriteLine(Calculate(a, b, c));


        }
    }
}
