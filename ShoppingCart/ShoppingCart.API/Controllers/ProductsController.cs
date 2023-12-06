using Microsoft.AspNetCore.Mvc;
using ShopingCart.Core.Entities;
using ShopingCart.Core.Interface;
using ShoppingCart.Core.Attribtues;

namespace ShoppingCart.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Auth]
    public class ProductsController : ControllerBase
    {
        private readonly IInventoryRepository _inventoryRepository;

        public ProductsController(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                var products = await _inventoryRepository.GetAllProductsAsync();
                return Ok(products);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            try
            {
                var product = await _inventoryRepository.GetProductByIdAsync(id);
                if (product == null) return NotFound();

                return Ok(product);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            try
            {
                await _inventoryRepository.AddProductAsync(product);
                return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
