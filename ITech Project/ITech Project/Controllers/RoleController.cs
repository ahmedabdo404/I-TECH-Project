using Microsoft.AspNetCore.Mvc;
using ITech_Project.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Linq;

namespace ITech_Project.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {

        RoleManager<IdentityRole> RoleManager;
        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            RoleManager = roleManager;
        }

        #region Get Roles

        public IActionResult GetRoles()
        {
            List<string> Roles = RoleManager.Roles.Select(x => x.Name).ToList();
            return View(Roles);
        }
        #endregion

        #region Adding Role

        public IActionResult AddRole()
        {
            return View();
        }


        [HttpPost]
        public async Task <IActionResult> AddRole(RoleViewModel newRole)
        {
            if (ModelState.IsValid == true)
            {
                IdentityRole Role = new IdentityRole() { Name = newRole.RoleName };

                IdentityResult Result = await RoleManager.CreateAsync(Role);
                if(Result.Succeeded == true)
                {
                    return View();
                }
                else
                {
                    foreach (var error in Result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(newRole);
        }
        #endregion

        #region Removing Role

        public async Task<IActionResult> Remove(string name)
        {
            IdentityRole Role = await RoleManager.FindByNameAsync(name);
            try
            {
                await RoleManager.DeleteAsync(Role);
                return RedirectToAction("GetRoles");
            }
            catch
            {
                ModelState.AddModelError(string.Empty, "This role is already exists!");
            }
            return View("GetRoles");
        }
        #endregion
    }
}
