using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase31marzo.src.Dtos
{
    public class StoreDto
    {
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public List<ProductDto> Products { get; set; } = [];
    }
}