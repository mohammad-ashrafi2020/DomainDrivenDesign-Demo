namespace Clean_arch.Domain.Orders.Repository;

public interface IOrderRepository
{
    Task<Order> GetById(long id);
    void Add(Order order);
    void Update(Order order);
    Task SaveChanges();
}