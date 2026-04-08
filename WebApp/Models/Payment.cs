using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class Payment
    {
        public int Id { get; set; }
        [Precision(15, 2)]
        public decimal Amount { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
    }
}
