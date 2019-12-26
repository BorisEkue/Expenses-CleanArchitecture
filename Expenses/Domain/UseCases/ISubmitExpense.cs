using System;
using System.Collections.Generic;
using System.Text;

namespace Expenses.Domain.UseCases
{
    interface ISubmitExpense
    {
        void Execute(Guid userId, string description, long priceWithoutTax, long priceIncludingTax);
    }
}
