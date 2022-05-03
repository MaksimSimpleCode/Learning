using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Services
{
    public class MessageService
    {
        IMessageSender _sender;

        //через конструктор класса передается зависимость от IMessageSender. Причем здесь неизвестно, что это будет за реализация интерфейса IMessageSender.
        public MessageService(IMessageSender sender)
        {
            _sender = sender;
        }
        public string Send()
        {
            return _sender.Send();
        }
    }
}
