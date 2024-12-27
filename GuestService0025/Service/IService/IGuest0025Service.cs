using GuestService0025.Models;

namespace GuestService0025.Service.IService
{
    public interface IGuest0025Service
    {
        // Guest operations
        Guest0025 AddGuest0025(Guest0025 newGuest);
        List<Guest0025> GetGuestsByEventId0025(string eventId);
        Guest0025 GetGuestById0025(string id);
        Guest0025 UpdateGuest0025(string id, Guest0025 updatedGuest);
        bool DeleteGuest0025(string id);

        // Guest Group operations
        GuestGroup0025 AddGuestGroup0025(GuestGroup0025 newGroup);
        GuestGroup0025 GetGuestGroupById0025(string id);
        List<GuestGroup0025> GetGuestGroupsByEventId0025(string eventId);
        bool UpdateGuestGroup0025(string id, List<string> guestIds);
        bool DeleteGuestGroup0025(string id);
    }
}
