using System.Collections.Generic;

namespace SplitBudget.Core
{
    abstract class Transaction
    {
        private decimal Amount { get; }

        private decimal OriginalCurrencyAmount { get; }

        private string Description { get; }

        private string OriginalCurrency { get; }

        private List<Tag> Tags { get; }
    }
}
