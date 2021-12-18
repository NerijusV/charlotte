namespace Charlotte.Models
{
    public class Property : BaseEntity
    {
        public PropertyType Type { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Color { get; set; }
    }

    public enum PropertyType
    {
        New,
        Top,
        Hot,
        Vegetarian,
        Vegan,
        Ingredient
    }
}