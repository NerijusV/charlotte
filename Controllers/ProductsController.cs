using Charlotte.Data;
using Charlotte.Models;
using Microsoft.AspNetCore.Mvc;

namespace Charlotte.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly MockProductRepo productRepo = new MockProductRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            var result = productRepo.GetAllProducts();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var result = productRepo.GetProductById(id);
            return Ok(result);
        }

    }
}