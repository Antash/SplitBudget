using System;
using System.Collections.Generic;
using System.Text;

namespace SplitBudget.Core
{
    class Deposit : Account
    {
        protected override AccountType Type => AccountType.Deposit;
    }
}
