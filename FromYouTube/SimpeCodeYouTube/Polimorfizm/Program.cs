using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm   //Полиморфизм. Один интерфейс, множество реализаций
{
    class Car
    {
        public virtual void Drive()     //Ключевое слово virtual позволяет переопределять метод у наследников
        {
            Console.WriteLine("Я еду");
        }
    }

    class SportCar:Car
    {
        public override void Drive()    //Ключевое слово override позволяет переопределить метод базового класса
        {
            //base.Drive();             //Если хотим использовать уже написанный функционал с базового класса
            Console.WriteLine("Я еду на спортивной машине");    //Задаем новый функционал
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Drive();

            Console.WriteLine();

            SportCar sportCar = new SportCar();
            sportCar.Drive();   //Один и тот же метод выдает разные реализации в зависимости от класса
        }
    }
}
