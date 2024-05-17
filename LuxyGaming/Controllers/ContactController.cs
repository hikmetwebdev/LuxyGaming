using LuxyGaming.Models;
using Microsoft.AspNetCore.Mvc;

namespace LuxyGaming.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            Contact contact = new("Contact Us", "SAY HELLO", "Əlaqə üçün aşağıdakı məlumatları doldurun", "Nasimi disctrict", "+994554770076", "hikmetwebdev@gmail.com");
            return View(contact);
        }
    }
}
