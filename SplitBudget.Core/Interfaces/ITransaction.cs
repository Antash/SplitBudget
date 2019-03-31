using System;
using System.Collections.Generic;
using System.Text;

namespace SplitBudget.Core.Interfaces
{
    interface ITransaction
    {
        bool Processed { get; }

        void Process();

        void Rollback();
    }
}
