using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests.Unit
{
    public class ComputingTests
    {
        [Fact]
        public void OddOrEvent_Should_Return_Odd_When_Input_is_OddValue()
        {
            var computing = new Computing();

            var result = computing.OddOrEven(11);

            Assert.Equal("Odd", result);
        }

        [Theory]
        [InlineData(10)]
        public void OddOrEvent_Should_Return_Even_When_Input_is_EvenValue(int value)
        {
            var computing = new Computing();

            var result = computing.OddOrEven(value);

            Assert.Equal("Even", result);
        }
    }
}
