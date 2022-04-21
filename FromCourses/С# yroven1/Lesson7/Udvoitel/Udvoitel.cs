using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udvoitel
{
    class Udvoitel
    {
        int current = 1, finish, count=0;

        public Udvoitel(int finish)
        {
            this.finish = finish;
        }

        public int Count
        {
            get { return count; }
        }
        public void CountP()
        {
            count++;
            
        }

        public int Current
        {
            get { return current; }
        }

        public void Plus()
        {
            current++;
        }

        public void Multi()
        {
            current *= 2;
        }

        public void Reset()
        {
            current = 1;
        }

        public int Finish
        {
            get { return finish; }
        }
    }
}
