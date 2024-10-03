using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Read the maze from INPUT.TXT
        string[] inputLines = File.ReadAllLines("/home/user/RiderProjects/CrossplatformLabs/Lab3/ConsoleApp/ResultExecution/INPUT.TXT");
        string[] dimensions = inputLines[0].Split();
        int N = int.Parse(dimensions[0]);
        int M = int.Parse(dimensions[1]);

        char[,] maze = new char[N, M];

        // Read the maze
        for (int i = 0; i < N; i++)
        {
            string line = inputLines[i + 1];
            for (int j = 0; j < M; j++)
            {
                maze[i, j] = line[j];
            }
        }

        // Get the shortest path length and if the slave can escape
        (int pathLength, bool canEscape) = Dijkstra(maze, N, M, 0, 0);

        // Output results to OUTPUT.TXT
        using (StreamWriter writer = new StreamWriter("/home/user/RiderProjects/CrossplatformLabs/Lab3/ConsoleApp/ResultExecution/OUTPUT.TXT"))
        {
            writer.WriteLine(pathLength);
            writer.WriteLine(canEscape ? "Yes" : "No");
        }
    }

    public static (int, bool) Dijkstra(char[,] maze, int rows, int cols, int startX, int startY)
    {
        // Initialize distances and a priority queue
        int[,] distances = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                distances[i, j] = int.MaxValue; // Set all distances to infinity
            }
        }

        // Check if the starting point or exit point is blocked
        if (maze[startX, startY] == '#' || maze[rows - 1, cols - 1] == '#')
        {
            return (int.MaxValue, false); // No path if start or end is blocked
        }

        distances[startX, startY] = 0;

        // Initialize the priority queue
        PriorityQueue<(int x, int y), int> pq = new PriorityQueue<(int, int), int>();
        pq.Enqueue((startX, startY), 0);

        (int dx, int dy)[] directions = { (0, 1), (1, 0), (0, -1), (-1, 0) };

        while (pq.Count > 0)
        {
            var (currentX, currentY) = pq.Dequeue();

            // If we reached the exit
            if (currentX == rows - 1 && currentY == cols - 1)
            {
                return (distances[currentX, currentY], true); // Return path length and escape possibility
            }

            // Iterate through the possible directions
            foreach (var (dx, dy) in directions)
            {
                int newX = currentX + dx;
                int newY = currentY + dy;

                // Check bounds and if the cell is free
                if (newX >= 0 && newX < rows && newY >= 0 && newY < cols && maze[newX, newY] != '#')
                {
                    int newDist = distances[currentX, currentY] + 1;

                    // Only update if the new distance is less
                    if (newDist < distances[newX, newY])
                    {
                        distances[newX, newY] = newDist;
                        pq.Enqueue((newX, newY), newDist);
                    }
                }
            }
        }

        // If we exit the loop without finding the exit
        return (int.MaxValue, false);
    }
}
