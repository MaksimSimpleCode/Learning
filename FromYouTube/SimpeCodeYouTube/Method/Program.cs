using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method        //Методы
{
    class Program
    {
        static int Read()       //Метод  считывания значений с клавиатуры
        {
           return int.Parse(Console.ReadLine());    
        }


        static int Sum (int a, int b)   //Метот сложения 2 чисел
        {
           return  a + b;      // Возвращаем результат операции
        }


        static void Main(string[] args)
        {
          //int a = int.Parse(Console.ReadLine());
         // int b = int.Parse(Console.ReadLine());

           Console.WriteLine(Sum(Read(), Read()));       // Вызываю метод
           Console.WriteLine("===============");
        }

    }
}
