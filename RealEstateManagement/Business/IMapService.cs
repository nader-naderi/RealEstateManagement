using RealEstateManagement.Data.Repositories;
using RealEstateManagement.Models.Entities;

namespace RealEstateManagement.Business
{
    public interface IMapService
    {
        List<PropertyWithLocation> GetPropertiesWithLocation();
        List<Property> GetPropertiesInArea(double latitude, double longitude, double radiusInMeters);
    }

    public class MapService : IMapService
    {
        private readonly IPropertyRepository _propertyRepository;

        public MapService(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        public List<PropertyWithLocation> GetPropertiesWithLocation()
        {
            // Implementation to get properties with location
            return null;
        }

        public List<Property> GetPropertiesInArea(double latitude, double longitude, double radiusInMeters)
        {
            // Implementation to get properties within the specified area
            return null;
        }
    }
}
