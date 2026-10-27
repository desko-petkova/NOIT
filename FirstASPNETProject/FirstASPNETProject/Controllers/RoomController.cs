using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
