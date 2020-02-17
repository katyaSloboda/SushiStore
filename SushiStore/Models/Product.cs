using System;

namespace SushiStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string NameKey { get; set; }
        public string CompositionKey { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
        public int Calories { get; set; }
        public int Proteins { get; set; }
        public int Fats { get; set; }
        public int Carbohydrates { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsVegetarian { get; set; }
    }
}
