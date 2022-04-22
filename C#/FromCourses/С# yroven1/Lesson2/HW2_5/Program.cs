using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_5
{
    class Program
    {
        static int AmountOfCharInNumber(string number)
        {
            return number.Length;
        }

        static string GetNumbericString()//проверяем ввод
        {
            string number = "";
            bool checkNotAnumber;
            do
            {
                checkNotAnumber = false;
                number = Console.ReadLine();
                for (int i = 0; i < number.Length; i++)
                {
                    if (!char.IsNumber(number, i))
                    {
                        checkNotAnumber = true;
                        Console.Write("Неверный ввод(требуется числовое значение)");
                        break;
                    }
                }
            } while (checkNotAnumber);
            return number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас пиветсвует программа подсчета количества цифр числа");
            Console.WriteLine("Введите число: ");
            string number = GetNumbericString();
            Console.WriteLine(Environment.NewLine + "Количество цифр: " + AmountOfCharInNumber(number));
            Console.ReadKey();
        }
    }
}
