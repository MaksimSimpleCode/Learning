using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
     internal class Program
     {
      

        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(100);
            account.Notify += DisplayMassage;       // Добавляем обработчик для события Notify
            account.Put(20);
            account.Take(150);
            account.Take(1500);
            account.Put(300);
            account.Take(1520);
            account.Put(1520);
        }
         static void DisplayMassage(BankAccount sender, AccountEventArgs e)
         {
            Console.WriteLine($"Сумма транзакции: {e.Sum}");
            Console.WriteLine(e.Message);
            Console.WriteLine($"Текущая сумма на счете: {sender.Sum}");
         }

     }
    internal class BankAccount
    {
        public delegate void AccountHandler(BankAccount sender, AccountEventArgs e); //1. Создаем делегат
        public event AccountHandler Notify;                  //2. Объявляем событие которое представляет делегат AccauntHandler

       public int Sum { get; private set; }

        public BankAccount(int sum)
        {
            Sum = sum;
            Console.WriteLine($"Аккаунт создан с суммой на счету: {Sum}");
        }

        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke(this, new AccountEventArgs($"Сумма {sum} снята со счета", sum));   //3. используем событие о котором хотим оповещать.* В данном случае зашита строка. 
                                                            // Но может быть использована системная настройка или какой нибудь метод с нужным нам сообщением или оповещением и тд.
            }
            else
            {
                Notify?.Invoke(this, new AccountEventArgs("Недостаточно денег на счете", sum));  //3.
            }
        }

        public void Put( int sum)
        {
            Sum += sum;
            Notify?.Invoke(this, new AccountEventArgs($"На счет поступило {sum}", sum));    //3.
        }
    }
  internal class AccountEventArgs
    {
        // Сообщение
        public string Message { get; }
        // Сумма, на которую изменился счет
        public int Sum { get; }
        public AccountEventArgs(string message, int sum)
        {
            Message = message;
            Sum = sum;
        }
    }
}