using ITech_Project.Models;
using ITech_Project.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ITech_Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService ProductRepo;
        private readonly ISupplierService SupplierRepo;

        public ProductController(IProductService productRepo, ISupplierService supplierRepo)
        {
            ProductRepo = productRepo;
            SupplierRepo = supplierRepo;
        }

        public IActionResult GetAll()
        {
            ViewData["supplier"] = SupplierRepo.GetAll();
            return View(ProductRepo.GetAll());
        }
        public IActionResult GetById([FromRoute]int id)
        {
            ViewData["supplier"] = SupplierRepo.GetAll();
            return View(ProductRepo.GetById(id));
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewData["supplier"] = SupplierRepo.GetAll();
            return View();
        }


        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductRepo.Create(product);
                return RedirectToAction("GetAll");
            }
            ViewData["supplier"] = SupplierRepo.GetAll();
            return View();
        }



        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Update([FromRoute] int id)
        {
            return View(ProductRepo.GetById(id));
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductRepo.Update(product);
                return RedirectToAction("GetAll");
            }
            ViewData["supplier"] = SupplierRepo.GetAll();
            return View();
        }


        [Authorize(Roles = "Admin")]
        public IActionResult Delete([FromRoute]int id)
        {
            try
            {
                ProductRepo.Delete(id);
                return RedirectToAction("GetAll");
            }
            catch
            {
                ModelState.AddModelError("","this product is in use");
                return View("Update");
            }
        }

    }
}
