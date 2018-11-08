using System;
using System.Collections.Generic;
using System.Text;

namespace SplitBudget.Core
{
    class Income : Transaction
    {
        private string Source { get; }

        private Account TargetAccount { get; }
    }
}
