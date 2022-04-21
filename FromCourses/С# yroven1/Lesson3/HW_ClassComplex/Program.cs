using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ClassComplex
{

    class Complex
    {
        //Приватное поле.
        private double im;
        //По умолчанию поле приватное так что Private можно не писать.
        double re;
        //Конструктор без параметров
        public Complex()
        {
            im = 0;
            re = 0;
        }
        //Конструктор в котором задаем поля(параметры)
        public Complex(double im, double re)
        {
            //Чтобы показать,что к полю нашего класса присваевается параметр, используется словов this
            this.im = im;
            this.re = re;
        }

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + this.im;
            x3.re = x2.im + this.re;
            return x3;
        }

        //Свойства- это механизм доступа к данным класса.
        public double lm
        {
            get { return im; }
            set { if (value >= 0) im = value; }//для примера ограничим значение только положительными числами.
        }

        public string ToString()
        {
            return re + "+" + im + "i"+" lakmus";
        }
       

    }


    class Program
    {


        static void Main(string[] args)
        {
            //Описали обхект
            Complex x1;
            //Создали объект и сохранили ссылку на него в test
            x1 = new Complex(1,2);
            //Описали объект и создали его 
            Complex x2 = new Complex(2,4);
            //С помощью свойства lm изменили внутрненнее (приватное) поле im.
            x2.lm = 3;
            //Создали ссылку на объект 
            Complex x3;
            //Так как в методе Pluse создается новый объект, то в test 3 сохраняем ссылку на вновь созданный объект.
            x3 = x1.Plus(x2);
            Console.WriteLine(x3);
            Console.ReadKey();

            

        }
    }
}
