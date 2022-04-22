using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_Text_With_Border
{
    class Program
    {
        private static void WriteTextWithBorder(string text)
        {
            for (int i = 0; i <= text.Length + 3; i++)
            {
                if (i ==0)
                {
                    Console.Write("+");
                }
                else if (i== text.Length + 3)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write("-");
                }
            }

            Console.WriteLine("\n| " + text + " |");

            for (int i = 0; i <= text.Length + 3; i++)
            {
                if (i == 0)
                {
                    Console.Write("+");
                   
                }
                else if (i == text.Length + 3)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write("-");
                }
            }

            Console.WriteLine();

        }


        static void Main(string[] args)
        {
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");
        }
    }
}
