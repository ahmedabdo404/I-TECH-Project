using Microsoft.AspNetCore.Mvc;
using ITech_Project.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using System.Net.Mail;
using System.Security.Claims;
using System.Linq;

namespace ITech_Project.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;



        #region Injection
        public AccountController(UserManager<IdentityUser> _userManager,
            SignInManager<IdentityUser> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }
        #endregion

        #region Sign UP Customer

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
            if (ModelState.IsValid)
            {
                IdentityUser user = new();
                user.UserName = newAccount.UserName;
                user.Email = newAccount.Email;
                user.PhoneNumber = newAccount.Phone;

                //Saving user
                IdentityResult Result = await userManager.CreateAsync(user, newAccount.Password);
                if (Result.Succeeded)
                {
                    IdentityResult role = await userManager.AddToRoleAsync(user, "Customer");
                    if (role.Succeeded)
                    {
                        //Creating Cookie from [signIn Manger] => Sign in, Sign out, Check Cookie
                        await signInManager.SignInAsync(user, false);  //False => Per session
                        return RedirectToAction("Create", "Customer");
                    }
                    else
                    {
                        ModelState.AddModelError("", "No Supplier role is found !");
                    }
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

        #region Sign Up Supplier

        //To open an empty page
        [HttpGet]
        public IActionResult SignUpSupplier()
        {
            return View();
        }
        //Saving data in Database
        [HttpPost]
        public async Task<IActionResult> SignUpSupplier(SignUpViewModel newAccount)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new();

                user.UserName = newAccount.UserName;
                user.Email = newAccount.Email;
                user.PhoneNumber = newAccount.Phone;

                //Saving user
                IdentityResult Result = await userManager.CreateAsync(user, newAccount.Password);
                if (Result.Succeeded)
                {
                    IdentityResult role = await userManager.AddToRoleAsync(user, "Supplier");
                    if (role.Succeeded)
                    {
                        //Creating Cookie from [signIn Manger] => Sign in, Sign out, Check Cookie
                        await signInManager.SignInAsync(user, false);  //False => Per session
                        return RedirectToAction("Create", "Supplier");
                    }
                    else
                    {
                        ModelState.AddModelError("", "No Supplier role is found !");
                    }
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

        #region Sign Up Admin

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult SignUpAdmin()
        {
            return View();
        }


        //Saving data in Database
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> SignUpAdmin(SignUpViewModel newAccount)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new();
                user.UserName = newAccount.UserName;
                user.Email = newAccount.Email;
                user.PhoneNumber = newAccount.Phone;

                //Saving user and creating cookie
                IdentityResult Result = await userManager.CreateAsync(user, newAccount.Password);
                if (Result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Admin");
                    return RedirectToAction("Dashboard", "Dashboard");
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

        #region Check Email Exist

        public async Task<IActionResult> Exist(string Email)
        {
            IdentityUser user = await userManager.FindByEmailAsync(Email);
            if (user == null)
                return Json(true);
            return Json(false);
        }


        #endregion

        #region Login



        //Check create cookie

        [HttpGet]
        public async Task<IActionResult> LoginWithGoogle(string returnUrl)
        {
            LoginViewModel model = new()
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> LoginWithGoogle(LoginViewModel LoginUser, string ReturnUrl = "~/Home/index")
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByEmailAsync(LoginUser.Email);
                if (user != null)
                {
                    Microsoft.AspNetCore.Identity.SignInResult Result =
                        await signInManager.PasswordSignInAsync(user, LoginUser.Password, LoginUser.RememberMe, false);
                    if (Result.Succeeded)
                    {
                        return RedirectToAction("index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid user name or password");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Invalid user name or password");
                }
            }
            return View(LoginUser);
        }

        [HttpGet]
        public IActionResult Login(string ReturnUrl = "~/Home/index")
        {
            ViewData["ReturnUrl"] = ReturnUrl;
            if (!User.Identity.IsAuthenticated)
            {
                return View();
            }
            return RedirectToAction("index", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel LoginUser, string ReturnUrl = "~/Home/index")
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByEmailAsync(LoginUser.Email);
                if (user != null)
                {
                    Microsoft.AspNetCore.Identity.SignInResult Result =
                        await signInManager.PasswordSignInAsync(user, LoginUser.Password,
                        LoginUser.RememberMe, false);
                    if (Result.Succeeded)
                    {
                        //return LocalRedirect(ReturnUrl);
                        if (await userManager.IsInRoleAsync(user, "Admin"))
                        {
                            return RedirectToAction("Dashboard", "Dashboard");
                        }
                        else
                        {
                            if (!string.IsNullOrWhiteSpace(ReturnUrl) && Url.IsLocalUrl(ReturnUrl))
                            {
                                return Redirect(ReturnUrl);
                            }
                            else
                            {
                                return RedirectToAction("index", "Home");
                            }
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid user name or password");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Invalid user name or password");
                }
            }
            return View(LoginUser);
        }



        [AllowAnonymous]
        [HttpPost]
        public IActionResult ExternalLogin(string provider, string returnUrl)
        {
            var redirectUrl = Url.Action("ExternalLoginCallback", "Account", new { ReturnUrl = returnUrl });
            var properties = signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return new ChallengeResult(provider, properties);
        }


        [AllowAnonymous]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null, string remoteError = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            LoginViewModel loginViewModel = new LoginViewModel
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };

            if (remoteError != null)
            {
                ModelState.AddModelError(string.Empty, $"Error from external provider: {remoteError}");

                return View("Login", loginViewModel);
            }

            // Get the login information about the user from the external login provider
            var info = await signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                ModelState.AddModelError(string.Empty, "Error loading external login information.");

                return View("Login", loginViewModel);
            }

            // If the user already has a login (i.e if there is a record in AspNetUserLogins
            // table) then sign-in the user with this external login provider
            var signInResult = await signInManager.ExternalLoginSignInAsync(info.LoginProvider,
                info.ProviderKey, isPersistent: false, bypassTwoFactor: true);

            if (signInResult.Succeeded)
            {
                return LocalRedirect(returnUrl);
            }
            // If there is no record in AspNetUserLogins table, the user may not have
            // a local account
            else
            {
                // Get the email claim value
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);

                if (email != null)
                {
                    // Create a new user without password if we do not have a user already
                    var user = await userManager.FindByEmailAsync(email);

                    if (user == null)
                    {
                        user = new IdentityUser
                        {
                            UserName = info.Principal.FindFirstValue(ClaimTypes.Email),
                            Email = info.Principal.FindFirstValue(ClaimTypes.Email)
                        };

                        await userManager.CreateAsync(user);
                    }

                    // Add a login (i.e insert a row for the user in AspNetUserLogins table)
                    await userManager.AddLoginAsync(user, info);
                    await signInManager.SignInAsync(user, isPersistent: false);

                    return LocalRedirect(returnUrl);
                }

                // If we cannot find the user email we cannot continue
                ViewBag.ErrorTitle = $"Email claim not received from: {info.LoginProvider}";
                ViewBag.ErrorMessage = "Please contact support I-Tech.com";

                return View("Error");
            }
        }





        #endregion

        #region Logout

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        #endregion
    }
}