using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwLesson16
{
    class Program
    {/// <summary>
    /// Написать программу которая будет подсчитывать количество четных и не четных чисел в указанном диапазоне
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите 1 число диапазона: ");
            int count = int.Parse(Console.ReadLine());
            int even = 0;   // Переменная для записи четных чисел
            int notEven = 0; // Переменная для записи не четных чисел
            Console.Write("Введите 2 число диапазона: ");
            int limit = int.Parse(Console.ReadLine());

            while(count<=limit)
            {
                if (count % 2 == 0)
                {
                    even++;
                }
                else notEven++;

                count++;
            
            }

            Console.WriteLine("Колчичество четных чисел: {0}\n Количество не четных чисел: {1}",even,notEven);
        }
    }
}
