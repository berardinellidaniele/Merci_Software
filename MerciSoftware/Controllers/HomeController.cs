using MerciSoftware.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MerciSoftware.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Database _database;

        public HomeController(ILogger<HomeController> logger, Database database)
        {
            _logger = logger;
            _database = database;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Passeggeri()
        {
            var passeggeri = _database.GetAllPasseggeri();
            return View(passeggeri);
        }

        [HttpPost]
        public IActionResult AggiungiPasseggero(Passeggero nuovoPasseggero)
        {
            if (nuovoPasseggero == null)
            {
                ViewBag.Errore = "Dati non validi.";
                return RedirectToAction("Passeggeri");
            }

            try
            {
                _database.AggiungiPasseggero(nuovoPasseggero);
                ViewBag.Successo = "Passeggero aggiunto con successo!";
            }
            catch (Exception ex)
            {
                ViewBag.Errore = "Errore durante l'aggiunta del passeggero: " + ex.Message;
            }

            return RedirectToAction("Passeggeri");
        }


        public IActionResult Controlli()
        {
            var controlli = _database.GetAllControlli();
            var puntiControllo = _database.GetAllPuntiControllo(); 
            var addetti = _database.GetAllAddetti();
            var passeggeri = _database.GetAllPasseggeri();

            return View(Tuple.Create(controlli, puntiControllo, addetti, passeggeri)); 
        }


        [HttpPost]
        public IActionResult ModificaControllo(Controllo controllo)
        {
            if (controllo == null)
            {
                ViewBag.Errore = "Dati non validi.";
                return RedirectToAction("Controlli");
            }

            try
            {
                _database.ModificaControllo(controllo);
                ViewBag.Successo = "Controllo aggiornato con successo!";
            }
            catch (Exception ex)
            {
                ViewBag.Errore = "Errore durante la modifica del controllo: " + ex.Message;
            }

            return RedirectToAction("Controlli");
        }


        [HttpPost]
        public IActionResult AggiungiMerce(Merce nuovaMerce)
        {
            if (nuovaMerce == null)
            {
                ViewBag.Errore = "Dati non validi.";
                return RedirectToAction("Merci");
            }

            try
            {
                _database.AggiungiMerce(nuovaMerce);
                ViewBag.Successo = "Merce aggiunto con successo!";
            }
            catch (Exception ex)
            {
                ViewBag.Errore = "Errore durante l'aggiunta della merce: " + ex.Message;
            }

            return RedirectToAction("Merci");
        }

        [HttpPost]
        public IActionResult AggiungiSequestroMerce(SequestroMerce nuovoSequestro)
        {
            if (nuovoSequestro == null)
            {
                ViewBag.Errore = "Dati non validi.";
                return RedirectToAction("Merci");
            }

            try
            {
                _database.AggiungiSequestro(nuovoSequestro);
                ViewBag.Successo = "Sequestro registrato con successo!";
            }
            catch (Exception ex)
            {
                ViewBag.Errore = "Errore durante la segnalazione del sequestro: " + ex.Message;
            }

            return RedirectToAction("Merci");
        }


        [HttpPost]
        public IActionResult AggiungiSegnalazione(Segnalazione nuovaSegnalazione)
        {
            
            if (nuovaSegnalazione == null)
            {
                ViewBag.Errore = "Dati non validi.";
                return RedirectToAction("Segnalazioni");
            }

            try
            {
                _database.AggiungiSegnalazione(nuovaSegnalazione);
                ViewBag.Successo = "Segnalazione aggiunta con successo!";
            }
            catch (Exception ex)
            {
                ViewBag.Errore = "Errore durante l'aggiunta della segnalazione: " + ex.Message;
            }

            return RedirectToAction("Segnalazioni");


        }

        public IActionResult Segnalazioni()
        {
            var segnalazioni = _database.GetAllSegnalazioni();
            return View(segnalazioni);
        }

        public IActionResult Merci()
        {
            var merci = _database.GetAllMerci();  
            var sequestri = _database.GetAllSequestriMerce();

            return View(Tuple.Create(merci, sequestri)); 
        }


        public IActionResult Privacy()
        {
            return View();
        }
    }
}