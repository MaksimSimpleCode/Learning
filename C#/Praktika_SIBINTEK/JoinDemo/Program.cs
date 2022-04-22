using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinDemo
{
    class Item
    {
        public string Name { get; set; }
        public int ItemNumber { get; set; }
        public Item(string n, int inum)
        {
            Name = n;
            ItemNumber = inum;
        }
    }
    // Класс, связывающий наименование товара с состоянием его запасов на складе.
    class InStockStatus
    {
        public int ItemNumber { get; set; }
        public bool InStock { get; set; }
        public InStockStatus(int n, bool b)
        {
            ItemNumber = n;
            InStock = b;
        }
    }

    // Класс, инкапсулирующий наименование товара и
    // состояние его запасов на складе.
    class Temp
    {
        public string Name { get; set; }
        public bool InStock { get; set; }
        public Temp(string n, bool b)
        {
            Name = n;
            InStock = b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Item[] items = {
             new Item("Кусачки", 1424),
             new Item("Тиски", 7892),
             new Item("Молоток", 8534),
             new Item("Пила", 6411)
            };
            InStockStatus[] statusList = {
                new InStockStatus(1424, true),
                new InStockStatus(7892, false),
                new InStockStatus(8534, true),
                new InStockStatus(6411, true)
            };
            // Сформировать запрос, объединяющий объекты классов Item
            // и InStockStatus для составления списка наименований товаров
            // и их наличия на складе. Обратите внимание на формирование
            // последовательности объектов класса Temp.
            var inStockList = from item in items
                              join entry in statusList
                              on item.ItemNumber equals entry.ItemNumber
                              select new Temp(item.Name, entry.InStock);
            Console.WriteLine("Товар\tНаличие\n");
            // Выполнить запрос и вывести его результаты.
            foreach (Temp t in inStockList)
                Console.WriteLine("{0}\t{1}",t.Name, t.InStock);
        }
    }
}
