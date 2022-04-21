using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здесь ты просто пишешт что хочешь вывести на консоль");
            Console.WriteLine("Допустим введите мия: ");

            string name = Console.ReadLine();   //Здесь мы присваиваем в переменную то что введем в консоли до нажатия ENTER

            Console.WriteLine("Теперь выведем то что ты ввел: {0}", name); //первый способ

            Console.WriteLine(); //пустая строка

            Console.WriteLine("Выведем еще раз, допустим Как дела? " + name);//второй способ

            //Третий способ как у тебя в примере
            Console.ReadLine();
        }
    }
}
