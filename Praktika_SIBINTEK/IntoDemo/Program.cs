using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] websites = { "hsNameA.com", "hsNameB.net", "hsNameC.net",
                "hsNameD.com", "hsNameE.org", "hsNameF.org",
                "hsNameG.tv", "hsNameH.net", "hsNameI.tv","КАХА.tv","Каха.ком","КАХАвместо точки запятая,ком"
              };
            // Сформировать запрос на получение списка веб-сайтов,
            // группируемых по имени домена самого верхнего уровня.
            var webAddrs = from addr in websites
                           where addr.LastIndexOf('.') != -1    //возвращает -1 если указанная подстрока не содержится в вызывающей строке
                           group addr by addr.Substring(addr.LastIndexOf('.'))
                            into ws
                           where ws.Count() > 2
                           select ws;

            // Выполнить запрос и вывести его результаты.
            Console.WriteLine("Домены самого верхнего уровня с более чем двумя членами");
            foreach (var sites in webAddrs)
            {
                Console.WriteLine("Веб-сайты, сгруппированные " +
                "по имени домена" + sites.Key);
                foreach (var site in sites)
                    Console.WriteLine(" " + site);
                Console.WriteLine();
            }
        }
    }
}
