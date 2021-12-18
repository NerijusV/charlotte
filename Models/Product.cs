namespace Charlotte.Models
{
    public class Product : BaseEntity
    {
        public int Number { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public int CategoryId { get; set; }
        public double OldPrice { get; set; }
        public double Price { get; set; }
        public bool Active { get; set; }
    }
}