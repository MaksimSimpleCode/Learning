using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    // Этот обобщенный делегат может вызывать любой метод, который
    // возвращает void и принимает единственный параметр типа Т.
    public delegate void MyGenericDelegate<T>(T arg);



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Generic Delegates * ****\n");
            // Зарегистрировать цели.
           MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StringTarget);
            strTarget("Строковые данные");
            MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(IntTarget);
            intTarget(9);


            Console.ReadLine();
        }

        static void StringTarget(string arg)
        {
            Console.WriteLine("Аргумент в верхнем регистре: {0}", arg.ToUpper());
        }

        static void IntTarget(int arg)
        {
            Console.WriteLine("++Аргумент: {0}", ++arg);
        }
    }
}
