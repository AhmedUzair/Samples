using Microsoft.EntityFrameworkCore;
using ShopingCart.Core.Entities;

namespace ShopingCart.Infrastructure
{
    public class ShoppingCartContext : DbContext
    {
        public ShoppingCartContext(DbContextOptions<ShoppingCartContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<CartItem> CartItems { get; set; }
    }
}
