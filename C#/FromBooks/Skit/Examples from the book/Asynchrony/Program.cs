using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchrony
{
    class Program
    {
        async static  Task Main(string[] args)
        {
            Console.WriteLine("Начало метода Main");
            await  PrintAsync(2);               //Ожидаем выполнение этого метода
            PrintAsync(4);                      //Этот метод выполняется без ожидания
            Console.WriteLine($"---------------------------6 в 6 степени = {CalculateAsync(6).Result}");    //Этот метод может выполнится в любом месте  PrintAsync(4);  
            Console.WriteLine("Конец метода Main");                                                         //Этот метод может выполнится в любом месте  PrintAsync(4);  

            //Если мы хотим чтобы асинхронные операции происходили параллельно: 
            //1. Запускаем задачи:
            var task1 = PrintAsync(7);
            var task2 = PrintAsync(8);
            var task3 = PrintAsync(9);
            //2. ожидаем завершения задач
            await task1;
            await task2;
            await task3;
            // Таким образом задачи выполняются параллельно. 

            double pow = await CalculateAsync(2);   //Благодаря тому что метод Main async, мы можем применить await к методу CalculateAsync,                   
            Console.WriteLine(pow);                 //тем самым автоматически распоковаов результат метода.Иначе пришлось использовать Result.

            Console.ReadLine();
        }
        static void Print(int x)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"{i} в степени {x} =  {Math.Pow(i, x)}");
            }
        }
        static async Task PrintAsync(int x)
        {
            Console.WriteLine("Начало асинхронного метода PrintAsync ");
            await Task.Run(() => Print(x));
            Console.WriteLine("Конец асинхронного метода PrintAsync ");
        }
        static double Calculate(int x)
        {
            return Math.Pow(x, x);
        }
        static async Task<double> CalculateAsync(int x)
        {
          return  await Task.Run(() => Calculate(x));
        }
    }


}
