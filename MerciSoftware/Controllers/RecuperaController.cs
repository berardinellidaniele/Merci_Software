using Microsoft.AspNetCore.Mvc;

namespace MerciSoftware.Controllers
{
    public class RecuperaController : Controller
    {
        [HttpGet]
        [Route("/recupera")]
        public IActionResult Recupera()
        {
            return View();
        }

        [HttpPost]
        [Route("/recupera")]
        public IActionResult Recupera(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                ViewBag.Errore = "Inserisci un'email valida.";
                return View();
            }

            ViewBag.Successo = "Se l'email esiste nel sistema, riceverai un'email con le istruzioni per il recupero.";
            return View();
        }
    }
}
