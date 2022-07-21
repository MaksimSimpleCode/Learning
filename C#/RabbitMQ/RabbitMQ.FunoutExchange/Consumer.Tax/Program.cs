using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
namespace Consumer.Tax
{
    class Program
    {
        private static double _totalHold = 0;
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

                Console.WriteLine("Waiting for payments...");

                var consumer = new EventingBasicConsumer(channel);

                consumer.Received += (sender, e) =>
                {
                    var body = e.Body;
                    var message = Encoding.UTF8.GetString(body.ToArray());

                    var payment = GetPayment(message);
                   // _totalHold += payment * 0.01;

                    Console.WriteLine($"С суммы: {payment}");
                    Console.WriteLine($"${GetPayment(message) * 0.01} удержано в качестве налога");
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
