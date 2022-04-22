using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Timerr
{   //не понимаю при чем тут многопоточность, ну да ладно
    
    class Program
    {
        static void PrintTime(object state)
        {
            Console.WriteLine("Time is: {0}", DateTime.Now.ToLongTimeString());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("****** Working with Timer type ******\n");
            //Создать делегат для типа Timer
            TimerCallback timeCB = new TimerCallback(PrintTime);

            //Установить параметры таймера
            Timer t = new Timer(timeCB, null, 0, 1000);
            Console.WriteLine("Нажми клавишу Enter чтобы завершить...");
            Console.ReadLine();
        }
    }
}
