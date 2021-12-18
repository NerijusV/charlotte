namespace Charlotte.Models
{
    public class Category : BaseEntity
    {
        public string? Title { get; set; }
        public string Icon { get; set; }
        public bool Active { get; set; }

    }
}