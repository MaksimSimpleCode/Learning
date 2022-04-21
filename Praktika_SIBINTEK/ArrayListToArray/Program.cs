using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            // Добавить элементы в динамический массив.
            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Add(4);
            Console.Write("Содержимое: ");
            foreach (int i in al)
                Console.Write(i + " ");
            Console.WriteLine();
            // Получить массив.
            int[] ia = (int[])al.ToArray(typeof(int));      //Из за того что пользуемся необобщенной коллекцией приходится делать кучу преобразований,упаковок/распоковок что бъет по производительности
            int sum = 0;
            // Просуммировать элементы массива.
            for (int i = 0; i < ia.Length; i++)
                sum += ia[i];
            Console.WriteLine("Сумма равна: " + sum);
        }
    }
}
