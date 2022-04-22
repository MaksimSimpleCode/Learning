using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace HumanReciever
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleConsumer();
        }
        public static void SimpleConsumer()
        {

                var factory = new ConnectionFactory() { HostName = "srv-rmq-01" };

                factory.UserName = "admin";
                factory.Password = "password";
                factory.VirtualHost = "Igonina";

               // string exchangeName = "multyExchange";
                var rabbitConnection = factory.CreateConnection();
                var channel = rabbitConnection.CreateModel();

                var consumer = new EventingBasicConsumer(channel);

                    consumer.Received += (sender, e) =>
                    {
                      //  int timeToSleep = new Random().Next(1000, 10000);
                      //  Thread.Sleep(timeToSleep);
                        var body = e.Body;
                        var message = Encoding.UTF8.GetString(body.ToArray());
                        Console.WriteLine(" Received message: {0}", message);
                    };

                    channel.BasicConsume(queue: "Queue",
                                         autoAck: true,
                                         consumer: consumer);

                    Console.WriteLine("Subscribed to the queue 'dev-queue'");

                    Console.ReadLine();
           }
    public static void DirectedCunsumer()
    {
        var factory = new ConnectionFactory() { HostName = "srv-rmq-01" };

        factory.UserName = "admin";
        factory.Password = "password";
        factory.VirtualHost = "Igonina";

        string exchangeName = "multyExchange";
        var rabbitConnection = factory.CreateConnection();
        var channel = rabbitConnection.CreateModel();
        {
            channel.ExchangeDeclare(exchange: exchangeName, type: ExchangeType.Direct);

            var queueName = channel.QueueDeclare().QueueName;

            channel.QueueBind(queue: queueName,
                                     exchange: exchangeName,
                                     routingKey: "man");
            channel.QueueBind(queue: queueName,
                                     exchange: exchangeName,
                                     routingKey: "woman");

            var consumer = new EventingBasicConsumer(channel);

            consumer.Received += (sender, e) =>
            {
                var body = e.Body;
                var message = Encoding.UTF8.GetString(body.ToArray());
                Console.WriteLine(" Received message: {0}", message);
            };

            channel.BasicConsume(queue: queueName,
                                 autoAck: true,
                                 consumer: consumer);

            Console.WriteLine($"Subscribed to the queue '{queueName}'");

            Console.ReadLine();
        }
    }
    }
}