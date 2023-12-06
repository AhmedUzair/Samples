using ShopingCart.Core.Entities;
using ShopingCart.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Persistance.Repositories
{
    public class CheckoutRepository : ICheckoutRepository
    {
        public Task<bool> CheckOutCartAsync(List<CartItem> cartItems)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckOutProductAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
