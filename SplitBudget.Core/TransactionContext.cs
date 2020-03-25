using System;
using System.Collections.Generic;

namespace SplitBudget.Core
{
    public class TransactionContext
    {
        public TransactionContext(TransactionType type)
        {
            Type = type;
        }

        private TransactionType Type { get; }

        internal Account Source { get; set; }

        internal Account Destination { get; set; }

        internal DateTime Date { get; set; }

        internal string Description { get; set; }

        internal decimal Amount { get; set; }

        internal string Currency { get; set; }

        public IList<Tag> Tags { get; } = new List<Tag>();

        internal bool IsComplete()
        {
            if (Amount == 0)
            {
                return false;
            }
            switch (Type)
            {
                case TransactionType.Expence:
                    return Source != null && Tags.Count > 0;
                case TransactionType.Transfer:
                    return Destination != null && Source != null;
                case TransactionType.Income:
                    return Destination != null;
                default:
                    throw new NotSupportedException($"Transaction {Type} is not supported.");
            }
        }

        internal Transaction CreateTransaction()
        {
            string currency;
            TransactionData data;
            switch (Type)
            {
                case TransactionType.Expence:
                    currency = Currency ?? Destination.Currency;
                    data = new TransactionData(Date, Amount, Description, currency);
                    return new Expence(Source, data);

                case TransactionType.Transfer:
                    currency = Currency ?? Destination.Currency;
                    data = new TransactionData(Date, Amount, Description, currency);
                    return new Transfer(Source, Destination, data);

                case TransactionType.Income:
                    currency = Currency ?? Destination.Currency;
                    data = new TransactionData(Date, Amount, Description, currency);
                    return new Income(Destination, data);

                default:
                    throw new NotSupportedException($"Transaction {Type} is not supported.");
            }
        }
    }
}
