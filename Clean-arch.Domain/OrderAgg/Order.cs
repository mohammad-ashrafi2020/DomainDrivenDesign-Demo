using Clean_arch.Domain.OrderAgg;
using Clean_arch.Domain.OrderAgg.Events;
using Clean_arch.Domain.OrderAgg.Exceptions;
using Clean_arch.Domain.OrderAgg.Services;
using Clean_arch.Domain.Shared;
using Clean_arch.Domain.Shared.Exceptions;

namespace Clean_arch.Domain.Orders;

public class Order : AggregateRoot
{
    private Order()
    {

    }
    public long UserId { get; private set; }
    public int TotalPrice => Items.Sum(r => r.Price.RialValue);
    public int TotalItems { get; set; }
    public bool IsFinally { get; private set; }
    public DateTime FinallyDate { get; private set; }
    public ICollection<OrderItem> Items { get; private set; }
    public Order(long userId)
    {
        UserId = userId;
        Items = new List<OrderItem>();
    }
    public void Finally()
    {
        IsFinally = true;
        FinallyDate = DateTime.Now;
        AddDomainEvent(new OrderFinalized(Id, UserId));
    }
    public void AddItem(long productId, int count, int price, IOrderDomainService orderService)
    {
        if (orderService.IsProductNotExsist(productId))
            throw new ProductNotFoundException();

        if (Items.Any(p => p.ProductId == productId))
            return;

        Items.Add(new OrderItem(Id, count, productId, Money.FromTooman(price)));
        TotalItems += count;
    }
    public void RemoveItem(long productId)
    {
        var item = Items.FirstOrDefault(f => f.ProductId == productId);
        if (item == null)
            throw new InvalidDomainDataException();

        Items.Remove(item);
        TotalItems -= item.Count;
    }
}