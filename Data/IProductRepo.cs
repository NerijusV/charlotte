using Charlotte.Models;

namespace Charlotte.Data {
    public interface IProductRepo
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);

    }
}