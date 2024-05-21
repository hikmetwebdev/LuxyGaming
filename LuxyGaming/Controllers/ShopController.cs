using LuxyGaming.Models;
using LuxyGaming.Models.DataAccess;
using LuxyGaming.VieewModels;
using Microsoft.AspNetCore.Mvc;

namespace LuxyGaming.Controllers
{
    public class ShopController : Controller
    {
        private readonly LuxyDbContext _dbContext;

        public ShopController(LuxyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index(string? category)
        {
            Category selectedCategory = null;

            if (category != null)
            {
                selectedCategory = _dbContext.Categories.FirstOrDefault(x => x.Name == category);
            }

            if (category == "All")
            {
                selectedCategory = null;
            }
            ShopVM shopVM = new ShopVM()
            {
                Categories = _dbContext.Categories.ToList(),
                Games = _dbContext.Games.ToList(),
                SelectedCategory = selectedCategory,
            };
            return View(shopVM);
        }
    }
}
