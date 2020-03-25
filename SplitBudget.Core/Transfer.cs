using System;

namespace SplitBudget.Core
{
    public class Transfer : Transaction
    {
        public Account Source { get; }

        public Account Destination { get; }

        public Transfer(Account source, Account destination, TransactionData data) 
            : base(data)
        {
            Source = source;
            Destination = destination;
        }

        public override void Process()
        {
            throw new NotImplementedException();
        }

        public override void Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
