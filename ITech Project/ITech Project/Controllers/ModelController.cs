using ITech_Project.Models;
using ITech_Project.Service;
using Microsoft.AspNetCore.Mvc;

namespace ITech_Project.Controllers
{
    public class ModelController : Controller
    {
        private readonly IModelService ModelRepo;
        public ModelController(IModelService modelRepo)
        {
            ModelRepo = modelRepo;
        }

        public IActionResult GetAll()
        {

            return View(ModelRepo.GetAll());
        }
        public IActionResult GetById([FromRoute] int id)
        {

            return View(ModelRepo.GetById(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Model model)
        {
            if (ModelState.IsValid)
            {
                ModelRepo.Create(model);
                return RedirectToAction("GetAll");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update([FromRoute] int id)
        {
            return View(ModelRepo.GetById(id));
        }
        [HttpPost]
        public IActionResult Update(Model model)
        {
            if (ModelState.IsValid)
            {
                ModelRepo.Update(model);
                return RedirectToAction("GetAll");
            }
            return View();
        }

        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                ModelRepo.Delete(id);
                return RedirectToAction("GetAll");
            }
            catch
            {
                ModelState.AddModelError("", "this model is in use");
                return View("Update");
            }
        }

    }
}
