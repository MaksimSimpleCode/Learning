using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base      //Ключевое слово Base
{
    class Point2D
    {
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Вызван Point2D");
        }
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Point3D:Point2D
    {
        public Point3D(int x, int y, int z):base(x,y)   //обращается к базовому клас
        {
            Z = z;
            Console.WriteLine("Вызван Point3D");
        }
        public int Z { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point3D = new Point3D(8,7,9);        //Конструктор 2D тоже отработает.
            
        }
    }
}
