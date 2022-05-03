using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Test
    {
        
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] pins = new int[4] { r.Next() % 10, r.Next() % 10, r.Next() % 10, r.Next() % 10 };
            foreach (int s in pins)
                Console.WriteLine(s);
            int a = 0;
            a = pins.Length;
            Console.WriteLine("Legth: "+a);

            int[] copy = new int[pins.Length];      //Определяю длинну нового массиво отнасительно длины другого 
            pins.CopyTo(copy, 0);       //Коприрую все из pins в copy с 0 элемента.
            Console.WriteLine("Legth: " + copy.Length);     // для проверки вывожу длину копированного масива

            int[] copy2 = (int[])pins.Clone();      // еще один способ быстрой копии
        }
    }
}
