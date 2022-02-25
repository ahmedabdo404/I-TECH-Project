using ITech_Project.Models;
using ITech_Project.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ITech_Project.Controllers
{
    public class OrderController : Controller
    {
        public IOrderService OrderServices { get; }
        public ICustomerService CustomerServices { get; }

        public OrderController(IOrderService _ordRepo,
            ICustomerService _custRepo)
        {
            OrderServices = _ordRepo;
            CustomerServices = _custRepo;
        }


        public IActionResult GetAll()
        {
            ViewData["Cust"] = CustomerServices.GetAll();
            return View(OrderServices.GetAll());
        }

        
        public IActionResult GetById([FromRoute] int id)
        {
            ViewData["Cust"] = CustomerServices.GetAll();
            return View(OrderServices.GetById(id));
        }

        
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Cust"] = CustomerServices.GetAll();
            return View();
        }


        [HttpPost]
        public IActionResult Create(Order neword)
        {
            if (ModelState.IsValid)
            {
                //save db
                OrderServices.Create(neword);
                //display index view
                return RedirectToAction("GetAll");
            }
            ViewData["Cust"] = CustomerServices.GetAll();
            return View(neword);//html
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewData["Cust"] = CustomerServices.GetAll();
            Order ord = OrderServices.GetById(id);
            return View(ord);
        }
        [HttpPost]
        public IActionResult Update(Order newOrder)
        {
            if (ModelState.IsValid)
            {
                OrderServices.Update(newOrder);
                return RedirectToAction("GetAll");
            }
            ViewData["Cust"] = CustomerServices.GetAll();
            return View(newOrder);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                OrderServices.Delete(id);
                return RedirectToAction("GetAll");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.InnerException.Message);
                return View("Update");
            }
        }



      



    }
}
