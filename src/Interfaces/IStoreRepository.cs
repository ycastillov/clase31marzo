using clase31marzo.src.Dtos;
using clase31marzo.src.Models;

namespace clase31marzo.src.Interfaces
{
    public interface IStoreRepository
    {
        // Crear Tienda
        Task<Store> CreateStore(Store store);
        // Obtener todas las tiendas
        Task<List<Store>> GetAllStores();
        // Obtener tienda por Id
        Task<Store?> GetStoreById(int id);
    }
}