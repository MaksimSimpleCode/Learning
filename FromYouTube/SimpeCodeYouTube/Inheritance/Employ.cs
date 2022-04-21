using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employ:Person //Класс работник, есть одно свойство, для зарплаты
    {
        public decimal Salary { get; set; }

        public void PrintSalary()
        {
            Console.WriteLine("Моя зарплата: " + Salary);
        }
    }
}
