using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @null
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null; //?- модификатор требуется для возможности объявления пустого значения

            if (!i.HasValue)
            {
                //Если переменная iсодержит пустое значение, присвоить ей 99
                i = 99;
                Console.WriteLine(i.Value);
            }
            else
            {
                Console.WriteLine(i.Value);
            }
        }
    }
}
