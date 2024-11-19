using Microsoft.AspNetCore.Mvc;
using RentalCars.Models;

namespace RentalCars.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Booking(int CarId)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Booking(Booking booking)
        {
            return View();
        }
        public IActionResult Confirmation(int bookingId)
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
