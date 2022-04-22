using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace RedisChache
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionMultiplexer connection = ConnectionMultiplexer.Connect("localhost:6379");

            IDatabase db = connection.GetDatabase(11);

            //db.SetAdd("mykey", "12345");  // Set - тип данных множества, нужно подробнее читать в документации Redis.
            //var myVal = db.SetScan("mykey");
            //db.KeyDelete("mykey");

            db.StringSet("timeKey",DateTime.Now.ToString());

            var time =db.StringGet("timeKey");


            Console.WriteLine($"Значение моего первого ключа в Redis: {time}");
            Console.ReadLine();
        }
    }
}
