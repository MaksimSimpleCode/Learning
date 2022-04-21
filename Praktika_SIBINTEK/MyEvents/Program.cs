using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvents  //Попробую создать событие сам
{
    class BankAccount
    {
        public int Sum { get; private set; }
        public string UserName { get; private set; }
        private int ID;
        private static int totalID;

        public BankAccount(string userName,int sum)
        {
            this.UserName = userName;
            this.Sum = sum;
            ID=totalID;
            totalID++;
        }

        public void FullInfoFromACC() => Console.WriteLine("Имя: {0}\n Сумма на счету: {1}\n ID Клиента: {2}\n _______________________________", UserName, Sum, ID);

        public void Put(int putSum)
        {
             Sum += putSum;
            myEvent?.Invoke($"На счет поступило: {putSum}");    //Если событие не null то выдаем такое сообщение
        }

        public void Take(int takeSum)
        {
            if(Sum>=takeSum)
            {
                Sum -= takeSum;
                myEvent?.Invoke($"Со счета снято: {takeSum}");  //Если событие не null и Сумма на счете больше или равна снятию то такое сообщение
            }
            else
            {
                myEvent?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); //Если недостаточно средств то такое
            }
            
        }


        //Создаю событие типа Action (встроенный делегат чтобы не создавать свой)
        public  event Action<string> myEvent;
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount("Maks", 1000);
            BankAccount acc2 = new BankAccount("Robin", 520);
            BankAccount acc3 = new BankAccount("Jon", 4100);
            BankAccount acc4 = new BankAccount("Yilam", 3200);
            acc1.FullInfoFromACC();
            // acc2.FullInfoFromACC();
            // acc3.FullInfoFromACC();
            // acc4.FullInfoFromACC();
            acc1.myEvent += DisplayMessage; //Добовляем обработчик события|Аналоговый способ, лямбда выражение: message => Console.WriteLine(message)

            acc1.Put(500);
            acc1.Take(2502);
            acc1.FullInfoFromACC();
        }

        private static void DisplayMessage(string message)  //Автоматом по сниппету создается обработчик события 
        {
            Console.WriteLine(message);
        }

        /* В общем и целом мы создаем делегат, далее создаем событие которое принимает тип делегата(определенный делегат),
         * в различных методах где что-то происходит мы внедряем логику делегата при определенных исходах(недостаточно средств и т.д)
         * затем мы в Main() создаем обработчик события "acc1.myEvent += DisplayMessage;" и вешаем на него методы которые можно создать по сниппету
         * вот в них немного не понимаю, они что ли как заглушка действуют или как зеркало, не суть.
         * После этого если срабатывает событие в каком либо методе класса, оно у нас происходит.
         * Ну и конечно мы можем добовлять и удалять обработик событий += -=
         * Вместо обработчика событий могут использоваться не только методы но и делегаты, лямда выражения, анонимные методы
         */
    }
}
