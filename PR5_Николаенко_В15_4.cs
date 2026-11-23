using System;

namespace Task4
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите строку: ");
            string text = Console.ReadLine() ?? "";

            Console.Write("Введите один символ-разделитель: ");
            string? input = Console.ReadLine();

            if (input == null || input.Length != 1)
            {
                Console.WriteLine("Нужно ввести ровно один символ.");
                return;
            }

            string[] parts = SplitBySeparator(text, input[0]);

            if (parts.Length == 0)
            {
                Console.WriteLine("Непустых частей нет.");
                return;
            }

            Console.WriteLine("Непустые части:");

            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }

        static string[] SplitBySeparator(string text, char separator)
        {
            return text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
