using GuestService0025.Data;
using GuestService0025.Models;
using GuestService0025.Service.IService;

namespace GuestService0025.Service
{
    public class Guest0025Service : IGuest0025Service
    {
        private readonly GuestDbContext0025 _dbContext;

        public Guest0025Service(GuestDbContext0025 dbContext)
        {
            _dbContext = dbContext;
        }

        // Guest Operations
        public Guest0025 AddGuest0025(Guest0025 newGuest)
        {
            newGuest.Id = Guid.NewGuid().ToString();
            newGuest.CreatedAt = DateTime.UtcNow;
            newGuest.UpdatedAt = DateTime.UtcNow;
            _dbContext.Guests.Add(newGuest);
            _dbContext.SaveChanges();
            return newGuest;
        }

        public List<Guest0025> GetGuestsByEventId0025(string eventId)
        {
            return _dbContext.Guests.Where(g => g.EventId == eventId).ToList();
        }

        public Guest0025 GetGuestById0025(string id)
        {
            return _dbContext.Guests.FirstOrDefault(g => g.Id == id);
        }

        public Guest0025 UpdateGuest0025(string id, Guest0025 updatedGuest)
        {
            var existingGuest = _dbContext.Guests.FirstOrDefault(g => g.Id == id);
            if (existingGuest == null) return null;

            existingGuest.FirstName = updatedGuest.FirstName;
            existingGuest.LastName = updatedGuest.LastName;
            existingGuest.Email = updatedGuest.Email;
            existingGuest.PhoneNumber = updatedGuest.PhoneNumber;
            existingGuest.Address = updatedGuest.Address;
            existingGuest.NumberOfAccompanyingGuests = updatedGuest.NumberOfAccompanyingGuests;
            existingGuest.InvitationStatus = updatedGuest.InvitationStatus;
            existingGuest.RsvpStatus = updatedGuest.RsvpStatus;
            existingGuest.DietaryRestrictions = updatedGuest.DietaryRestrictions;
            existingGuest.GroupCategory = updatedGuest.GroupCategory;
            existingGuest.RsvpResponseDate = updatedGuest.RsvpResponseDate;
            existingGuest.UpdatedAt = DateTime.UtcNow;

            _dbContext.SaveChanges();
            return existingGuest;
        }

        public bool DeleteGuest0025(string id)
        {
            var existingGuest = _dbContext.Guests.FirstOrDefault(g => g.Id == id);
            if (existingGuest == null) return false;

            _dbContext.Guests.Remove(existingGuest);
            _dbContext.SaveChanges();
            return true;
        }

        // Guest Group Operations
        public GuestGroup0025 AddGuestGroup0025(GuestGroup0025 newGroup)
        {
            newGroup.Id = Guid.NewGuid().ToString();
            _dbContext.GuestGroups.Add(newGroup);
            _dbContext.SaveChanges();
            return newGroup;
        }

        public GuestGroup0025 GetGuestGroupById0025(string id)
        {
            return _dbContext.GuestGroups.FirstOrDefault(g => g.Id == id);
        }

        public List<GuestGroup0025> GetGuestGroupsByEventId0025(string eventId)
        {
            return _dbContext.GuestGroups.Where(g => g.EventId == eventId).ToList();
        }

        public bool UpdateGuestGroup0025(string id, List<string> guestIds)
        {
            var existingGroup = _dbContext.GuestGroups.FirstOrDefault(g => g.Id == id);
            if (existingGroup == null) return false;

            existingGroup.GuestIds = guestIds;
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteGuestGroup0025(string id)
        {
            var existingGroup = _dbContext.GuestGroups.FirstOrDefault(g => g.Id == id);
            if (existingGroup == null) return false;

            _dbContext.GuestGroups.Remove(existingGroup);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
