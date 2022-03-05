using ITech_Project.Models;
using ITech_Project.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ITech_Project.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierService supplier;

        public SupplierController(ISupplierService supplier)
        {
            this.supplier = supplier;
        }


        [Authorize(Roles = "Admin")]
        public IActionResult GetAll()
        {
            return View(supplier.GetAll());
        }

        //[Authorize(Roles = "Supplier")]
        public IActionResult GetById(int id)
        {
            return View(supplier.GetById(id));
        }

        //[Authorize(Roles = "Supplier")]
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
                return RedirectToAction("index", "home");
            }
            return View(sup);
        }


        [HttpGet]
        [Authorize(Roles = "Supplier")]
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
                return RedirectToAction("index", "home");
            }
            return View();
        }

        [Authorize(Roles = "Admin")]
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
