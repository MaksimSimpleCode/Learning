using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;

namespace SignalRClient
{
    class Program
    {
        static HubConnection HubConnection;
        static async Task Main(string[] args)
        {
            HubConnection = new HubConnectionBuilder()
                .WithUrl("http://localhost:18244/notification")
                .Build();

            HubConnection.On<string>("Send", message => Console.WriteLine($"Message From Server: {message}"));

            await HubConnection.StartAsync();

            bool isExit = false;
            while (!isExit)
            {
                var message = Console.ReadLine();
                if (message != "exit")
                {
                    await HubConnection.SendAsync("SendMessage", message);
                }
                else
                    isExit = true;
            }
            Console.ReadLine();
        }
    }
}
