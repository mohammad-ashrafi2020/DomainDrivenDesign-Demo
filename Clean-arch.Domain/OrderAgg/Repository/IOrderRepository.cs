namespace Clean_arch.Domain.Orders.Repository;

public interface IOrderRepository
{
    List<Order> GetList();
    Order GetById(long id);
    void Add(Order order);
    void Update(Order order);
    void SaveChanges();
}