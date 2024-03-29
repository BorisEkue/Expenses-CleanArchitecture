﻿using System;
using System.Collections.Generic;
using System.Text;

using Expenses.Domain.Entities;
using Expenses.Domain.Repositories;

namespace Expenses.Domain.UseCases
{
    class SubmitExpense : ISubmitExpense
    {
        private readonly IExpenseRepository _repository;

        public SubmitExpense(IExpenseRepository repository)
        {
            _repository = repository;
        }

        public void Execute(Guid userId, string description, long priceWithoutTax, long priceIncludingTax)
        {
            _repository.Create(new Expense(Guid.NewGuid(), userId, description, priceWithoutTax, priceIncludingTax));
        }
    }
}
