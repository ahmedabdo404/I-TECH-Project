using ITech_Project.Cart;
using ITech_Project.pagination;
using ITech_Project.Service;
using ITech_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace ITech_Project.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService ordRepo;
        private readonly ICustomerService custRepo;
        private readonly IProductService proRepo;
        private readonly ShoppingCart shoppingCart;

        public OrderController(IOrderService _ordRepo, ICustomerService _custRepo,
            IProductService _proRepo, ShoppingCart _shoppingCart)
        {

            ordRepo = _ordRepo;
            custRepo = _custRepo;
            proRepo = _proRepo;
            shoppingCart = _shoppingCart;
        }


        public IActionResult Index()
        {
            var items = shoppingCart.GetShoppingCart();
            shoppingCart.ShoppingCartItems = items;

            var response = new ShoppingCartViewModel()
            {
                ShoppingCart = shoppingCart,
                ShoppingCartTotal = shoppingCart.GetShoppingCartTotal(),
                ShoppingCartDiscount = shoppingCart.GetShoppingCartDiscount()
            };
            return View(response);
        }

        public async Task<IActionResult> GetAllOrders(int pg = 1)
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userRole = User.FindFirstValue(ClaimTypes.Role);
            var Orders = await ordRepo.GetOrdersByUserIdAndRoleAsync(userId, userRole);
            const int pageSize = 3;
            if (pg < 1)
                pg = 1;
            int recsCount = Orders.Count();
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = Orders.Skip(recSkip).Take(pager.PageSize).ToList();
            ViewBag.Pager = pager;
            return View(data);
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

        [Route("ordercompleted")]
        public async Task<IActionResult> CompleteOrder([FromQuery] bool Ispaid)
        {
            if (Ispaid == true)
            {
                var items = shoppingCart.GetShoppingCart();
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                string userEmailAddress = User.FindFirstValue(ClaimTypes.Email);
                await ordRepo.StoreOrder(items, userId, userEmailAddress);
                await shoppingCart.ClearShoppingCartAsync();
                return View();
            }
            else
            {
                return RedirectToAction("error", "Home");
            }
        }
    }
}


