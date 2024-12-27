namespace BudgetService0025.Models
{
    public class Budget0025
    {
        public string Id { get; set; }
        public string EventId { get; set; }
        public decimal TotalBudget { get; set; }
        public decimal RemainingBudget { get; set; }
        public decimal TotalSpent { get; set; }
        public List<BudgetCategory0025> Categories { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
