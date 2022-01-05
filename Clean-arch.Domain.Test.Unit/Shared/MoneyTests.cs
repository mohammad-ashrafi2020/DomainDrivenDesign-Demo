using Clean_arch.Domain.Shared;
using Clean_arch.Domain.Shared.Exceptions;
using FluentAssertions;
using Xunit;

namespace Clean_arch.Domain.Test.Unit.Shared
{
    public class MoneyTests
    {
        [Fact]
        public void Constructor_Should_Set_value_when_value_Begger_Than_Zero()
        {
            var money = new Money(10000);

            money.RialValue.Should().Be(10000);
        }
        [Fact]
        public void Constructor_Should_Throw_InvalidDomainDataException_when_value_Less_Than_Zero()
        {
            var result = () => new Money(-100);

            result.Should().ThrowExactly<InvalidDomainDataException>();
        }
        [Fact]
        public void FromRial_Should_Create_New_Money()
        {
            var money = Money.FromRial(1000);

            money.RialValue.Should().Be(1000);

        }
        [Fact]
        public void FromTooman_Should_Create_New_Money_With_ToomanValue()
        {
            var toomanValue = 1000;
            var money = Money.FromTooman(toomanValue);

            money.RialValue.Should().Be(toomanValue * 10);

        }

        [Fact]
        public void Plus_Operator_Should_Sum_Value_And_Return_New_Money()
        {
            //arrange
            var money = Money.FromRial(10000);
            var money2 = Money.FromRial(50000);


            //act
            var result = money + money2;


            //assets
            result.RialValue.Should().Be(60000);

        }
        [Fact]
        public void minus_Operator_Should_subtract_Value_And_Return_New_Money()
        {
            //arrange
            var money = Money.FromRial(10000);
            var money2 = Money.FromRial(50000);


            //act
            var result = money2 - money;


            //assets
            result.RialValue.Should().Be(40000);

        }
        [Fact]
        public void ToString_Should_Return_MonyValue_With_String_Format()
        {
            //arrange
            var money = Money.FromRial(10000);


            //act
            var result = money.ToString();


            //assets
            result.Should().Be("10,000");
        }
    }
}
