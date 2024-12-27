using GuestService0025.Models;
using GuestService0025.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GuestService0025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Guest0025Controller : ControllerBase
    {
        private readonly IGuest0025Service _guestService;

        public Guest0025Controller(IGuest0025Service guestService)
        {
            _guestService = guestService;
        }

        // Guest Endpoints
        [HttpPost("AddGuest")]
        public IActionResult AddGuest([FromBody] Guest0025 newGuest)
        {
            var result = _guestService.AddGuest0025(newGuest);
            return CreatedAtAction(nameof(GetGuestById), new { id = result.Id }, result);
        }

        [HttpGet("GetGuestsByEvent/{eventId}")]
        public IActionResult GetGuestsByEvent(string eventId)
        {
            return Ok(_guestService.GetGuestsByEventId0025(eventId));
        }

        [HttpGet("GetGuestById/{id}")]
        public IActionResult GetGuestById(string id)
        {
            var result = _guestService.GetGuestById0025(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPut("UpdateGuest/{id}")]
        public IActionResult UpdateGuest(string id, [FromBody] Guest0025 updatedGuest)
        {
            var result = _guestService.UpdateGuest0025(id, updatedGuest);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpDelete("DeleteGuest/{id}")]
        public IActionResult DeleteGuest(string id)
        {
            var result = _guestService.DeleteGuest0025(id);
            if (!result) return NotFound();
            return NoContent();
        }

        // Guest Group Endpoints
        [HttpPost("AddGuestGroup")]
        public IActionResult AddGuestGroup([FromBody] GuestGroup0025 newGroup)
        {
            var result = _guestService.AddGuestGroup0025(newGroup);
            return CreatedAtAction(nameof(GetGuestGroupById), new { id = result.Id }, result);
        }

        [HttpGet("GetGuestGroupsByEvent/{eventId}")]
        public IActionResult GetGuestGroupsByEvent(string eventId)
        {
            return Ok(_guestService.GetGuestGroupsByEventId0025(eventId));
        }

        [HttpGet("GetGuestGroupById/{id}")]
        public IActionResult GetGuestGroupById(string id)
        {
            var result = _guestService.GetGuestGroupById0025(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPut("UpdateGuestGroup/{id}")]
        public IActionResult UpdateGuestGroup(string id, [FromBody] List<string> guestIds)
        {
            var result = _guestService.UpdateGuestGroup0025(id, guestIds);
            if (!result) return NotFound();
            return NoContent();
        }

        [HttpDelete("DeleteGuestGroup/{id}")]
        public IActionResult DeleteGuestGroup(string id)
        {
            var result = _guestService.DeleteGuestGroup0025(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}
