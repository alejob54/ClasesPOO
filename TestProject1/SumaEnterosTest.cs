using Clase1;

namespace TestProject1;

public class SumaEnterosTest
{
    [Theory]
    [InlineData("929698479896695193", 2)]
    [InlineData("123456789", 9)]
    [InlineData("123456789123456789123456789", 9)]
    [InlineData("99999999999999999999", 9)]
    [InlineData("9999999999999999999999999999999999999999", 9)]
    [InlineData("654321", 3)]
    [InlineData("1", 1)]
    [InlineData("123", 6)]
    public void TestSumaEnteros(string input, int expectedSum)
    {
        //Arrange

        //Act
        var resul = new SumaEnteros().Suma(input);

        //Assert
        Assert.Equal(expectedSum, resul);
    }
}
