using System;
using System.Collections.Generic;
using System.Text;

using Expenses.Domain.Entities;

namespace Expenses.Domain.Repositories
{
     interface IExpenseRepository
    {
        void Create(Expense expense);
    }
}
