using Microsoft.AspNetCore.Mvc;
using ITech_Project.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace ITech_Project.Controllers
{
    public class AccountController : Controller
    {
        UserManager<IdentityUser> userManager;
        SignInManager<IdentityUser> signInManager;


        #region Injection
        public AccountController(UserManager<IdentityUser> _userManager, SignInManager<IdentityUser> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }
        #endregion

        #region Sign UP

        //To open an empty page
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }


        //Saving data in Database
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel newAccount)
        {
            if (ModelState.IsValid == true)
            {
                IdentityUser user = new IdentityUser();

                user.UserName = newAccount.UserName;
                user.Email = newAccount.Email;

                //Saving user and creating cookie
                IdentityResult Result = await userManager.CreateAsync(user, newAccount.Password);
                if (Result.Succeeded == true)
                {
                    //Creating Cookie from [signIn Manger] => sign in, sign out, Check Cookie
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("");
                }
                else
                {
                    foreach (var error in Result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(newAccount);
        }


        #endregion
    }
}
