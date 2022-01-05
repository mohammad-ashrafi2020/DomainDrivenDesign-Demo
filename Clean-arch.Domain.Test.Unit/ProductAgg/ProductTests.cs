using Clean_arch.Domain.Shared;
using Clean_arch.Domain.Shared.Exceptions;
using Clean_arch.Domain.Test.Unit.Builders;
using FluentAssertions;
using System;
using Xunit;

namespace Clean_arch.Domain.Test.Unit
{
    public class ProductTests
    {
        private ProductBuilder _productBuilder;
        public ProductTests()
        {
            _productBuilder = new ProductBuilder();
        }
        [Fact]
        public void Constructor_Should_Create_Product_when_Data_Is_Ok()
        {
            //arrange
            _productBuilder.SetTitle("test2").SetMoney(1000);

            //act
            var product = _productBuilder.Build();


            //asserts
            product.Title.Should().Be("test2");
        }

        [Fact]
        public void Constructor_Should_Throw_NullOrEmptyException_when_Title_isNull()
        {

            //act
            var action = new Action(() =>
              {
                  _productBuilder.SetTitle("").Build();
              });


            //asserts
            action.Should().ThrowExactly<NullOrEmptyDomainDataException>()
                .WithMessage("title is null or empty");
        }

        [Fact]
        public void Edit_Should_Update_Product_when_Data_Is_Ok()
        {
            //arrange
            var product = _productBuilder.SetTitle("test2").SetMoney(1000).Build();

            //act
            product.Edit("edited", new Money(10000000), "das");


            //asserts
            product.Title.Should().Be("edited");
            product.Money.RialValue.Should().Be(10000000);
        }
        [Fact]
        public void Edit_Should_Throw_NullOrEmptyException_when_Title_isNull()
        {
            //arrange
            var product = _productBuilder.SetTitle("test2").SetMoney(1000).Build();

            //act
            var action = () =>
              {
                  product.Edit("", new Money(10000000), "ads");
              };


            //asserts
            action.Should().ThrowExactly<NullOrEmptyDomainDataException>()
                 .WithMessage("title is null or empty");
        }
        [Fact]
        public void AddImage_Should_Add_New_Image_To_Product()
        {
            //arrange
            var product = _productBuilder.SetTitle("test2").SetMoney(1000).Build();

            //act
            product.AddImage("test.png");


            //asserts
            product.Images.Should().HaveCount(1);
        }
        [Fact]
        public void RemoveImage_Should_Remove_Image_When_Image_Is_Exsist()
        {
            //arrange
            var product = _productBuilder.SetTitle("test2").SetMoney(1000).Build();
            product.AddImage("test.png");


            //act
            product.RemoveImage(0);

            //asserts
            product.Images.Should().HaveCount(0);
        }

        [Fact]
        public void RemoveImage_Should_Throw_NullOrEmptyException_When_Image_Is_Not_Exsist()
        {
            //arrange
            var product = _productBuilder.SetTitle("test2").SetMoney(1000).Build();


            //act
            var action = () => product.RemoveImage(0);

            //asserts
            action.Should().ThrowExactly<NullOrEmptyDomainDataException>()
                .WithMessage("Image not found");
        }
    }
}