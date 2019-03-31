using System;
using System.Collections.Generic;
using System.Text;

namespace SplitBudget.Core
{
    class Deposit : Account
    {
        protected override AccountType Type => AccountType.Deposit;

        public Deposit(string name, string currency) : base(name, currency)
        {
        }
    }
}
