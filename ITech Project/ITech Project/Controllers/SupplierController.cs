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

        [Route("suppliers")]
        public IActionResult GetAll()
        {

            return View(supplier.GetAll());
        }

        [Authorize(Roles = "Supplier")]
        [Route("suplier/{id}")]
        public IActionResult GetById(int id)
        {
            return View(supplier.GetById(id));
        }
        [Authorize(Roles = "Supplier")]

        public IActionResult GetByName(string name)
        {
            return View(supplier.GetByName(name));
        }

        [HttpGet]
        [Route("createsupplier")]
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
        [Authorize(Roles = "Supplier")]
        [Route("editsupplier/{id}")]
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

        [Authorize(Roles = "Admin")]
        [Route("deletesupplier/{id}")]
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
