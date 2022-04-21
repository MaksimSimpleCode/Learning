using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson1_2
{
    class Program
    {
        static void Print(string msg, int x, int y)
        {
            //Устанавливаем позицию курсора
            Console.SetCursorPosition (x, y);
            Console.Write(msg);
        }

        static void Print(string msg, ConsoleColor foregroundcolor)
        {
            //Устанавливаем цвет символов
            Console.ForegroundColor = foregroundcolor;
            Console.Write(msg);
              
        }
        
        // Создаем перегрузку функции в которой будет указана позиция и цвет
        static void Main(string[] args)
        {
            Print("Привет\n" ,10, 10);
            Print("Привет еще раз ", ConsoleColor.Red);
            Console.ReadKey();
        }
    }
}
