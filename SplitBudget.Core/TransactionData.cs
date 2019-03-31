using System;

namespace SplitBudget.Core
{
    public class TransactionData
    {
        public TransactionData(DateTime date, decimal amount, string description, string currency)
        {
            Date = date == default(DateTime) ? DateTime.Now : date;
            Amount = amount;
            Description = description;
            Currency = currency;
        }

        public DateTime Date { get; }

        public string Description { get; }

        public decimal Amount { get; }

        public string Currency { get; }
    }
}
