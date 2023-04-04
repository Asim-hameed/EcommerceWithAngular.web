using EcommerceWithAngular.web.Models;

namespace EcommerceWithAngular.web.Services.Repository
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomer(int id);

        void insert(Customer customer);
        void update(Customer customer);
        void delete(int id);
        void save();
    }
}
