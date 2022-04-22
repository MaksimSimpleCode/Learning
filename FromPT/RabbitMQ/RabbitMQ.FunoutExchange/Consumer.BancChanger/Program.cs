using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Consumer.BancChanger
{
    class Program
    {
        private static int _totalHold = 0;
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(exchange: "notifier", type: ExchangeType.Fanout);

                var queueName = channel.QueueDeclare().QueueName;
                channel.QueueBind(queue: queueName,
                    exchange: "notifier",
                    routingKey: string.Empty);

                var consumer = new EventingBasicConsumer(channel);

                consumer.Received += (sender, e) =>
                {
                    var body = e.Body;
                    var message = Encoding.UTF8.GetString(body.ToArray());

                    var payment = GetPayment(message);
                    _totalHold += payment;

                    Console.WriteLine($"Получено денег в количестве: {payment}");
                    Console.WriteLine($"${_totalHold} у этого человека");
                };

                channel.BasicConsume(queue: queueName,
                                     autoAck: true,
                                     consumer: consumer);

                Console.WriteLine($"Subscribed to the queue {queueName}");
                Console.WriteLine($"Listering.....");
                Console.ReadLine();
            }
        }
        private static int GetPayment(string message)
        {
            var messageWords = message.Split(' ');
            return int.Parse(messageWords[^1]);
        }
    }
}
