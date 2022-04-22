using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog.Events;

namespace SerilogProject
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            var _logger = new LoggerConfiguration()
               .MinimumLevel.Debug()
               .WriteTo.Console()
               .WriteTo.File("MyLog-.txt", rollingInterval: RollingInterval.Day)
               .CreateLogger();
            
            var names = new Dictionary<int, string>();
            names.Add(0, "Maksim");
            names.Add(1, "Nika");
            names.Add(2, "Jana");
            names.Add(3, "Lesya");
            Random rnd = new Random();
            for(int i =0; i<10; i++)
            {
                new Employee(names[rnd.Next(0, 3)], rnd.Next(1, 100000),_logger);
                
            }
            Log.CloseAndFlush();
            Console.ReadLine();
        }
    }

    public class Employee
    {
       
        public Employee(string name, int salary, ILogger logger)
        {
           Name = name;
           Salary = salary;

           logger.Information($"New Employee: Name: {Name}, Salary:{Salary}");
        }
        private string Name { get; set; }
        private int Salary { get; set; }
    }
}
