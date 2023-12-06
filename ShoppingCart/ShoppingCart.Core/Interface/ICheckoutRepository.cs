using ShopingCart.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart.Core.Interface
{
    public interface ICheckoutRepository
    {
        Task<bool> CheckOutProductAsync(int id);

        Task<bool> CheckOutCartAsync(List<CartItem> cartItems);
    }
}
