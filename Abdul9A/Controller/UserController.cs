using Microsoft.AspNetCore.Mvc;

namespace Abdul9A.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
