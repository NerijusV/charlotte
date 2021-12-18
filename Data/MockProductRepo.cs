using Charlotte.Models;
using System;

namespace Charlotte.Data
{
    public class MockProductRepo : IProductRepo
    {
        public IEnumerable<Product> GetAllProducts()
        {
            var result = new List<Product>
            {
                new Product { Id = 1, Number = 1, Title = "Avocado Maki", Description = "Ryžiai, avokadai, dumblio lapas", Summary = "8 vnt.", CategoryId = 1, OldPrice = 3.49, Price = 2.99, Active = true},
                new Product { Id = 2, Number = 2, Title = "Mango Maki", Description = "Ryžiai, mango, dumblio lapas", Summary = "8 vnt.", CategoryId = 1, OldPrice = 3.49, Price = 2.99, Active = true},
                new Product { Id = 3, Number = 3, Title = "Pear Maki", Description = "Ryžiai, kriaušė, dumblio lapas", Summary = "8 vnt.", CategoryId = 1, OldPrice = 3.49, Price = 2.99, Active = true},
                new Product { Id = 4, Number = 4, Title = "Apple Maki", Description = "Ryžiai, ovuoliai, dumblio lapas", Summary = "8 vnt.", CategoryId = 1, OldPrice = 3.49, Price = 2.99, Active = true},
            };
            return result;
        }
        public Product GetProductById(int id)
        {
            return new Product
            {
                Id = 1,
                Number = 1,
                Title = "Avocado Maki",
                Description = "Ryžiai, avokadai, dumblio lapas",
                Summary = "8 vnt.",
                CategoryId = 1,
                OldPrice = 3.49,
                Price = 2.99,
                Active = true
            };
        }
    }
}