﻿using ITech_Project.Cart;
using ITech_Project.Models;
using ITech_Project.Service;
using ITech_Project.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ITech_Project.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService ordRepo;
        private readonly ICustomerService custRepo;
        private readonly IProductService proRepo;
        private readonly ShoppingCart shoppingCart;

        public OrderController(IOrderService _ordRepo,ICustomerService _custRepo,
            IProductService _proRepo, ShoppingCart _shoppingCart)
        {
            
            ordRepo = _ordRepo;
            custRepo = _custRepo;
            proRepo = _proRepo;
            shoppingCart = _shoppingCart;
        }

        //---------------------------//
        public IActionResult Index()
        {
            var items = shoppingCart.GetShoppingCart();
            shoppingCart.ShoppingCartItems=items;

            var response = new ShoppingCartViewModel()
            {
                ShoppingCart = shoppingCart,
                ShoppingCartTotal = shoppingCart.GetShoppingCartTotal()

            };
            return View(response);
        }
        //[Authorize(Roles = "Admin")]

        public async Task<IActionResult> GetAllOrders()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userRole = User.FindFirstValue(ClaimTypes.Role);

            var Orders = await ordRepo.GetOrdersByUserIdAndRoleAsync(userId, userRole);
            return View(Orders);
        }

        public IActionResult AddToShoppingCart(int id)
        { 
        var item = proRepo.GetById(id);

            if (item != null)
            { 
            shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveItemFromCart(int id)
        {
            var item = proRepo.GetById(id);

            if (item != null)
            {
                shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction("Index");
        }

        public async Task <IActionResult> CompleteOrder()
        {
            var items = shoppingCart.GetShoppingCart();
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userEmailAddress = User.FindFirstValue(ClaimTypes.Email);
            await ordRepo.StoreOrder(items, userId, userEmailAddress);
            await shoppingCart.ClearShoppingCartAsync();
            return View();
        }
    }
}
