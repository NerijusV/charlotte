using Charlotte.Data;
using Charlotte.Models;
using Microsoft.AspNetCore.Mvc;

namespace Charlotte.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly MockCategoryRepo repo = new MockCategoryRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetAllProducts()
        {
            var result = repo.GetAllCategories();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetCategoryById(int id)
        {
            var result = repo.GetCategoryById(id);
            return Ok(result);
        }

    }
}