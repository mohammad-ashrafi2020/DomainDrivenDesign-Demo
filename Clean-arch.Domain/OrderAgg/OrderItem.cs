using Clean_arch.Domain.Products;
using Clean_arch.Domain.Shared;

namespace Clean_arch.Domain.OrderAgg
{
    public class OrderItem:BaseEntity
    {
        public OrderItem(long orderId, int count, Guid productId, Mony price)
        {
            OrderId = orderId;
            Count = count;
            ProductId = productId;
            Price = price;
        }

        public long Id { get; private set; }
        public long OrderId { get; protected set; }
        public int Count { get; private set; }
        public Guid ProductId { get; private set; }
        public Mony Price { get; private set; }
    }
}
