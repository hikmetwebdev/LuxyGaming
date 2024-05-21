using LuxyGaming.Models;

namespace LuxyGaming.VieewModels
{
    public class ProdcutDetailVM
    {
        public Games? GameDetail { get; set; }
        public List<Games>? RelatedGames { get; set; }
        public List<Category>? Categories { get; set; }
    } 
}
