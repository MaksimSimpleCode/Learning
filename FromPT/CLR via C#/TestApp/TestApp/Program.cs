using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{       //Делегаты начало. Вызов,сигнатура.
    public class Program
    {
        public delegate void testDelegate();

        static void Main(string[] args)
        {
            testDelegate t;
            t = new Car().Sound;    //Метод из другого класса
            t += new Bus().Beeb;
            t += LocalStaticMethod;       //Локальный статический метод
            t += new Program().LocalExeplarMethod;  //Локальный ЭКЗЕМПЛЯРНЫЙ метод
          
            t.Invoke();     //Вызываем делегат, или так:  t();

            //Делегаты можно объединять например: 
            testDelegate b = new Car().Sound; 
            testDelegate c = new Bus().Beeb;
            testDelegate x;
            x = c + b;
            x.Invoke();

            testDelegate nullDelegate = null;   //Если делегат пустой то при его вызове будет ошибка
            if(nullDelegate!= null)     //По этому нужно делать проверку.
            {
                nullDelegate.Invoke();
            }
        }
        public static void LocalStaticMethod()
        {
            Console.WriteLine("Локальный СТАТИЧЕСКИЙ метод");
        }
        public  void LocalExeplarMethod()
        {
            Console.WriteLine("Локальный ЭКЗЕМПЛЯРНЫЙ метод");
        }
    }
    public class Car
    {
        public void Sound()
        {
            Console.WriteLine("Метод \"Sound\"экзмемплярного класса \"Car\"");
        }
    }
    public class Bus
    {
        public void Beeb()
        {
            Console.WriteLine("Метод \"Beeb\"экзмемплярного класса \"Bus\"");
        }
    }
}
