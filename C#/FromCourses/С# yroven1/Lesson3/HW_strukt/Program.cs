using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_strukt
{
    class Program
    {
        struct User
        {
            public string name;
            public int age;

            public void DisplayInfo()
            {
                Console.WriteLine("UserName: {0} Age {1}",name,age);
            }




        }


        static void Main(string[] args)
        {
            User tom;
            tom.name = "Tom";
            tom.age = 22;
            tom.DisplayInfo();
            Console.ReadKey();
        }
    }
}
