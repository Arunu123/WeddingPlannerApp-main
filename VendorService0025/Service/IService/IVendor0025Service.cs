using VendorService0025.Models;

namespace VendorService0025.Service.IService
{
    public interface IVendor0025Service
    {
        Vendor0025 AddVendor(Vendor0025 vendor);
        Vendor0025 GetVendorById(string id);
        List<Vendor0025> GetAllVendors();
        Vendor0025 UpdateVendor(string id, Vendor0025 updatedVendor);
        bool DeleteVendor(string id);
    }
}
