using LuxyGaming.Models;
using LuxyGaming.VieewModels;
using Microsoft.AspNetCore.Mvc;

namespace LuxyGaming.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index(string? category)
        {
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
            Category selectedCategory = null;

            if (category !=null)
            {
                selectedCategory = categories.FirstOrDefault(x => x.Name == category);
            }

            if (category=="All")
            {
                selectedCategory = null;
            }
            ShopVM shopVM = new ShopVM()
            {
                Categories=categories,
                Games=games,
                SelectedCategory=selectedCategory,
            };
            return View(shopVM);
        }
    }
}
