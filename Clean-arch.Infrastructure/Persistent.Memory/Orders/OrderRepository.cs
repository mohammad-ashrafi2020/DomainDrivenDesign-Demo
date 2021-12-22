using Clean_arch.Domain.Orders;
using Clean_arch.Domain.Orders.Repository;

namespace Clean_arch.Infrastructure.Persistent.Memory.Orders;

public class OrderRepository : IOrderRepository
{
    private Context _context;
    public OrderRepository(Context context)
    {
        _context = context;
    }
    public List<Order> GetList()
    {
        return _context.Orders;
    }

    public Order GetById(long id)
    {
        return _context.Orders.FirstOrDefault(f => f.Id == id);
    }

    public void Add(Order order)
    {
        _context.Orders.Add(order);
    }

    public void Update(Order order)
    {
        var oldOrder = GetById(order.Id);
        _context.Orders.Remove(oldOrder);
        Add(order);
    }

    public void SaveChanges()
    {
        //
    }
}