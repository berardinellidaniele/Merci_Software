using Microsoft.AspNetCore.Mvc;

namespace MerciSoftware.Controllers
{
    public class AccountController : Controller
    {
        [Route("/login")]  
        public IActionResult Login()
        {
            return View();
        }

        [Route("/register")]  
        public IActionResult Register()
        {
            return View("Login");  
        }
    }
}
