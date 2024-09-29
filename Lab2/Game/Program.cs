using System;

public class Game
{
    public static int DetermineWinner(int[] nums)
    {
        int n = nums.Length;
        int[,] dp = new int[n, n];
        
        // Заповнюємо таблицю динамічного програмування
        for (int i = 0; i < n; i++)
        {
            dp[i, i] = nums[i];
        }

        for (int len = 2; len <= n; len++)
        {
            for (int i = 0; i <= n - len; i++)
            {
                int j = i + len - 1;
                dp[i, j] = Math.Max(nums[i] - dp[i + 1, j], nums[j] - dp[i, j - 1]);
            }
        }

        // Якщо перший гравець отримав більше або рівно, то він виграв
        if (dp[0, n - 1] > 0)
            return 1;
        else if (dp[0, n - 1] < 0)
            return 2;
        else
            return 0;
    }

    public static void Main(string[] args)
    {
        // Читання даних з файлу INPUT.TXT
        string[] input = System.IO.File.ReadAllLines("/home/user/RiderProjects/CrossplatformLabs/Lab2/Game/ResultExecution/INPUT.TXT");
        int n = int.Parse(input[0]);
        int[] nums = Array.ConvertAll(input[1].Split(' '), int.Parse);
        
        // Визначення переможця
        int result = DetermineWinner(nums);
        
        // Запис результату в файл OUTPUT.TXT
        System.IO.File.WriteAllText("/home/user/RiderProjects/CrossplatformLabs/Lab2/Game/ResultExecution/OUTPUT.TXT", result.ToString());
    }
}