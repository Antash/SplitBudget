using System;
using System.Collections.Generic;
using System.Text;

namespace SplitBudget.Core
{
    class Debt : Account
    {
        private User Creditor { get; }

        protected override AccountType Type => AccountType.Credit;
    }
}
