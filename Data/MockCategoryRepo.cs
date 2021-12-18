using Charlotte.Models;
using System;

namespace Charlotte.Data
{
    public class MockCategoryRepo : ICategoryRepo
    {
        public IEnumerable<Category> GetAllCategories()
        {
            var result = new List<Category>
            {
                new Category { Id = 1, Title = "Suši", Icon="sushi", Active = true},
                new Category { Id = 2, Title = "Rinkiniai", Icon="sushi", Active = true},
                new Category { Id = 3, Title = "Padėklai", Icon="sushi", Active = true},
                new Category { Id = 4, Title = "Apple Maki", Icon="sushi", Active = true},
            };
            return result;
        }
        public Category GetCategoryById(int id)
        {
            return new Category { Id = 1, Title = "Suši", Icon = "sushi", Active = true };
        }
    }
}