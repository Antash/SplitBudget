namespace SplitBudget.Core
{
    public class Account
    {
        public Account(string name, string currency)
        {
            Name = name;
            Currency = currency;
        }

        private string Name { get; }

        internal string Currency { get; }

        internal decimal Balance { get; private set; }

        private User Owner { get; }

        protected virtual AccountType Type => AccountType.Debet;
    }
}
