using System;

namespace Task3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите предложение: ");
            string sentence = Console.ReadLine() ?? "";

            Console.WriteLine($"Слов с заглавной буквы: {CountCapitalizedWords(sentence)}");
        }

        static int CountCapitalizedWords(string sentence)
        {
            string[] words = sentence.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;

            foreach (string word in words)
            {
                int position = 0;

                while (position < word.Length && char.IsPunctuation(word[position]))
                {
                    position++;
                }

                if (position < word.Length && char.IsUpper(word[position]))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
