using ITech_Project.Models;
using ITech_Project.Service;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ITech_Project.Controllers
{
    public class OrderController : Controller
    {
        public IOrderService OrderServices { get; }

        public OrderController(IOrderService _ordRepo)
        {
            OrderServices = _ordRepo;
        }


        public IActionResult GetAll()
        {
            //ViewData["Cust"] = CustomerServices.GetAll();
            //ViewData["Pay"] = PaymentServices.GetAll();
            //ViewData["Ship"] = ShipperServices.GetAll();

            return View( OrderServices.GetAll());
        }

        
        public IActionResult GetById([FromRoute] int id)
        {
            return View(OrderServices.GetById(id));
        }

        
        [HttpGet]
        public IActionResult Create()
        {
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
           
            return View(neword);//html
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            
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
           
            return View(newOrder);
        }


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
