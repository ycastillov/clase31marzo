using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase31marzo.src.Models
{
    public class Store
    {
        public required int Id { get; set; }
        public required string Nombre { get; set; } = string.Empty;
        public required string City { get; set; } = string.Empty;
        // Relation with Products
        public required List<Product> Products { get; set; } = [];
    }
}