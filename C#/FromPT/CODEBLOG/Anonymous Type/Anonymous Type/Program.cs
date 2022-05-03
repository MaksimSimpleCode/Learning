using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 5;
            var product = new   //Создали анонимный тип. *Свойства будут доступны только для чтения!
            {
                Name = "Milk",
                Energy = 10
            };

            Console.WriteLine(product);
            Console.WriteLine(product.Energy);
            Console.WriteLine(product.Name);

            var eat = new Eat()
            {
                Name = "Meat"
            };
            var product2 = new
            {
                eat.Name,
                Energy = 200
            };
            Console.WriteLine(product2);


            Tuple<int, string> tuple = new Tuple<int, string>(5, "Привет"); //Создали кортеж с 2 эллементами. *Эллементы так же доступны только для чтения!
            Console.WriteLine($"Эллемент 1: {tuple.Item1}");
            Console.WriteLine($"Эллемент 2: {tuple.Item2}");

            var tuble2 = (5, 3213, 3.231, "GOGOGO");    //Более простая запись кортежа. * Возможно придется из NuGet установить пакет для кортежей (ValueTuple).

            tuble2.Item4 = "New GOGOGOGO";
            Console.WriteLine(tuble2.Item4);
            Console.WriteLine(tuble2);

            var tuble3 = (Name: "Tommato", Energy: 20); //Кортеж с именовонными полями, у таких полей мы можем менять значения, а так же как в примере выше.
            tuble3.Name = "New Tommato";
            Console.WriteLine(tuble3.Name);
            Console.WriteLine(tuble3.Energy);
        }
    }
}
