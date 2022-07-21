using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsApp
{
    class MailManager
    {
        public event EventHandler<NewEmailEventArgs> NewMail;   //Создаем событие

        protected virtual void OnNewMail(NewEmailEventArgs e)
        {
            //1 вариант, уязвим при многопоточности
            //NewMail?.Invoke(this, e);
    
            //2 вариант, решает проблему многопоточности
            var temp = NewMail;
            temp?.Invoke(this, e);
        }
        public void SimulateNewMail(string from,string to,string subject)
        {
            //Проверить входные данные на корректность

            //Создать объект для хранения инфрмации, которую
            //нужно передать получателям уведомления
            var e = new NewEmailEventArgs(from, to, subject);

            //Вызвать виртуальный метод, уведомляющий объект о событии
            //Если ни один из производных типов не переопределяет этот метод,
            //объект уведомит всех зарегестрированных получателей уведомления
            OnNewMail(e);
        }
    }
}
