using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Ввод предложения
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();
        string output;

        // Проверка на непустую строку
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Строка не должна быть пустой.");
            return;
        }

        var result = Logic.CalculateLetterPercentage(input);

        // Вывод результата
        output = $"Доля букв в предложении: {result.percentage}%";
        Console.WriteLine(output);
    }
}

public class Logic
{
    public struct Result
    {
        public double percentage;
    }

    public static Result CalculateLetterPercentage(string input)
    {
        // Подсчёт общего количества символов и количества букв
        int totalChars = input.Length;
        int letterCount = input.Count(char.IsLetter);

        // Вычисление процента букв
        double percentage = (double)letterCount / totalChars * 100;

        return new Result { percentage = Math.Round(percentage, 2) };
    }
}
