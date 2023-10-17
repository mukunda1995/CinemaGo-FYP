using Microsoft.AspNetCore.Mvc;

namespace CinemaGo.Api.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
