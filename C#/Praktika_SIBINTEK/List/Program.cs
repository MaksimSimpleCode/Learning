using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать коллекцию в виде динамического массива.
            List<char> lst = new List<char>();
            Console.WriteLine("Исходное количество элементов: " + lst.Count);
            Console.WriteLine();
            Console.WriteLine("Добавить 6 элементов");
            // Добавить элементы в динамический массив.
            lst.Add('С');
            lst.Add('А');
            lst.Add('Е');
            lst.Add('В');
            lst.Add('D');
            lst.Add('F');
            Console.WriteLine("Количество элементов: " + lst.Count);
            // Отобразить содержимое динамического массива,
            // используя индексирование массива.
            Console.Write("Текущее содержимое: ");
            for (int i = 0; i < lst.Count; i++)
                Console.Write(lst[i] + " ");
            Console.WriteLine("\n");
            Console.WriteLine("Удалить 2 элемента ");
            // Удалить элементы из динамического массива.
            lst.Remove('F');
            lst.Remove('А');

            Console.WriteLine("Количество элементов: " + lst.Count);
            // Отобразить содержимое динамического массива, используя цикл foreach.
            Console.Write("Содержимое: ");
            foreach (char с in lst)
                Console.Write(с + " ");
            Console.WriteLine("\n");
            Console.WriteLine("Добавить еще 20 элементов");
            // Добавить количество элементов, достаточное для
            // принудительного расширения массива.
            for (int i = 0; i < 20; i++)
                lst.Add((char)('a' + i));
            Console.WriteLine("Текущая емкость: " + lst.Capacity);
            Console.WriteLine("Количество элементов после добавления 20 новых: " +
            lst.Count);
            Console.Write("Содержимое: ");
            foreach (char с in lst)
                Console.Write(с + " ");
            Console.WriteLine("\n");
            // Изменить содержимое динамического массива,
            // используя индексирование массива.
            Console.WriteLine("Изменить три первых элемента");
            lst[0] = 'X';
            lst[1] = 'Y';
            lst[2] = 'Z';
            Console.Write("Содержимое: ");
            foreach (char с in lst)
                Console.Write(с + " ");
            Console.WriteLine();
            // Следующая строка кода недопустима из-за
            // нарушения безопасности обобщенного типа.
            // lst.Add(99); // Ошибка, поскольку это не тип char!
        }
    }
}
