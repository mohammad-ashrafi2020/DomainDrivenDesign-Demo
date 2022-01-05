using Clean_arch.Domain.Shared;

namespace Clean_arch.Domain.OrderAgg
{
    public class OrderItem : BaseEntity
    {
        private OrderItem()
        {

        }
        public OrderItem(long orderId, int count, long productId, Money price)
        {
            OrderId = orderId;
            Count = count;
            ProductId = productId;
            Price = price;
        }

        public long OrderId { get; protected set; }
        public int Count { get; private set; }
        public long ProductId { get; private set; }
        public Money Price { get; private set; }
    }
}
