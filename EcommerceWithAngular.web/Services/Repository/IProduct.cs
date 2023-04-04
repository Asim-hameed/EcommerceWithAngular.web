using EcommerceWithAngular.web.Models;

namespace EcommerceWithAngular.web.Services.Repository
{
    public interface IProduct
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);

        void insert(Product product);
        void update(Product product);
        void delete(int id);
        void Count();
        void save();
    }
}
