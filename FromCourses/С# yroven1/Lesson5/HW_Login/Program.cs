using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Login
{
    class Program
    {
        //Метод отображения слова попытка в правильной форме
        //param name = x - количество попыток

        static string RightTryWord(int x)
        {
            string s = "";
            //Попытка, когда заканчивается на 1, кроме 11.
            if (x % 10 == 1 && x != 11) s += " попытка";
            else
                //Попытки
                if ((x >= 2 && x <= 4) || (x >= 22 && x <= 24) || (x >= 32 && x <= 34) || (x > 41 && x < 45)) s += " попытки";
            else
                // Попыток
                if ((x == 11) || (x >= 5 && x <= 20) || (x >= 25 && x <= 30) || (x >= 35 && x < 41) || (x > 44 && x < 51)) s += " попыток";
            return s;
        }
        //Метод проверяет что символ- латинская буква
        private static bool isLatineLetter(char letter)
        {
            int num = letter;
            if ((num >= 65 && num <= 90) || (num >= 97 && num <= 122))
                return true;
            else
                return false;
        }

        //Метод проверки на соответствие логина требованиям
        static bool CheckLogin(string login)
        {
            int length = login.Length;
            if (length >= 2 && length<= 10)
            {
                bool check = true;
                char letter = login[0];
                if (char.IsDigit(letter))
                    return false;
                for (int i = 1; i < length; i++)
                {
                    letter = login[i];
                    if (!(char.IsDigit(letter) || isLatineLetter(letter)))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    return true;

            }
            return false;
        }

        //Метод проверки на соотвествие логина требованиям через регулярные выражения
        static bool ChekLogin(string login)
        {
            char latter = login[0];
            if (char.IsDigit(latter))
                return false;
            if (!Regex.IsMatch(login, @"^[a-zA-Z0-9]+${2,10}"))
                return false;
            return true;


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветсвует программа проверки корректности логина.");
            int AmountOfTries = 3;

            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                
                if (CheckLogin(login) && ChekLogin(login))
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    AmountOfTries--;
                    Console.WriteLine("Неверный ввод логина. \nДолжны быть соблюдены следующие условия:"
                        + "\nДлина строки 2 до 10 символов;"
                        + "\nбуквы только латинского алфавита или цифры;"
                        + "\nцифра не может быть первой"
                        + Environment.NewLine + "\nУ вас осталось" + AmountOfTries + RightTryWord(AmountOfTries));
                }
                
            }while (AmountOfTries > 0) ;
            Console.WriteLine("Логин корректен!");
            Console.ReadKey();
        }
    }
}
