using VendorService0025.Data;
using VendorService0025.Models;
using VendorService0025.Service.IService;

namespace VendorService0025.Service
{
    public class VendorSchedule0025Service : IVendorSchedule0025Service
    {
        private readonly Vendor0025DbContext _context;

        public VendorSchedule0025Service(Vendor0025DbContext context)
        {
            _context = context;
        }

        public VendorSchedule0025 AddVendorSchedule(VendorSchedule0025 schedule)
        {
            _context.VendorSchedules.Add(schedule);
            _context.SaveChanges();
            return schedule;
        }

        public VendorSchedule0025 GetVendorScheduleById(string id)
        {
            return _context.VendorSchedules.FirstOrDefault(s => s.Id == id);
        }

        public List<VendorSchedule0025> GetSchedulesByEventId(string eventId)
        {
            return _context.VendorSchedules.Where(s => s.EventId == eventId).ToList();
        }

        public bool DeleteVendorSchedule(string id)
        {
            var schedule = _context.VendorSchedules.FirstOrDefault(s => s.Id == id);
            if (schedule == null) return false;

            _context.VendorSchedules.Remove(schedule);
            _context.SaveChanges();
            return true;
        }
    }
}
