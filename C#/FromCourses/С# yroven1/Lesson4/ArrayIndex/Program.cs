using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndex
{
    class MyArray
    {
        int[] a; //приватный по дефолту
        public MyArray(int n)
        {
            a = new int[n];
        }

        //либо делаем метод для получения эллемента массива
        public int Get(int i)
        {
            return a[i];
        }
        //и метод для того чтобы задать элемент
        public void Set(int i, int value)
        {
            a[i] = value;
        }

        // ЛИБО создадим индексируемое свойство
        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray(10);
            for (int i = 0; i < 10; i++)
            {
                //Для доступа используем либо метод
                array.Set(i, i * 10);
                Console.WriteLine(array[i]);
            }
            //Или индексируемое свойство, что более удобно
            for (int i = 0; i < 10; i++)
            {
                array[i] = i * 10;
                Console.WriteLine(array[i]);
            }
            
        }
    }
}
