using Microsoft.AspNetCore.Mvc;

namespace RealEstateManagement.Controllers
{
    public class MapController : Controller
    {
        //private readonly IMapService _mapService;
        //private readonly IDeviceGeolocationService _deviceGeolocationService;

        //public MapController(IMapService mapService, IDeviceGeolocationService deviceGeolocationService)
        //{
        //    _mapService = mapService;
        //    _deviceGeolocationService = deviceGeolocationService;
        //}

        public IActionResult Index()
        {
            //var viewModel = new MapViewModel
            //{
            //    Properties = _mapService.GetPropertiesWithLocation(),
            //    UserLocation = _deviceGeolocationService.GetUserLocation()
            //};

            //return View(viewModel);
            return View();
        }

        public IActionResult GetPropertiesInArea(double latitude, double longitude, double radiusInMeters)
        {
            //var properties = _mapService.GetPropertiesInArea(latitude, longitude, radiusInMeters);

            //return Json(properties);
            return Json("");
        }
    }
}
