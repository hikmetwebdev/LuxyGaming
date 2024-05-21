using LuxyGaming.Models;
using LuxyGaming.Models.DataAccess;
using LuxyGaming.VieewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LuxyGaming.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LuxyDbContext _dbContext;
        public HomeController(ILogger<HomeController> logger, LuxyDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
 
      
            HomeVM homeVM = new HomeVM() 
            {
                MainGame = _dbContext.MainGames.FirstOrDefault(),
                Categories= _dbContext.Categories.ToList(),
                TrendGames=_dbContext.Games.Where(x=>x.IsTrend).Take(4).ToList(),
                MostPlayedGames=_dbContext.Games.Where(x=>x.IsMostPlayed).Take(6).ToList(),
            };
            return View(homeVM);
        }

        public IActionResult Detail(int? id)
        {
            var game = _dbContext.Games.FirstOrDefault(x => x.Id == id);
            var categories = _dbContext.Categories.ToList();
            if (game == null)
            {
                return NotFound();
            }

            ProdcutDetailVM prodcutDetailVM = new ProdcutDetailVM()
            {
                GameDetail = _dbContext.Games.FirstOrDefault(x => x.Id == id),
                RelatedGames = _dbContext.Games.Where(x => x.CategoryId == game.CategoryId).ToList(),
                Categories=categories,
            };
            return View(prodcutDetailVM);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
