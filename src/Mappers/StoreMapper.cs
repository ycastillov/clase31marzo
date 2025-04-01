using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using clase31marzo.src.Dtos;
using clase31marzo.src.Models;

namespace clase31marzo.src.Mappers
{
    public static class StoreMapper
    {
        public static StoreDto ToDto(this Store store)
        {
            return new StoreDto
            {
                Name = store.Name,
                City = store.City,
                Products = store.Products.Select(p => p.ToDto()).ToList()
            };
        }
        public static Store ToStore(this StoreDto storeDto)
        {
            return new Store
            {
                Name = storeDto.Name,
                City = storeDto.City
            };
        }
    }
}