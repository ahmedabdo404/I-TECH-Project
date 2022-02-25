using Microsoft.AspNetCore.Mvc;

namespace ITech_Project.Controllers
{
    public class DashboardController : Controller
    {

        //[Route("Dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
