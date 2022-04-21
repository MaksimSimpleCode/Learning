using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FunWithCSharpAcync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Fun With Async ===>");
           
           
            Console.WriteLine("Completed");
            string message = await DoWorkAsync();
            Console.WriteLine(message);

            Console.ReadKey();
        }

        static async Task<string> DoWorkAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5000);
                return "Done with work!";
            });
        }

       
    }
}
