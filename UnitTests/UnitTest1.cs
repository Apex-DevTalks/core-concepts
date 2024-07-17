namespace UnitTests;

public class UnitTest1
{
    [Fact]
    public void CalculateSquareArea()
    {
        // Arrange
        OOP_Pillars.Square square = new(2, 2);
        // Act
        var result = square.CalculateArea();
        // Assert
        Assert.Equal(4, result);
    }
    [Fact]
    public void CalculateTriangleArea()
    {
        // Arrange
        OOP_Pillars.Triangle triangle = new(2, 3);
        // Act
        var result = triangle.CalculateArea();
        // Assert
        Assert.Equal(3, result);
    }
    [Fact]
    public void CalculateCircleArea()
    {
        // Arrange
        OOP_Pillars.Circle circle = new(10);
        // Act
        var result = circle.CalculateArea();
        // Assert
        Assert.Equal(Math.PI*100, result);
    }
}