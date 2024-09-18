using System;
using Xunit;

public class ProgramTests
{
    [Fact]
    public void TestWithSmallInput()
    {
        int L = 1;
        int N = 3;
        int[] numbers = { 1, 2, 3 };

        int result = Program.CalculateMinimumGroups(L, N, numbers);

        Assert.Equal(1, result);
    }

    [Fact]
    public void TestWithNoOverlap()
    {
        int L = 1;
        int N = 3;
        int[] numbers = { 1, 5, 10 };

        int result = Program.CalculateMinimumGroups(L, N, numbers);

        Assert.Equal(3, result);
    }

    [Fact]
    public void TestWithAllNumbersInOneGroup()
    {
        int L = 3;
        int N = 5;
        int[] numbers = { 1, 2, 3, 4, 5 };

        int result = Program.CalculateMinimumGroups(L, N, numbers);

        Assert.Equal(1, result);
    }

    [Fact]
    public void TestWithMultipleGroups()
    {
        int L = 2;
        int N = 6;
        int[] numbers = { 1, 2, 3, 10, 11, 12 };

        int result = Program.CalculateMinimumGroups(L, N, numbers);

        Assert.Equal(2, result);
    }

    [Fact]
    public void TestWithSingleNumber()
    {
        int L = 5;
        int N = 1;
        int[] numbers = { 7 };

        int result = Program.CalculateMinimumGroups(L, N, numbers);

        Assert.Equal(1, result);
    }

    [Fact]
    public void TestWithAllNumbersSame()
    {
        int L = 10;
        int N = 4;
        int[] numbers = { 5, 5, 5, 5 };

        int result = Program.CalculateMinimumGroups(L, N, numbers);

        Assert.Equal(1, result);
    }

    [Fact]
    public void TestWithLargeRange()
    {
        int L = 100;
        int N = 5;
        int[] numbers = { 1, 500, 1000, 1500, 2000 };

        int result = Program.CalculateMinimumGroups(L, N, numbers);

        Assert.Equal(5, result);
    }
}