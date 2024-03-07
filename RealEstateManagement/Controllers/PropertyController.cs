using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using RealEstateManagement.Business;
using RealEstateManagement.Models.Entities;
using RealEstateManagement.Models.ViewModels;

namespace RealEstateManagement.Controllers
{
    public class PropertyController(IPropertyService propertyService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var properties = await propertyService.GetAllProperties();
            return View(properties);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var property = await propertyService.GetPropertyById(id);

            var model = new PropertyViewModel
            {
                Address = property.Address,
                City = property.City,   
                PostalCode = property.PostalCode,
                Country = property.Country,
                Description = property.Description,
                NumberOfBathrooms = property.NumberOfBathrooms,
                NumberOfBedrooms = property.NumberOfBedrooms,
                Price = property.Price,
                PropertyType = property.PropertyType,
                PropertyTypeList = new SelectList(Enum.GetValues(typeof(PropertyType))),
                SquareFeet = property.SquareFeet,
                State = property.State,
                Title = property.Title
            };

            return View(model);
        }

        public IActionResult Create()
        {
            var propertyTypes = new SelectList(Enum.GetValues(typeof(PropertyType)));

            var model = new PropertyViewModel
            {
                PropertyTypeList = propertyTypes
            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Create(PropertyViewModel model)
        {
            var property = new Property
            {
                Address = model.Address,
                City = model.City,
                PostalCode = model.PostalCode,
                Country = model.Country,
                Description = model.Description,
                NumberOfBathrooms = model.NumberOfBathrooms,
                NumberOfBedrooms = model.NumberOfBedrooms,
                Price = model.Price,
                PropertyType = model.PropertyType,
                SquareFeet = model.SquareFeet,
                State = model.State,
                Title = model.Title
            };

            await propertyService.AddProperty(property);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Edit(Guid id)
        {
            var property = await propertyService.GetPropertyById(id);

            var model = new PropertyViewModel
            {
                Id = property.Id,
                Address = property.Address,
                City = property.City,
                PostalCode = property.PostalCode,
                Country = property.Country,
                Description = property.Description,
                NumberOfBathrooms = property.NumberOfBathrooms,
                NumberOfBedrooms = property.NumberOfBedrooms,
                Price = property.Price,
                PropertyType = property.PropertyType,
                PropertyTypeList = new SelectList(Enum.GetValues(typeof(PropertyType))),
                SquareFeet = property.SquareFeet,
                State = property.State,
                Title = property.Title
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, PropertyViewModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            var property = new Property
            {
                Address = model.Address,
                City = model.City,
                PostalCode = model.PostalCode,
                Country = model.Country,
                Description = model.Description,
                NumberOfBathrooms = model.NumberOfBathrooms,
                NumberOfBedrooms = model.NumberOfBedrooms,
                Price = model.Price,
                PropertyType = model.PropertyType,
                SquareFeet = model.SquareFeet,
                State = model.State,
                Title = model.Title
            };

            await propertyService.UpdateProperty(id, property);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {
            var property = propertyService.GetPropertyById(id);
            return View(property);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await propertyService.DeleteProperty(id);
            return RedirectToAction("Index");
        }
    }
}
