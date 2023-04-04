using EcommerceWithAngular.web.Models;

namespace EcommerceWithAngular.web.Services.Repository
{
    public interface ICartItem
    {
        IEnumerable<ICartItem> GetCartItems();
        ICartItem GetCartItem(int id);

        void insert(CartItem cartItem);
        void update(CartItem cartItem);
        void delete(int id);
        void Count();
        void save();
    }
}
