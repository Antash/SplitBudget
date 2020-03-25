using System;

namespace SplitBudget.Core
{
    public class Income : OneWayTransaction
    {
        public Income(Account destination, TransactionData data) : base(destination, data)
        {
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
