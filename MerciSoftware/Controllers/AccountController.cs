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

        public IActionResult Register(string nome, string email)
        {
            bool registrationSuccess = true; 

            if (registrationSuccess)
            {
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false, message = "Errore durante la registrazione" });
            }
        }


    }
}