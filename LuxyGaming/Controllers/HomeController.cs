using LuxyGaming.Models;
using LuxyGaming.VieewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LuxyGaming.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            MainGame game = new("BEST GAME", "This is selected game you want","banner-image.jpg",20,15);
            List<Category> categories = new List<Category>()
            {
                new Category { Id=1, Name="Action", ImageUrl="categories-01.jpg" },
                new Category { Id=2, Name="Adventure", ImageUrl="categories-02.jpg" },
                new Category { Id=3, Name="Fighting", ImageUrl="categories-03.jpg" },
                new Category { Id=4, Name="Shooter", ImageUrl="categories-04.jpg" },
                new Category { Id=5, Name="Survival", ImageUrl="categories-05.jpg" }

            };
            List<Games> games = new List<Games>()
             {
                 new Games{Id=1, Name="Assasin creed", ImageUrl="banner-image.jpg",Price=50,Discount=20,CategoryId=1,IsTrend=true},
                 new Games{Id=1, Name="Pubg mobile", ImageUrl="top-game-02.jpg",Price=100,Discount=30,CategoryId=3,IsMostPlayed=true},
                 new Games{Id=1, Name="Apex", ImageUrl="top-game-03.jpg",Price=30,Discount=10,CategoryId=2,IsMostPlayed=true},
                 new Games{Id=1, Name="Call if duty", ImageUrl="trending-04.jpg",Price=50,Discount=20,CategoryId=3,IsTrend=true},
                 new Games{Id=1, Name="Clas of clans", ImageUrl="trending-01.jpg",Price=50,Discount=20,CategoryId=2,IsTrend=true},
                 new Games{Id=1, Name="Destiny 2", ImageUrl="trending-04.jpg",Price=40,Discount=20,CategoryId=1,IsTrend=true},
                 new Games{Id=1, Name="Bubble shooter", ImageUrl="trending-04.jpg",Price=80,Discount=20,CategoryId=1,IsMostPlayed=true},
                 new Games{Id=1, Name="Zombies", ImageUrl="top-game-05.jpg",Price=90,Discount=30,CategoryId=3,IsMostPlayed=true},
                 new Games{Id=1, Name="Red ball", ImageUrl="top-game-04.jpg",Price=60,Discount=10,CategoryId=5,IsMostPlayed=true},
                 new Games{Id=1, Name="Retro", ImageUrl="top-game-01.jpg",Price=50,Discount=10,CategoryId=1,IsMostPlayed=true},
             };
            HomeVM homeVM = new HomeVM()
            {
                MainGame = game,
                Categories= categories,
                TrendGames=games.Where(x=>x.IsTrend=true).Take(4).ToList(),
                MostPlayedGames=games.Where(x=>x.IsMostPlayed=true).Take(6).ToList(),
            };
            return View(homeVM);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
