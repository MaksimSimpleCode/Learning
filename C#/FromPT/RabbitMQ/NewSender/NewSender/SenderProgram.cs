using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace NewSender
{
    class SenderProgram
    {
        static void Main(string[] args)
        {
            SimplePublish();
        }
        public static void SimplePublish()
        {
            var counter = 0;
            do
            {

                Thread.Sleep(1000);

                var factory = new ConnectionFactory() { HostName = "srv-rmq-01" };
                factory.UserName = "admin";
                factory.Password = "password";
                factory.VirtualHost = "Igonina";
                var rabbitConnection = factory.CreateConnection();
                var channel = rabbitConnection.CreateModel();
                {
                    channel.QueueDeclare(queue: "Queue",
                                         durable: false,
                                         exclusive: false,
                                         autoDelete: false,
                                         arguments: null);

                    string message = $"Message from publisher N {counter}";

                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "",
                                        routingKey: "Queue",
                                        basicProperties: null,
                                        body: body);

                    Console.WriteLine($"Message [N:{counter++}] is sent into Queue");
                }
            } while (true);
        }
        static Func<Task> CreateTask(int timeToSleepTo, string routingKey)
        {
            return () =>
            {
                var counter = 0;
                do
                {
                    int timeToSleep = new Random().Next(1000, timeToSleepTo);
                    Thread.Sleep(timeToSleep);
                    var factory = new ConnectionFactory() { HostName = "srv-rmq-01" };
                    factory.UserName = "admin";
                    factory.Password = "password";
                    factory.VirtualHost = "Igonina";
                    var rabbitConnection = factory.CreateConnection();
                    var channel = rabbitConnection.CreateModel();
                    {
                        channel.ExchangeDeclare(exchange: "multyExchange", type: ExchangeType.Direct);

                        string message = $" Message {routingKey} from {counter}";

                        var body = Encoding.UTF8.GetBytes(message);

                        channel.BasicPublish(exchange: "multyExchange",
                                            routingKey: routingKey,
                                            basicProperties: null,
                                            body: body);

                        Console.WriteLine($"Message type [{routingKey}] is sent. [N:{counter++}]");
                    }
                } while (true);
            };
        }
    }
   
}
