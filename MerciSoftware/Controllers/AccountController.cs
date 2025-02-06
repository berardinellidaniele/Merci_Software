using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MerciSoftware.Models;

namespace MerciSoftware.Controllers
{
    public class AccountController : Controller
    {
        private readonly Database _database;

        public AccountController(Database database)
        {
            _database = database;
        }

        [HttpGet]
        [Route("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("/login")]
        public IActionResult Login(string email, string password)
        {
            var funzionario = _database.VerificaCredenzialiFunzionario(email, password);

            if(funzionario != null)
            {
                HttpContext.Session.SetString("FunzionarioLoggato", funzionario.Nome);
                HttpContext.Session.SetInt32("FunzionarioID", funzionario.ID_Funzionario);

                return RedirectToAction("Index", "Home"); 
            }

            ViewBag.Errore = "Email o password errate";
            return View();
        }


        [HttpGet]
        [Route("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); 
            return RedirectToAction("Login");
        }
    }
}
