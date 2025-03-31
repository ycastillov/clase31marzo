using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase31marzo.src.Models
{
    public class Product
    {
        public required int Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public required int Price { get; set; }
        // Relationship with Store
        public required int StoreId { get; set; }
    }
}