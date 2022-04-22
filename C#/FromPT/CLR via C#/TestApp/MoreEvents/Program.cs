using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreEvents
{
    public delegate void KeyPressEventDelegate();
   
    public class KeyboardMaster
    {
        public event KeyPressEventDelegate wKeyPressedEvent = null;  //События
        public event KeyPressEventDelegate sKeyPressedEvent = null;  
        public void WKeyPressInvokeEvent()   
        {
            if(wKeyPressedEvent != null)
                wKeyPressedEvent.Invoke();
        }  
        public void SKeyPressInvokeEvent()   //Метод для вызова активации события
        {
            if(sKeyPressedEvent != null)
                sKeyPressedEvent.Invoke();
        }
    }
    public  class Program
    {
        static private void buttonW_Click()
        {
            Console.WriteLine("Вперед");
        }
        static private void buttonS_Click()
        {
            Console.WriteLine("Назад");
        }
        static void Main(string[] args)
        {
            KeyboardMaster kM = new KeyboardMaster();

            kM.wKeyPressedEvent += buttonW_Click;   //Подписываем методы на события
            kM.sKeyPressedEvent += buttonS_Click;

            ConsoleKey pressedKey;

            while (true)
            {
                pressedKey = Console.ReadKey().Key;
                switch (pressedKey)
                {
                    case ConsoleKey.W:
                        kM.WKeyPressInvokeEvent();  //Вызываем событие
                        break;
                    case ConsoleKey.S:
                        kM.SKeyPressInvokeEvent();
                        break;
                }
            }
        }
    }
}
