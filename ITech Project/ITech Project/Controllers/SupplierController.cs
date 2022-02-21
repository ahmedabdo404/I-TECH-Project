using ITech_Project.Models;
using ITech_Project.Service;
using Microsoft.AspNetCore.Mvc;

namespace ITech_Project.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierService supplier;

        public SupplierController(ISupplierService supplier)
        {
            this.supplier = supplier;
        }

        public IActionResult GetAll()
        { 
        
        return View(supplier.GetAll());
        }

        public IActionResult GetById(int id)
        { 
        return View(supplier.GetById(id));  
        }

        public IActionResult GetByName(string name)
        { 
        return View(supplier.GetByName(name));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Supplier sup)
        {
            if (ModelState.IsValid)
            { 
            supplier.Create(sup);
                return RedirectToAction("GetAll");
            }
            return View(sup);
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(supplier.GetById(id));
        }

        [HttpPost]
        public IActionResult Update(Supplier sup)
        {
            if (ModelState.IsValid)
            { 
            supplier.Update(sup);
                return RedirectToAction("GetAll");
            }
            return View();        
        }


        public IActionResult Delete(int id)
        {
            try
            {
                supplier.Delete(id);
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
