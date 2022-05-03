using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_struktura
{
    class Program
    {
        struct Complex
        {
            public double im;
            public double re;
        
            //В структурах могут храниться так же действия над данными
            public Complex Plus(Complex x)
            {
             Complex y;
             y.im = im + x.im;
             y.re = re +x.re;
             return y;
            }

            Complex Multi(Complex x)
            {
                Complex y;
                y.im = im * x.im + re * x.im;
                y.re = re * x.im - im * x.re;
                return y;
            }

            public string ToString()
            {
                return re + "+" + im + "i";
            }
        }

    static void Main(string[] args)
        {
            Complex a, b;
            a.im = 5;
            b.re = 4;
            
            Console.WriteLine(a.im+" "+b.re);
            
        }
    }
}
