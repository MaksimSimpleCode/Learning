using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{

    class MyArray
    {
        int[] a;


        public MyArray(int n)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = i;
        }

        public int FirstIndexOf(int el) //Найти указанное число
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == el) return i;
            return -1;
        }

        public int Max // Найти максимум
        {
            get
            {
                int max = a[0];
                foreach (int el in a)
                    if (el > max)
                    {
                        max = el;
                    }
                return max;
            }
            
        }
        public void Sortt()
        {
            //Array.Sort(a);
            for (int i = 0; i < a.Length; i++) //Сортировка пузырьковым методом
                for (int j = 0; j < a.Length - 1; j++)
                    if (a[j] < a[j + 1])
                    {
                        int t = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = t;
                    }
        }
        public int this[int ind] //индексация
        {
            get { return a[ind]; }
            set { a[ind] = value; }
        }


        public override string ToString()
        {
            string s = "";
            foreach (int el in a) s = s + el + " ";
            return s;
        }



    }



    class Program
    {
        


        static void Main(string[] args)
        {
            MyArray a = new MyArray(5);
            MyArray b = new MyArray(6);
            a.Sortt();
            a[0] = 10;
            Console.WriteLine(a);
            Console.WriteLine(a.FirstIndexOf(3));
            Console.WriteLine("Max= {0}", a.Max);
        }
    }
} 
