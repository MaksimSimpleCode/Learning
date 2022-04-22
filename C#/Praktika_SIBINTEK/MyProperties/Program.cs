using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperties
{
    class SimpProp
    {
        int prop;   //Поле управляемое свойством MyPop

        public SimpProp() { prop = 0; } //Конструктор
        public int MyProp       //Свойство
        {
            get { return prop; }
            set
            {
                if (value >= 0) prop = value;
                else
                {
                    prop = 0;
                    Console.WriteLine("Отрицательное число недопустимо! Defolt=0");
                }
            }
        }
    

    }
    class Program
    {
        static void Main(string[] args)
        {
            SimpProp myprop = new SimpProp();
            myprop.MyProp = 100;
            Console.WriteLine("Значение: " + myprop.MyProp);
            Console.WriteLine();
            myprop.MyProp = -5;
            Console.WriteLine("Значение: " + myprop.MyProp);
        }
    }
}
