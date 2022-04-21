using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Секундомер");
            DateTime time = DateTime.Now;
            Console.WriteLine(time);

            int min = 0;

            for(int second = 1; min<60;second++)
            {
                System.Threading.Thread.Sleep(1000);
                //Console.WriteLine(second);

                if(second==60)
                {
                    second = 0;
                    min++;
                }
                Console.WriteLine("Время: " + min + "минут " + second + "секунд");
                
              
            }
            
            

        }
    }
}
