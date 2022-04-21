using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        //Метот паузы
        static void Pause()
        {
            Console.ReadKey();
        }

        static void Pause(string msg)
        {
            // Можно сразу ввести чему равно msg 
            Console.WriteLine(msg);
            Console.ReadKey();
        }


        //Выше мы создали два метода с одним названием, это называется ПЕРЕГРУЗКОЙ. В итоге внизу где мы вызываем метод Pause
        //можно оставить его пустым, тем самым срабоатет первый метот, или ввести значение и сработает второй.
        //Сделано это для того чтобы не создавать кучу похожих методов с разными названиями и параметрами, а оставить одно название и в итоге вписывать нужные параметры.


        static void Main(string[] args)
        {
    
            // int a, b, c;
           //a = 150;
           //b = 250;
            //c = 350;
            //Console.WriteLine("Переменная номер:{0} , {1}, {2}", a, b, c);
            //Console.ReadKey();


            //Метод Math(Квадратный корень) и конвертация числа для ввода в консоль
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SQRT({0})={1}", a, Math.Sqrt(a));
            Pause("Нажми что нибудь");
        }
    }
}
 