using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public struct S : IDisposable
    {
        private bool dispose;
        public void Dispose()
        {
            dispose = true;
        }
        public bool GetDispose()
        {
            return dispose;
        }

        class Program
        {
            static void Main(string[] args)
            {
                var s = new S();
                using (s)
                {
                    Console.WriteLine(s.GetDispose());
                }
                Console.WriteLine(s.GetDispose());
            }
        }
    }
}
