using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SimpleMultiThreadApp
{
    public class Printer
    {
        public void PrintNumbers()
        {
            //Вывести информацию о потоке
            Console.WriteLine("-> {0} выполняет PrintNumbers", Thread.CurrentThread.Name);
            //Вывести числа
            Console.Write("Твои числа: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}, ", i);
                Thread.Sleep(2000);
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Приложение с потоками ***** ");
            Console.WriteLine("Хочешь работать с [1] или [2] потоками?");
            string threadCount = Console.ReadLine();    //Запрос количества потоков

            //Назначить имя текущему потоку
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Начальный";

            //Вывести информацию о потоке.
            Console.WriteLine("-> {0} выполняет Main()", Thread.CurrentThread.Name);

            //Создать рабочий класс
            Printer p = new Printer();
            switch (threadCount)
            {
                case "2":
                    //Создать поток.
                    Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
                    backgroundThread.Name = "Вторичный";
                    backgroundThread.Start();
                    break;
                case "1":
                    p.PrintNumbers();
                    break;
                default:
                    Console.WriteLine("Я не знаю что вы выбрали, работаем в 1-поточном режиме");
                    goto case "1";  //Переход к варианту с одним потоком
            }
            //Выполнить некоторую дополнительную работу
            MessageBox.Show("Я занят!", "Работаю над основным потоком...");
            Console.ReadLine();


        }
    }
}
