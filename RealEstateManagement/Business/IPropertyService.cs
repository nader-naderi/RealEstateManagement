using RealEstateManagement.Data.Repositories;
using RealEstateManagement.Models.Entities;

namespace RealEstateManagement.Business
{
    public interface IPropertyService
    {
        Task<List<Property>> GetAllProperties();
        Task<Property> GetPropertyById(Guid id);

        Task<Property> AddProperty(Property property);

        Task<Property> UpdateProperty(Guid id, Property property);

        Task DeleteProperty(Guid id);
    }

    public class PropertyService(IPropertyRepository _propertyRepository) : IPropertyService
    {
        public async Task<List<Property>> GetAllProperties()
        {
            return await _propertyRepository.GetAllProperties();
        }

        public async Task<Property> GetPropertyById(Guid id)
        {
            return await _propertyRepository.GetPropertyById(id);
        }

        public async Task<Property> AddProperty(Property property)
        {
            return await _propertyRepository.AddProperty(property);
        }

        public async Task<Property> UpdateProperty(Guid id, Property property)
        {
            return await _propertyRepository.UpdateProperty(id, property);
        }

        public async Task DeleteProperty(Guid id)
        {
            await _propertyRepository.DeleteProperty(id);
        }
    }
}
