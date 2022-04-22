using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IP
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("64.233.162.103");
            byte[] adress = ip.GetAddressBytes();
            string ipString = ip.ToString();
            Console.WriteLine(ipString);
                //хз, не понял в чем фишка (выше)
            Console.WriteLine("--------------------------");

            string hostName = "www.google.com", message = "IP адруса для домена " + hostName + "\n";
            IPHostEntry entry = Dns.GetHostEntry(hostName);

            foreach (IPAddress a in entry.AddressList)
                message += " -->" + a.ToString() + "\n";

            message += "\nАльтернативное имя домена: ";
            foreach (string aliasName in entry.Aliases)
                message += aliasName + "\n";

            message += "\nРеальное название хоста: " + entry.HostName;
            Console.WriteLine(message);
        }
    }
}
