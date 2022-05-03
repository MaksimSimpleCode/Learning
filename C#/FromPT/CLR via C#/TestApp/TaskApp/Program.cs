using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(() => {
                Console.WriteLine($"Id задачи: {Task.CurrentId}");
            });

            // задача продолжения
            Task task2 = task1.ContinueWith(Display);

            task1.Start();

            // ждем окончания второй задачи
            task2.Wait();
            Console.WriteLine("Выполняется работа метода Main");
            Console.ReadLine();
        }

        static void Display(Task t)
        {
            Console.WriteLine($"Id задачи: {Task.CurrentId}");
            Console.WriteLine($"Id предыдущей задачи: {t.Id}");
            Thread.Sleep(3000);
        }
    }
}