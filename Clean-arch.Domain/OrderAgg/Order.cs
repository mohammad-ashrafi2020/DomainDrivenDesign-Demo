﻿using Clean_arch.Domain.OrderAgg;
using Clean_arch.Domain.OrderAgg.Events;
using Clean_arch.Domain.OrderAgg.Services;
using Clean_arch.Domain.Shared;

namespace Clean_arch.Domain.Orders;

public class Order : AggregateRoot
{
    public long UserId { get; private set; }
    public int TotalPrice;
    public int TotalItems { get; set; }
    public bool IsFinally { get; private set; }
    public DateTime FinallyDate { get; private set; }
    public ICollection<OrderItem> Items { get; private set; }
    public Order(long userId)
    {
        UserId = userId;
    }
    public void Finally()
    {
        IsFinally = true;
        FinallyDate = DateTime.Now;
        AddDomainEvent(new OrderFinalized(Id, UserId));
    }
    public void AddItem(Guid productId, int count, int price, IOrderDomainService orderService)
    {
        if (orderService.IsProductNotExsist(productId))
            throw new Exception("test");

        if (Items.Any(p => p.ProductId == productId))
            return;

        Items.Add(new OrderItem(Id, count, productId, Mony.FromTooman(price)));
        TotalItems += count;
    }
    public void RemoveItem(Guid productId)
    {
        var item = Items.FirstOrDefault(f => f.ProductId == productId);
        if (item == null)
            throw new Exception("dasda");

        Items.Remove(item);
        TotalItems -= item.Count;
    }
}