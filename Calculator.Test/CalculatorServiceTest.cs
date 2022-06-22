using AutoFixture;
using Calculator.Service;
using FluentAssertions;

namespace Calculator.Test
{
    public class CalculatorServiceTest
    {
        private readonly Fixture _fixture;
        public CalculatorServiceTest()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void Should_Return_Sum()
        {
            //Arrange
            int a = 2;
            int b = 3;
            var expected = 5;

            //Act
            var act = new CalculatorService();
            var actual = act.Add(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Return_AutoFixture_Sum()
        {
            //Arrange
            int a = _fixture.Create<int>();
            int b = _fixture.Create<int>();
            var expected = a + b;

            //Act
            var act = new CalculatorService();
            var actual = act.Add(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,2,5)]
        [InlineData(-3, 2, -1)]
        [InlineData(1.53, 2.46, 3.99)]
        public void Should_Return_Parameter_Sum(int a, int b, int expected)
        {
            //Arrange

            //Act
            var act = new CalculatorService();
            var actual = act.Add(a, b);

            //Assert
            actual.Should().Be(expected);
        }
    }
}