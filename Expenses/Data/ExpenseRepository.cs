using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

using Expenses.Domain.Entities;
using Expenses.Domain.Repositories;

namespace Expenses.Data
{
    class ExpenseRepository : IExpenseRepository
    {
        private readonly ExpensesDbContext _dbContext;

        public ExpenseRepository(ExpensesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Expense expense)
        {
            _dbContext.Expenses.Add(DbExpense.FromExpense(expense));
        }
    }

    public class DbExpense
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [Required]
        public long PriceWithoutTax { get; set; }

        [Required]
        public long PriceIncludingTax { get; set; }

        public static DbExpense FromExpense(Expense expense)
        {
            return new DbExpense()
            {
                Id = expense.Id,
                UserId = expense.UserId,
                Description = expense.Description,
                PriceWithoutTax = expense.PriceWithoutTax,
                PriceIncludingTax = expense.PriceIncludingTax
            };
        }
    }
}
