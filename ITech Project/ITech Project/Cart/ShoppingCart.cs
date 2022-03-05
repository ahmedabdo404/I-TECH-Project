using ITech_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITech_Project.Cart
{
    public class ShoppingCart
    {

        public Db _context;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public ShoppingCart(Db context)
        {
            _context = context;
        }

        public static ShoppingCart GEtShopCart(IServiceProvider services)
        {
            ISession Session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<Db>();

            string CartId = Session.GetString("CartId") ?? Guid.NewGuid().ToString();
            Session.SetString("CartId", CartId);
            return new ShoppingCart(context)
            {
                ShoppingCartId = CartId,
            };
        }

        public void AddItemToCart(Product product)
        {
            var ShoppingCartItem = _context.ShoppingCartItems.FirstOrDefault(n => n.product.Id == product.Id &&
            n.ShoppingCartId == ShoppingCartId);

            if (ShoppingCartItem == null)
            {
                ShoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    product = product,
                    Amount = 1

                };
                _context.ShoppingCartItems.Add(ShoppingCartItem);
            }
            else
            { ShoppingCartItem.Amount++; }
            _context.SaveChanges();
        }

        public void RemoveItemFromCart(Product product)
        {
            var ShoppingCartItem = _context.ShoppingCartItems.FirstOrDefault(n => n.product.Id == product.Id &&
          n.ShoppingCartId == ShoppingCartId);

            if (ShoppingCartItem != null)
            {
                if (ShoppingCartItem.Amount > 1)
                {
                    ShoppingCartItem.Amount--;
                }

                else
                {
                    _context.ShoppingCartItems.Remove(ShoppingCartItem);
                }
            }
            _context.SaveChanges();

        }



        public List<ShoppingCartItem> GetShoppingCart()
        {
            return ShoppingCartItems ?? _context.ShoppingCartItems.Where(f => f.ShoppingCartId ==
              ShoppingCartId).Include(n => n.product).ToList();
        }


        public double GetShoppingCartTotal() => _context.ShoppingCartItems.Where(n => n.ShoppingCartId ==
         ShoppingCartId).Select(n => (n.product.UnitPrice - n.product.Discount) * n.Amount).Sum();

        public double GetShoppingCartDiscount() => _context.ShoppingCartItems.Where(n => n.ShoppingCartId ==
         ShoppingCartId).Select(n => n.product.Discount * n.Amount).Sum();

        public async Task ClearShoppingCartAsync()
        {
            var items = await _context.ShoppingCartItems.Where(f => f.ShoppingCartId ==
              ShoppingCartId).ToListAsync();
            _context.ShoppingCartItems.RemoveRange(items);
            await _context.SaveChangesAsync();
        }

    }
}
