using System.Collections.Generic;

namespace SplitBudget.Core
{
    public class Transaction
    {
        public Transaction(Account source, Account destination, TransactionData data)
        {
            Source = source;
            Destination = destination;
            Data = data;
            Tags = new List<Tag>() { new Tag() };
        }

        public TransactionData Data { get; }

        public Account Source { get; }

        public Account Destination { get; }

        public IList<Tag> Tags { get; }
    }
}
