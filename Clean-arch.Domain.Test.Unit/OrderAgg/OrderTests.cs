using Clean_arch.Domain.OrderAgg.Events;
using Clean_arch.Domain.OrderAgg.Exceptions;
using Clean_arch.Domain.OrderAgg.Services;
using Clean_arch.Domain.Orders;
using Clean_arch.Domain.Shared.Exceptions;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace Clean_arch.Domain.Test.Unit.OrderAgg;

public class OrderTests
{
    [Fact]
    public void Should_Create_Order()
    {
        var order = new Order(1);

        order.UserId.Should().Be(1);
        order.IsFinally.Should().Be(false);
    }

    [Fact]
    public void Should_Finally_Order_And_Add_DomainEvent()
    {
        //arrange
        var order = new Order(1);

        //act
        order.Finally();

        order.DomainEvents.Should().HaveCount(1);
    }

    [Fact]
    public void AddItem_Should_Throw_ProductNotFoundException_When_Product_Not_Exist()
    {
        //arrange
        var order = new Order(1);
        var orderDomainService = Substitute.For<IOrderDomainService>();
        orderDomainService.IsProductNotExsist(Arg.Any<long>()).Returns(true);

        //act
        var res = () => order.AddItem(1, 2, 30000, orderDomainService);

        res.Should().ThrowExactly<ProductNotFoundException>();
    }

    [Fact]
    public void AddItem_Should_Add_New_Item_To_Order()
    {
        //arrange
        var order = new Order(1);
        var orderDomainService = Substitute.For<IOrderDomainService>();
        orderDomainService.IsProductNotExsist(Arg.Any<long>()).Returns(false);

        //act
        order.AddItem(1, 2, 30000, orderDomainService);

        order.TotalItems.Should().Be(2);
    }

    [Fact]
    public void Should_Not_Add_Item_To_Order_when_Product_Exist_In_Order()
    {
        //arrange
        var order = new Order(1);
        var orderDomainService = Substitute.For<IOrderDomainService>();
        orderDomainService.IsProductNotExsist(Arg.Any<long>()).Returns(false);
        order.AddItem(1, 2, 30000, orderDomainService);

        //act
        order.AddItem(1, 3, 30000, orderDomainService);

        order.TotalItems.Should().Be(2);
    }

    [Fact]
    public void Remove_item_Should_Throw_InvalidDomainDataException_When_Product_Not_Exist_IN_Order()
    {
        //arrange
        var order = new Order(1);

        //act
        var action = () => order.RemoveItem(1);

        action.Should().ThrowExactly<InvalidDomainDataException>();
    }

    [Fact]
    public void Should_Remove_Item_From_Order()
    {
        //arrange
        var order = new Order(1);
        var orderDomainService = Substitute.For<IOrderDomainService>();
        orderDomainService.IsProductNotExsist(Arg.Any<long>()).Returns(false);
        order.AddItem(1, 3, 30000, orderDomainService);

        //act
        order.RemoveItem(1);

        order.TotalItems.Should().Be(0);
    }
}