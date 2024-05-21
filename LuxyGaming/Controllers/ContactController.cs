using LuxyGaming.Models;
using LuxyGaming.Models.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace LuxyGaming.Controllers
{
    public class ContactController : Controller
    {
        private readonly LuxyDbContext _dbContext;

        public ContactController(LuxyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(_dbContext.Contacts.FirstOrDefault());
        }
    }
}
