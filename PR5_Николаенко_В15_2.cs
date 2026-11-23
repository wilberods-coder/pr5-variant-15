using System;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите строку: ");
            string text = Console.ReadLine() ?? "";
            string? result = GetTextBetweenSpaces(text);

            if (result == null)
            {
                Console.WriteLine("В строке должно быть хотя бы два пробела.");
                return;
            }

            Console.WriteLine($"Подстрока: «{result}»");
        }

        static string? GetTextBetweenSpaces(string text)
        {
            int firstSpace = text.IndexOf(' ');
            int lastSpace = text.LastIndexOf(' ');

            if (firstSpace == -1 || firstSpace == lastSpace)
            {
                return null;
            }

            return text.Substring(firstSpace + 1, lastSpace - firstSpace - 1);
        }
    }
}
