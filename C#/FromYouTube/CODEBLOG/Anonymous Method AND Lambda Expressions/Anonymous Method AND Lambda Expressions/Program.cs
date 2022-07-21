using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Method_AND_Lambda_Expressions
{
    class Program
    {
        //Анонимные методы / лямбда-выражения

        delegate int MyHandler(int i);
        static void Main(string[] args)
        {
            int keypress = Convert.ToInt32(Console.ReadLine());
            MyHandler handler = delegate (int i)    //Анонимный метод
            {
                var r = i * i;
                Console.WriteLine(r);
                return r;
            };
            handler += Method;
            handler(keypress);
            handler(88);

            MyHandler lambdaHandler = (i) =>    //лямбда-выражение
            {
                var r = i * i;
                Console.WriteLine(r);
                return r;
            };
            Console.WriteLine("Лямбда- выражение: "+ lambdaHandler(99));
        }
        public static int Method(int i)
        {
            var r = i * i * i;
            Console.WriteLine(r);
            return r;
        }
    }
}
