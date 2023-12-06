using ShopingCart.Core.Entities;
using ShopingCart.Core.Interface;

namespace ShoppingCart.Persistance.Repositories
{
    public class CartRepository : ICartRepository
    {
        public Task AddCartItemAsync(CartItem CartItem)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCartItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CartItem>> GetAllCartItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CartItem> GetCartItemByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCartItemAsync(CartItem CartItem)
        {
            throw new NotImplementedException();
        }
    }
}
