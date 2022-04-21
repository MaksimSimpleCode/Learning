using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected     //Модификатор доступа protected при наследовании
{
    class A
    {
        public int publicFiled;
        private int privateFiled;
        protected int protectedFiled;

        public A()
        {
            Console.WriteLine(publicFiled);
            Console.WriteLine(privateFiled);
            Console.WriteLine(protectedFiled);      //Внутри класса можем работать с любым модификатором
        }

        public void Foo()
        {
            Console.WriteLine(privateFiled);
        }
    }

    class B:A
    {
        public B()
        {
            Console.WriteLine(publicFiled);     //Доступен
            Console.WriteLine(privateFiled);    //Не можем получить доступ на прямую
            Console.WriteLine(protectedFiled);  //Доступен при наследовании
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            Console.WriteLine(a.publicFiled);
            Console.WriteLine(a.privateFiled);      //не можем получить доступ
            Console.WriteLine(a.protectedFiled);    //не можем получить доступ

            B b = new B();

            Console.WriteLine(b.publicFiled);
            Console.WriteLine(b.privateFiled);      //не можем получить доступ
            Console.WriteLine(b.protectedFiled);    //не можем получить доступ
            b.Foo();        //Получили доступ к private переменной
        }
    }
}
