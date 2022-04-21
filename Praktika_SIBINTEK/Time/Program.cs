using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            int seconds;
            DateTime dt = DateTime.Now;
            seconds = dt.Second;
            for (; ; )
            {
                dt = DateTime.Now;
                // обновлять время через каждую секунду
                if (seconds != dt.Second)
                {
                    seconds = dt.Second;
                    t = dt.ToString("T");
                    if (dt.Minute == 0 && dt.Second == 0)
                        t = t + "\a"; // производить звонок через каждый час
                    Console.WriteLine(t);
                }
            }
        }
    }
}