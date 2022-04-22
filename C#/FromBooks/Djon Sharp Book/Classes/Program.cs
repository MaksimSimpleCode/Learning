using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point();
            Point bottomRight = new Point(1366, 768);
            double distance = origin.DistanceTo(bottomRight);
            Console.WriteLine($"Distance is:{distance}");
            Console.WriteLine($"Number of Point objects:{Point.ObjectCount()}");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
