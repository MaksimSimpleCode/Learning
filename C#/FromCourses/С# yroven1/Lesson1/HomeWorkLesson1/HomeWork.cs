using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson1
{
    class HomeWork
    {   
        //Метод для проверки на четность
        static bool Odd(int n)
        {
            return n % 2 == 0;
        }


        static void Main(string[] args)
        {
            //Четное не четное
            int a = 0;
            Console.WriteLine("Введите четное или не четное число: ");
             a= Convert.ToInt32(Console.ReadLine());
            Odd(a);
            if (Odd(a))
            {
                Console.WriteLine("Вы ввели ЧЕТНОЕ число");
            }
            else
            {
                Console.WriteLine("Вы ввели НЕЧЕТНОЕ число");
            }
            Console.ReadKey();
        }
    }
}
