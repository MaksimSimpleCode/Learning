using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {//Исключения(перехват ошибок)
            bool flag; //Использование логической переменной в качестве "флага"
            do
            {
                try
                {
                    flag = false; // Флаг опущен
                    int a = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception err) //Exception клас в котором есть методы для ошибок например:Message
                {
                    Console.WriteLine("Неправильно ввели данные");
                    Console.WriteLine(err.Message);
                    flag = true;// ошибка - подняли флаг
                }
                finally     //выполняетс в любом случае, может отсутсвовать
                {
                    Console.WriteLine("Finally,пишет в любом случае");
                }
            }
            while (flag); // Проверяем пока флаг поднят

            //Почему то не очень корректно работает
        }
    }
}
