using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsOptional        //Необязательные параметры
{
    class Program
    {
        static int Sum (int a,int b, bool Log = false)  // Log - не обязательный  параметр так как у него установлено значение по умолчанию
        {
            int result = a + b;

            if(Log)     
            {
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
                Console.WriteLine("a+b= " + result);
            }
            return result;
        }

        static void Main(string[] args)
        {
            Sum(b:8, a:9,Log:true); // если мы не пропишем true, Log не выполниться и на консоль ничего не покажет.
            //так же использую именованные параметры, то есть указываю какое значение в какую переменную я хочу поместить( порядок не важен)
        }
    }                                                              
}
