using Microsoft.AspNetCore.Mvc;

namespace RealEstateManagement.Controllers
{
    public class GeolocationController : Controller
    {
        //private readonly IDeviceGeolocationService _deviceGeolocationService;

        //public GeolocationController(IDeviceGeolocationService deviceGeolocationService)
        //{
        //    _deviceGeolocationService = deviceGeolocationService;
        //}

        public IActionResult GetUserLocation()
        {
            //var userLocation = _deviceGeolocationService.GetUserLocation();

            //return Json(userLocation);
            return Json("");
        }
    }
}
