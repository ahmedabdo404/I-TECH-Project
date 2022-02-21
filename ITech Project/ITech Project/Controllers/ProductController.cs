using ITech_Project.Models;
using ITech_Project.Service;
using Microsoft.AspNetCore.Mvc;

namespace ITech_Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService ProductRepo;
        private readonly ICategoryService CategoryRepo;
        private readonly IModelService ModelRepo; 
        private readonly ISupplierService SupplierRepo;

        public ProductController(IProductService productRepo, ICategoryService categoryRepo,
            IModelService modelRepo, ISupplierService supplierRepo)
        {
            ProductRepo = productRepo;
            CategoryRepo = categoryRepo;
            ModelRepo = modelRepo;
            SupplierRepo = supplierRepo;
        }

        public IActionResult GetAll()
        {
            ViewData["category"] = CategoryRepo.GetAll();
            ViewData["model"] = ModelRepo.GetAll();
            ViewData["supplier"] = SupplierRepo.GetAll();
            return View(ProductRepo.GetAll());
        }
        public IActionResult GetById([FromRoute]int id)
        {
            ViewData["category"] = CategoryRepo.GetAll();
            ViewData["model"] = ModelRepo.GetAll();
            ViewData["supplier"] = SupplierRepo.GetAll();
            return View(ProductRepo.GetById(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["category"] = CategoryRepo.GetAll();
            ViewData["model"] = ModelRepo.GetAll();
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
            ViewData["category"] = CategoryRepo.GetAll();
            ViewData["model"] = ModelRepo.GetAll();
            ViewData["supplier"] = SupplierRepo.GetAll();
            return View();
        }

        [HttpGet]
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
            ViewData["category"] = CategoryRepo.GetAll();
            ViewData["model"] = ModelRepo.GetAll();
            ViewData["supplier"] = SupplierRepo.GetAll();
            return View();
        }

        public IActionResult Delete([FromRoute]int id)
        {
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
