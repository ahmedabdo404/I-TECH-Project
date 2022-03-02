using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ITech_Project.Controllers
{
    public class DashboardController : Controller
    {
        [Authorize(Roles = "Admin")]
        [Route("Dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
