using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtMethods
{// Использовать ряд методов расширения, определенных в классе Enumerable.
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 1, 2, 5, 4 };
            Console.WriteLine("Минимальное значение равно " + nums.Min());
            Console.WriteLine("Максимальное значение равно " + nums.Max());
            Console.WriteLine("Первое значение равно " + nums.First());
            Console.WriteLine("Последнее значение равно " + nums.Last());
            Console.WriteLine("Суммарное значение равно " + nums.Sum());
            Console.WriteLine("Среднее значение равно " + nums.Average());
            if (nums.All(n => n > 0))
                Console.WriteLine("Все значения больше нуля.");
            if (nums.Any(n => (n % 2) == 0))
                Console.WriteLine("По крайней мере одно значение является четным.");
            if (nums.Contains(3))
                Console.WriteLine("Массив содержит значение 3.");
        }
    }
}
