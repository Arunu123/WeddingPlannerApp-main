using Microsoft.EntityFrameworkCore;
using NotificationService0025.Models;

namespace NotificationService0025.Data
{
    public class NotificationDbContext0025 : DbContext
    {
        public NotificationDbContext0025(DbContextOptions<NotificationDbContext0025> options) : base(options) { }

        public DbSet<Notification0025> Notifications { get; set; }
        public DbSet<NotificationPreference0025> NotificationPreferences { get; set; }
    }
}
