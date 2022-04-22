using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать хеш-таблицу.
            Hashtable ht = new Hashtable();
            // Добавить элементы в таблицу.
            ht.Add("здание", "жилое помещение");
            ht.Add("автомашина", "транспортное средство");
            ht.Add("книга", "набор печатных слов");
            ht.Add("яблоко", "съедобный плод");
            // Добавить элементы с помощью индексатора.
            ht["трактор"] = "сельскохозяйственная машина";
            // Получить коллекцию ключей.
            ICollection с = ht.Keys;
            // Использовать ключи для получения значений.
            foreach (string str in с)
                Console.WriteLine(str + ": " + ht[str]);
        }
    }
}
