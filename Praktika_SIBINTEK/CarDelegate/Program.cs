using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    public class Car
    {
        //Данные состояния 
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        //Исправлен ли автомобиль
        private bool carIsDead;

        //Конструкторы класса
        public Car() { }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        //1. Определить тип делегата.
        public delegate void CarEngineHandler(string msgForCaller);
        //2. Определить переменную- член этого типа делегата.
        private CarEngineHandler listOfHandlers;
        //3. Добавить регистрационную функцию для вызывающего кода.
        // Добавление поддержки группового вызова.
        // Обратите внимание на использование операции +=,
        // а не обычной операции присваивания (=) .
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers += methodToCall;     //-=
        }

        // 4. Реализовать метод Accelerate () для обращения к списку
        // вызовов делегата в подходящих обстоятельствах.
        public void Accelerate (int delta)
        {
            // Если этот автомабиль сломан, то отправить сообщение об этом.
            if(carIsDead)
            {
                if (listOfHandlers != null)
                    listOfHandlers("Извините, эта машина сломана");
            }
            else
            {
                CurrentSpeed += delta;
                //Автомабиль почти сломан?
                if(10==(MaxSpeed-CurrentSpeed)&& listOfHandlers!= null)
                {
                    listOfHandlers("Осторожней! Сейчас взорвется!");
                }
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("Текущая скорость = {0}",CurrentSpeed);
            }
        }
        
    }

    class Program
    {
        // Теперь есть ДВА метода, которые будут
        // вызываться Саг при отправке уведомлений.
        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("*********************************\n");
        }
        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("=> {0}", msg.ToUpper());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***** Delegates as event enablers *****\n");
            // Создать объект Car.
            Car cl = new Car("SlugBug",100,10);

            //Сообщить объекту Car, какой метод вызвать,
            // когда он пожелает отправить сообщение
            cl.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            cl.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));

            //Увеличить скорость( это инициирует события)
            Console.WriteLine("*****Speeding up *****");
            for (int i = 0; i < 6; i++)
                cl.Accelerate(20);
            Console.ReadLine();
        }
    }
}
