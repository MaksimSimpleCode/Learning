using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @out      //модификатор out
{   
    class Program
    {
        static void Foo (ref int value)
        {
            value++;
            Console.WriteLine(value);
        }
        //Работает точно так же как ref за исключением того что обязывает внутри метода присваивать значения параметру с модификатором out
        static void Bar (out int value)
        {
            value = 5;
            value++;
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            int a =10;
            Foo(ref a); // Если а не будет инициализированна, будет ошибка.
            Bar(out a); // Если а здесь будет обявлена но не инициализированна, ошибки не будет, так как значение присваиваеться в методе.

            Bar(out int b); //можем объявлять переменную прямо в вызове метода с параметром out.

            string str = Console.ReadLine();// Запрашиваем ввод

            int.TryParse(str, out int result);// Пробуем ввод преобразовать в инт
            Console.WriteLine(result);
        }
    }
}
