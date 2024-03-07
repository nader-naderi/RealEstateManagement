using Microsoft.AspNetCore.Mvc.Rendering;

using RealEstateManagement.Models.Entities;

namespace RealEstateManagement.Models.ViewModels
{
    public class PropertyViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int NumberOfBedrooms { get; set; }
        public int NumberOfBathrooms { get; set; }
        public int SquareFeet { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public PropertyType PropertyType { get; set; }
        public SelectList PropertyTypeList { get; set; }
    }
}
