using System;
namespace ThreeLatinianLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int num =int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                char first = (char)('a'+i);
                for (int a = 0; a < num; a++)
                {
                    char second = (char)('a' + a);
                    for (int b = 0; b < num; b++)
                    {
                        char third = (char)('a' + b);
                        Console.WriteLine(first+""+second+""+third);
                    }
                }
            }
        }
    }
}