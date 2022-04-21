using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_7
{
    class Program
    {
        // Для запикивания пароля
        static string EnterPass()
        {
            string pass = "";
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                //Backspace и Enter не учитываются
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        pass = pass.Substring(0, (pass.Length - 1));
                        Console.Write("\b\b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);
            return pass;
        }



        static bool Passvord(string login, string pass)
        {
            if (login == "maksim" && pass == "qwert12345")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static void Main(string[] args)
        {
            int AmountOfTries = 3;
            Console.WriteLine("Программа авторизации логина и пароля.");
            do
            {
                Console.Write("Введите логин ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль ");
                string pass = EnterPass();

                if (Passvord(login, pass))
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    AmountOfTries--;
                    Console.WriteLine("Неверный ввод логина или пароля." + Environment.NewLine + "У вас осталось " + AmountOfTries + " попыток");
                }
            }
            while (AmountOfTries > 0);
            {
                Console.WriteLine("Добро пожаловать");
                Console.ReadKey();
            }


            

        }
    }
}
