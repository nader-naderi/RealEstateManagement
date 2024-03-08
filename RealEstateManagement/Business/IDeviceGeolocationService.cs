using RealEstateManagement.Models.Entities;

namespace RealEstateManagement.Business
{
    public interface IDeviceGeolocationService
    {
        UserLocation GetUserLocation();
    }

    public class DeviceGeolocationService : IDeviceGeolocationService
    {
        public UserLocation GetUserLocation()
        {
            // Implementation to get user's current location
            return null;
        }
    }
}
