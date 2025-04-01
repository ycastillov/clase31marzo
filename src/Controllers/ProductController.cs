using clase31marzo.src.Dtos;
using clase31marzo.src.Interfaces;
using clase31marzo.src.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace clase31marzo.src.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController(IProductRepository productRepository, IStoreRepository storeRepository) : ControllerBase
    {
        private readonly IProductRepository _productRepository = productRepository;
        private readonly IStoreRepository _storeRepository = storeRepository;
        [HttpPost("{storeId}")]
        public async Task<IActionResult> CreateProduct([FromBody]ProductDto productDto, [FromRoute]int storeId)
        {
            if (productDto == null || storeId <= 0)
            {
                return BadRequest("Invalid product data or store ID.");
            }
            if (string.IsNullOrEmpty(productDto.Name) || productDto.Price <= 0)
            {
                return BadRequest("Invalid product name or price.");
            }
            var storeExists = await _storeRepository.GetStoreById(storeId);
            if (storeExists == null)
            {
                return NotFound($"Store with ID {storeId} does not exist.");
            }
            var productModel = productDto.ToProduct(storeId);
            var createdProduct = await _productRepository.CreateProduct(productModel, storeId);
            return Ok(createdProduct.ToDto());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid product ID.");
            }
            var product = await _productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound($"Product with ID {id} does not exist.");
            }
            return Ok(product.ToDto());
        }
        
    }
}