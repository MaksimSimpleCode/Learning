using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFire
{
     
        

   
    class Program
    {
        static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
        {
            //if (enemyInFront && (enemyName != "boss"))
            //{
            //    return true;
            //}
            //else if (enemyInFront && enemyName == "boss" && robotHealth > 100)
            //{
            //    return true;
            //}

            //else return false;
            bool shouldFire = true;
            return enemyInFront && (enemyName != "boss"||(enemyName=="boss" && robotHealth>=50));
        }

            static void Main(string[] args)
           {
            string unit = "boss";

            Console.WriteLine(ShouldFire2(true, unit, 10));
           }
    }
}
