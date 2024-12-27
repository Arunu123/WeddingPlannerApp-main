namespace BudgetService0025.Models
{
    public class BudgetCategory0025
    {
        public string Id { get; set; }
        public string BudgetId { get; set; }
        public string CategoryName { get; set; } // Venue, Catering, Flowers, etc.
        public decimal AllocatedAmount { get; set; }
        public decimal SpentAmount { get; set; }
        public List<Expense0025> Expenses { get; set; }
    }
}
