 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                char b = 'B', c = '\x64', d = '\uffff';

                Console.WriteLine("{0}, {1},{2}", b, c, d);
                Console.WriteLine("{0}, {1},{2}", char.ToLower(b), char.ToUpper(c), char.ToString(d));
                char a = new char();
                do
                {
                    Console.WriteLine("Введите символ: ");
                    a = char.Parse(Console.ReadLine());
                    Console.WriteLine("Введен символ {0}, его код{1}, его категория{2}", a, (int)a, char.GetUnicodeCategory(a));
                    if (char.IsLetter(a)) Console.WriteLine("Буква");
                    if (char.IsUpper(a)) Console.WriteLine("Верхний регистр");
                    if (char.IsLower(a)) Console.WriteLine("Нижний регистр");
                    if (char.IsControl(a)) Console.WriteLine("Управляющий символ");
                    if (char.IsNumber(a)) Console.WriteLine("Число");
                    if (char.IsPunctuation(a)) Console.WriteLine("Разделитель");

                } while (a != 'e');

            }
            catch
            {
                Console.WriteLine("Возникло исключение");
            }


            
        }
    }
}
