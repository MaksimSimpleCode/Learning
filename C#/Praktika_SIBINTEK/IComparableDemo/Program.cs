using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IComparableDemo
{
    /*
     * Если требуется отсортировать объекты, хранящиеся в необобщенной коллекции,
то для этой цели придется реализовать необобщенный вариант интерфейса
IComparable. В этом варианте данного интерфейса определяется только один метод
CompareTo(), который определяет порядок выполнения самого сравнения.
*/
    // Реализовать необобщенный вариант интерфейса IComparable.
    class Inventory : IComparable
    {
        string name;
        double cost;
        int onhand;
        public Inventory(string n, double c, int h)
        {
            name = n;
            cost = c;
            onhand = h;
        }
        public override string ToString()
        {
            return
            String.Format("{0,-10}Стоимость: {1} Наличие: {2}",
            name, cost, onhand);
        }
        // Реализовать интерфейс IComparable.
        public int CompareTo(object obj)
        {
            Inventory b;
            b = (Inventory)obj;
            return name.CompareTo(b.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList inv = new ArrayList();
            // Добавить элементы в список.
            inv.Add(new Inventory("Кусачки", 5.95, 3));
            inv.Add(new Inventory("Отвертки", 8.29, 2));
            inv.Add(new Inventory("Молотки", 3.50, 4));
            inv.Add(new Inventory("Дрели", 19.88, 8));
            Console.WriteLine("Перечень товарных запасов до сортировки:");
            foreach (Inventory i in inv)
            {
                Console.WriteLine(" " + i);
            }
            Console.WriteLine();
            // Отсортировать список.
            inv.Sort();
            Console.WriteLine("Перечень товарных запасов после сортировки:");
            foreach (Inventory i in inv)
            {
                Console.WriteLine(" " + i);
            }
        }
    }
}
