using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage_Collection
{
    public class TestGC
    {
        public static int ID;
        public int IdObject { get;}
        public TestGC()
        {
            IdObject = ID;
            ID++;
        }

        ~TestGC()   //деконструктор, сюда добовляем логику которая срабатывает при отчистки объекта сборщиком мусора
        {
            Console.WriteLine($"Объект с ID: {IdObject} уничтожен" );
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начало");
            Console.WriteLine("Памяти: "+ GC.GetTotalMemory(false));    //Подсчитываем память
            for(int i = 0;i<50;i++)
            {
                var newObj = new TestGC();
                Console.WriteLine("Создан объект с Id: " + newObj.IdObject);
            }
            Console.WriteLine("Памяти после создания объектов: " + GC.GetTotalMemory(false));

            GC.Collect();   //Чистим память

            Console.WriteLine("Памяти после ЧИСТКИ : " + GC.GetTotalMemory(false));


            Console.WriteLine("Конец");
        }
    }
}
