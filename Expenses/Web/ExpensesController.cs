using System;
using System.Collections.Generic;
using System.Text;

using Expenses.Domain.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace Expenses.Web
{
    class ExpensesController : ControllerBase
    {
        private readonly ISubmitExpense _submitExpense;

        public ExpensesController(ISubmitExpense submitExpense)
        {
            _submitExpense = submitExpense;
        }

        public void submitExpense([FromBody] SubmitExpenseCommand expense)
        {
            _submitExpense.Execute(expense.UserId, expense.Description, expense.PriceWithoutTax, expense.PriceIncludingTax);
        }
    }

    public class SubmitExpenseCommand
    {
        public Guid UserId { get; set; }
        public string Description { get; set; }
        public long PriceWithoutTax { get; set; }
        public long PriceIncludingTax { get; set; }
    }
}
