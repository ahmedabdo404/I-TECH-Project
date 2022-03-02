using ITech_Project.Cart;
using ITech_Project.Models;
using ITech_Project.pagination;
using ITech_Project.Service;
using ITech_Project.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
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
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> GetAllOrders(int pg = 1)
        {
            string userId = "";
            var Orders = await ordRepo.GetOrdersByUserId(userId);
            const int pageSize = 2;
            if (pg < 1)
                pg = 1;
            int recsCount =Orders.Count();
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = Orders.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;
            return View(data);
            //return View(Orders);
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
