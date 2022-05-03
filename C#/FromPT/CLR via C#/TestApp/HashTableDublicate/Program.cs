using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDublicate
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> voted = new Dictionary<string, string>();
            voted.Add("Майкл", "За");
            voted.Add("Джон", "Против");
            voted.Add("Сэм", "Против");

            CheckVoter("Майкл", voted);
            CheckVoter("Сэм", voted);
            CheckVoter("Фиона", voted);
        }

        static void CheckVoter(string name, Dictionary<string, string> votedDic)
        {
            if (votedDic.ContainsKey(name))
            {
                Console.WriteLine($"Участник {name} голосовал, выгнать!"); 
            }
            else
                Console.WriteLine($"Участнику {name} голосование разрещено!");
        }


    }
}
