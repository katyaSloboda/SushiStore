using System;
using System.Collections.Generic;

namespace SushiStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string NameKey { get; set; }
        public List<Product> Products { get; set; }
        public Category()
        {
            Products = new List<Product>();
        }
    }
}
