using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncApp
{
    class Program
    {
        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        // определение асинхронного метода
        static async void FactorialAsync(int n)
        {
            int x = await Task.Run(() => Factorial(n));
            Console.WriteLine($"Факториал равен {x}");
        }
        static void Main(string[] args)
        {
            FactorialAsync(5);
            FactorialAsync(6);
            Console.Read();
        }
    }
}