using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAndFuncDelegates
{
   
    class Program
    {
        // Это цель для делегата Actiono.
        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            //Установить цвет текста консоли
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
                Console.ForegroundColor--;
            }
            // Восстановить цвет.
            Console.ForegroundColor = previous;
        }


        // Цель для делегата Funco.
        static int Add (int x, int y)
        {
            return x + y;
        }

        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Action and Func *****");
            // Использовать делегат Action<> для указания на DisplayMessage.
            Action<string, ConsoleColor, int> actionTarget = DisplayMessage;     //new Action<string, ConsoleColor, int>(DisplayMessage);  так тоже можно
            actionTarget("Action Message!", ConsoleColor.Yellow, 5);


            Func<int, int, int> funcTarget = Add; //  !!!последний параметр всегда является типом возвращаемого значения в методе на который ссылается делегат Func<>!
            int result = funcTarget.Invoke(40, 40);// НЕ ПОНЯЛ ПРО Invoke, откудаон и зачем. UPD: проверил, убрал инвок. без него тоже работает, вопросов еще больше) 
            Console.WriteLine("40+40 = {0}", result);

            Func<int, int, string> funcTarget2 = SumToString;
            string sum = funcTarget2(90, 300);
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
