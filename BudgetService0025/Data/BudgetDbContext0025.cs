using BudgetService0025.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetService0025.Data
{
    public class BudgetDbContext0025 : DbContext
    {
        public BudgetDbContext0025(DbContextOptions<BudgetDbContext0025> options) : base(options) { }

        public DbSet<Budget0025> Budgets { get; set; }
        public DbSet<BudgetCategory0025> BudgetCategories { get; set; }
        public DbSet<Expense0025> Expenses { get; set; }
    }
}
