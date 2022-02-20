using ITech_Project.Models;
using ITech_Project.Service;
using Microsoft.AspNetCore.Mvc;

namespace ITech_Project.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService CategoryRepo;
        public CategoryController(ICategoryService categoryRepo)
        {
            CategoryRepo = categoryRepo;
        }

        public IActionResult GetAll()
        {

            return View(CategoryRepo.GetAll());
        }
        public IActionResult GetById([FromRoute] int id)
        {

            return View(CategoryRepo.GetById(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                CategoryRepo.Create(category);
                return RedirectToAction("GetAll");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update([FromRoute] int id)
        {
            return View(CategoryRepo.GetById(id));
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            if (ModelState.IsValid)
            {
                CategoryRepo.Update(category);
                return RedirectToAction("GetAll");
            }
            return View();
        }

        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                CategoryRepo.Delete(id);
                return RedirectToAction("GetAll");
            }
            catch
            {
                ModelState.AddModelError("", "this category is in use");
                return View("Update");
            }
        }

    }
}
