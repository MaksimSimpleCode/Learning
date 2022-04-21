using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
                for (int j = 0; j < 24; j++) 
            {
                Console.SetCursorPosition(i, j);
                    Console.Write('*');
                    System.Threading.Thread.Sleep(20);

            }
        }
    }
}
