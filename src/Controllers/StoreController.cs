using clase31marzo.src.Dtos;
using clase31marzo.src.Interfaces;
using clase31marzo.src.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace clase31marzo.src.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController(IStoreRepository storeRepository) : ControllerBase
    {
        private readonly IStoreRepository _storeRepository = storeRepository;
        [HttpGet]
        public async Task<IActionResult> GetAllStores()
        {
            var stores = await _storeRepository.GetAllStores();
            return Ok(stores.Select(s => s.ToDto()));
        }
        [HttpPost]
        public async Task<IActionResult> CreateStore(StoreDto storeDto)
        {
            if (storeDto == null)
            {
                return BadRequest("Invalid store data.");
            }
            if (string.IsNullOrEmpty(storeDto.Name) || string.IsNullOrEmpty(storeDto.City))
            {
                return BadRequest("Invalid store name or city.");
            }
            var storeModel = storeDto.ToStore();
            var createdStore = await _storeRepository.CreateStore(storeModel);
            return Ok(createdStore.ToDto());
        }
    }
}