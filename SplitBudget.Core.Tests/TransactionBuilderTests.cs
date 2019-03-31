using System;
using Xunit;

namespace SplitBudget.Core.Tests
{
    public class TransactionBuilderTests
    {
        [Fact]
        public void TestCreatesTransaction()
        {
            Account source = new Account("Debet", "USD");
            Account destination = new Account("Credit", "USD");

            var expence = TransactionBuilder.Spend(100)
                .From(source)
                .To(destination)
                .Done();

            Assert.Equal(source, expence.Source);
            Assert.Equal(destination, expence.Destination);
            Assert.Equal(100, expence.Data.Amount);
            Assert.Equal("USD", expence.Data.Currency);
            Assert.Collection(expence.Tags, tag => Assert.Equal(tag.Name, new Tag().Name));
        }
    }
}
