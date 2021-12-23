using Clean_arch.Domain.Shared;
namespace Clean_arch.Domain.OrderAgg.Events;
public class OrderFinalized : BaseDomainEvent
{
    public OrderFinalized(long orderId, long userId)
    {
        OrderId = orderId;
        UserId = userId;
    }

    public long OrderId { get; private set; }
    public long UserId { get; private set; }
}
