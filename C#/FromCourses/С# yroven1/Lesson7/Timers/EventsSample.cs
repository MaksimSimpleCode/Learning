using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timers
{
    class EventsSample
    {
        static void Main()
        {
            System.Timers.Timer timet = new System.Timers.Timer();
            timet.Interval = 1000;
            timet.Start();
            timet.Elapsed += Timet_Elapsed;
            Console.ReadLine();
        }

        private static void Timet_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //throw new NotImplementedException();
            Console.WriteLine(DateTime.Now.ToString());
        }
    }
}
