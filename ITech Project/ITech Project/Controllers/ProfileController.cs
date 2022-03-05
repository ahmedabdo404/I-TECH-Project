using Microsoft.AspNetCore.Mvc;
using ITech_Project.ViewModels;
using Microsoft.AspNetCore.Identity;
using ITech_Project.Models;
using System.Linq;
using System.Security.Claims;

namespace ITech_Project.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly Db _Context;

        public ProfileController(UserManager<IdentityUser> _userManager,
            SignInManager<IdentityUser> _signInManager, Db context)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            _Context = context;
        }
        [Route("Profile")]
        public IActionResult Profile()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userRole = User.FindFirstValue(ClaimTypes.Role);
            var currentUser = _Context.Users.Where(x => x.Id == userId).FirstOrDefault();
            ViewBag.UserInfo = currentUser;
            if (userRole == "Customer")
            {
                Customer customer = _Context.Customers.Where(x => x.FirstName == currentUser.UserName).FirstOrDefault();
                return View(customer);
            }
            else if (userRole == "Supplier")
            {
                Supplier supplier = _Context.Suppliers.Where(x => x.ContactFName == currentUser.UserName).FirstOrDefault();
                return View(supplier);

            }
            return View();
        }


    }
}

