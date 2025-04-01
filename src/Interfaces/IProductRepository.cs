using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using clase31marzo.src.Models;

namespace clase31marzo.src.Interfaces
{
    public interface IProductRepository
    {
        // Crear Producto
        Task<Product> CreateProduct(Product product, int storeId);
        Task<Product?> GetProductById(int id);
    }
}