using Microsoft.AspNetCore.Mvc;

namespace UserManagementApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Users");
        }
    }
}
