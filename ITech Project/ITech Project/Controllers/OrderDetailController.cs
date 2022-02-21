using ITech_Project.Models;
using ITech_Project.Service;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ITech_Project.Controllers
{
    public class OrderDetailController : Controller
    {
        public IOrderDetailService OrderDetailServices { get; }
<<<<<<< HEAD
        public IOrderService OrderServices { get; }
        public IProductService ProductServices { get; }

        public OrderDetailController(IOrderDetailService _ordDetRepo, IOrderService _ordRepo, IProductService _prdRepo)
=======
        public OrderDetailController(IOrderDetailService _ordRepo, IProductService productRepo)
>>>>>>> 4b3f6483b35d98a4f1281820b598e908ee893e2f
        {
            OrderDetailServices = _ordDetRepo;
            OrderServices = _ordRepo;
            ProductServices = _prdRepo;
        }


        public IActionResult GetAll()
        {
            //ViewData["Ord"] = OrderServices.GetAll();
            //ViewData["Cust"] = CustomerServices.GetAll();
            return View(OrderDetailServices.GetAll());
        }

       
        public IActionResult GetById([FromRoute] int id)
        {
            //ViewData["Ord"] = OrderServices.GetAll();
            //ViewData["Cust"] = CustomerServices.GetAll();
            return View(OrderDetailServices.GetById(id));
        }

        
        [HttpGet]
        public IActionResult Create()
        {
            //ViewData["Ord"] = OrderServices.GetAll();
            //ViewData["Cust"] = CustomerServices.GetAll();
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
            //ViewData["Ord"] = OrderServices.GetAll();
            //ViewData["Cust"] = CustomerServices.GetAll();
            return View(neword);//html
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            //ViewData["Ord"] = OrderServices.GetAll();
            //ViewData["Cust"] = CustomerServices.GetAll();
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
            //ViewData["Ord"] = OrderServices.GetAll();
            //ViewData["Cust"] = CustomerServices.GetAll();
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
