using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeravleAndIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {

            Week week = new Week();
            foreach (var day in week)
            {
                Console.WriteLine(day);
            }

        }
       

    }
    //Простейшая реализация IEnumerable 
    class Week : IEnumerable
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                         "Friday", "Saturday", "Sunday" };
        // public IEnumerator GetEnumerator() => days.GetEnumerator();
        public IEnumerator GetEnumerator() => new WeekEnumerator(days);
    }

    //Собественная реализация, аналог метода GetEnumerator();
    //Здесь мы можем задавать собственную логику перечесления
    class WeekEnumerator : IEnumerator
    {
        string[] days;
        int position = -1;
        public WeekEnumerator(string[] days) => this.days = days;
        public object Current
        {
            get
            {
                if (position == -1 || position >= days.Length)
                    throw new ArgumentException();
                return days[position];
            }
        }
        public bool MoveNext()
        {
            if (position < days.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }
        public void Reset() => position = -1;
    }

}
