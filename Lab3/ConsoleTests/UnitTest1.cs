using System;
using Xunit;

public class MazeTests
{
    [Fact]
    public void Test_FullWall()
    {
        // Arrange
        char[,] maze = 
        {
            { '#', '#', '#', '#' },
            { '#', '#', '#', '#' },
            { '#', '#', '#', '#' },
            { '#', '#', '#', '#' }
        };

        // Act
        var (pathLength, canEscape) = Program.Dijkstra(maze, 4, 4, 0, 0);

        // Assert
        Assert.Equal(int.MaxValue, pathLength);
        Assert.False(canEscape);
    }

    [Fact]
    public void Test_SimplePath()
    {
        // Arrange
        char[,] maze = 
        {
            { ' ', ' ', ' ' },
            { '#', '#', ' ' },
            { ' ', ' ', ' ' }
        };

        // Act
        var (pathLength, canEscape) = Program.Dijkstra(maze, 3, 3, 0, 0);

        // Assert
        Assert.Equal(4, pathLength); // Expected path length
        Assert.True(canEscape);
    }

    [Fact]
    public void Test_LargeMazeWithMultiplePaths()
    {
        // Arrange
        char[,] maze = 
        {
            { ' ', '#', ' ', ' ', ' ' },
            { ' ', '#', ' ', '#', ' ' },
            { ' ', ' ', ' ', '#', ' ' },
            { '#', '#', ' ', '#', ' ' },
            { ' ', ' ', ' ', ' ', ' ' }
        };

        // Act
        var (pathLength, canEscape) = Program.Dijkstra(maze, 5, 5, 0, 0);

        // Assert
        Assert.Equal(8, pathLength); // Adjusted expected path length
        Assert.True(canEscape);
    }

    [Fact]
    public void Test_NoPath()
    {
        // Arrange
        char[,] maze = 
        {
            { ' ', '#', ' ' },
            { '#', '#', '#' },
            { ' ', ' ', ' ' }
        };

        // Act
        var (pathLength, canEscape) = Program.Dijkstra(maze, 3, 3, 0, 0);

        // Assert
        Assert.Equal(int.MaxValue, pathLength);
        Assert.False(canEscape);
    }

    [Fact]
    public void Test_SinglePath()
    {
        // Arrange
        char[,] maze = 
        {
            { ' ', ' ', ' ' },
            { '#', '#', ' ' },
            { ' ', ' ', ' ' }
        };

        // Act
        var (pathLength, canEscape) = Program.Dijkstra(maze, 3, 3, 0, 0);

        // Assert
        Assert.Equal(4, pathLength);
        Assert.True(canEscape);
    }

    [Fact]
    public void Test_StartingPointBlocked()
    {
        // Arrange
        char[,] maze = 
        {
            { '#', ' ', ' ' },
            { ' ', '#', ' ' },
            { ' ', ' ', ' ' }
        };

        // Act
        var (pathLength, canEscape) = Program.Dijkstra(maze, 3, 3, 0, 0);

        // Assert
        Assert.Equal(int.MaxValue, pathLength);
        Assert.False(canEscape);
    }

    [Fact]
    public void Test_ExitBlocked()
    {
        // Arrange
        char[,] maze = 
        {
            { ' ', ' ', ' ' },
            { ' ', '#', ' ' },
            { ' ', ' ', '#' }
        };

        // Act
        var (pathLength, canEscape) = Program.Dijkstra(maze, 3, 3, 0, 0);

        // Assert
        Assert.Equal(int.MaxValue, pathLength);
        Assert.False(canEscape);
    }
}
