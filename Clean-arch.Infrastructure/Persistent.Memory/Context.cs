using Clean_arch.Domain.Orders;
using Clean_arch.Domain.Products;

namespace Clean_arch.Infrastructure.Persistent.Memory;

public class Context
{
    public List<Product> Products { get; set; }
    public List<Order> Orders { get; set; } = new List<Order>() { new Order(Guid.NewGuid(), 1, 1000) };
}