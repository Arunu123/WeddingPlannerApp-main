using Microsoft.EntityFrameworkCore;
using VendorService0025.Models;

namespace VendorService0025.Data
{
    public class Vendor0025DbContext : DbContext
    {
        public Vendor0025DbContext(DbContextOptions<Vendor0025DbContext> options) : base(options) { }

        public DbSet<Vendor0025> Vendors { get; set; }
        public DbSet<VendorSchedule0025> VendorSchedules { get; set; }
    }
}
