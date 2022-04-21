using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program 
    {
        
        static void Main(string[] args)
        {
            int[] mas = new int[10];
            for (int i = 1; i < 10; ++i)
            {
                mas[i] = i;
            }
            Console.WriteLine(string.Join("," , mas));

            light color;
            color = light.green;
            Console.WriteLine(/*(int)*/color);
        }
    }
}
