using Microsoft.AspNetCore.Mvc;
using ITech_Project.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using System.Net.Mail;
using System.Security.Claims;


namespace ITech_Project.Controllers
{
    public class AccountController : Controller
    {
        UserManager<IdentityUser> userManager;
        SignInManager<IdentityUser> signInManager;
        ILogger<IdentityUser> logger;



        #region Injection
        public AccountController(UserManager<IdentityUser> _userManager,
            SignInManager<IdentityUser> _signInManager, ILogger<IdentityUser> _logger)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            logger = _logger;
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
                    //Creating Cookie from [signIn Manger] => Sign in, Sign out, Check Cookie
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

        #region Login

        [HttpGet]
        public IActionResult Login(string ReturnUrl = "~/Instructor/Index")
        {
            ViewData["RedirectURL"] = ReturnUrl;
            return View();
        }


        //Check create cookie
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel LoginUser, string ReturnUrl = "~/Instructor/Index")
        {
            if (ModelState.IsValid == true)
            {
                IdentityUser user = await userManager.FindByEmailAsync(LoginUser.Email);
                if (user != null)
                {
                   Microsoft.AspNetCore.Identity.SignInResult Result = await signInManager.PasswordSignInAsync(user, LoginUser.Password, LoginUser.RememberMe, false);
                   if(Result.Succeeded == true)
                    {
                        return LocalRedirect(ReturnUrl);
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


        #endregion

        #region Logout

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        #endregion

        #region Forget Password

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        //&& await userManager.IsEmailConfirmedAsync(user)

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel userMail)
        {
            if (ModelState.IsValid)
            {
                //Generate Password Reset Token
                var user = await userManager.FindByEmailAsync(userMail.Email);

                if (user != null)
                {
                    var token = await userManager.GeneratePasswordResetTokenAsync(user);

                    //Build Password Reset Link [URL] TO Action and Controller

                    //var PasswordResetLink = Url.Action("ResetPassword", "Account", new { email = userMail.Email, token = token },
                    //    Request.Scheme);

                    var PasswordResetLink = $"https://localhost:{44302}/Account/ResetPassword?email={userMail.Email}&token={token}";

                    //Request.scheme => it generates the request scheme and it's required to generate the full absolute url

                    //Log Password Reset Link
                    logger.Log(LogLevel.Warning, PasswordResetLink);


                    return View("ForgetPasswordConfirmation");
                }
                return View("ForgetPasswordConfirmation");
            }
            return View(userMail);
        }
        //public async Task<IActionResult> ForgetPassword(string UserMail)
        //{

        //        if (!ModelState.IsValid)
        //            return View(UserMail);

        //        var user = await userManager.FindByEmailAsync(UserMail);
        //        if (user == null)
        //            return RedirectToAction("ForgotPasswordConfirmation");

        //        var token = await userManager.GeneratePasswordResetTokenAsync(user);
        //        var link = Url.Action("ResetPassword", "Account", new { token, email = user.Email }, Request.Scheme);

        //        EmailHelper emailHelper = new EmailHelper();
        //        bool emailResponse = emailHelper.SendEmailPasswordReset(user.Email, link);

        //        if (emailResponse)
        //            return RedirectToAction("ForgotPasswordConfirmation");
        //        else
        //        {
        //            // log email failed 
        //        }
        //        return View(UserMail);

        //}
        #endregion

        #region Sign Up Admin


        [HttpGet]
        public IActionResult SignUpAdmin()
        {
            return View();
        }


        //Saving data in Database
        [HttpPost]
        public async Task<IActionResult> SignUpAdmin(SignUpViewModel newAccount)
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
                    //Add to Admin Role
                    IdentityResult role = await userManager.AddToRoleAsync(user, "Admin");
                    if (role.Succeeded)
                    {
                        return LocalRedirect(ReturnUrl);
                    }
                    ModelState.AddModelError("", "No role found");

                    //Creating Cookie from [signIn Manger] => Sign in, Sign out, Check Cookie
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
