using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRead
{
    class Program
    {
        static void Main(string[] args)
        { 

            StreamReader sr = new StreamReader("data.txt");
            int N = int.Parse(sr.ReadLine());
            for (int i = 0; i < N; i++)
            {
                try
                {
                    int a = Convert.ToInt32(sr.ReadLine());
                    Console.WriteLine(a);
                }
                catch(Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            sr.Close();

        }
    }
}
