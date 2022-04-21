using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params    //Ключевое слово params
{
    class Program
    {
        static int Sum (params int [] parameters)
        {
            int result = 0;
            for(int i =0; i<parameters.Length;i++)
            {
                result += parameters[i];
            }
            return result;
        }   


        static void Foo (params object[] parametrs) //params позволяет принимать множество аргументов через запятую
        {
            string message = "Тип данных: {0}, значение: {1}";
            foreach (var item in parametrs)
                Console.WriteLine(message, item.GetType(), item);
        }
        static void Main(string[] args)
        {
            int result = Sum(5, 6,2,12,2,23,5); //params позволяет принимать множество аргументов через запятую 
            //если бы в методе Sum не было params, пришлось бы делать перегрузки для 2,3,4,5... сложений.
            Console.WriteLine(result);

            Foo("test", 123, 2.12, 12, 'c', 34, 5f, true);   //params позволяет принимать множество аргументов через запятую
            //если бы в методе Foo не было params, пришлось бы делать перегрузки для разного колчичества аргументов. 
        }
    }
}
