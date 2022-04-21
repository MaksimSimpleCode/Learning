using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    class DemandAccount : Account
    {
        public DemandAccount(decimal sum, int percentage) : base(sum, percentage)
        { 
        }
        protected internal override void Open()
        {
            base.OnAdded(new AccountEventArgs($"Открыт новый счет до востребования! ID счета: {this.Id}", this.Sum));
        }
    }
}
