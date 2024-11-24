using Microsoft.AspNetCore.Mvc;
using RentalCars.Models;

namespace RentalCars.Controllers
{
    public class BookingController : Controller
    {
        [HttpGet]
        public IActionResult Create(int CarId)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Booking booking)
        {
            return View();
        }
        public IActionResult Return()
        {
            return View();
        }
        public IActionResult History(int userId)
        {
            return View();
        }
    }
}
