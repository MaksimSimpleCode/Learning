using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_1
{
    class MyArray
    {
        int[] a;

        public MyArray(int n, int max, int min)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(max, min);

        }

        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод(требуется числовое значение).\nПожалуйста повторите ввод:");
                else return x;
        }

        public int Max
        {
            get
            {
                int max=a[0];
                for (int i = 0; i < a.Length; i++) 
                if (a[i] > max) max = a[i];
                return max;

            }
        }

        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 0; i < a.Length; i++)
                    if (a[i]<min) min = a[i];
                return min;
            }

        }

        public double Summ
        {
            get
            {
                double Summ = 0;
                foreach (int el in a)
                    Summ += el;
                return Summ;

            }
        }
        public int[] A
        {
            get { return a; }
            set { a = value; }
        }

        public int Multi2
        {
            set
            {
                for (int i = 0; i < a.Length; i++)
                    a[i] = a[i] * value;
                
            }
        }

        public int Inverse
        {
            set
            {
                for (int i = 0; i < a.Length; i++)
                    a[i] = a[i] * value;

            }
        }

        public int Multi
        {
            get
            {
                int umn = int.Parse(Console.ReadLine());
                foreach (int el in a)
                    umn = umn * el;
                return umn;
            }
        }

        public override string ToString()

        {
            // для вывода массива на экран
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(3, 0, 5);
            Console.WriteLine(a.ToString());
            Console.WriteLine("Максимальное число: "+a.Max);
            Console.WriteLine("Минимальное число: " + a.Min);
            Console.WriteLine("Сумма элементов: " + a.Summ);
            Console.Write("Введите число на которое хотите умножить весь массив: ");
            Console.WriteLine("Умножение : " + a.Multi);
            a.Inverse = -1;
            Console.WriteLine("Замена знаков массива: "+a.ToString());
            Console.WriteLine("Введите число на которое будет умножен каждый элемент массива: ");
            a.Multi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Умноженный массив: "+a.ToString());
            
        }
    }
}
