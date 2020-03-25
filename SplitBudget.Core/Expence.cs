using System;

namespace SplitBudget.Core
{
    public class Expence : OneWayTransaction
    {
        public Expence(Account source, TransactionData data) : base(source, data)
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
