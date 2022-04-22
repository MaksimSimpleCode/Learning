using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    //Описываем делегат.В делегате описывается сигнатура методов, на 
    //которые может ссылаться делегат в дальнейшем(хранить в себе)
    public delegate double Fun(double x);

    class Program
    {
       public static void Table(Fun F, double x , double b)
        {
            //Создаем метод, который принимает делегат
            //То есть на практике, этот метод сможет принимать любой метод
            // с такой же сигнатурой как у делегата
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("|{0,8:0.000}|{1,8:0.000}|",x,F(x));
                x += 1;
            }
            Console.WriteLine("-----------------------");
        }

        //Создаем метод для передачи его в качетсве параметра в Table
        public static double MyFunc(double x)
        {
            return x * x * x;
        }

        static void Main(string[] args)
        {
            //Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции MyFunc: ");
            //Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table(new Fun(MyFunc), -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            //Упрощение(с С#2.0). Делегат создается автоматически
            Table(MyFunc, -2, 2);
            Console.WriteLine("Таблица с функцией Sin: ");
            Table(Math.Sin, -2, 2); //Можно передавать уже созданные методы
            Console.WriteLine("Таблица фенкции x^2:");
            //Упрощение(с С#2.0). Использование анонимного метода
            Table(delegate (double x) { return x * x; }, 0, 3);
        }
    }
}
