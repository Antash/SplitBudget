namespace SplitBudget.Core
{
    class Account
    {
        private string Name { get; }

        private string Currency { get; }

        private decimal Balance { get; }

        private User Owner { get; }

        protected virtual AccountType Type { get; }
    }
}
