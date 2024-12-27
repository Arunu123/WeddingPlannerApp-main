using GuestService0025.Models;
using Microsoft.EntityFrameworkCore;

namespace GuestService0025.Data
{
    public class GuestDbContext0025 : DbContext
    {
        public GuestDbContext0025(DbContextOptions<GuestDbContext0025> options) : base(options)
        {
        }

        public DbSet<Guest0025> Guests { get; set; }
        public DbSet<GuestGroup0025> GuestGroups { get; set; }
    }
}
