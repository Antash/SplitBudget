using System.Collections.Generic;
using SplitBudget.Core.Interfaces;

namespace SplitBudget.Core
{
    public abstract class Transaction : ITransaction
    {
        protected Transaction(TransactionData data)
        {
            Data = data;
            Tags = new List<Tag>() { new Tag() };
        }

        public TransactionData Data { get; }

        public IList<Tag> Tags { get; }

        public bool Processed { get; protected set; }

        public abstract void Process();

        public abstract void Rollback();
    }
}
