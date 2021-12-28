using Calculator.Tests.Unit.ClassFixture;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests.Unit
{
    public class ComputingTests : IClassFixture<ComputingClassFixture>
    {
        Computing computing;

        public ComputingTests(ComputingClassFixture c)
        {
            computing = c.computing;
        }

        [Fact]
        public void OddOrEvent_Should_Return_Odd_When_Input_is_OddValue()
        {
            //arrange

            //act
            var result = computing.OddOrEven(11);


            //asserts
            result.Should().Be("Odd");
        }

        [Theory]
        [InlineData(10)]
        public void OddOrEvent_Should_Return_Even_When_Input_is_EvenValue(int value)
        {
            var result = computing.OddOrEven(value);
            result.Should().Be("Even");
        }
        [Fact]
        public void CalculateAge_Should_Calculate_Age_When_CurrentYear_And_BirthDate_Is_Valid_Data()
        {
            var result = computing.CalculateAge(1380, 1400);
            result.Should().Be(20);
        }
        [Fact]
        public void CalculateAge_Should_Return_Zero_When_Birth_LessThan_Zero()
        {
            var result = computing.CalculateAge(-1, 1400);
            result.Should().Be(0);
        }
        [Fact]
        public void CalculateAge_Should_Throw_ArgumentException_When_Birth_Or_CurrentYear_Is_Zero()
        {
            var result = new Action(() =>
              {
                  computing.CalculateAge(0, 1400);
              });
            result.Should().Throw<ArgumentException>();
        }

        //
        public void Dispose()
        {
            //
        }
    }
}
