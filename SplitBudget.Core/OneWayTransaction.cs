namespace SplitBudget.Core
{
    public abstract class OneWayTransaction : Transaction
    {
        public Account Account { get; }

        protected OneWayTransaction(Account account, TransactionData data) : base(data)
        {
            Account = account;
        }
    }
}
