using ITech_Project.Models;
using ITech_Project.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using ITech_Project.pagination;

namespace ITech_Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService ProductRepo;

        public ProductController(IProductService productRepo)
        {
            ProductRepo = productRepo;
        }

        public IActionResult Filter(string searchstring)
        {
            var allproducts = ProductRepo.GetAll();
            if (!string.IsNullOrEmpty(searchstring))
            {
                var filterresult = allproducts.Where(n => n.Name.ToLower().Contains(searchstring.ToLower())
                 || n.Description.ToLower().Contains(searchstring.ToLower())).ToList();
                return View("GetAll", filterresult);
            }
            return View("GetAll", allproducts);

        }

        public IActionResult GetAll(int pg = 1)
        {
            var products = ProductRepo.GetAll();
            const int pageSize = 8;
            if (pg < 1)
                pg = 1;
            int recsCount = products.Count();
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = products.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;
            return View(data);

        }

        public IActionResult GetById([FromRoute] int id)
        {
            var product = ProductRepo.GetById(id);
            //if (product == null)
            //    return Content("Product Not Found");
            return View(product);
        }

        [HttpGet]
        [Authorize(Roles = "Supplier")]
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

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Update([FromRoute] int id)
        {
            var product = ProductRepo.GetById(id);
            if (product == null)
                return Content("Product Not Found");
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductRepo.Update(product);
                return RedirectToAction("index", "home");
            }
            return View(product);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete([FromRoute] int id)
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
                ModelState.AddModelError("", "this product is in use");
                return View("Update");
            }
        }

    }
}
