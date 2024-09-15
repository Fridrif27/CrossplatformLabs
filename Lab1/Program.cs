using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Читаємо вхідні дані з файлу INPUT.TXT
        var input = File.ReadAllLines("INPUT.TXT");
        var firstLine = input[0].Split().Select(int.Parse).ToArray();
        int L = firstLine[0]; // Максимальна зміна величини
        int N = firstLine[1]; // Кількість чисел
        
        var numbers = input[1].Split().Select(int.Parse).ToArray();
        
        // Сортуємо числа для зручності роботи
        Array.Sort(numbers);
        
        // Ініціалізуємо межі діапазону
        int lowerBound = numbers[0] - L;
        int upperBound = numbers[0] + L;
        int count = 1; // Мінімальна кількість чисел після операцій

        for (int i = 1; i < N; i++)
        {
            // Якщо поточне число виходить за межі діапазону
            if (numbers[i] - L > upperBound || numbers[i] + L < lowerBound)
            {
                count++; // Додаємо нову групу
                lowerBound = numbers[i] - L;
                upperBound = numbers[i] + L;
            }
            else
            {
                // Оновлюємо межі діапазону, якщо числа можна об'єднати
                lowerBound = Math.Max(lowerBound, numbers[i] - L);
                upperBound = Math.Min(upperBound, numbers[i] + L);
            }
        }

        // Записуємо результат у файл OUTPUT.TXT
        File.WriteAllText("OUTPUT.TXT", count.ToString());
    }
}