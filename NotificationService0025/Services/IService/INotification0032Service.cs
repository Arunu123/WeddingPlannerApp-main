using NotificationService0025.Models;

namespace NotificationService0025.Services.IService
{
    public interface INotification0025Service
    {
        Notification0025 CreateNotification(Notification0025 notification);
        List<Notification0025> GetAllNotifications();
        Notification0025 GetNotificationById(string id);
        bool MarkAsRead(string id);
    }

    public interface INotificationPreference0025Service
    {
        NotificationPreference0025 GetPreferencesByUserId(string userId);
        NotificationPreference0025 UpdatePreferences(NotificationPreference0025 preferences);
    }
}
