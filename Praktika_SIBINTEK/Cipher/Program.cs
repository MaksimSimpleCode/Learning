using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class Program
    {
        private static string DecodeMessage(string[] lines)
        {
          
            List<string> list = new List<string>();
             list = new List<string>();
            foreach (string line in lines)
                if (!String.IsNullOrEmpty(line))
                    foreach (string word in line.Split(' '))
                        if (char.IsUpper(word[0]))
                            list.Add(word);
            list.Reverse();
            return string.Join(" ", list.ToArray());
        }
        static void Main(string[] args)
        {
            string[] lines = new string[] { "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть если особенно упорно подойдешь к делу будет Трудно конечнО Код ведЬ не из простых очень ХОРОШИЙ код то у тебя все получится и я буДу Писать тЕбЕ еще" };

            DecodeMessage(lines);
        }
    }
}
