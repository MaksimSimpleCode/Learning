using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderPraktika
{
    class Program
    {
        private static string ApplyCommands(string[] commands)
        {
            var message = new StringBuilder();
            int numberOfDetete;
            int positionDelete;
            for (int command=0; command<commands.Length; command++)
            {
                if (commands[command].StartsWith("push"))
                    message.Append(commands[command].Substring(5, commands[command].Length - 5));
                else
                {
                    numberOfDetete = int.Parse(commands[command].Substring(4, commands[command].Length - 4));
                    positionDelete = message.Length - numberOfDetete;
                    message.Remove(positionDelete, numberOfDetete);
                }
            }
            return message.ToString();
        }

        
        static void Main(string[] args)
        {
            var textList = new string[6];
            textList[0] = "push Привет! Это снова я! Пока!";
            textList[1] = "pop 5";
            textList[2] = "push Как твои успехи? Плохо?";
            textList[3] = "push qwertyuiop";
            textList[4] = "push 1234567890";
            textList[5] = "pop 26";
            Console.WriteLine("\n" + ApplyCommands(textList));
        }
    }
}
