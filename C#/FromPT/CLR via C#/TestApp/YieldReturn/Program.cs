using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }

    }
    class Numbers
    {
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 6; i++)
            {
                if(i==0)
                yield return i * i;
            }
        }
    }
}
