using System;
using System.Collections.Generic;
using System.Text;

namespace SplitBudget.Core.Services
{
    public class ExchangeRateService
    {
        public static decimal GetExchangeRate(string currencyFrom, string currecyTo)
        {
            return currecyTo.Equals(currencyFrom, StringComparison.InvariantCultureIgnoreCase)
                ? 1 
                : throw new NotImplementedException();
        }
    }
}
