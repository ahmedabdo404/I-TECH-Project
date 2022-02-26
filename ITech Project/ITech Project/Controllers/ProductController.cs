using ITech_Project.Models;
using ITech_Project.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ITech_Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService ProductRepo;

        public ProductController(IProductService productRepo)
        {
            ProductRepo = productRepo;
        }

        public IActionResult GetAll()
        {
            var products = ProductRepo.GetAll();
            return View(products);
        }
        public IActionResult GetById([FromRoute]int id)
        {
            var product = ProductRepo.GetById(id);
            if (product == null)
                return Content("Product Not Found");
            return View(product);
        }

        [HttpGet]
        //[Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
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
            return View(product);
        }

        //[HttpGet]
        //[Authorize(Roles = "Admin")]
        public IActionResult Update([FromRoute] int id)
        {
            var product = ProductRepo.GetById(id);
            if(product == null) 
                return Content("Product Not Found");
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductRepo.Update(product);
                return RedirectToAction("GetAll");
            }
            return View(product);
        }

        //[Authorize(Roles = "Admin")]
        public IActionResult Delete([FromRoute]int id)
        {
            var product = ProductRepo.GetById(id);
            if (product == null)
                return Content("Product Not Found");
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
