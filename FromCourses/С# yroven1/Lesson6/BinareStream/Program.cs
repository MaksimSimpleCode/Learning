using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinareStream
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("data.bin", FileMode.Open);
            BinaryReader fln = new BinaryReader(f);
            long n = f.Length / 4; //определяем количество чисел в двоичном поток
            int a;
            for(int i = 0;i<n; i++)
            {
                a = fln.ReadInt32();
                Console.Write(a + " ");
            }
            fln.Close();
            f.Close();
        }
    }
}
