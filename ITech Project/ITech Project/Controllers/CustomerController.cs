using System;
using ITech_Project.Models;
using ITech_Project.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ITech_Project.Controllers
{
    public class CustomerController : Controller
    {

        private readonly ICustomerService CustomerService;
        public CustomerController(ICustomerService customerservice)
        {
            CustomerService = customerservice;
        }
        #region Read

        [Authorize(Roles = "Admin")]
        public IActionResult GetAllCustomers()
        {
            return View(CustomerService.GetAll());
        }

        [Authorize(Roles = "Customer, Admin")]
        public IActionResult GetById(int id)
        {
            return View(CustomerService.GetById(id));
        }
        #endregion

        #region Create

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {

            if (ModelState.IsValid)
            {
                CustomerService.Create(customer);
                return RedirectToAction("Index", "Home");
            }
            return View(customer);
        }
        #endregion

        #region Update

        [HttpGet]
        [Authorize(Roles = "Customer")]
        public IActionResult Update([FromRoute] int id)
        {
            Customer customer = CustomerService.GetById(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Update(Customer customer)
        {
            if (ModelState.IsValid)
            {
                CustomerService.Update(customer);
                return RedirectToAction("index", "home");
            }
            return View(customer);
        }


        #endregion

        #region Delete


        [Authorize(Roles = "Admin")]
        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                CustomerService.Remove(id);
                return RedirectToAction("GetAllCustomers");
            }
            catch (Exception exception)
            {
                ModelState.AddModelError("", exception.InnerException.Message);
                return View("Update");
            }
        }
        #endregion

    }
}
