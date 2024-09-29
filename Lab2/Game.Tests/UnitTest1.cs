using Xunit;

public class GameTests
{
    [Fact]
    public void Test1()
    {
        int[] nums = { 3, 2, 5, 4 };
        int result = Game.DetermineWinner(nums);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Test2()
    {
        int[] nums = { 5, 5, 5, 5, 5, 5 };
        int result = Game.DetermineWinner(nums);
        Assert.Equal(0, result);
    }

    [Fact]
    public void Test3()
    {
        int[] nums = { 2, 1, 3, 2, 9, 1, 2, 3, 1 };
        int result = Game.DetermineWinner(nums);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Test4()
    {
        int[] nums = { 2, 5, 3, 12, 4, 6, 13, 7, 1, 3 };
        int result = Game.DetermineWinner(nums);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Test5()
    {
        int[] nums = { 9, 7, 3 };
        int result = Game.DetermineWinner(nums);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Test6()
    {
        int[] nums = { 4, 4, 2, 2, 10 };
        int result = Game.DetermineWinner(nums);
        Assert.Equal(1, result);
    }
}
