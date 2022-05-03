using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    // Этот делегат может указывать на любой метод, который принимает
    // два целочисленных значения и возвращает целочисленное значение,
    public delegate int BinaryOp(int x, int y);

    // Этот класс содержит методы, на которые
    // будет указывать BinaryOp.
    public class SimpleMath
    {
        public static int Add(int x, int y) => x + y;
        public static int Substact(int x, int y) => x - y;
        public static int SquareNumber(int a) => a * a;
    }
    class Program
    {
        static void DisplayDelegateInfo(Delegate delObj)
        {
            //Вывести имена всех членов в списке вызовов делегата,
            foreach(Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Имя метода {0}", d.Method);
                Console.WriteLine("Имя типа {0}",d.Target); //ЕСЛИ метод на который ссылается делегат static, то ничего не выведет, так как отсутсвует ссылка на объект 
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*****Простой делегат, пример*****\n");
            // Создать объект делегата BinaryOp, который
            // "указывает" на SimpleMath.Add()
            BinaryOp b = new BinaryOp(SimpleMath.Add);
            DisplayDelegateInfo(b);
            // Вызвать метод Add() косвенно с использованием объекта делегата.
            Console.WriteLine("10+10 is {0}", b(10, 10));

            // Ошибка на этапе компиляции! Метод не соответствует шаблону делегата так как нужно чтобы он принимал 2 int параметра
            //BinaryOp Ь2 = new BinaryOp(SimpleMath.SquareNumber);

            Console.ReadLine();
        }
    }
}
