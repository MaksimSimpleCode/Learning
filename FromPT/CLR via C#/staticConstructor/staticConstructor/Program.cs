using System;

namespace staticConstructor
{
    class People
    {
        public string Name { get; set; }
        public int id { get; private set; }

        public static int countId;
        

        
        public People(string name)
        {
            Name = name;
            countId++;
            id = countId;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            People p1 = new People("Вася");
            People p2 = new People("Коля");
            People p3 = new People("Гена");
            People p4 = new People("Паша");
            var P4id = p4.id;
        }
    }
}
