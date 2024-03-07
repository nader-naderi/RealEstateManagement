using Microsoft.AspNetCore.Mvc;

namespace RealEstateManagement.Controllers
{
    public class TenantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            // TODO: Add logic for tenant dashboard
            return View();
        }

        public IActionResult SubmitApplication(int propertyId)
        {
            // TODO: Add logic for rental application submission
            return View();
        }

        public IActionResult MaintenanceRequest()
        {
            // TODO: Add logic for maintenance request submission
            return View();
        }
    }
}
