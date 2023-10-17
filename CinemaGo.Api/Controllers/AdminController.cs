using Microsoft.AspNetCore.Mvc;

namespace CinemaGo.Api.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
