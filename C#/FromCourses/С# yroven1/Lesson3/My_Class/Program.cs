using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Class
{
    //class MyClass
    //{


    //}


    class cPoint
    {
        public double x, y;
    }

    struct sPoint
    {
        public double x, y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            cPoint A = new cPoint();
            A.x = 10;

            sPoint B;
            B.x = 10;
        }
    }
}
