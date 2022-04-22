using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension     //Разширяемые методы/ методы разширения
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            currentDateTime.Print();    //Метод разширения класса DateTime, создал его в своем классе
        }
    }
}
