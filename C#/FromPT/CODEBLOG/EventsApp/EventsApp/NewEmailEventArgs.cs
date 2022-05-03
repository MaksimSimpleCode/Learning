using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsApp
{
    //класс который инкапсулирует необходимые данные для передачи 
    class NewEmailEventArgs :EventArgs   
    {
        public string From { get; }
        public string To { get; }
        public string Subject { get; }
        public NewEmailEventArgs(string from,string to,string subject) 
        {
            From = from;
            To =to;
            Subject = subject;
        }

        public override string ToString()
        {
            return $"Письмо от {From}, для {To}: {Subject}"; 
        }

    }
}
