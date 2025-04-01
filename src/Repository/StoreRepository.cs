using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using clase31marzo.src.Data;
using clase31marzo.src.Interfaces;
using clase31marzo.src.Models;
using Microsoft.EntityFrameworkCore;

namespace clase31marzo.src.Repository
{
    public class StoreRepository(DataContext dataContext) : IStoreRepository
    {
        private readonly DataContext _dataContext = dataContext;
        public async Task<Store> CreateStore(Store store)
        {
            await _dataContext.Stores.AddAsync(store);
            await _dataContext.SaveChangesAsync();
            return store;
        }

        public async Task<List<Store>> GetAllStores()
        {
            return await _dataContext.Stores.Include(s => s.Products).ToListAsync();
        }

        public async Task<Store?> GetStoreById(int id)
        {
            var store = await _dataContext.Stores.Include(s => s.Products).FirstOrDefaultAsync(s => s.Id == id);
            return store;
        }
    }
}