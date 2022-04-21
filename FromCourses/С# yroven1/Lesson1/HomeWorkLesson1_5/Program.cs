using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson1_5
{
    class Program
    {

        static void Data(string msg, int x , int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }



        static void Main(string[] args)
        {
            Data("Тест",40,12);
            Console.ReadKey();
        }
    }
}
