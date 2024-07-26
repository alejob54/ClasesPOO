using Clase1;

namespace TestProject1;

public class NarcissisticTests
{
    [Theory]
    [InlineData(0, true)]        // Narcissistic number: 0^1 = 0
    [InlineData(1, true)]        // Narcissistic number: 1^1 = 1
    [InlineData(153, true)]      // Narcissistic number: 1^3 + 5^3 + 3^3 = 153
    [InlineData(370, true)]      // Narcissistic number: 3^3 + 7^3 + 0^3 = 370
    [InlineData(9474, true)]     // Narcissistic number: 9^4 + 4^4 + 7^4 + 4^4 = 9474
    [InlineData(12, false)]      // Not a narcissistic number: 1^2 + 2^2 ≠ 12
    [InlineData(123, false)]     // Not a narcissistic number: 1^3 + 2^3 + 3^3 ≠ 123
    public void Narcissistic_Number_ReturnsExpected(int value, bool expected)
    {
        // Act
        bool result = Kata1.Narcissistic(value);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Narcissistic_LargeNumber_ReturnsExpected()
    {
        // Arrange
        int value = 548834;
        bool expected = true;  // Narcissistic number: 5^6 + 4^6 + 8^6 + 8^6 + 3^6 + 4^6 = 548834

        // Act
        bool result = Kata1.Narcissistic(value);

        // Assert
        Assert.Equal(expected, result);
    }
}
