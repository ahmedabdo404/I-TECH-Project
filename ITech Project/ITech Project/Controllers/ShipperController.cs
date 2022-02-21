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

        public IActionResult GetAll()
        {
            return View(shipperService.GetAll());   
        }

        public IActionResult GetById(int id)
        { 
        return View(shipperService.GetById(id));
        }

        public IActionResult GetByName(string name)
        { 
        return View(shipperService.GetByName(name));
        }
            
            
            [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Shipper ship)
        {
            if (ModelState.IsValid)
            { 
            shipperService.Create(ship);
            return RedirectToAction("GetAll");
            }
            return View(ship);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(shipperService.GetById(id));
        }
        [HttpPost]

        public IActionResult Update(Shipper ship)
        {
            if (ModelState.IsValid)
            { 
            shipperService.Update(ship);
                return RedirectToAction("GetAll");
            }
            return View();
        }


        public IActionResult Delete(int id)
        {
            try
            {
                shipperService.Delete(id);
                return RedirectToAction("GetAll");
            }
            catch //(System.Exception)
            {
                ModelState.AddModelError("", "this category is in use");
                return View("Update");
            }
        
        }














    }
}
