using Microsoft.AspNetCore.Mvc;
using ParkingSystem.Data;
using ParkingSystem.Models;

namespace ParkingSystem.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(DataAccess.Cars);
        }
      
    }
}
