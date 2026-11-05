
using Store.Domain.Enums;

namespace Store.Domain.Entities;

public class Order
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public OrderStatus Status { get; set; } = OrderStatus.Pending;

    public decimal SubTotal { get; set; }

    public decimal Discount { get; set; }

    public decimal Total { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public User Customer { get; set; } = null!;

    public ICollection<OrderItem> Items { get; set; }
        = new List<OrderItem>();
}
