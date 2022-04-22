using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравстуйте, введите ваше имя и возраст:");
            Console.WriteLine("Имя: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("Очень приятно" + " " + name1 + " " + "Вам уже больше 18, а точнее:" + age);
            }
            else
            {
                Console.WriteLine("Вам еще нет 18 так что ссори");
            }
            Console.ReadKey();
        }
        static void Test(string[] args)
        {
            
            // hello world
            string name = "";
            Console.WriteLine("Введите сове имя:");
            name  = Console.ReadLine();
            Console.WriteLine("Привет" +" "+ name);
            Console.WriteLine();
        }



    }
}
