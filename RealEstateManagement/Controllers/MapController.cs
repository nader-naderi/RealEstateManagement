using Microsoft.AspNetCore.Mvc;

using RealEstateManagement.Business;
using RealEstateManagement.Models.ViewModels;

namespace RealEstateManagement.Controllers
{
    public class MapController : Controller
    {
        private readonly IMapService _mapService;
        private readonly IDeviceGeolocationService _deviceGeolocationService;

        public MapController(IMapService mapService, IDeviceGeolocationService deviceGeolocationService)
        {
            _mapService = mapService;
            _deviceGeolocationService = deviceGeolocationService;
        }

        public IActionResult Index()
        {
            var viewModel = new MapViewModel
            {
                PropertiesWithLocation = _mapService.GetPropertiesWithLocation(),
                UserLocation = _deviceGeolocationService.GetUserLocation()
            };

            return View(viewModel);
        }

        public IActionResult GetPropertiesInArea(double latitude, double longitude, double radiusInMeters)
        {
            var properties = _mapService.GetPropertiesInArea(latitude, longitude, radiusInMeters);

            return Json(properties);
        }
    }
}
