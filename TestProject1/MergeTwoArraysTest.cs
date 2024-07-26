using Clase1;

namespace TestProject1;

public class MergeTwoArraysTest
{
    [Fact]
    public void Test1()
    {
        //Arrange
        //[1, 2, 3, 4, 5], [6, 7, 8, 9, 10] -> [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 6, 7, 8, 9, 10 };
        int[] array3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //Act
        var result = new MergeTwoArrays().DoWork(array1, array2);

        //Assert
        Assert.Equal(result, array3);
    }

    [Fact]
    public void Test2()
    {
        //Arrange
        //[1, 3, 5, 7, 9], [10, 8, 6, 4, 2] -> [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
        int[] array1 = { 1, 3, 5, 7, 9 };
        int[] array2 = { 10, 8, 6, 4, 2 };
        int[] array3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //Act
        var result = new MergeTwoArrays().DoWork(array1, array2);

        //Assert
        Assert.Equal(result, array3);
    }

    [Fact]
    public void Test3()
    {
        //Arrange
        //[1, 3, 5, 7, 9, 11, 12], [1, 2, 3, 4, 5, 10, 12] -> [1, 2, 3, 4, 5, 7, 9, 10, 11, 12]
        int[] array1 = { 1, 3, 5, 7, 9, 11, 12 };
        int[] array2 = { 1, 2, 3, 4, 5, 10, 12 };
        int[] array3 = { 1, 2, 3, 4, 5, 7, 9, 10, 11, 12 };

        //Act
        var result = new MergeTwoArrays().DoWork(array1, array2);

        //Assert
        Assert.Equal(result, array3);
    }
}
