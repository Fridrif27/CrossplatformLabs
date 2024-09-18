using System;
using System.IO;
using System.Linq;

class Program
{
    public static void Main()
    {
        // Read input data from file INPUT.TXT
        var input = File.ReadAllLines("INPUT.TXT");
        var firstLine = input[0].Split().Select(int.Parse).ToArray();
        int L = firstLine[0];
        int N = firstLine[1];
        var numbers = input[1].Split().Select(int.Parse).ToArray();

        int result = CalculateMinimumGroups(L, N, numbers);

        // Write the result to file OUTPUT.TXT
        File.WriteAllText("OUTPUT.TXT", result.ToString());
    }

    public static int CalculateMinimumGroups(int L, int N, int[] numbers)
    {
        Array.Sort(numbers);

        int lowerBound = numbers[0] - L;
        int upperBound = numbers[0] + L;
        int count = 1;

        for (int i = 1; i < N; i++)
        {
            if (numbers[i] - L > upperBound || numbers[i] + L < lowerBound)
            {
                count++;
                lowerBound = numbers[i] - L;
                upperBound = numbers[i] + L;
            }
            else
            {
                lowerBound = Math.Max(lowerBound, numbers[i] - L);
                upperBound = Math.Min(upperBound, numbers[i] + L);
            }
        }

        return count;
    }
}