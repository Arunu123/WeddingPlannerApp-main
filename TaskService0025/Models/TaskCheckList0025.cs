namespace TaskService0025.Models
{
    public class TaskCheckList0025
    {
        public string Id { get; set; }
        public string TaskId { get; set; }
        public string ItemDescription { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime? CompletedDate { get; set; }
    }
}
