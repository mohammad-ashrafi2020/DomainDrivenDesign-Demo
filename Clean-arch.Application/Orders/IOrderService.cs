using Clean_arch.Application.Orders.DTOs;

namespace Clean_arch.Application.Orders;

public interface IOrderService
{
    void AddOrder(AddOrderDto command);
    void FinallyOrder(FinallyOrderDto command);
    OrderDto GetOrderById(long id);
    List<OrderDto> GetOrders();

}