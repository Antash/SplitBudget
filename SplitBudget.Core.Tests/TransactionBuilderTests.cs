using System;
using Xunit;

namespace SplitBudget.Core.Tests
{
    public class TransactionBuilderTests
    {
        [Fact]
        public void TestCreatesExpence()
        {
            Account source = new Account("Debet", "USD");

            var expence = TransactionBuilder.Spend(100)
                .From(source)
                .Done();

            Assert.IsType<Expence>(expence);
            Assert.Equal(100, expence.Data.Amount);
            Assert.Equal("USD", expence.Data.Currency);
            Assert.Collection(expence.Tags, tag => Assert.Equal(tag.Name, new Tag().Name));
        }
    }
}
