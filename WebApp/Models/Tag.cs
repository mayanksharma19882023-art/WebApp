namespace WebApp.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<ProductTag> ProductTags { get; set; } = new List<ProductTag>();
    }
}
