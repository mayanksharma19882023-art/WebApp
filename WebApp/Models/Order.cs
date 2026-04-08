namespace WebApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Payment Payment { get; set; } = null!;                        
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
