using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_8
{
    class Program
    {
        static string CheckNorm(double bmi, double height)
        {
            string result = "";
            if (bmi >= 18.5 && bmi <= 24.99)
            {
                result = "Все в норме!";
            }
            else if (bmi < 18.5)
            {
                double recommendation = (18.5 - bmi) * height * height;
                result = string.Format("необходимо набрать {0:0.00} кг для нормализации веса!", recommendation);
            }
            else if (bmi > 24.99)
            {
                double recommendation = (bmi - 24.99) * height * height;
                result = string.Format("необходимо сбросить {0:0.00} кг для нормализации веса!", recommendation);

            }
            return result;
        }





        static void Main(string[] args)
        {
            double i = 0;
            Console.WriteLine("Программа расчета индекса массы тела.");
            Console.Write("Введите ваш вес: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Введите ваш рост: ");
            double h = double.Parse(Console.ReadLine());
            h = h / 100;
            i = m / (h*h);

           
            Console.WriteLine(CheckNorm(i, h));
            Console.ReadKey();


        }   

    }
}
