using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;
            int maxCount = (int)Math.Log(max - min + 1, 2) + 1;
            int count = 0;
            Random rnd = new Random();
            int guessNumber = rnd.Next(min, max);
            Console.WriteLine("Игра угадай число");
            Console.WriteLine("компьютер загадал число от {0} до {1}. Попробуйте отгадать его за {2} попыток." ,min,max,maxCount);

            int n;
            do
            {
                count++;
                Console.Write("{0} попытка. Введите число:", count);
                n = int.Parse(Console.ReadLine());
                if (n > guessNumber) Console.WriteLine("Перелет!");
                if (n < guessNumber) Console.WriteLine("Недолет!");

            }
            while (count< maxCount && n!=guessNumber);
            if (n == guessNumber) Console.WriteLine("Поздравляю! Вы угадали число за {0} попыток", count);
            else Console.WriteLine("Неудача, попробуйте еще раз. Загаданным числом было {0}",guessNumber);


            

            Console.ReadKey();
        }
        
    }
}
