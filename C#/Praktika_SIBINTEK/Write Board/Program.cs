using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_Board
{
    class Program
    {
        private static void WriteBoard(int size)
        {
            string x = ".";
            string y = "#";
            int i = 0;
            while (i < size) //строки
            {
                i++;
                if(i%2 ==0)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(x);
                        }
                        else
                        {
                            Console.Write(y);
                        }

                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(y);
                        }
                        else
                        {
                            Console.Write(x);
                        }

                    }
                    Console.WriteLine();
                   
                }
                

            }

            Console.WriteLine("Пустая строка");
        }

        static void Main(string[] args)
        {
            WriteBoard(2);
            WriteBoard(1);
            WriteBoard(2);
            WriteBoard(3);
            WriteBoard(10);
        }
    }
}
