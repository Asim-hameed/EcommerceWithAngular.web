using EcommerceWithAngular.web.Models;

namespace EcommerceWithAngular.web.Services.Repository
{
    public interface ISubCategory
    {
        IEnumerable<SubCategory> GetSubCategories();
        SubCategory GetSubCategory(int id);

        void insert(SubCategory subcategory);
        void update(SubCategory subcategory);
        void delete(int id);
        void Count();
        void save();
    }
}
