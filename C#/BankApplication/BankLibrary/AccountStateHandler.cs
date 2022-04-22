using System;
using System.Collections.Generic;
using System.Text;


namespace BankLibrary
{
    public delegate void AccountStateHandler(object sender, AccountEventArgs e);    //Делегат AccountStateHandler будет использоваться для создания событий.
    // А для обработки событий также определен класс AccountEventArgs, который определяет два свойства для чтения: сообщение о событии и сумма, на которую изменился счет.
    public class AccountEventArgs
    {
        public string Message { get; private set; }
        // Сумма, на которую изменился счет
        public decimal Sum { get; private set; }

        public AccountEventArgs(string _mes, decimal _sum)
        {
            Message = _mes;
            Sum = _sum;
        }
    }
}
