using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties    //Свойства
{
    class Point
    {
        private int x;
        

        public void SetX(int x)     //Сеттер(присвоение значения)
        {
            this.x = x;
        }


        public int GetX()   //Геттер(взятие значения)
        {
            return x;
        }

        private int y;

        public int Y   //Свойства
        {
            get { return y; }   //Берем значение
            set { y = value; }  //Присваиваем значение
            // могу устонавить private тогда в Main не будет доступен аксессор(get или set)
        }

        public int Z { get; set; }  //Автосвойсвто, сокращенное свойсвто.

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.SetX(5);

            int x = point.GetX();

            point.Y = 10;   //Присваиваем через свойство значение
            int y = point.Y;    // Через свойство берем значение
        }
    }
}
