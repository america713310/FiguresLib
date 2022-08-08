using FiguresLib.Figures;
using Xunit;

namespace Figures.Test
{
    public class TriangleTest
    {
        [Fact]
        public void Test()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            var answer = 6;

            // Act
            var result = triangle.GetArea();

            // Assert
            Assert.Equal(answer, result);
        }
    }
}
