using EcommerceWithAngular.web.Models;

namespace EcommerceWithAngular.web.Services.Repository
{
    public interface IOrderLine
    {
        IEnumerable<OrderLine> GetOrderLine();
        OrderLine GetOrderLine(int id);

        void insert(OrderLine orderLine);
        void update(OrderLine orderLine);
        void Count();
        void save();
    }
}
