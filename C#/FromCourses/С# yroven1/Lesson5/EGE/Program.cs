using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGE
{
    struct Element
    {
        public string FIO;
        public int N;
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("FIO.txt");
            int N = int.Parse(sr.ReadLine());
            Element[] a = new Element[N];
            for (int i = 0; i < N; i++)
            {
                string s1 = sr.ReadLine();
                string[] s = s1.Split(' ');
                a[i].FIO = s[0] +" "+ s[1];
                a[i].N = int.Parse(s[2]);
            }
            sr.Close();
            int[] massiv = new int[100];
            for (int i = 0; i < N; i++) massiv[a[i].N]++;
            int min = 100;
            for (int i = 0; i < 100; i++)
                if (massiv[i] != 0 && massiv[i] < min) min = massiv[i];
            for (int i = 0; i < 100; i++)
                if (massiv[i] == min) Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
