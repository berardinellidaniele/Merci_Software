using Microsoft.AspNetCore.Mvc;

namespace MerciSoftware.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
