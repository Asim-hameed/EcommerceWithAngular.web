using EcommerceWithAngular.web.Models;

namespace EcommerceWithAngular.web.Services.Repository
{
    public interface IOrder
    {
        IEnumerable<Order> GetOrders();
        Order GetOrder(int id);
        void delete(int id);
        void Count();
        void save();
    }
}
