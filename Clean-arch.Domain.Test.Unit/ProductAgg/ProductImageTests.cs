using Clean_arch.Domain.ProductAgg;
using Clean_arch.Domain.Shared.Exceptions;
using FluentAssertions;
using Xunit;

namespace Clean_arch.Domain.Test.Unit.ProductAgg
{
    public class ProductImageTests
    {

        [Fact]
        public void Should_Create_New_ProductImage_When_Data_Is_Ok()
        {
            //arrange
            var productImage = new ProductImage(1, "test.png");


            //asserts
            productImage.ImageName.Should().Be("test.png");
        }

        [Fact]
        public void Constructor_Should_Throw_NullOrEmptyDomainDataException_When_ImageName_Is_Null()
        {
            //arrange
            var result = () => new ProductImage(1, "");


            //asserts
            result.Should().ThrowExactly<NullOrEmptyDomainDataException>()
                .WithMessage("imageName is null or empty");
        }
    }
}
