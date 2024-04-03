using Microsoft.AspNetCore.Mvc;
using ParkingSystem.Data;
using ParkingSystem.Models;

namespace ParkingSystem.Controllers
{
    public class CarController : Controller
    {
        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            DataAccess.Cars.Add(car);
            return Redirect("/");
        }

        public IActionResult DeleteCar(string plateNumber)
        {
            var car = DataAccess.Cars.FirstOrDefault(x => x.PlateNumber == plateNumber);
            DataAccess.Cars.Remove(car);
            return Redirect("/");
        }
    }
}
