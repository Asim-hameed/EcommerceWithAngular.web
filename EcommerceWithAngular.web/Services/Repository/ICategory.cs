using EcommerceWithAngular.web.Models;

namespace EcommerceWithAngular.web.Services.Repository
{
    public interface ICategory
    {
        IEnumerable<Category> GetCategories();
        Category GetCategory(int id);

        void insert(Category category);
        void update(Category category);
        void delete(int id);
        void Count();
        void save();
    }
}
