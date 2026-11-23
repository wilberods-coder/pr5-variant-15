using System;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите строку: ");
            string text = Console.ReadLine() ?? "";

            Console.WriteLine($"Результат: {ConvertLettersToUpper(text)}");
        }

        static string ConvertLettersToUpper(string text)
        {
            char[] characters = text.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                char symbol = characters[i];

                if ((symbol >= 'a' && symbol <= 'z') ||
                    (symbol >= 'а' && symbol <= 'я') || symbol == 'ё')
                {
                    characters[i] = char.ToUpperInvariant(symbol);
                }
            }

            return new string(characters);
        }
    }
}
