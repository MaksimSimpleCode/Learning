using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var str = "str";
            var number = 42;
            Generic(car);
            Generic(str);
            Generic(number);
        }
        public static void  Generic<T>(T obj)
        {
            if (obj is Car)
            {
                Console.WriteLine("тачка");
            }
            else if (obj is string)
            {
                Console.WriteLine("строка");
            }
            else
                Console.WriteLine("ХЗ");

        }
    }
    public class Car
    {

    }
}
