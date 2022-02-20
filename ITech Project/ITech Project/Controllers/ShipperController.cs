using ITech_Project.Models;
using ITech_Project.Service;
using Microsoft.AspNetCore.Mvc;

namespace ITech_Project.Controllers
{
    public class ShipperController : Controller
    {
        private readonly IShipperService shipperService;

        public ShipperController(IShipperService shipperService)
        {
            this.shipperService = shipperService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
