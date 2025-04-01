using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using clase31marzo.src.Data;
using clase31marzo.src.Interfaces;
using clase31marzo.src.Mappers;
using clase31marzo.src.Models;
using Microsoft.EntityFrameworkCore;

namespace clase31marzo.src.Repository
{
    public class ProductRepository(DataContext dataContext) : IProductRepository
    {
        private readonly DataContext _dataContext = dataContext;
        public async Task<Product> CreateProduct(Product product, int storeId)
        {
            await _dataContext.Products.AddAsync(product);
            await _dataContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product?> GetProductById(int id)
        {
            var product = await _dataContext.Products.FirstOrDefaultAsync(p => p.Id == id);
            return product;
        }
    }
}