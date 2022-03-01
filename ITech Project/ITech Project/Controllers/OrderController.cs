using ITech_Project.Cart;
using ITech_Project.Models;
using ITech_Project.Service;
using ITech_Project.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [Authorize(Roles = "Admin")]

        public IActionResult GetAll()
        {
            ViewData["Cust"] = custRepo.GetAll();
            return View(ordRepo.GetAll());
        }

        [Authorize(Roles = "Customer")]
        public IActionResult GetById([FromRoute] int id)
        {
            ViewData["Cust"] = custRepo.GetAll();
            return View(ordRepo.GetById(id));
        }

        
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Cust"] = custRepo.GetAll();
            return View();
        }


        [HttpPost]
        public IActionResult Create(Order neword)
        {
            if (ModelState.IsValid)
            {
                //save db
                ordRepo.Create(neword);
                //display index view
                return RedirectToAction("GetAll");
            }
            ViewData["Cust"] = custRepo.GetAll();
            return View(neword);//html
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewData["Cust"] = custRepo.GetAll();
            Order ord = ordRepo.GetById(id);
            return View(ord);
        }
        [HttpPost]
        public IActionResult Update(Order newOrder)
        {
            if (ModelState.IsValid)
            {
                ordRepo.Update(newOrder);
                return RedirectToAction("GetAll");
            }
            ViewData["Cust"] = custRepo.GetAll();
            return View(newOrder);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                ordRepo.Delete(id);
                return RedirectToAction("GetAll");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.InnerException.Message);
                return View("Update");
            }
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
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> GetAllOrders()
        {
            string userId = "";
            var Orders = await ordRepo.GetOrdersByUserId(userId);
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
            string userId = "";
            string userEmailAddress = "";
            await ordRepo.StoreOrder(items, userId, userEmailAddress);
            await shoppingCart.ClearShoppingCartAsync();
            return View();
        }
    }
}
