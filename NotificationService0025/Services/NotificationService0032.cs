using NotificationService0025.Data;
using NotificationService0025.Models;
using NotificationService0025.Services.IService;

namespace NotificationService0025.Services
{
    public class Notification0025Service : INotification0025Service
    {
        private readonly NotificationDbContext0025 _db;

        public Notification0025Service(NotificationDbContext0025 db)
        {
            _db = db;
        }

        public Notification0025 CreateNotification(Notification0025 notification)
        {
            notification.Id = Guid.NewGuid().ToString();
            notification.CreatedAt = DateTime.UtcNow;
            _db.Notifications.Add(notification);
            _db.SaveChanges();
            return notification;
        }

        public List<Notification0025> GetAllNotifications()
        {
            return _db.Notifications.ToList();
        }

        public Notification0025 GetNotificationById(string id)
        {
            return _db.Notifications.FirstOrDefault(n => n.Id == id);
        }

        public bool MarkAsRead(string id)
        {
            var notification = _db.Notifications.FirstOrDefault(n => n.Id == id);
            if (notification == null) return false;

            notification.Status = "Read";
            notification.ReadAt = DateTime.UtcNow;
            _db.SaveChanges();
            return true;
        }
    }

    public class NotificationPreference0025Service : INotificationPreference0025Service
    {
        private readonly NotificationDbContext0025 _db;

        public NotificationPreference0025Service(NotificationDbContext0025 db)
        {
            _db = db;
        }

        public NotificationPreference0025 GetPreferencesByUserId(string userId)
        {
            return _db.NotificationPreferences.FirstOrDefault(p => p.UserId == userId);
        }

        public NotificationPreference0025 UpdatePreferences(NotificationPreference0025 preferences)
        {
            var existing = _db.NotificationPreferences.FirstOrDefault(p => p.UserId == preferences.UserId);
            if (existing == null)
            {
                preferences.Id = Guid.NewGuid().ToString();
                preferences.UpdatedAt = DateTime.UtcNow;
                _db.NotificationPreferences.Add(preferences);
            }
            else
            {
                existing.EmailEnabled = preferences.EmailEnabled;
                existing.SmsEnabled = preferences.SmsEnabled;
                existing.PushEnabled = preferences.PushEnabled;
                existing.NotificationTypes = preferences.NotificationTypes;
                existing.UpdatedAt = DateTime.UtcNow;
            }

            _db.SaveChanges();
            return preferences;
        }
    }
}
