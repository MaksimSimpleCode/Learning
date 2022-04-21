using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать отсортированный список.
            SortedList sl = new SortedList();
            // Добавить элементы в список.
            sl.Add("здание", "жилое помещение");
            sl.Add("автомашина", "транспортное средство");
            sl.Add("книга", "набор печатных слов");
            sl.Add("яблоко", "съедобный плод");
            // Добавить элементы с помощью индексатора,
            sl["трактор"] = "сельскохозяйственная машина";
            // Получить коллекцию ключей.
            ICollection с = sl.Keys;
            // Использовать ключи для получения значений.
            Console.WriteLine("Содержимое списка по индексатору.");
            foreach (string str in с)
                Console.WriteLine(str + ": " + sl[str]);
            Console.WriteLine();
            // Отобразить список, используя целочисленные индексы.
            Console.WriteLine("Содержимое списка по целочисленным индексам.");
            for (int i = 0; i < sl.Count; i++)
                Console.WriteLine(sl.GetByIndex(i));
            Console.WriteLine();
            // Показать целочисленные индексы элементов списка.
            Console.WriteLine("Целочисленные индексы элементов списка.");
            foreach (string str in с)
                Console.WriteLine(str + ": " + sl.IndexOfKey(str));
        }
    }
}
