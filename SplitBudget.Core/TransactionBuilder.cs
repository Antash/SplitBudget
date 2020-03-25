using System;

namespace SplitBudget.Core
{
    public static class TransactionBuilder
    {
        public static TransactionContext Spend(decimal amount)
        {
            var context = new TransactionContext(TransactionType.Expence);
            context.Amount = amount;
            return context;
        }

        public static TransactionContext Transfer(decimal amount)
        {
            var context = new TransactionContext(TransactionType.Transfer);
            context.Amount = amount;
            return context;
        }

        public static TransactionContext Recieve(decimal amount)
        {
            var context = new TransactionContext(TransactionType.Income);
            context.Amount = amount;
            return context;
        }

        public static TransactionContext From(this TransactionContext context, Account source)
        {
            context.Source = source;
            return context;
        }

        public static TransactionContext To(this TransactionContext context, Account destination)
        {
            context.Destination = destination;
            return context;
        }

        public static TransactionContext On(this TransactionContext context, DateTime date)
        {
            context.Date = date;
            return context;
        }

        public static TransactionContext In(this TransactionContext context, string currency)
        {
            context.Currency = currency;
            return context;
        }

        public static TransactionContext Tag(this TransactionContext context, Tag tag)
        {
            context.Tags.Add(tag);
            return context;
        }

        public static Transaction Done(this TransactionContext context)
        {
            if (!context.IsComplete())
            {
                throw new ArgumentException("Context is missing mandatory data.");
            }

            return context.CreateTransaction();
        }
    }
}
