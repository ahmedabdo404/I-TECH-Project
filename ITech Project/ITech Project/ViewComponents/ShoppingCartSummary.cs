using ITech_Project.Cart;
using Microsoft.AspNetCore.Mvc;
namespace ITech_Project.ViewComponents
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCart();
            return View(items.Count);
        }

    }
}
