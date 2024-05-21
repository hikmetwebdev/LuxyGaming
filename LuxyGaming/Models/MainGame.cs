namespace LuxyGaming.Models
{
    public class MainGame : Base
    {
        public string Title { get; set; }=string.Empty;
        public string Summary { get; set; }=string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public double Price { get; set; }
        public double Discount { get; set; }
    }
}
