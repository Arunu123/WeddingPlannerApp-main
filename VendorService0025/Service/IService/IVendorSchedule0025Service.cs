using VendorService0025.Models;

namespace VendorService0025.Service.IService
{
    public interface IVendorSchedule0025Service
    {
        VendorSchedule0025 AddVendorSchedule(VendorSchedule0025 schedule);
        VendorSchedule0025 GetVendorScheduleById(string id);
        List<VendorSchedule0025> GetSchedulesByEventId(string eventId);
        bool DeleteVendorSchedule(string id);
    }
}
