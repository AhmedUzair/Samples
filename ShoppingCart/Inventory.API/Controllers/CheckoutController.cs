using Microsoft.AspNetCore.Mvc;
using ShopingCart.Core.Entities;
using ShopingCart.Core.Interface;
using ShoppingCart.Core.Attribtues;

namespace Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Auth]
    public class CheckoutController : ControllerBase
    {
        private readonly ICheckoutRepository _checkoutRepository;

        public CheckoutController(ICheckoutRepository checkoutRepository)
        {
            _checkoutRepository = checkoutRepository;
        }


        [HttpPost]
        public async Task<IActionResult> CheckOut(List<CartItem> cartItems)
        {
            try
            {
                await _checkoutRepository.CheckOutCartAsync(cartItems);
                return Ok(nameof(CheckOut));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
