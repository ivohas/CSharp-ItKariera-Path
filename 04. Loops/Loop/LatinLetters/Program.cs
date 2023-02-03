using System;
namespace LatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = "Latin alphabet:";
            for (int i = 'a'; i <= 'z'; i++)
            {
                char letter = (char)i;
                result += $" {letter}";
            }
            Console.WriteLine(result.Trim());
        }
    }
}