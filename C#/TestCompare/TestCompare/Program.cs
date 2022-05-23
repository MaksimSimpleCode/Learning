using System;
using System.Collections.Generic;

namespace TestCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>
            {
                new Duck{Name = "Donald",Weight=2},
                new Duck{Name = "Joe",Weight=5},
                new Duck{Name = "BonBon",Weight=1},
                new Duck{Name = "Tali",Weight=3},
            };

             ducks.Sort();


            foreach (var duck in ducks)
            {
                Console.WriteLine($"Name: {duck.Name}, Weigh: {duck.Weight}");
            }


            //--------------------
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["one"] = 1;
            dict["two"] = 2;
            dict["three"] = 3;
            
            foreach (var el in dict)
            {
                Console.WriteLine($"Key: {el.Key}, Value: {el.Value}");
            }
            
            int value = 0;

           if( dict.TryGetValue("one", out value)){
                Console.WriteLine(value);
            }
            
        }
    }
    public class Duck:IComparable<Duck>
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public int CompareTo(Duck other)
        {
            if (this.Weight > other.Weight)
            {
                return 1;
            }
            else if (this.Weight < other.Weight)
            {
                return -1;
            }
            else return 0;
        }
    }
}
