using LuxyGaming.Models;

namespace LuxyGaming.VieewModels
{
    public class ShopVM
    {
       public List<Category>? Categories { get; set; }
        public List<Games>? Games { get; set; } 
        public Category? SelectedCategory {  get; set; } 
    }
}
