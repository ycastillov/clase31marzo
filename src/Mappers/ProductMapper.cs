using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using clase31marzo.src.Dtos;
using clase31marzo.src.Models;

namespace clase31marzo.src.Mappers
{
    public static class ProductMapper
    {
        public static ProductDto ToDto(this Product product)
        {
            return new ProductDto
            {
                Name = product.Name,
                Price = product.Price,
                StoreId = product.StoreId
            };
        }
        public static Product ToProduct(this ProductDto productDto)
        {
            return new Product
            {
                Id = productDto.Id, // Ensure the required 'Id' is set
                Name = productDto.Name,
                Price = productDto.Price,
                StoreId = productDto.StoreId
            };  
        }
    }
}