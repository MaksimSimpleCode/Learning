using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPoint
{
    class Point
    {
        // поля класса(приватные так как того требует инкапсуляция) 
        private double x = 0, y=0;

        //Далее идут различные методы для того чтобы взаимодействовать с данными(приватными полями) класса
        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetX(double value)
        {
            this.x = value;
        }

        public double GetX()
        {
            return this.x;
        }
        //Свойство. Get получаем данные. Set устонавливаем данные.
        public double X
        {
            get {return x; }
            set {x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public string ToString()
        {
            return String.Format("X:{0:F3} Y:{1:F3}", x, y);
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Point a, b;
            a = new Point(10,20);
            b = new Point();
            a.SetX(20);
            a.X = 10;
            b.Y = 15;
            Console.Write(a.X);
            Console.Write(b.Y);
            Console.WriteLine(a.ToString());
        }
    }
}
