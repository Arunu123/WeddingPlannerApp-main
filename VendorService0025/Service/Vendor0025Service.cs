using VendorService0025.Data;
using VendorService0025.Models;
using VendorService0025.Service.IService;

namespace VendorService0025.Service
{
    public class Vendor0025Service : IVendor0025Service
    {
        private readonly Vendor0025DbContext _context;

        public Vendor0025Service(Vendor0025DbContext context)
        {
            _context = context;
        }

        public Vendor0025 AddVendor(Vendor0025 vendor)
        {
            vendor.CreatedAt = DateTime.UtcNow;
            vendor.UpdatedAt = DateTime.UtcNow;
            _context.Vendors.Add(vendor);
            _context.SaveChanges();
            return vendor;
        }

        public Vendor0025 GetVendorById(string id)
        {
            return _context.Vendors.FirstOrDefault(v => v.Id == id);
        }

        public List<Vendor0025> GetAllVendors()
        {
            return _context.Vendors.ToList();
        }

        public Vendor0025 UpdateVendor(string id, Vendor0025 updatedVendor)
        {
            var vendor = _context.Vendors.FirstOrDefault(v => v.Id == id);
            if (vendor == null) return null;

            vendor.CompanyName = updatedVendor.CompanyName;
            vendor.ContactPerson = updatedVendor.ContactPerson;
            vendor.Email = updatedVendor.Email;
            vendor.PhoneNumber = updatedVendor.PhoneNumber;
            vendor.ServiceType = updatedVendor.ServiceType;
            vendor.Status = updatedVendor.Status;
            vendor.QuotedPrice = updatedVendor.QuotedPrice;
            vendor.ContractStatus = updatedVendor.ContractStatus;
            vendor.ContractSignedDate = updatedVendor.ContractSignedDate;
            vendor.Notes = updatedVendor.Notes;
            vendor.UpdatedAt = DateTime.UtcNow;

            _context.SaveChanges();
            return vendor;
        }

        public bool DeleteVendor(string id)
        {
            var vendor = _context.Vendors.FirstOrDefault(v => v.Id == id);
            if (vendor == null) return false;

            _context.Vendors.Remove(vendor);
            _context.SaveChanges();
            return true;
        }
    }
}
