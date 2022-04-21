using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {

        static void doWork()
        {
            int i = 0;
            Console.WriteLine(i);
            Pass.Value(ref i);
            Console.WriteLine(i);

            //WrappedInt wi = new WrappedInt();
            //Console.WriteLine(wi.Number);
            //Pass.Reference(wi);
            //Console.WriteLine(wi.Number);
        }

        static void Main (string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
