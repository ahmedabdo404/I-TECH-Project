using ITech_Project.Models;
using ITech_Project.Service;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ITech_Project.Controllers
{
    public class OrderDetailController : Controller
    {
        public IOrderDetailService OrderDetailServices { get; }
        public OrderDetailController(IOrderDetailService _ordRepo)
        {
            OrderDetailServices = _ordRepo;
        }


        public IActionResult GetAll()
        {
            return View(OrderDetailServices.GetAll());
        }

        // Student/GetById
        //[Route("Student/id:int")]
        public IActionResult GetById([FromRoute] int id)
        {
            return View(OrderDetailServices.GetById(id));
        }

        // Student/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(OrderDetail neword)
        {
            if (ModelState.IsValid)
            {
                //save db
                OrderDetailServices.Create(neword);
                //display index view
                return RedirectToAction("GetAll");
            }

            return View(neword);//html
        }

        [HttpGet]
        public IActionResult Update(int id)
        {

            OrderDetail ord = OrderDetailServices.GetById(id);
            return View(ord);
        }
        [HttpPost]
        public IActionResult Update(OrderDetail newOrder)
        {
            if (ModelState.IsValid)
            {
                OrderDetailServices.Update(newOrder);
                return RedirectToAction("GetAll");
            }

            return View(newOrder);
        }


        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                OrderDetailServices.Delete(id);
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
