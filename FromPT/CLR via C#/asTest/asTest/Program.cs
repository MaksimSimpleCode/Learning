using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asTest
{
    class Employe
    {

    }

    class Manager
    {

    }
    class Program
    {
        static void Main(string[] args)
        {

            Object obj = new Object();
            Object obj2 = new Object();
            Employe employe = new Employe();
            Manager manager = new Manager();

            //user = obj as Employe;
            obj = employe as Employe;  //конструкция as возвращает null если типы не совместимы. Конструкция is в свою очередь вернет bool
            if (employe != null)
            {
                Console.WriteLine("Типы совместимы");

            }
            else
            {
                Console.WriteLine("Типы не совместимы!");
            }


            if (obj2 is Manager)
            {
                Console.WriteLine("Типы совместимы");
                Manager managa = (Manager)obj2;
                //Работает с managa внутри конструкции


            }
            else
            {
                Console.WriteLine("Типы не совместимы!");
            }
            Object obj3 = new Object();
            Object obj4 = new Object();

            var test1 = obj3 as Manager;    //Вернет null если не совместимы или присвоит ссылку на объект
                
            var test2 = obj4 is Manager;    //Вернет false или true

            //По сути, оператор as отличается от оператора приведения типа только тем, что никогда не генерирует исключение.Если приведение типа невозможно, результатом является null.\

            
            
        }
       
    }
}
