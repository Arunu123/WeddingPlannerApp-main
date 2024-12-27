using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotificationService0025.Models;
using NotificationService0025.Services.IService;

namespace NotificationService0025.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationPreferenceController0025 : ControllerBase
    {
        private readonly INotificationPreference0025Service _preferenceService;

        public NotificationPreferenceController0025(INotificationPreference0025Service preferenceService)
        {
            _preferenceService = preferenceService;
        }

        [HttpGet("{userId}")]
        public IActionResult GetPreferences(string userId)
        {
            var preferences = _preferenceService.GetPreferencesByUserId(userId);
            if (preferences == null) return NotFound();
            return Ok(preferences);
        }

        [HttpPut]
        public IActionResult UpdatePreferences(NotificationPreference0025 preferences)
        {
            var updated = _preferenceService.UpdatePreferences(preferences);
            return Ok(updated);
        }
    }
}
