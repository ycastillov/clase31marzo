using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase31marzo.src.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        // Relationship with Store
        public int StoreId { get; set; }
        public Store Store { get; set; } = null!;// Navigation property
    }
}