using ShopingCart.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart.Core.Interface
{
    public interface ICartRepository
    {
        Task<IEnumerable<CartItem>> GetAllCartItemsAsync();
        Task<CartItem> GetCartItemByIdAsync(int id);
        Task AddCartItemAsync(CartItem CartItem);
        Task UpdateCartItemAsync(CartItem CartItem);
        Task DeleteCartItemAsync(int id);
    }
}
