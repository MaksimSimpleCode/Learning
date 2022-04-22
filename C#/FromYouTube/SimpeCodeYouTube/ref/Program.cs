using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @ref      //Ключевое слово ref
{
    struct MyStruct
    {
        public int a;
        public double b;
        public float c;
    }


    class MyClass
    {
        public int a;
        public double b;
        public float c;
    }
    class Program
    {
        static void Foo (ref int a)     
        {
            a = -5;
        }

        static void Foo2(ref MyStruct myStruct)
        {
            myStruct.a = -5;
        }

        static void Foo3( MyClass myClass)
        {
            myClass.a = -5;
        }

        static void Main(string[] args)
        {
            int a = 2;

            Foo(ref a);         // Значимый тип
            Console.WriteLine(a);       //Благодоря ref мы у значимых типов получаем поведение как у ссылочных и вместо 2 получаем -5.

            MyStruct myStruct = new MyStruct(); // Значимый тип
            Foo2(ref myStruct);     //Тоже самое, без ref мы не получим -5 в структуре.

            /*
             *  А теперь посмотрим каким образоим измениться поведение при использовании ref на ссылочных типах. 
             */

            MyClass myClass = new MyClass();
            Foo3( myClass);     // Ссылочные типы работаю таким образм что ref включен по умолчанию. И что с ним (ref) что без него передаеться значение из метода.

            int[] myArray = new int[5];
           ref int b = ref myArray[0];      // Тоже самое с массивами. Мы смогли присвоить переменную к индексу массива.

            b = 5;
        }
    }
}
