namespace LuxyGaming.Models
{
    public class MainGame : Base
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public double? Discount { get; set; }


        public MainGame(string title, string summary,string imageUrl, double price, double discount)
        {
            Title = title;
            Summary = summary;
            ImageUrl = imageUrl;
            Price = price;
            Discount = discount;
        }
    }
}
