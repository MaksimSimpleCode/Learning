using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    public class Student
    {

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (name == null)
                {
                    throw new ArgumentException();
                }
                else
                {
                    name = value;
                }  
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
          //  a = "b";      //Ошибка, так как var - дает в результате строготипизированные данные.

            dynamic b = 5;
            b = "war";
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        
    }
}
