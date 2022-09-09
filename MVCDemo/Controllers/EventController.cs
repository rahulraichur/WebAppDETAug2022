using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{ 
    public class EventController : Controller
    {
        public List<Booking> events { get; set; }
        

        public IActionResult Index()
        {
            events = new List<Booking>();
            events.Add(new Booking { Title = "MEETING", Date = DateTime.Now, Quantity = 5 });
            return View(events);
        }
    }
}
