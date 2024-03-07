using Microsoft.EntityFrameworkCore;

using RealEstateManagement.Models.Entities;

namespace RealEstateManagement.Data.Repositories
{
    public interface IPropertyRepository
    {
        Task<List<Property>> GetAllProperties();
        Task<Property> GetPropertyById(Guid id);
        Task<Property> AddProperty(Property property);
        Task<Property> UpdateProperty(Guid id, Property property);
        Task DeleteProperty(Guid id);
    }

    public class PropertyRepository(ApplicationDbContext _context) : IPropertyRepository
    {

        public async Task<List<Property>> GetAllProperties()
        {
            return await _context.Properties.ToListAsync();
        }

        public async Task<Property> GetPropertyById(Guid id)
        {
            return await _context.Properties.FindAsync(id);
        }

        public async Task<Property> AddProperty(Property property)
        {
            _context.Properties.Add(property);
            await _context.SaveChangesAsync();
            return property;
        }

        public async Task<Property> UpdateProperty(Guid id, Property property)
        {
            if (property == null)
            {
                throw new ArgumentNullException(nameof(property));
            }

            var existingProperty = await _context.Properties.FindAsync(id);

            if (existingProperty == null)
            {
                throw new KeyNotFoundException($"Property with ID {id} not found.");
            }

            // Update properties other than Id
            existingProperty.Title = property.Title;
            existingProperty.Description = property.Description;
            existingProperty.Price = property.Price;
            existingProperty.NumberOfBedrooms = property.NumberOfBedrooms;
            existingProperty.NumberOfBathrooms = property.NumberOfBathrooms;
            existingProperty.SquareFeet = property.SquareFeet;
            existingProperty.Address = property.Address;
            existingProperty.City = property.City;
            existingProperty.State = property.State;
            existingProperty.Country = property.Country;
            existingProperty.PostalCode = property.PostalCode;
            existingProperty.PropertyType = property.PropertyType;

            await _context.SaveChangesAsync();

            return existingProperty;
        }


        public async Task DeleteProperty(Guid id)
        {
            var property = await _context.Properties.FindAsync(id);
            _context.Properties.Remove(property);
            await _context.SaveChangesAsync();
        }
    }
}