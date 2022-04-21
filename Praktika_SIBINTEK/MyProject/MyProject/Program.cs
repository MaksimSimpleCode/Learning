using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    //Засунуть в другой проект+ разбить по методам более грамотно
    class Ruletka
    {
        static void GuessNumber()
        {
            int min = 1;
             int max = 100;
            int maxCount = (int)Math.Log(max - min + 1, 2) + 1;
            int count = 0;
             Random rnd = new Random();
            int guessNumber = rnd.Next(min, max);
            Console.WriteLine("Игра угадай число");
            Console.WriteLine("компьютер загадал число от {0} до {1}. Попробуйте отгадать его за {2} попыток.", min, max, maxCount);

            int n;
         do
         {
            count++;
            Console.Write("{0} попытка. Введите число:", count);
            n = int.Parse(Console.ReadLine());
            if (n > guessNumber) Console.WriteLine("Перелет!");
            if (n < guessNumber) Console.WriteLine("Недолет!");

         }
            while (count < maxCount && n != guessNumber);
         if (n == guessNumber) Console.WriteLine("Поздравляю! Вы угадали число за {0} попыток", count);
            else Console.WriteLine("Неудача, попробуйте еще раз. Загаданным числом было {0}", guessNumber);




        Console.ReadKey();
    }

    static void Test()
    {
        Console.WriteLine("Здесь пока ничего нет.");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Игровое меню");
        Console.WriteLine("1 - Угадай число");
        Console.WriteLine("2 - Пока толкьо одна игра");
        string s = Console.ReadLine();
        switch (s)
        {
            case "1":
                GuessNumber();
                break;
            case "2":
                Test();
                break;
        }
    }

}
class Program
    {
        static void Polosa()
        {

            for (int i = 0; i < 80; i++)
                Console.Write("=");

        }


        static void Main(string[] args)
        {
            Console.Title = "Рулетка";
            Console.Write("Ваше имя:" );
            string name = Console.ReadLine();
            Console.WriteLine("Привет," + name + "! Давай сыграем!");


            int round = 1;
            int money = 100;
            int stavka = 0;
            int stavkaMonye = 0;
            Random rnd = new Random();
            do
            {
                Console.WriteLine("Раунд " + round);
                Console.WriteLine("На счету: " + money);
                Console.Write("На что ставите от 1 до 10?");
                stavka = Convert.ToInt32(Console.ReadLine());
                Console.Write("Сколько ставите: ");
                stavkaMonye = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Вы поставили " + stavkaMonye + " на " + stavka);

            int g = rnd.Next(1, 10);

            
                if (stavka == g)
                {
                    money += stavkaMonye;
                    Console.WriteLine("Поздравляю, вы угалади! На вашем счету: " + money);
                    Polosa();
                }
                else
                {
                    money -= stavkaMonye;
                    Console.WriteLine("А выпало:" + g + " На вашем счету: " + money + Environment.NewLine );
                    Polosa();
                }

                round++;

            } while (money >5 );Console.WriteLine("У вас закончились деньги( Приходите как будут еще!");


            
            Console.ReadKey();
        }
    }
}
