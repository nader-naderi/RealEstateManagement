using RealEstateManagement.Models.Entities;

namespace RealEstateManagement.Models.ViewModels
{
    public class MapViewModel
    {
        public List<PropertyWithLocation> PropertiesWithLocation { get; set; }
        public UserLocation UserLocation { get; set; }
    }
}
