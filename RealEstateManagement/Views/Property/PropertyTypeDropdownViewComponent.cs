using Microsoft.AspNetCore.Mvc;

using System;

namespace YourNamespace.ViewComponents
{
    public class PropertyTypeDropdownViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var propertyTypes = new[] { "Commercial", "Residential", "Land" };

            return View(propertyTypes);
        }
    }
}
