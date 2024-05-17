namespace LuxyGaming.Models
{
    public class Games:Base
    {
        public required string Name { get; set; }
        public required string  ImageUrl { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public bool IsTrend { get; set; }
        public bool IsMostPlayed { get; set; }
        public  Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}
