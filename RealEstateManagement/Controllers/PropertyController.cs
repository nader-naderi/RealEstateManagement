using Microsoft.AspNetCore.Mvc;

namespace RealEstateManagement.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            //var property = _repository.GetPropertyById(id);
            //return View(property);
            return View();
        }
    }
}
