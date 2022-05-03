using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_1
{
    class Program
    {
        //Защита от дурака, вводим числа и пока правильное не введем дальше не пойдет.
        static double Input(string msg)
        {
            double x;
            string s;
            bool flag;

            do
            {
                Console.WriteLine(msg);
                s = Console.ReadLine();
                // Если перевод произошел неправильно, то результатом будет false
                flag = double.TryParse(s, out x);
            }
            while (!flag); // Пока False(!false = true), повторять цикл
            return x;
        }

        static double Dist(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        

        static double Dist(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2));
        }

        struct Point
        {
           public double x, y;
           public double Dist(Point B)
            {
                return Math.Sqrt(Math.Pow(x - B.x, 2) + Math.Pow(y - B.y, 2));
            }
        }

        static void Main(string[] args)
        {
            Point A, B;
            A.x = Input("Input x1: ");
            A.y = Input("Input y1: ");
            B.x = Input("Input x2: ");
            B.y = Input("Input y2: ");
            Console.WriteLine("Длина" + Dist(A, B));
            Console.WriteLine("Длина: " + A.Dist(B));
        }
    }
}
