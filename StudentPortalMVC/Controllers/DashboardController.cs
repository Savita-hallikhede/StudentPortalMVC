using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StudentPortalMVC.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

//[Authorize]

//Means:

//👉 Only logged-in users can access this controller.

//If the user is not logged in, ASP.NET Identity automatically redirects them to the Login page.