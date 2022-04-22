using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMethods  
    /*Здесь мы применяем обобщения к методу
     * очень удобно, не нужно переопределять кучу методов с разными типами данных
     * за место этого мы работаем с одним методом в который можем положить любой тип.
     */
{
    class Program
    {  // Этот метод будет менять местами два элемента
       // типа, указанного в параметре <Т>.
        static void Swap<T>(ref T a, ref T b) //where T :class     мы можем сделать ограничение для обобщенного типа.
        {
            Console.WriteLine("You sent the Swap() method a {0}", typeof(T));
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            // Обмен двух целочисленных значений,
            int a = 10, b = 90;
            Console.WriteLine("Before swap: {0}, {1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("After swap: {0}, {1}", a, b);
            Console.WriteLine();
            // Обмен двух строковых значений,
            string si = "Hello", s2 = "There";
            Console.WriteLine("Before swap: {0} {1}'", si, s2);
            Swap<string>(ref si, ref s2);
            Console.WriteLine("After swap: {0} {1}!", si, s2);
            Console.ReadLine();
        }
    }
}
