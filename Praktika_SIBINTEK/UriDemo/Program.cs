using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace UriDemo
{
    class Program
    {// Пример применения свойств из класса Uri.
        static void Main(string[] args)
        {
            Uri sample = new
            Uri("http://HerbSchildt.com/somefile.txt?SomeQuery");
            Console.WriteLine("Хост: " + sample.Host);
            Console.WriteLine("Порт: " + sample.Port);
            Console.WriteLine("Протокол: " + sample.Scheme);
            Console.WriteLine("Локальный путь: " + sample.LocalPath);
            Console.WriteLine("Запрос: " + sample.Query);
            Console.WriteLine("Путь и запрос: " + sample.PathAndQuery);
        }
    }
}
