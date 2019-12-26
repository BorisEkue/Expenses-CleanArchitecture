using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
namespace Expenses.Data
{
    class ExpensesDbContext : DbContext
    {
        public ExpensesDbContext(DbContextOptions<ExpensesDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<DbExpense> Expenses { get; set; }
    }
}
