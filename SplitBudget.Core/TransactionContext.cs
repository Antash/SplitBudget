using System;

namespace SplitBudget.Core
{
    public class TransactionContext
    {
        internal Account Source { get; set; }

        internal Account Destination { get; set; }

        internal DateTime Date { get; set; }

        internal string Description { get; set; }

        internal decimal Amount { get; set; }

        internal string Currency { get; set; }

        internal bool IsComplete()
        {
            return Destination != null &&
                   Source != null &&
                   Amount != 0;
        }

        internal Transaction CreateTransaction()
        {
            var currency = Currency ?? Destination.Currency;
            var data = new TransactionData(Date, Amount, Description, currency);
            return new Transaction(Source, Destination, data);
        }
    }
}
