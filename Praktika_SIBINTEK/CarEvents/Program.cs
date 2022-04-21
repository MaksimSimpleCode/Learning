using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
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



        //Car сможет отправлять следующие сообщения:
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutBlow;



        //2. Определить переменную- член этого типа делегата.
       // private CarEngineHandler listOfHandlers;
        //3. Добавить регистрационную функцию для вызывающего кода.
        // Добавление поддержки группового вызова.
        // Обратите внимание на использование операции +=,
        // а не обычной операции присваивания (=) .
     //   public void RegisterWithCarEngine(CarEngineHandler methodToCall)
      //  {
      //      listOfHandlers += methodToCall;     //-=
      //  }

        // 4. Реализовать метод Accelerate () для обращения к списку
        // вызовов делегата в подходящих обстоятельствах.
        public void Accelerate(int delta)
        {
            // Если этот автомабиль сломан, то отправить сообщение об этом.
            if (carIsDead)
            {
                Exploded?.Invoke("Извините, эта машина сломана");   //Упрощенная версия проверки на null
            }
            else
            {
                CurrentSpeed += delta;
                //Автомабиль почти сломан?
                if (10 == MaxSpeed - CurrentSpeed) 
                {
                    AboutBlow?.Invoke("Осторожней! Сейчас взорвется!"); //Упрощенная версия проверки на null
                }
                //Все еще в порядке
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("Текущая скорость = {0}", CurrentSpeed);
            }
        }

    }

    class Program
    {
        public static void CarAboutToBlow(string msg)
        { Console.WriteLine(msg); }
        
        public static void CarlsAlmostDoomed(string msg)
        { Console.WriteLine("=> Critical Message from Car: {0}", msg); }

        public static void CarExploded(string msg)
        { Console.WriteLine(msg); }
            

            static void Main(string[] args)
        {
            Console.WriteLine("******Fun with Events *****\n");
            Car cl = new Car("SlugBug", 100, 10);

            //Зарегистрировать обработчики событий
            cl.AboutBlow += CarlsAlmostDoomed;
            cl.AboutBlow += CarAboutToBlow;
            cl.Exploded += CarExploded;    //CarExploded

            Console.WriteLine("***** Speeding up *****");
            for(int i = 0; i<6; i++)
            {
                cl.Accelerate(20);
            }

            cl.Exploded -= CarExploded;

            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                cl.Accelerate(20);
            }
            Console.ReadLine();
        }
           
                

        
    }
}
