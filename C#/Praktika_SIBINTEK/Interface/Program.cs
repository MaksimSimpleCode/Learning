using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacee
{
    interface IWeapon
    {
        void Stats();
        void Shot();
        void Test();
    }

    class AK47:IWeapon
    {
        public void Stats()
        {
            Console.WriteLine("Ak_47");
        }
        public void Shot()
        {
            Console.WriteLine("Выстрел с AK47");
        }

        public void Test()
        {
            Console.WriteLine("Test AK");
        }
    }

    class Knife : IWeapon
    {
        public void Shot()
        {
            Console.WriteLine("Knife");
        }
        public void Test() => Console.WriteLine("Тест лямбда выражения");   //Лямбда-выражение
       

        public void Stats()
        {
            Console.WriteLine("Удар с Knife");
        }
    }

    class Katana    //Создаю класс с такими же методами но не наследую интерфейс и соответсвенно не реализую его.
    {
        public void Shot()
        {
            Console.WriteLine("Katana");
        }

        public void Stats()
        {
            Console.WriteLine("Удар с Katana");
        }
    }

    enum Days{
        Pon,
        Vtor,
        Sred,
        Chet,
        Pyat,
        Sub,
        Vos
    };
    class Program
    {
        static void Main(string[] args)
        {
            Knife knife = new Knife();
            knife.Stats();
            knife.Shot();
            knife.Test();

            Console.WriteLine();

            AK47 ak = new AK47();
            ak.Stats();
            ak.Shot();
            ak.Test();

            Console.WriteLine();

            Katana katana = new Katana();
            katana.Stats();
            katana.Shot();

            Console.WriteLine();

            object[] guns = { new AK47(), new Knife(), new Katana() };  //Массив объектов

            for (int i = 0;i<guns.Length;i++)   //Перебираем объекты и выяснем реализует ли объет интерфейс IWeapon
            {
                if (guns[i] is IWeapon ip)   //Таким образом можно выяснить реализует ли объект тот или иной интерфейс, полезно когда много объектов 
                    //и нужно выямнить это.
                    Console.WriteLine(guns[i] + " Реализует интерфейс IWeapon");
                else
                    Console.WriteLine(guns[i] + " Не реализует интерфейст IWeapon");
            }

           
            

            for(int i=0; i<=(int)Days.Sub;i++)
            {
                Console.WriteLine(i);
                if (i == (int)Days.Sub)
                    Console.WriteLine("Дошли до Субботы");
            }
        }
    }
}
