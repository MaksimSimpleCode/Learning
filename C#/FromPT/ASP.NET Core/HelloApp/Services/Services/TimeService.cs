using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Services
{
    public class TimeService
    {
        public string GetTime() => System.DateTime.Now.ToString("hh:mm:ss");
    }
}
