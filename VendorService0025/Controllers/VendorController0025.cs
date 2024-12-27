using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendorService0025.Models;
using VendorService0025.Service.IService;

namespace VendorService0025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController0025 : ControllerBase
    {
        private readonly IVendor0025Service _vendorService;

        public VendorController0025(IVendor0025Service vendorService)
        {
            _vendorService = vendorService;
        }

        [HttpPost("AddVendor")]
        public IActionResult AddVendor([FromBody] Vendor0025 vendor)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newVendor = _vendorService.AddVendor(vendor);
            return CreatedAtAction(nameof(GetVendorById), new { id = newVendor.Id }, newVendor);
        }

        [HttpGet("GetVendorById/{id}")]
        public IActionResult GetVendorById(string id)
        {
            var vendor = _vendorService.GetVendorById(id);
            if (vendor == null)
                return NotFound();

            return Ok(vendor);
        }

        [HttpGet("GetAllVendors")]
        public IActionResult GetAllVendors()
        {
            return Ok(_vendorService.GetAllVendors());
        }

        [HttpPut("UpdateVendor/{id}")]
        public IActionResult UpdateVendor(string id, [FromBody] Vendor0025 updatedVendor)
        {
            var vendor = _vendorService.UpdateVendor(id, updatedVendor);
            if (vendor == null)
                return NotFound();

            return Ok(vendor);
        }

        [HttpDelete("DeleteVendor/{id}")]
        public IActionResult DeleteVendor(string id)
        {
            var result = _vendorService.DeleteVendor(id);
            if (!result)
                return NotFound();

            return NoContent();
        }
    }
}
