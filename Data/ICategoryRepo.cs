using Charlotte.Models;

namespace Charlotte.Data {
    public interface ICategoryRepo
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int id);
    }
}