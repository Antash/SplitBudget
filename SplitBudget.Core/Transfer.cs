using System;
using System.Collections.Generic;
using System.Text;

namespace SplitBudget.Core
{
    class Transfer : Transaction
    {
        private Account SourceAccount { get; }

        private Account TargetAccount { get; }
    }
}
