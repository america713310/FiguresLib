using FiguresLib.Figures;
using System;
using Xunit;

namespace Figures.Test
{
    public class CircleTest
    {
        [Fact]
        public void Test()
        {
            // Arrange
            var circle = new Circle(10);
            var answer = Math.PI * 10 * 10;

            // Act
            var result = circle.GetArea();

            // Assert
            Assert.Equal(answer, result);
        }
    }
}
