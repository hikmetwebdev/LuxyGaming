using LuxyGaming.Models;

namespace LuxyGaming.VieewModels
{
    public class HomeVM
    {
        public MainGame? MainGame { get; set; }
        public List<Category>? Categories { get; set; }
        public List<Games>? TrendGames { get; set; }
        public List<Games>? MostPlayedGames { get; set; }
    }
}
 