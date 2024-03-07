using Microsoft.AspNetCore.Mvc;

namespace RealEstateManagement.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
