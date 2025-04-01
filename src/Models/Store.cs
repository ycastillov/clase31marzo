using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase31marzo.src.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        // Relation with Products
        public List<Product> Products { get; set; } = [];
    }
}