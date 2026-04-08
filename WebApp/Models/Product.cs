using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        [Precision(15, 2)]
        public decimal Price { get; set; }
        public List<ProductTag> ProductTags { get; set; } = new List<ProductTag>();
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
