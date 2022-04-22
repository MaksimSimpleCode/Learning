using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL.EF;
using AutoLotDAL.Models;
using System.Data.Entity;

namespace AutoLotTestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
           // Database.SetInitializer(new MyDataInitializer());
            Console.WriteLine("***** Fun with ADO.NET EF Code First *****\n");
            using (var context = new AutoLotEntities())
            {
                foreach (Inventory c in context.Inventory)
                    Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}
