using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StringBuilderLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder - это класс, представляющий собой изменяемую строку
            var builder = new StringBuilder();

            //Он содержит различные методы вставки, добавления, удаления и т.д.
            builder.Append("Тест");
            builder.Append("иеще тест");
            builder.Remove(4, 9);
            builder.Insert(4, " вставка ");
            Console.WriteLine(builder);

            //StringBuilder можно превратить в строку
            var str = builder.ToString();
            Console.WriteLine(str);

            builder[2] = '!';
            Console.WriteLine(builder);
            // Не нужно полностью заменять строки на StringBuilder,
            //Только в тех случаях, когда действительно выполняется много преобразований


            var watch = new Stopwatch();

            watch.Start();
            WrongConcatenation();   //Без StreamBilding
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds +" мс");

            watch = new Stopwatch();
            watch.Start();
            RightConcatenation();   //С StreamBilding"
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds + " мс");
        }

        static void WrongConcatenation()
        {
            //Если нам нужно сконкатенировать большое количество строк
            //то конкатенация "в лоб" потребует очень много памяти в куче, 
            //и будет работать медленно

            var str = "";

            for (int i = 0; i < 50000; i++)
            {
                str += i.ToString() + ", ";
                
            }
            Console.WriteLine( "Без StreamBilding");
        }

        static void RightConcatenation()
        {
            //Конкатенация со StringBuilder работает в сотни раз быстрее
            //Однако, в случае 3-4 строк вы не почувствуете разницы, поэтому 
            //в этом случае пользоваться StringBuilder не обязательно
            var builder = new StringBuilder();

            for (int i = 0; i < 50000; i++)
            {
                builder.Append(i);
                builder.Append(", ");
                
            }
            Console.WriteLine("С StreamBilding");
        }
    }
}
