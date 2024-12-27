using Microsoft.EntityFrameworkCore;
using TaskService0025.Models;

namespace TaskService0025.Data
{
    public class TaskDbContext0025 : DbContext
    {
        public TaskDbContext0025(DbContextOptions<TaskDbContext0025> options) : base(options) { }

        public DbSet<Task0025> Tasks { get; set; }
        public DbSet<TaskCheckList0025> TaskCheckLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task0025>().HasKey(t => t.Id);
            modelBuilder.Entity<TaskCheckList0025>().HasKey(c => c.Id);
        }
    }
}
