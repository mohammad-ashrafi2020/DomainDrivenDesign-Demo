using Clean_arch.Application.Orders;
using Clean_arch.Contracts;
using Clean_arch.Domain.Orders.Repository;
using Xunit;
using NSubstitute;
using Clean_arch.Application.Orders.DTOs;
using Clean_arch.Domain.Orders;
using FluentAssertions;
using System.Collections.Generic;

namespace Clean_arch.Application.Test.Unit
{
    public class OrderServiceTests
    {
        private readonly OrderService _orderService;
        private readonly IOrderRepository _repository;
        private readonly ISmsService _smsService;
        public OrderServiceTests()
        {
            _repository = Substitute.For<IOrderRepository>();
            _smsService = Substitute.For<ISmsService>();
            _orderService = new(_repository, _smsService);
        }

        [Fact]
        public void Should_Add_Order()
        {
            //arrange
            var command = new AddOrderDto(1, 2, 30000);

            //act
            _orderService.AddOrder(command);

            //asserts
            _repository.Received(1).SaveChanges();
        }

        [Fact]
        public void Should_Finally_Order_And_Send_Sms()
        {
            //arrange
            _repository.GetById(Arg.Any<long>()).Returns(new Order(1));
            var command = new FinallyOrderDto(1);

            //act
            _orderService.FinallyOrder(command);

            //asserts
            _repository.Received(1).SaveChanges();
            _smsService.Received(1).SendSms(Arg.Any<SmsBody>());
        }

        [Fact]
        public void Should_Return_Order_By_Id()
        {
            //arrange
            _repository.GetById(Arg.Any<long>()).Returns(new Order(2));

            //act
            var result = _orderService.GetOrderById(1);

            //asserts
            result.UserId.Should().Be(2);
        }

        [Fact]
        public void Should_Return_List_Of_Order()
        {
            //arrange
            _repository.GetList().Returns(
                new List<Order>()
            {
                    new Order(1),
                    new Order(2)
                });

            //act
            var result = _orderService.GetOrders();

            //asserts
            result.Should().HaveCount(2);
        }
    }
}