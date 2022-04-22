using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace WomanReciever
{
    class ManProgram
    {
        static void Main(string[] args)
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