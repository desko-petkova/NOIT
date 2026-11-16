using ASP_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC.Controllers
{
    public class RoomController : Controller
    {
        List<Room> rooms = new()
            {
               new Room(1,"A1", 28, 3, false),
               new Room(2, "K3", 16, 1, true),
               new Room(3, "Physics",28,2,false)
            };
        public IActionResult Index()
        {
            
            return View(rooms);
        }



    }
}
