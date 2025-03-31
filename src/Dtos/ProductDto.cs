using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase31marzo.src.Dtos
{
    public class ProductDto
    {
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public int StoreId { get; set; }
    }
}