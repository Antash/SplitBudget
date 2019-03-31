using System;
using System.Collections.Generic;
using System.Text;

namespace SplitBudget.Core
{
    class Credit : Account
    {
        public decimal Limit { get; }

        protected override AccountType Type => AccountType.Credit;

        public Credit(string name, string currency) : base(name, currency)
        {
        }
    }
}
