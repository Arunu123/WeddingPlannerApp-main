using BudgetService0025.Models;

namespace BudgetService0025.Services.IService
{
    public interface IBudgetService0025
    {
        Budget0025 CreateBudget(Budget0025 budget);
        Budget0025 GetBudget(string budgetId);
        Budget0025 UpdateBudget(string budgetId, Budget0025 updatedBudget);
        bool DeleteBudget(string budgetId);
        List<BudgetCategory0025> GetBudgetCategories(string budgetId);
        Expense0025 AddExpense(string categoryId, Expense0025 expense);
    }
}
