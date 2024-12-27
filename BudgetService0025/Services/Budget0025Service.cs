using BudgetService0025.Data;
using BudgetService0025.Models;
using BudgetService0025.Services.IService;
using Microsoft.EntityFrameworkCore;

namespace BudgetService0025.Services
{
    public class Budget0025Service : IBudgetService0025
    {
        private readonly BudgetDbContext0025 _context;

        public Budget0025Service(BudgetDbContext0025 context)
        {
            _context = context;
        }

        public Budget0025 CreateBudget(Budget0025 budget)
        {
            budget.Id = Guid.NewGuid().ToString();
            budget.CreatedAt = DateTime.UtcNow;
            budget.UpdatedAt = DateTime.UtcNow;
            _context.Budgets.Add(budget);
            _context.SaveChanges();
            return budget;
        }

        public Budget0025 GetBudget(string budgetId)
        {
            return _context.Budgets
                .Include(b => b.Categories)
                .ThenInclude(c => c.Expenses)
                .FirstOrDefault(b => b.Id == budgetId);
        }

        public Budget0025 UpdateBudget(string budgetId, Budget0025 updatedBudget)
        {
            var budget = _context.Budgets.FirstOrDefault(b => b.Id == budgetId);
            if (budget == null) return null;

            budget.TotalBudget = updatedBudget.TotalBudget;
            budget.RemainingBudget = updatedBudget.RemainingBudget;
            budget.TotalSpent = updatedBudget.TotalSpent;
            budget.UpdatedAt = DateTime.UtcNow;

            _context.SaveChanges();
            return budget;
        }

        public bool DeleteBudget(string budgetId)
        {
            var budget = _context.Budgets.FirstOrDefault(b => b.Id == budgetId);
            if (budget == null) return false;

            _context.Budgets.Remove(budget);
            _context.SaveChanges();
            return true;
        }

        public List<BudgetCategory0025> GetBudgetCategories(string budgetId)
        {
            var budget = _context.Budgets
                .Include(b => b.Categories)
                .FirstOrDefault(b => b.Id == budgetId);
            return budget?.Categories;
        }

        public Expense0025 AddExpense(string categoryId, Expense0025 expense)
        {
            var category = _context.BudgetCategories.FirstOrDefault(c => c.Id == categoryId);
            if (category == null) return null;

            expense.Id = Guid.NewGuid().ToString();
            expense.CreatedAt = DateTime.UtcNow;
            _context.Expenses.Add(expense);

            category.SpentAmount += expense.Amount;

            _context.SaveChanges();
            return expense;
        }
    }
}
