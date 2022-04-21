using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *По сути это объект который ссылается на методы
 * то есть делегат может вызвать метод на который он ссылается
 */
namespace Delegate  //Делегаты
{
    delegate void MyDelegate(string str);   //Объявляем делегат

    class Methods
    {
        MyDelegate deleg;
        
         public void Write(string str)
         { 
            Console.WriteLine("Этот метот ставит - вместо пробелов");
            str.Replace(' ', '-');

         }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Methods obj = new Methods();

            MyDelegate deleg;
            deleg = obj.Write;

            deleg("Это предложение записивыю в делегат");
        }
    }
}
