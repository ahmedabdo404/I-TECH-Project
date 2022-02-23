﻿using System;
using ITech_Project.Models;
using ITech_Project.Service;
using Microsoft.AspNetCore.Mvc;

namespace ITech_Project.Controllers
{
    public class CustomerController : Controller
    {

        private readonly ICustomerService CustomerService;
        public CustomerController(ICustomerService customerRepo)
        {
            CustomerService = customerRepo;
        }

        #region Read
        public IActionResult GetAllCustomers()
        {
            return View(CustomerService.GetAll());
        }

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
                return RedirectToAction("GetAll");
            }
            return View(customer);
        }
        #endregion

        #region Update
        [HttpGet]
        public IActionResult Update([FromRoute]int id)
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
                return RedirectToAction("GetAll");
            }
            return View(customer);
        }


        #endregion

        #region Delete

        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                CustomerService.Remove(id);
                return RedirectToAction("GetAll");
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