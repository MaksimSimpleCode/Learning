using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_test_
{
    class Program
    {
        
        private static int Summ (int a, int b)
        {
            return a + b;
        }

        private static int Substract(int a, int b)
        {
            return a - b;
        }

        private static int multiply(int a, int b)
        {
            return a * b;
        }

        private static double Share(int a, int b)
        {
            return (double) a / b;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор");
            int a;
            int b;
            int operation;
            bool quit =false;


            while (quit != true)
            {
                Console.Clear();
                Console.WriteLine("Выберите операцию:\n 1-сложение\n 2-вычитание\n 3-умножение\n 4-деление\n");
                //Это желательно обернуть в метод и все вызывать в case
                try
                {
                    operation = int.Parse(Console.ReadLine());

                    Console.Write("Введите а: ");
                     a = int.Parse(Console.ReadLine());
                    Console.Write("Введите b: ");
                     b = int.Parse(Console.ReadLine());
                }

                catch (Exception)
                {
                    Console.WriteLine("Ошибка ввода");
                    Console.ReadLine();
                    continue;
                }

                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Сумма равна: " + Summ(a, b));
                        break;
                    case 2:
                        Console.WriteLine("Разность: " + Substract(a, b));
                        break;
                    case 3:
                        Console.WriteLine("Произведение: " + multiply(a, b));
                        break;
                    case 4:
                        Console.WriteLine("Деление: " + Share(a, b));
                        break;

                    default:
                        Console.WriteLine("Вы ввели неизвестную команду, попробуйте еще раз.");
                        break;
                }

                Console.Write("Если хотите начать заного введите Да: ");
                if (Console.ReadLine() == "Да")
                {
                    //Console.Clear();  //лучше очищать консоль в начале цикла так как могут быть ошибки и до сюда просто не дойдет
                    quit = false;
                }
                else
                {
                    Console.WriteLine("ВЫХОД ИЗ ПРОГРАММЫ");
                    quit = true;
                }  
                
                        
            }
        }
    }
}
