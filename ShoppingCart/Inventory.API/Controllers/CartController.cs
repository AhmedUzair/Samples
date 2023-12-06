using Microsoft.AspNetCore.Mvc;
using ShopingCart.Core.Entities;
using ShopingCart.Core.Interface;
using ShoppingCart.Core.Attribtues;

namespace Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Auth]
    public class CartController : ControllerBase
    {
        private readonly ICartRepository _cartRepository;

        public CartController(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        [HttpPost]
        public async Task<IActionResult> GetCartItems()
        {
            try
            {
                var items = await _cartRepository.GetAllCartItemsAsync();
                return Ok(items);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCartItems(int id)
        {
            try
            {
                var product = await _cartRepository.GetCartItemByIdAsync(id);
                if (product == null) return NotFound();

                return Ok(product);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> CheckOut(CartItem item)
        {
            try
            {
                await _cartRepository.AddCartItemAsync(item);
                return CreatedAtAction(nameof(GetCartItems), new { id = item.Id }, item);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
