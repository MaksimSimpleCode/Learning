using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginEGE
{
    class Program
    {
        struct Info
        {
            public string name;
            public int count;

        }

        static void Main(string[] args)
        {
            Info[] info = new Info[100];
            StreamReader sr = new StreamReader("data.txt");
            int N = int.Parse(sr.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string s = sr.ReadLine();
                string[] ss = s.Split(' ');
                int c = 1;
                for (int j = 0; j < i; j++)
                    if (ss[0] == info[j].name) c++;
                info[i].name = ss[0];
                info[i].count = c;
            }
            sr.Close();
            for (int i = 0; i < N; i++)
            {
                Console.Write(info[i].name);
                if (info[i].count > 1) Console.Write(info[i].count);
                Console.WriteLine();
            }
        }
    }
}
